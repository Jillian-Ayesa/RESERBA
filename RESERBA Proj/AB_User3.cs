using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _1B_User3 : Form
    {
        public _1B_User3()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _1B_User2 nextScreen = new _1B_User2();
            nextScreen.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            _1B_User4 nextScreen = new _1B_User4();
            nextScreen.Show();
            this.Hide();
        }
    }
}
