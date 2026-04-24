using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _2_3Map : UserControl
    {
        public _2_3Map()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }

        private void rbPUV_CheckedChanged(object sender, EventArgs e)
        {
            _2_4Maps nextPage = new _2_4Maps();
            Dashboard mainForm = (Dashboard)this.FindForm();
            if (mainForm != null)
            {
                mainForm.LoadPage(nextPage);
            }
        }

        private void rbRIV_CheckedChanged(object sender, EventArgs e)
        {
            _2_4Maps nextPage = new _2_4Maps();
            Dashboard mainForm = (Dashboard)this.FindForm();
            if (mainForm != null)
            {
                mainForm.LoadPage(nextPage);
            }
        }

        private void rbEV_CheckedChanged(object sender, EventArgs e)
        {
            _2_4Maps nextPage = new _2_4Maps();
            Dashboard mainForm = (Dashboard)this.FindForm();
            if (mainForm != null)
            {
                mainForm.LoadPage(nextPage);
            }
        }

        private void rb2W_CheckedChanged(object sender, EventArgs e)
        {
            _2_4Maps nextPage = new _2_4Maps();
            Dashboard mainForm = (Dashboard)this.FindForm();
            if (mainForm != null)
            {
                mainForm.LoadPage(nextPage);
            }
        }

        private void rb4W_CheckedChanged(object sender, EventArgs e)
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
