namespace KahitAno2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            BtnAdmin.HoverState.FillColor = Color.FromArgb(20, 33, 61);
            BtnAdmin.FillColor = Color.FromArgb(0, 120, 215);
            BtnAdmin.FillColor2 = Color.FromArgb(114, 117, 203);
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            BtnUser.FillColor = Color.FromArgb(50, 100, 201);
            BtnUser.FillColor2 = Color.FromArgb(144, 117, 203);
        }
    }
}
