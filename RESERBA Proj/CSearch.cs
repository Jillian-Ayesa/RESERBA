using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _3Search : UserControl
    {
        public _3Search()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            _2_4Maps nextPage = new _2_4Maps();
            Dashboard mainForm = (Dashboard)this.FindForm();
            if (mainForm != null)
            {
                mainForm.LoadPage(nextPage);
            }
        }
    }
}
