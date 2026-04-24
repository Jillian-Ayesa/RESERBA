using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _6_1Info : UserControl
    {
        public _6_1Info()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            _6_2Info nextPage = new _6_2Info();
            Dashboard mainForm = (Dashboard)this.FindForm();

            if (mainForm != null)
            {
                mainForm.LoadPage(nextPage);
            }
        }
    }
}
