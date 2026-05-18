using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RESERBA_Proj.Database.GuardRepository;

namespace RESERBA_Proj
{
    public partial class _1Admin2 : Form
    {
        public _1Admin2()
        {
            InitializeComponent();

        }
        private readonly IGuardRepository _guardRepo = new GuardRepository();

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
                if (_guardRepo.UsernameExists(username))
                {
                    MessageBox.Show("Username already exists. Please choose another.",
                        "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbUsername.Focus();
                    return;
                }

                _guardRepo.Register(username, password);

                MessageBox.Show("Account registered successfully! You can now log in.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _1Admin1 loginScreen = new _1Admin1();
                loginScreen.Show();
                this.Hide();
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AACStart nextScreen = new AACStart();
            nextScreen.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}