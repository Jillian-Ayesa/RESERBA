using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using RESERBA_Proj.Database;
using System;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class EAPaymentNowVIPA : UserControl
    {
        public EAPaymentNowVIPA()
        {
            InitializeComponent();
            LoadReceipt();
        }

        private void LoadReceipt()
        {
            // Don't try to load if there is no session
            if (string.IsNullOrEmpty(SessionContext.ActiveSessionId))
                return;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "SELECT * FROM parking_sessions WHERE session_id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", SessionContext.ActiveSessionId);

                    using (var r = cmd.ExecuteReader())
                    {
                        // EVERYTHING MUST BE INSIDE THIS if (r.Read()) BLOCK!
                        if (r.Read())
                        {
                            // 1. Populates standard labels with database info
                            ReceiptDate.Text = Convert.ToDateTime(r["entry_time"]).ToString("M/dd/yy");
                            ReceiptNum.Text = "PH-" + r["session_id"].ToString().Substring(1, 4);

                            decimal amount = Convert.ToDecimal(r["amount_due"]);
                            ReceiptTotal.Text = $"PHP {amount:N0}";

                            TimeIn.Text = Convert.ToDateTime(r["entry_time"]).ToString("HH:mm");
                            TimeOut.Text = "--:--";

                            // 2. Dynamically update the status label
                            label1.Text = SessionContext.PassengerType.ToUpper();

                            // 3. --- SMART UI TRICK FOR VIPS & ATTENDANTS ---
                            if (SessionContext.PassengerType == "VIP")
                            {
                                BtnCancel.Visible = true;
                                BtnCancel.Text = "Cancel";
                                BtnPay.Text = "Continue";

                                // Hide the dynamic name
                                labelattendant.Visible = false;

                                // Show the white box to cover the printed text!
                                panelHideAttendant.Visible = true;
                            }
                            else
                            {
                                BtnCancel.Visible = true;
                                BtnCancel.Text = "Pay Later";
                                BtnPay.Text = "Pay Now";

                                // Show the dynamic name
                                labelattendant.Visible = true;
                                labelattendant.Text = r["valet_name"].ToString();

                                // Hide the white box so the Valet title is visible!
                                panelHideAttendant.Visible = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading receipt: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (SessionContext.PassengerType == "VIP")
            {
                // VIP clicked Cancel: Wipe the session and go back to the VIP Selection screen
                SessionContext.ClearSession();
                ((Dashboard)this.FindForm())?.LoadPage(new _4VIP());
            }
            else
            {
                // Valet clicked Pay Later: Save choice and go to Vehicle Selection (BAMap)
                UpdateSessionType("Later");
                ((Dashboard)this.FindForm())?.LoadPage(new _2Map());
            }
        }

        // Empty event handlers kept intact to prevent designer errors
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void ReceiptTotal_Click(object sender, EventArgs e) { }
        private void ReceiptDate_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void labelattendant_Click(object sender, EventArgs e) { }

        private void BtnPay_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    // Unified super-query: Updates type, status, time, matches paid to due, AND records guard_id!
                    var cmd = new MySqlCommand(
                        @"UPDATE parking_sessions 
                          SET session_type = 'Now', 
                              payment_status = 'Paid', 
                              payment_time = NOW(), 
                              amount_paid = amount_due,
                              guard_id = 2 
                          WHERE session_id = @id", conn);

                    cmd.Parameters.AddWithValue("@id", SessionContext.ActiveSessionId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Pops up an error box if the database gets stuck
                MessageBox.Show("Payment Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Everyone goes to BAMap next!
            // In EAPaymentNowVIPA when Valet clicks to go to BAMap:
            _2Map.IsValetFlow = true;
            ((Dashboard)this.FindForm())?.LoadPage(new _2Map());
        }

        // Helper method to record their choice in the database before going to the map (Used by Pay Later)
        private void UpdateSessionType(string type)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand("UPDATE parking_sessions SET session_type=@type WHERE session_id=@id", conn);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@id", SessionContext.ActiveSessionId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch { }
        }
    }
}