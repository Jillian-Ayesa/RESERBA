using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA
{
    public partial class Admin1 : Form
    {
        public Admin1()
        {
            InitializeComponent();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin2 nextScreen = new Admin2();
            nextScreen.Show();
            this.Hide();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            Admin3 nextScreen = new Admin3();
            nextScreen.Show();
            this.Hide();
        }
    }
}
