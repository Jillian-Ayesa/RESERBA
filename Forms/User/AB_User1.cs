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
    public partial class _1B_User1 : Form
    {
        public _1B_User1()
        {
            InitializeComponent();

        }



        private void BtnBack_Click(object sender, EventArgs e)
        {
            AACStart nextScreen = new AACStart();
            nextScreen.Show();
            this.Hide();
        }

        private void linkClickHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _1B_User2 nextScreen = new _1B_User2();
            nextScreen.Show();
            this.Hide();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            // Get the text from the box and trim any accidental spaces
            string userInput = TbParkingID.Text.Trim();

            // --- 1. CHECK IF IT IS EMPTY ---
            if (string.IsNullOrEmpty(userInput))
            {
                MessageBox.Show("Please enter a plate number.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Clean the input for our smart search
            string cleanInput = userInput.Replace(" ", "").Replace("-", "");

            // --- 2. CHECK IF PLATE EXISTS IN THE DATABASE ---
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // We search the database for this specific plate number.
                    // We also make sure exit_time IS NULL so we only find cars currently inside the parking lot!
                    var cmd = new MySqlCommand(@"
                        SELECT session_id, slot_id, plate_number 
                        FROM parking_sessions 
                        WHERE REPLACE(REPLACE(plate_number, '-', ''), ' ', '') = @cleanPlate 
                        AND exit_time IS NULL LIMIT 1", conn);

                    // THE FIX: Changed @plate to @cleanPlate, and passed the cleanInput variable!
                    cmd.Parameters.AddWithValue("@cleanPlate", cleanInput);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // SUCCESS! The plate number was found!
                            SessionContext.ActiveSessionId = reader["session_id"].ToString();
                            SessionContext.SelectedSlotId = reader["slot_id"].ToString();

                            // Save the perfectly formatted plate number from the database into memory
                            SessionContext.PlateNumber = reader["plate_number"].ToString();

                            _1B_User4 locationScreen = new _1B_User4();
                            locationScreen.Show();

                            // Optional: Hide the current login window so it doesn't clutter the screen
                            this.Hide();
                        }
                        else
                        {
                            // FAILED: Not found.
                            MessageBox.Show("We couldn't find an active parking session for that Plate Number. Please check your spelling and try again.",
                                "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbParkingID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
