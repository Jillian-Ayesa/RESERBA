using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _2_4Maps : UserControl
    {
        public _2_4Maps()
        {
            InitializeComponent();
        }

        private void BtnStandard_Click(object sender, EventArgs e)
        {
            SessionContext.PassengerType = "Standard";
            ((Dashboard)this.FindForm())?.LoadPage(new _2_2Map());
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            SessionContext.PassengerType = "Student";
            ((Dashboard)this.FindForm())?.LoadPage(new _2_2Map());
        }

        private void BtnPWD_Click(object sender, EventArgs e)
        {
            SessionContext.PassengerType = "PWD";
            ((Dashboard)this.FindForm())?.LoadPage(new _2_2Map());
        }


        private void btnBack_Click_1(object sender, EventArgs e)
        {
            ((Dashboard)this.FindForm())?.LoadPage(new _2_3Map());
        }

        private void _2_4Maps_Load(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
    }
}