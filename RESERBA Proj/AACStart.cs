using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class AACStart : Form
    {
        public AACStart()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }

        private void tbUser_Click(object sender, EventArgs e)
        {
            _1B_User1 nextScreen = new _1B_User1();
            nextScreen.Show();
            this.Hide();
        }

        private void tbAdmin_Click(object sender, EventArgs e)
        {
            _1Admin1 nextScreen = new _1Admin1();
            nextScreen.Show();
            this.Hide();
        }
    }
}
