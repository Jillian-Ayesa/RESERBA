using System;
using System.Windows.Forms;
using System.Text.RegularExpressions; // NEW: Required for pattern validation

namespace RESERBA_Proj
{
    public partial class _2Map : UserControl
    {
        public _2Map()
        {
            InitializeComponent();
        }
        public static bool IsValetFlow { get; set; } = false;
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string plate = TbParkingID.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(plate))
            {
                MessageBox.Show("Please enter a plate number.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- NEW: STRICT PLATE NUMBER VALIDATION ---
            // This pattern requires exactly 3 letters, an optional space or dash, and exactly 4 digits.
            if (!Regex.IsMatch(plate, @"^[A-Z]{3}[-\s]?\d{4}$"))
            {
                MessageBox.Show("Please enter a valid plate number format (e.g., ABC-1234).", "Invalid Format",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Smart Formatting: If they typed "ABC1234" or "ABC 1234", force it into the clean "ABC-1234" format
            plate = plate.Replace(" ", ""); // Remove any spaces
            if (!plate.Contains("-"))
            {
                plate = plate.Insert(3, "-"); // Inject the dash after the 3rd letter
            }
            // -------------------------------------------

            string guardUsername = SessionContext.GuardUsername;
            int guardId = SessionContext.GuardId;
            string gateId = SessionContext.GateId;

            // Preserve Valet-specific data ONLY if this is a Valet flow
            string passengerType = IsValetFlow ? SessionContext.PassengerType : null;
            string activeSession = IsValetFlow ? SessionContext.ActiveSessionId : null;

            SessionContext.ClearSession();

            SessionContext.GuardUsername = guardUsername;
            SessionContext.GuardId = guardId;
            SessionContext.GateId = gateId;
            SessionContext.PassengerType = passengerType;
            SessionContext.ActiveSessionId = activeSession;
            SessionContext.PlateNumber = plate;

            // Reset flag after use
            IsValetFlow = false;

            // Move forward to Vehicle Selection
            ((Dashboard)this.FindForm())?.LoadPage(new _2_3Map());
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // --- SMART BACK ROUTING ---
            if (SessionContext.PassengerType == "VIP" || SessionContext.PassengerType == "Valet")
            {
                // VIPs and Valets go back to the Receipt!
                ((Dashboard)this.FindForm())?.LoadPage(new EAPaymentNowVIPA());
            }
            else
            {
                // Normal users go back to the Dashboard!
                ((Dashboard)this.FindForm())?.LoadPage(new ABDashboard());
            }
        }

        private void TbParkingID_TextChanged(object sender, EventArgs e) { }
    }
}