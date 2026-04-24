using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _4VIP : UserControl
    {
        public _4VIP()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }

        private void LoadPage(UserControl userControl)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void BtnValet_Click(object sender, EventArgs e)
        {
            _5_1Payment nextPage = new _5_1Payment();
            Dashboard mainForm = (Dashboard)this.FindForm();
            if (mainForm != null)
            {
                mainForm.LoadPage(nextPage);
            }
        }

        private void BtnVIP2_Click(object sender, EventArgs e)
        {
            _5_1Payment nextPage = new _5_1Payment();
            Dashboard mainForm = (Dashboard)this.FindForm();
            if (mainForm != null)
            {
                mainForm.LoadPage(nextPage);
            }
        }
    }
}
