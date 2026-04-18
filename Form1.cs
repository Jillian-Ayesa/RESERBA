namespace RESERBA
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Form2 roleSelectionForm = new Form2();

            // Show the new form
            roleSelectionForm.Show();

            // Hide the current welcome form so it doesn't stay open in the background
            this.Hide();
        }

        

        
    }
}
