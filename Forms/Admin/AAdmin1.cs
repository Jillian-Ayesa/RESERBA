using MySql.Data.MySqlClient;
using RESERBA_Proj.Database;
using RESERBA_Proj.Database.GuardRepository;
using System;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _1Admin1 : Form
    {
        public _1Admin1()
        {
            InitializeComponent();
        }

        private readonly IGuardRepository _guardRepo = new GuardRepository();

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
                if (_guardRepo.ValidateGuard(username, password, out int guardId))
                {
                    SessionContext.GuardId = guardId;
                    SessionContext.GuardUsername = username;

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

        private bool isPasswordVisible = false;

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AACStart nextScreen = new AACStart();
            nextScreen.Show();
            this.Hide();
        }

        private void TbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}