using MySql.Data.MySqlClient;
using RESERBA_Proj.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _1B_User5 : Form
    {
        public _1B_User5()
        {
            InitializeComponent();

            // Instantly load the exact receipt data from the database when the screen opens!
            LoadReceipt();
        }

        private void LoadReceipt()
        {
            // --- 1. PULL EVERYTHING STRICTLY FROM THE DATABASE ---
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
                                if (r["exit_time"] != DBNull.Value)
                                {
                                    DateTime finalTimeOut = Convert.ToDateTime(r["exit_time"]);
                                    TimeOut.Text = finalTimeOut.ToString("hh:mm tt");

                                    decimal penaltyRate = 20;
                                    decimal finalPayment = dbAmount;

                                    TimeSpan overtime = finalTimeOut - initialTimeOut;
                                    if (overtime.TotalMinutes > 0)
                                    {
                                        int overtimeHours = (int)Math.Ceiling(overtime.TotalMinutes / 60.0);
                                        decimal penaltyFee = overtimeHours * penaltyRate;
                                        finalPayment = dbAmount + penaltyFee;
                                    }

                                    if (r["payment_status"].ToString() == "Paid" && r["amount_paid"] != DBNull.Value)
                                    {
                                        decimal amountPaid = Convert.ToDecimal(r["amount_paid"]);
                                        finalPayment -= amountPaid;
                                        if (finalPayment < 0) finalPayment = 0;
                                    }

                                    ReceiptTotal.Text = $"PHP {finalPayment:N0}";
                                }

                                return; // Stop here if DB load was successful
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading receipt from database: " + ex.Message, "Error");
                }
            }

            // --- 2. FALLBACK: FOR BRAND NEW USERS ---
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

        private void BtnCancelUser_Click(object sender, EventArgs e)
        {
            _1B_User4 nextScreen = new _1B_User4();
            nextScreen.Show();
            this.Hide();
        }

        private void BtnPayNowReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Get the exact amount shown on the screen
                string cleanAmount = ReceiptTotal.Text.Replace("PHP", "").Replace(",", "").Trim();
                decimal amountPayingNow = 0;
                decimal.TryParse(cleanAmount, out amountPayingNow);

                // 2. Save the payment to the database so Earnings update perfectly!
                if (!string.IsNullOrEmpty(SessionContext.ActiveSessionId))
                {
                    using (var conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        var cmd = new MySqlCommand(@"
                            UPDATE parking_sessions 
                            SET payment_status = 'Paid',
                                payment_time = NOW(),
                                amount_due = @amtDue,
                                amount_paid = @amtPaid
                            WHERE session_id = @id", conn);

                        cmd.Parameters.AddWithValue("@amtDue", amountPayingNow);
                        cmd.Parameters.AddWithValue("@amtPaid", amountPayingNow);
                        cmd.Parameters.AddWithValue("@id", SessionContext.ActiveSessionId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payment: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop them from moving to the success screen if the payment failed
            }

            // 3. Move to the final Success / Thank You screen
            _1B_User6 nextScreen = new _1B_User6();
            nextScreen.Show();
            this.Hide();
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            AACStart nextScreen = new AACStart();
            nextScreen.Show();
            this.Hide();
        }
    }
}