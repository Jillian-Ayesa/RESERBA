using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using RESERBA_Proj.Database;
using System;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _5_1PaymentNow1_old : UserControl
    {
        public _5_1PaymentNow1_old()
        {
            InitializeComponent();

            // FIX 1: We must actually CALL the method when the page loads!
            LoadReceipt();
        }

        private void LoadReceipt()
        {
            // --- 1. PULL EVERYTHING STRICTLY FROM THE DATABASE (If they are an active session) ---
            if (!string.IsNullOrEmpty(SessionContext.ActiveSessionId))
            {
                try
                {
                    using (var conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        var cmd = new MySqlCommand("SELECT * FROM parking_sessions WHERE session_id=@id", conn);
                        cmd.Parameters.AddWithValue("@id", SessionContext.ActiveSessionId);

                        using (var r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                // 1. Set the top 4 Basic Info Labels
                                PlateNumber.Text = r["plate_number"].ToString();
                                VehicleType.Text = r["vehicle_type"].ToString();
                                SlotID.Text = r["slot_id"].ToString();
                                Status.Text = r["passenger_type"].ToString();

                                // 2. Set the Receipt Number and Date
                                ReceiptNum.Text = "PH-" + r["session_id"].ToString().Substring(1, 4);
                                DateTime entryTime = Convert.ToDateTime(r["entry_time"]);
                                ReceiptDate.Text = entryTime.ToString("M/dd/yy");

                                // 3. Set the Time In, Time Out, and Due Time
                                TimeIn.Text = entryTime.ToString("hh:mm tt");

                                int dbDuration = r["estimated_duration"] != DBNull.Value ? Convert.ToInt32(r["estimated_duration"]) : 0;
                                DateTime initialTimeOut = entryTime.AddHours(dbDuration);

                                TimeOut.Text = initialTimeOut.ToString("hh:mm tt");
                                DueTime.Text = initialTimeOut.ToString("hh:mm tt");

                                // 4. Set the Total Amount
                                decimal dbAmount = 0;
                                if (r["amount_due"] != DBNull.Value)
                                {
                                    dbAmount = Convert.ToDecimal(r["amount_due"]);
                                }
                                ReceiptTotal.Text = $"PHP {dbAmount:N0}";

                                // --- 5. OVERRIDE FOR FINAL CHECKOUT ---
                                // If they clicked "Final Time Out" earlier, adjust the Time Out and Total!
                                if (r["exit_time"] != DBNull.Value)
                                {
                                    DateTime finalTimeOut = Convert.ToDateTime(r["exit_time"]);
                                    TimeOut.Text = finalTimeOut.ToString("hh:mm tt"); // Override with true exit time

                                    decimal penaltyRate = 20;
                                    decimal finalPayment = dbAmount;

                                    TimeSpan overtime = finalTimeOut - initialTimeOut;
                                    if (overtime.TotalMinutes > 0)
                                    {
                                        int overtimeHours = (int)Math.Ceiling(overtime.TotalMinutes / 60.0);
                                        decimal penaltyFee = overtimeHours * penaltyRate;
                                        finalPayment = dbAmount + penaltyFee;
                                    }

                                    // Subtract what they already paid
                                    if (r["payment_status"].ToString() == "Paid" && r["amount_paid"] != DBNull.Value)
                                    {
                                        decimal amountPaid = Convert.ToDecimal(r["amount_paid"]);
                                        finalPayment -= amountPaid;
                                        if (finalPayment < 0) finalPayment = 0;
                                    }

                                    ReceiptTotal.Text = $"PHP {finalPayment:N0}";
                                }

                                // We successfully loaded from the DB, so we stop the code here!
                                return;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading receipt from database: " + ex.Message, "Error");
                }
            }

            // --- 2. FALLBACK: FOR BRAND NEW USERS ONLY ---
            // If they are arriving at the gate for the first time, build a preview receipt from memory.
            PlateNumber.Text = SessionContext.PlateNumber ?? "N/A";
            VehicleType.Text = SessionContext.VehicleType ?? "N/A";
            SlotID.Text = SessionContext.SelectedSlotId ?? "N/A";
            Status.Text = SessionContext.PassengerType ?? "Standard";

            if (SessionContext.EstimatedTimeOut != DateTime.MinValue && SessionContext.EstimatedDuration > 0)
            {
                string formattedTimeOut = SessionContext.EstimatedTimeOut.ToString("hh:mm tt");
                TimeOut.Text = formattedTimeOut;
                DueTime.Text = formattedTimeOut;

                DateTime exactTimeIn = SessionContext.EstimatedTimeOut.AddHours(-SessionContext.EstimatedDuration);
                TimeIn.Text = exactTimeIn.ToString("hh:mm tt");
            }

            decimal totalAmount = 0;
            if (SessionContext.PassengerType == "VIP") totalAmount = 0;
            else if (SessionContext.PassengerType == "Valet") totalAmount = 200;
            else
            {
                int hours = SessionContext.EstimatedDuration;
                if (hours > 0)
                {
                    totalAmount = 50;
                    if (hours > 3) totalAmount += (hours - 3) * 10;
                }
            }
            ReceiptTotal.Text = $"PHP {totalAmount:N0}";
            ReceiptNum.Text = "PH-" + new Random().Next(1000, 9999).ToString();
            ReceiptDate.Text = DateTime.Now.ToString("M/dd/yy");
        }

        private void BtnPayNow_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // --- 1. SMART AMOUNT CAPTURE ---
                    // Instead of recalculating, we grab the EXACT amount displayed on the receipt!
                    // This ensures any overtime penalties are perfectly captured.
                    string cleanAmount = ReceiptTotal.Text.Replace("PHP", "").Replace(",", "").Trim();
                    decimal amountPayingNow = 0;
                    decimal.TryParse(cleanAmount, out amountPayingNow);

                    int hours = SessionContext.EstimatedDuration;

                    // 2. SMART DATABASE CHECK: Do we UPDATE or INSERT?
                    if (!string.IsNullOrEmpty(SessionContext.ActiveSessionId))
                    {
                        // A. UPDATE EXISTING SESSION (For Valets & VIPs)
                        var cmd = new MySqlCommand(@"
                            UPDATE parking_sessions 
                            SET payment_status = 'Paid',
                                payment_time = NOW(),
                                amount_due = @amount,
                                amount_paid = COALESCE(amount_paid, 0) + @newPayment
                            WHERE session_id = @id", conn);

                        cmd.Parameters.AddWithValue("@amount", amountPayingNow); // Changed to amountPayingNow to keep it accurate
                        cmd.Parameters.AddWithValue("@newPayment", amountPayingNow);
                        cmd.Parameters.AddWithValue("@id", SessionContext.ActiveSessionId);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // B. INSERT NEW SESSION (For Standard & Student users!)
                        // Generate a brand new Session ID (e.g., S260509123045)
                        string newSessionId = "S" + DateTime.Now.ToString("yyMMddHHmmss");
                        SessionContext.ActiveSessionId = newSessionId; // Save it to memory

                        // --- THE FIX: Separated the parameters into @amountDue and @amountPaid! ---
                        var cmd = new MySqlCommand(@"
                            INSERT INTO parking_sessions 
                            (session_id, plate_number, vehicle_type, wheel_count, slot_id, passenger_type, session_type, entry_time, estimated_duration, amount_due, amount_paid, payment_status, payment_time, gate_id, guard_id)
                            VALUES 
                            (@id, @plate, @veh, @wheels, @slot, @pass, 'Now', NOW(), @dur, @amountDue, @amountPaid, 'Paid', NOW(), @gate, @guard)", conn);

                        cmd.Parameters.AddWithValue("@id", newSessionId);
                        cmd.Parameters.AddWithValue("@plate", SessionContext.PlateNumber ?? "UNKNOWN");
                        cmd.Parameters.AddWithValue("@veh", SessionContext.VehicleType ?? "Car");
                        cmd.Parameters.AddWithValue("@wheels", SessionContext.WheelCount > 0 ? SessionContext.WheelCount : 4);
                        cmd.Parameters.AddWithValue("@slot", SessionContext.SelectedSlotId ?? "NONE");
                        cmd.Parameters.AddWithValue("@pass", SessionContext.PassengerType ?? "Standard");
                        cmd.Parameters.AddWithValue("@dur", hours);

                        // Pass the captured UI amount to both columns safely
                        cmd.Parameters.AddWithValue("@amountDue", amountPayingNow);
                        cmd.Parameters.AddWithValue("@amountPaid", amountPayingNow);

                        cmd.Parameters.AddWithValue("@gate", SessionContext.GateId ?? "Gate 1");
                        cmd.Parameters.AddWithValue("@guard", 2);


                        cmd.ExecuteNonQuery();

                        // Bonus: Lock the physical parking slot on the map since they just paid for it!
                        var slotCmd = new MySqlCommand("UPDATE parking_slots SET is_occupied=TRUE WHERE slot_id=@slot", conn);
                        slotCmd.Parameters.AddWithValue("@slot", SessionContext.SelectedSlotId);
                        slotCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // If anything goes wrong, it will pop up an error box telling us exactly why!
                MessageBox.Show("Error processing payment: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Move forward to the final confirmation page
            ((Dashboard)this.FindForm())?.LoadPage(new _5_1PaymentNow2());
        }

        private void BtnPayLater_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // 1. Calculate the exact amount due
                    decimal totalAmount = 0;
                    int hours = SessionContext.EstimatedDuration;
                    if (hours > 0)
                    {
                        totalAmount = 50; // Base rate
                        if (hours > 3) totalAmount += (hours - 3) * 10; // Extra hour rate
                    }

                    // 2. SMART DATABASE CHECK: Do we UPDATE or INSERT?
                    if (!string.IsNullOrEmpty(SessionContext.ActiveSessionId))
                    {
                        // A. UPDATE EXISTING SESSION (Just in case a Valet/VIP ends up here)
                        var cmd = new MySqlCommand(@"
                            UPDATE parking_sessions 
                            SET session_type = 'Later', 
                                payment_status = 'Unpaid', 
                                estimated_duration = @dur
                            WHERE session_id = @id", conn);

                        cmd.Parameters.AddWithValue("@dur", hours);
                        cmd.Parameters.AddWithValue("@id", SessionContext.ActiveSessionId);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // B. INSERT NEW SESSION (For Standard & Student users!)
                        string newSessionId = "S" + DateTime.Now.ToString("yyMMddHHmmss");
                        SessionContext.ActiveSessionId = newSessionId;

                        // Notice how we hardcode 'Later', 'Unpaid', and 0 for the amount paid!
                        var cmd = new MySqlCommand(@"
                            INSERT INTO parking_sessions 
                            (session_id, plate_number, vehicle_type, wheel_count, slot_id, passenger_type, session_type, entry_time, estimated_duration, amount_due, amount_paid, payment_status, gate_id, guard_id)
                            VALUES 
                            (@id, @plate, @veh, @wheels, @slot, @pass, 'Later', NOW(), @dur, @amount, 0, 'Unpaid', @gate, @guard)", conn);

                        cmd.Parameters.AddWithValue("@id", newSessionId);
                        cmd.Parameters.AddWithValue("@plate", SessionContext.PlateNumber ?? "UNKNOWN");
                        cmd.Parameters.AddWithValue("@veh", SessionContext.VehicleType ?? "PRIV");
                        cmd.Parameters.AddWithValue("@wheels", SessionContext.WheelCount > 0 ? SessionContext.WheelCount : 4);
                        cmd.Parameters.AddWithValue("@slot", SessionContext.SelectedSlotId ?? "NONE");
                        cmd.Parameters.AddWithValue("@pass", SessionContext.PassengerType ?? "Standard");
                        cmd.Parameters.AddWithValue("@dur", hours);
                        cmd.Parameters.AddWithValue("@amount", totalAmount);

                        // We use the GateId we saved from the map screen earlier!
                        cmd.Parameters.AddWithValue("@gate", SessionContext.GateId ?? "Gate 1");
                        cmd.Parameters.AddWithValue("@guard", 2);

                        cmd.ExecuteNonQuery();

                        // Lock the physical parking slot on the map
                        var slotCmd = new MySqlCommand("UPDATE parking_slots SET is_occupied=TRUE WHERE slot_id=@slot", conn);
                        slotCmd.Parameters.AddWithValue("@slot", SessionContext.SelectedSlotId);
                        slotCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving Pay Later: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Clear memory and return to Dashboard
            SessionContext.ClearSession();
            ((Dashboard)this.FindForm())?.LoadPage(new _5_1PaymentNow2());
        }

        private void DueTime_Click(object sender, EventArgs e)
        {

        }
    }
}