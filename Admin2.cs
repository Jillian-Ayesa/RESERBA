using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA
{
    public partial class Admin2 : Form
    {
        public Admin2()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Admin1 nextScreen = new Admin1();
            nextScreen.Show();
            this.Hide();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin1 nextScreen = new Admin1();
            nextScreen.Show();
            this.Hide();
        }
    }
}
