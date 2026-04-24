using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class ABDashboard : UserControl
    {
        public ABDashboard()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }
        public void SetGateNumber(string gateNumber, string userName)
        {
            lbVehicle.Text = "Vehicle";
            lbEarning.Text = "Earning";
            lbStatus.Text = "Status";
        }
    }
}
