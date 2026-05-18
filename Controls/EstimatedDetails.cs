using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class EstimatedDetails : UserControl
    {
        public EstimatedDetails()
        {
            InitializeComponent();
            LoadSessionData();
        }

        private void LoadSessionData()
        {
            // If there's no active session, skip loading
            if (string.IsNullOrEmpty(SessionContext.ActiveSessionId)) return;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    // Pull the exact details of this specific parking session
                    var cmd = new MySqlCommand(
                        "SELECT plate_number, vehicle_type, slot_id, payment_status, entry_time, estimated_duration " +
                        "FROM parking_sessions WHERE session_id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", SessionContext.ActiveSessionId);

                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            // 1. Fill in the Database Info!
                            lblLargePlate.Text = r["plate_number"].ToString();
                            lblPlateValue.Text = r["plate_number"].ToString();
                            lblVehicleValue.Text = r["vehicle_type"].ToString();
                            lblSlotValue.Text = r["slot_id"].ToString();
                            lblStatusValue.Text = r["payment_status"].ToString();

                            // 2. Calculate the Initial Time Out
                            // We do this by taking the Entry Time and adding the hours they selected
                            DateTime entryTime = Convert.ToDateTime(r["entry_time"]);
                            int durationHours = r["estimated_duration"] != DBNull.Value ? Convert.ToInt32(r["estimated_duration"]) : 0;

                            DateTime initialTimeOut = entryTime.AddHours(durationHours);
                            lblTimeOut.Text = initialTimeOut.ToString("hh:mm tt");

                            // Leave final time out blank until they click the button
                            lbFTimeOut.Text = "--:--";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading summary: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- THE FINAL TIMEOUT BUTTON LOGIC ---
        private void btnRecordFinalTimeOut_Click(object sender, EventArgs e)
        {
            // 1. Show the Admin Confirmation Box!
            DialogResult result = MessageBox.Show(
                "Are you sure you want to record the final timeout for this vehicle? This will permanently end their session.",
                "Confirm Final Timeout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        // 2. Record the exact exit time in the database
                        var cmd = new MySqlCommand("UPDATE parking_sessions SET exit_time = NOW() WHERE session_id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", SessionContext.ActiveSessionId);
                        cmd.ExecuteNonQuery();

                        // 3. BONUS: Automatically free up their slot on the map so someone else can park there!
                        var freeSlotCmd = new MySqlCommand("UPDATE parking_slots SET is_occupied = FALSE WHERE slot_id = (SELECT slot_id FROM parking_sessions WHERE session_id = @id)", conn);
                        freeSlotCmd.Parameters.AddWithValue("@id", SessionContext.ActiveSessionId);
                        freeSlotCmd.ExecuteNonQuery();
                    }

                    // 4. Update the UI to show the exact time they checked out
                    lblFinalTimeOut.Text = DateTime.Now.ToString("hh:mm tt");

                    MessageBox.Show("Final timeout recorded successfully! The slot is now open.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error recording timeout: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- NAVIGATION BUTTONS ---
        private void btnCont_Click(object sender, EventArgs e)
        {
            ((Dashboard)this.FindForm())?.LoadPage(new _5_1PaymentNow1_old());
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            ((Dashboard)this.FindForm())?.LoadPage(new ABDashboard());
        }

        private void lbFTimeOut_Click(object sender, EventArgs e)
        {

        }

        private void BtnFTimeOut_Click(object sender, EventArgs e)
        {
            // Safety Check: Make sure there's an active session loaded
            if (string.IsNullOrEmpty(SessionContext.ActiveSessionId)) return;

            // 1. Ask for confirmation first!
            DialogResult result = MessageBox.Show(
                "Are you sure you want to record the final timeout? This will end the parking session and free up the slot.",
                "Confirm Checkout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();

                        // 2. Save the exact current time to the 'exit_time' column in the database
                        var cmd = new MySqlCommand("UPDATE parking_sessions SET exit_time = NOW() WHERE session_id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", SessionContext.ActiveSessionId);
                        cmd.ExecuteNonQuery();

                        // 3. Free up the physical parking slot on the map so someone else can use it!
                        var slotCmd = new MySqlCommand(
                            "UPDATE parking_slots SET is_occupied = FALSE WHERE slot_id = (SELECT slot_id FROM parking_sessions WHERE session_id = @id)", conn);
                        slotCmd.Parameters.AddWithValue("@id", SessionContext.ActiveSessionId);
                        slotCmd.ExecuteNonQuery();
                    }

                    // 4. Instantly update the UI to show the exact time you clicked it!
                    lbFTimeOut.Text = DateTime.Now.ToString("hh:mm tt");

                    MessageBox.Show("Checkout successful! The exact time has been recorded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
