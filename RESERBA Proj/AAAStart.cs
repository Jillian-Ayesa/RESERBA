using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class AAAStart : Form
    {
        public AAAStart()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            AABStart nextScreen = new AABStart();
            nextScreen.Show();
            this.Hide();
        }
    }
}
