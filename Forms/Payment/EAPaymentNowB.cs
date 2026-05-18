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
            
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            ((Dashboard)this.FindForm())?.LoadPage(new ABDashboard());
        }
    }
}
