using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RESERBA_Proj.Database;

namespace RESERBA_Proj
{
    public partial class _5_1EstimatedDuration : UserControl
    {
        private int selectedHours = 0;

        public _5_1EstimatedDuration()
        {
            InitializeComponent();
            LoadSessionData();
        }

        private void LoadSessionData()
        {
            lblLargePlate.Text = SessionContext.PlateNumber ?? "N/A";
            lblPlateValue.Text = SessionContext.PlateNumber ?? "N/A";
            lblVehicleValue.Text = SessionContext.VehicleType ?? "N/A";
            lblSlotValue.Text = SessionContext.SelectedSlotId ?? "N/A";
            lblTimeInValue.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void CalculateEstimatedTimeOut(int hours)
        {
            selectedHours = hours;
            DateTime timeIn = DateTime.Now;
            DateTime timeOut = timeIn.AddHours(hours);

            lblTimeOut.Text = timeOut.ToString("hh:mm tt");

            // Save to SessionContext
            SessionContext.EstimatedDuration = hours;
            SessionContext.EstimatedTimeOut = timeOut;
        }

        private void UpdateSessionInDb()
        {
            if (string.IsNullOrEmpty(SessionContext.ActiveSessionId)) return;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "UPDATE parking_sessions " +
                        "SET estimated_duration = @dur " +
                        "WHERE session_id = @id", conn);
                    cmd.Parameters.AddWithValue("@dur", SessionContext.EstimatedDuration);
                    cmd.Parameters.AddWithValue("@id", SessionContext.ActiveSessionId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating duration: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            if (selectedHours == 0)
            {
                MessageBox.Show("Please select a duration first.",
                    "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save to DB
            UpdateSessionInDb();

            // Go to receipt/dashboard
            ((Dashboard)this.FindForm())?.LoadPage(new _5_1PaymentNow1_old());
        }

        // ── Duration buttons ──────────────────────
        private void guna2Button2_Click(object sender, EventArgs e)
        { CalculateEstimatedTimeOut(1); }
        private void guna2Button3_Click(object sender, EventArgs e)
        { CalculateEstimatedTimeOut(2); }
        private void btn3hr_Click(object sender, EventArgs e)
        { CalculateEstimatedTimeOut(3); }
        private void guna2Button5_Click(object sender, EventArgs e)
        { CalculateEstimatedTimeOut(4); }
        private void btn5hr_Click(object sender, EventArgs e)
        { CalculateEstimatedTimeOut(5); }
        private void btn6hr_Click(object sender, EventArgs e)
        { CalculateEstimatedTimeOut(6); }
        private void btn7hr_Click(object sender, EventArgs e)
        { CalculateEstimatedTimeOut(8); }
        private void btn12hr_Click(object sender, EventArgs e)
        { CalculateEstimatedTimeOut(12); }

        // ── Empty stubs ───────────────────────────
        private void label4_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void ReceiptTotal_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void lblVehicleValue_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void guna2Button10_Click(object sender, EventArgs e)
        {

            if (selectedHours == 0)
            {
                MessageBox.Show("Please select a duration first.",
                    "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save to DB
            UpdateSessionInDb();

            // Go to receipt
            ((Dashboard)this.FindForm())?.LoadPage(new _5_1PaymentNow1_old());

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ((Dashboard)this.FindForm())?.LoadPage(new _2_4Maps());
        }
    }
}