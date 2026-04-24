using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RESERBA_Proj.Database;

namespace RESERBA_Proj
{
    public partial class _1Admin1 : Form
    {
        public _1Admin1()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string username = TbUsername.Text.Trim();
            string password = TbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.",
                    "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT username FROM guards " +
                                   "WHERE username=@u AND password=@p";
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);

                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        _1Admin3 gateScreen = new _1Admin3();
                        gateScreen.SetUser(username);
                        gateScreen.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.",
                            "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TbPassword.Clear();
                        TbUsername.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message,
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkRegisterHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _1Admin2 nextScreen = new _1Admin2();
            nextScreen.Show();
            this.Hide();
        }
    }
}   