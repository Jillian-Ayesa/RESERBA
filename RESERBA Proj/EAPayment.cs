using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _5_1Payment : UserControl
    {
        public _5_1Payment()
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

        private void BtnPayNow_Click(object sender, EventArgs e)
        {
            _5_1PaymentNow1 nextPage = new _5_1PaymentNow1();
            Dashboard mainForm = (Dashboard)this.FindForm();
            if (mainForm != null)
            {
                mainForm.LoadPage(nextPage);
            }
        }

        private void BtnPayLater_Click(object sender, EventArgs e)
        {
            _5_1PaymentNow2 nextPage = new _5_1PaymentNow2();
            Dashboard mainForm = (Dashboard)this.FindForm();
            if (mainForm != null)
            {
                mainForm.LoadPage(nextPage);
            }
        }
    }
}
