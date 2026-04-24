using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _1B_User4 : Form
    {
        public _1B_User4()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }

        private void BtnPayNow_Click(object sender, EventArgs e)
        {
            _1B_User5 nextScreen = new _1B_User5();
            nextScreen.Show();
            this.Hide();
        }

        private void BtnPayLater_Click(object sender, EventArgs e)
        {
            _1B_User6 nextScreen = new _1B_User6();
            nextScreen.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _1B_User3 nextScreen = new _1B_User3();
            nextScreen.Show();
            this.Hide();
        }
    }
}
