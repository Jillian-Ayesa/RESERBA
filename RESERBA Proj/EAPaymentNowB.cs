using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _5_1PaymentNow2 : UserControl
    {
        public _5_1PaymentNow2()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            _2Map nextPage = new _2Map();
            Dashboard mainForm = (Dashboard)this.FindForm();
            if (mainForm != null)
            {
                mainForm.LoadPage(nextPage);
            }
        }
    }
}
