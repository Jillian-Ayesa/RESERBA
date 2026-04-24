using Guna.UI2.WinForms;

namespace RESERBA_Proj
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }
        private void ButtonOff()
        {
            foreach (var control in SidePanel1.Controls)
            {
                if (control is Guna2Button Btn)
                {
                    Btn.FillColor = Color.Transparent;
                }
            }

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            ButtonOff();
            BtnDashboard.FillColor = Color.DarkOrange;
            ABDashboard DashPage = new ABDashboard();
            LoadPage(DashPage);
        }

        private void BtnMap_Click(object sender, EventArgs e)
        {
            ButtonOff();
            BtnMap.FillColor = Color.DarkOrange;
            _2Map mapPage = new _2Map();
            LoadPage(mapPage);
        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ButtonOff();
            BtnSearch.FillColor = Color.DarkOrange;
            _3Search searchPage = new _3Search();
            LoadPage(searchPage);
        }

        private void BtnVIP_Click(object sender, EventArgs e)
        {
            ButtonOff();
            BtnVIP.FillColor = Color.DarkOrange;
            _4VIP vipPage = new _4VIP();
            LoadPage(vipPage);
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            ButtonOff();
            BtnPayment.FillColor = Color.DarkOrange;
            _5_1Payment paymentPage = new _5_1Payment();
            LoadPage(paymentPage);
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            ButtonOff();
            BtnInfo.FillColor = Color.DarkOrange;
            _6_1Info infoPage = new _6_1Info();
            LoadPage(infoPage);
        }

        public void LoadPage(UserControl userControl)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public void SetGateNumber(string gateNumber, string userName)
        {
            lbUser.Text = userName;
            label3.Text = gateNumber;
            lbVehicle.Text = "Vehicle";
            lbEarning.Text = "Earning";
            lbStatus.Text = "Status";
        }
    }
}
