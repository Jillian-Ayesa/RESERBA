using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _2_3Map : UserControl
    {
        public _2_3Map()
        {
            InitializeComponent();

            // --- SMART CHECKBOX LOGIC (Forces Radio Button Behavior) ---

            // Group 1: Vehicle Types (PUV, PRIV, EV)
            guna2CustomCheckBox4.CheckedChanged += (s, e) => {
                if (guna2CustomCheckBox4.Checked) { guna2CustomCheckBox1.Checked = false; guna2CustomCheckBox2.Checked = false; }
            }; // PUV turns off PRIV and EV

            guna2CustomCheckBox1.CheckedChanged += (s, e) => {
                if (guna2CustomCheckBox1.Checked) { guna2CustomCheckBox4.Checked = false; guna2CustomCheckBox2.Checked = false; }
            }; // PRIV turns off PUV and EV

            guna2CustomCheckBox2.CheckedChanged += (s, e) => {
                if (guna2CustomCheckBox2.Checked) { guna2CustomCheckBox4.Checked = false; guna2CustomCheckBox1.Checked = false; }
            }; // EV turns off PUV and PRIV

            // Group 2: Wheel Count (2W, 4W)
            guna2CustomCheckBox3.CheckedChanged += (s, e) => {
                if (guna2CustomCheckBox3.Checked) guna2CustomCheckBox5.Checked = false;
            }; // 2 Wheels turns off 4 Wheels

            guna2CustomCheckBox5.CheckedChanged += (s, e) => {
                if (guna2CustomCheckBox5.Checked) guna2CustomCheckBox3.Checked = false;
            }; // 4 Wheels turns off 2 Wheels

            // ------------------------------------------------------------
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            List<string> vehicleTypes = new List<string>();
            if (guna2CustomCheckBox4.Checked) vehicleTypes.Add("PUV");
            if (guna2CustomCheckBox1.Checked) vehicleTypes.Add("PRIV");
            if (guna2CustomCheckBox2.Checked) vehicleTypes.Add("EV");

            int wheels = 0;
            if (guna2CustomCheckBox3.Checked) wheels = 2;
            if (guna2CustomCheckBox5.Checked) wheels = 4;

            if (vehicleTypes.Count == 0)
            {
                MessageBox.Show("Please select a vehicle type (PUV, PRIV, or EV).",
                    "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (wheels == 0)
            {
                MessageBox.Show("Please select wheel count (2 Wheels or 4 Wheels).",
                    "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Save selections to temporary memory
            // Because of our new logic above, this will now ALWAYS be just one vehicle type!
            SessionContext.VehicleType = string.Join(", ", vehicleTypes);
            SessionContext.WheelCount = wheels;

            // 2. Route the user to the correct next page
            if (SessionContext.PassengerType == "Valet" || SessionContext.PassengerType == "VIP")
            {
                // BOTH Valets and VIPs skip the Passenger Type selection and go straight to the Map!
                ((Dashboard)this.FindForm())?.LoadPage(new _2_2Map());
            }
            else
            {
                // Normal route: Go to Passenger Type selection (_2_4Maps)
                ((Dashboard)this.FindForm())?.LoadPage(new _2_4Maps());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Clear the memory for this page
            SessionContext.VehicleType = "";
            SessionContext.WheelCount = 0;

            // Everyone (VIP, Valet, and Normal) goes back to Plate Number entry (BAMap)
            ((Dashboard)this.FindForm())?.LoadPage(new _2Map());
        }

        // --- Empty Event Handlers ---
        private void rb4W_CheckedChanged(object sender, EventArgs e) { }
        private void rb2W_CheckedChanged(object sender, EventArgs e) { }
        private void rbEV_CheckedChanged(object sender, EventArgs e) { }
        private void rbPUV_CheckedChanged(object sender, EventArgs e) { }
        private void rbRIV_CheckedChanged(object sender, EventArgs e) { }
        private void _2_3Map_Load(object sender, EventArgs e) { }
        private void guna2CustomCheckBox5_Click(object sender, EventArgs e) { }
        private void guna2CustomCheckBox1_Click(object sender, EventArgs e) { }
    }
}