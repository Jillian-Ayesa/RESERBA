using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _1B_User5 : Form
    {
        public _1B_User5()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _1B_User4 nextScreen = new _1B_User4();
            nextScreen.Show();
            this.Hide();
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            _1B_User6 nextScreen = new _1B_User6();
            nextScreen.Show();
            this.Hide();
        }
    }
}
