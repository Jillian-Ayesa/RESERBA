using MySql.Data.MySqlClient;
using RESERBA_Proj.Database;
using System;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _1B_User4 : Form
    {
        public _1B_User4()
        {
            InitializeComponent();
            LoadLocationData();
        }

        private void LoadLocationData()
        {
            string currentSlot = SessionContext.SelectedSlotId;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // --- 1. STRICT ALIGNMENT WITH PLATE NUMBER SEARCH ---
                    // We use the Session ID that was saved when they searched their plate number
                    // to find their EXACT slot. 
                    if (string.IsNullOrEmpty(currentSlot) && !string.IsNullOrEmpty(SessionContext.ActiveSessionId))
                    {
                        var fetchCmd = new MySqlCommand("SELECT slot_id FROM parking_sessions WHERE session_id = @id", conn);
                        fetchCmd.Parameters.AddWithValue("@id", SessionContext.ActiveSessionId);

                        var result = fetchCmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            currentSlot = result.ToString();
                            SessionContext.SelectedSlotId = currentSlot; // Save it to memory
                        }
                    }

                    // If the database couldn't find anything associated with their plate/session
                    if (string.IsNullOrEmpty(currentSlot))
                    {
                        lbLocation.Text = "UNKNOWN\n(Error)";
                        return;
                    }

                    // --- 2. CHECK IF THE SLOT IS OCCUPIED ---
                    var occCmd = new MySqlCommand("SELECT is_occupied FROM parking_slots WHERE slot_id = @id", conn);
                    occCmd.Parameters.AddWithValue("@id", currentSlot);

                    object occResult = occCmd.ExecuteScalar();
                    bool isOccupied = occResult != null && Convert.ToBoolean(occResult);

                    string statusWord = isOccupied ? "(Occupied)" : "(Open)";

                    // --- 3. UPDATE THE GREEN BOX ---
                    lbLocation.Text = $"{currentSlot}\n{statusWord}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error");
                lbLocation.Text = "ERROR\n(Check DB)";
            }
        }

        // --- BUTTON ACTIONS ---

        private void BtnPayNowUser_Click(object sender, EventArgs e)
        {
            _1B_User5 nextScreen = new _1B_User5();
            nextScreen.Show();
            this.Hide();
        }

        private void BtnCancelTransac_Click(object sender, EventArgs e)
        {
            _1B_User2 nextScreen = new _1B_User2();
            nextScreen.Show();
            this.Hide();
        }

        private void lbLocation_Click(object sender, EventArgs e)
        {

        }
    }
}