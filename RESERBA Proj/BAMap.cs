using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _2Map : UserControl
    {
        public _2Map()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }
        public void LoadPage(UserControl userControl)
        {
            // 1. Clear whatever is currently in the dashed panel
            panel2.Controls.Clear();

            // 3. Add the new page to the panel
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {

            // 1. Create an instance of the NEXT page you want to show
            _2_2Map nextPage = new _2_2Map();

            // 2. Find the main dashboard form that is holding this control
            Dashboard mainForm = (Dashboard)this.FindForm();

            // 3. Call the public method on the main form to swap the page
            if (mainForm != null)
            {
                mainForm.LoadPage(nextPage);
            }
        }

        private void linkHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _3Search nextPage = new _3Search();

            // 2. Find the main dashboard form that is holding this control
            Dashboard mainForm = (Dashboard)this.FindForm();

            // 3. Call the public method on the main form to swap the page
            if (mainForm != null)
            {
                mainForm.LoadPage(nextPage);
            }
        }
    }

}
