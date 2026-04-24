using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class AABStart : Form
    {
        public AABStart()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }

        

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            AACStart nextScreen = new AACStart();
            nextScreen.Show();
            this.Hide();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            AAAStart nextScreen = new AAAStart();
            nextScreen.Show();
            this.Hide();
        }
    }
}
