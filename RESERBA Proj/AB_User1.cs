using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _1B_User1 : Form
    {
        public _1B_User1()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }



        private void BtnBack_Click(object sender, EventArgs e)
        {
            AACStart nextScreen = new AACStart();
            nextScreen.Show();
            this.Hide();
        }

        private void linkClickHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _1B_User2 nextScreen = new _1B_User2();
            nextScreen.Show();
            this.Hide();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            _1B_User3 nextScreen = new _1B_User3();
            nextScreen.Show();
            this.Hide();
        }
    }
}
