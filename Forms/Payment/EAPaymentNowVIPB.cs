using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class EAPaymentNowVIPB : UserControl
    {
        public EAPaymentNowVIPB()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            ((Dashboard)this.FindForm())?.LoadPage(new ABDashboard());
        }
    }
}
