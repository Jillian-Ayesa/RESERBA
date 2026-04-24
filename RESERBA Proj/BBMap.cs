using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _2_2Map : UserControl
    {
        public _2_2Map()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
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
