using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _1B_User6 : Form
    {
        public _1B_User6()
        {
            InitializeComponent();
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AACStart nextScreen = new AACStart();
            nextScreen.Show();
            this.Hide();
        }
    }
}
