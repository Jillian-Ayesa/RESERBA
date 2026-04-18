using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnImgUser_Click(object sender, EventArgs e)
        {
            Admin1 nextScreen = new Admin1();
            nextScreen.Show();
            this.Hide();
        }
        private void BtnImgAdmin_Click(object sender, EventArgs e)
        {

        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            User1 nextScreen = new User1();
            nextScreen.Show();
            this.Hide();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            Admin1 nextScreen = new Admin1();
            nextScreen.Show();
            this.Hide();
        }
    }
}
