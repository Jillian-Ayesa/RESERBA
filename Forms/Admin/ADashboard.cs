using Guna.UI2.WinForms;

namespace RESERBA_Proj
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();

            BtnDashboard_Click(this, EventArgs.Empty);
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




        private void BtnVIP_Click(object sender, EventArgs e)
        {
            ButtonOff();
            BtnVIP.FillColor = Color.DarkOrange;
            _4VIP vipPage = new _4VIP();
            LoadPage(vipPage);
        }

        public void LoadPage(UserControl userControl)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public void SetGateNumber(string gateNumber, string userName)
        {
            SessionContext.GateId = gateNumber;
            lbUser.Text = userName;
            label3.Text = gateNumber;
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            ButtonOff();
            BtnInfo.FillColor = Color.DarkOrange;
            Information InfoPage = new Information();
            LoadPage(InfoPage);
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            AACStart nextScreen = new AACStart();
            nextScreen.Show();
            this.Hide();
        }
    }
}
