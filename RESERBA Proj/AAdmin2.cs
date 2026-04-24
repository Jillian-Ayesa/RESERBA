using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RESERBA_Proj.Database;

namespace RESERBA_Proj
{
    public partial class _1Admin2 : Form
    {
        public _1Admin2()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = TbUsername.Text.Trim();
            string password = TbPassword.Text.Trim();
            string confirm = TbConPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("Please fill in all fields.",
                    "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match. Please try again.",
                    "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbPassword.Clear();
                TbConPassword.Clear();
                TbPassword.Focus();
                return;
            }

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Check if username already exists
                    string checkQuery = "SELECT COUNT(*) FROM guards WHERE username=@u";
                    var checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@u", username);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose another.",
                            "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TbUsername.Focus();
                        return;
                    }

                    // Insert new guard
                    string insertQuery = "INSERT INTO guards (username, password) VALUES (@u, @p)";
                    var insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@u", username);
                    insertCmd.Parameters.AddWithValue("@p", password);
                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Account registered successfully! You can now log in.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _1Admin1 loginScreen = new _1Admin1();
                    loginScreen.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message,
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLogInHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _1Admin1 nextScreen = new _1Admin1();
            nextScreen.Show();
            this.Hide();
        }
    }
}