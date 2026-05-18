using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RESERBA_Proj.Database;

namespace RESERBA_Proj
{
    public partial class _4VIP : UserControl
    {
        // Tracker to remember whose turn it is!
        private static int valetIndex = 0;

        public _4VIP()
        {
            InitializeComponent();
        }

        private void LoadPage(UserControl userControl)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        // --- NEW: Method to get the next valet from the actual Database ---
        private string GetNextValet(MySqlConnection conn)
        {
            List<string> valets = new List<string>();
            var cmd = new MySqlCommand("SELECT valet_name FROM valet_attendants", conn);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    valets.Add(reader["valet_name"].ToString());
                }
            }

            // Fallback just in case the database table is empty
            if (valets.Count == 0) return "No Valet Available";

            // Pick the next valet in line, then move the line forward
            string assignedValet = valets[valetIndex % valets.Count];
            valetIndex++;

            return assignedValet;
        }
        // ------------------------------------------------------------------

        private void CreateInitialSession(decimal amountDue)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sessionId = "S" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    SessionContext.ActiveSessionId = sessionId;

                    // 1. Get the real attendant from the database!
                    string assignedAttendant = null;
                    if (SessionContext.PassengerType == "Valet")
                    {
                        assignedAttendant = GetNextValet(conn);
                    }

                    // 2. Save it to brand new 'valet_name' column
                    var cmd = new MySqlCommand(@"
                        INSERT INTO parking_sessions 
                        (session_id, plate_number, vehicle_type, wheel_count, passenger_type, 
                         slot_id, gate_id, entry_time, payment_status, amount_due, valet_name)
                        VALUES 
                        (@sid, 'TBD', 'TBD', 4, @ptype, 
                         NULL, NULL, NOW(), 'Unpaid', @amount, @valet)", conn);

                    cmd.Parameters.AddWithValue("@sid", sessionId);
                    cmd.Parameters.AddWithValue("@ptype", SessionContext.PassengerType);
                    cmd.Parameters.AddWithValue("@amount", amountDue);
                    cmd.Parameters.AddWithValue("@valet", string.IsNullOrEmpty(assignedAttendant) ? (object)DBNull.Value : assignedAttendant);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating session: " + ex.Message, "DB Error");
            }
        }

        private void BtnValet_Click(object sender, EventArgs e)
        {
            SessionContext.ClearSession();
            SessionContext.PassengerType = "Valet";
            CreateInitialSession(200);
            ((Dashboard)this.FindForm())?.LoadPage(new EAPaymentNowVIPA());
        }

        private void BtnVIP2_Click(object sender, EventArgs e)
        {
            SessionContext.ClearSession();
            SessionContext.PassengerType = "VIP";
            CreateInitialSession(0);
            ((Dashboard)this.FindForm())?.LoadPage(new EAPaymentNowVIPA());
        }
    }
}