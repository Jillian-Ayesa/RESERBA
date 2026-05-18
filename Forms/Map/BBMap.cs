using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using RESERBA_Proj.Database;
using RESERBA_Proj.Database.GuardRepository;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _2_2Map : UserControl
    {
        private enum SlotAccess { Allowed, Alternative, NotAllowed }

        private string selectedSlotId = null;
        private Guna2Button selectedButton = null;
        private System.Windows.Forms.Timer refreshTimer;

        public _2_2Map()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                FontManager.ApplyFontToAll(this);
                SetupTimer();
                if (!string.IsNullOrEmpty(SessionContext.GateId))
                {
                    cmbFloor.Text = SessionContext.GateId;
                }
                else
                {
                    cmbFloor.SelectedIndex = 0;
                }
            }
        }

        private void SetupTimer()
        {
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 5000;
            refreshTimer.Tick += (s, e) => LoadSlots(cmbFloor.Text);
            refreshTimer.Start();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSlotId = null;
            selectedButton = null;
            LoadSlots(cmbFloor.Text);
        }

        private SlotAccess GetSlotAccess(string slotType)
        {
            string passenger = SessionContext.PassengerType ?? "";
            string vehicle = SessionContext.VehicleType ?? "";
            string wheelSuffix = SessionContext.WheelCount == 2 ? "2W" : "4W";

            if (string.IsNullOrEmpty(passenger)) return SlotAccess.Allowed;

            switch (passenger)
            {
                case "VIP":
                    if (slotType == $"VIP-{wheelSuffix}" || slotType == "VIP")
                        return SlotAccess.Allowed;
                    return SlotAccess.NotAllowed;

                case "PWD":
                    if (slotType == $"PWD-{wheelSuffix}" || slotType == "PWD")
                        return SlotAccess.Allowed;
                    if (slotType == $"REG-{wheelSuffix}" || slotType == "Regular")
                        return SlotAccess.Alternative;
                    return SlotAccess.NotAllowed;

                case "Standard":
                case "Student":
                    if (vehicle.Contains("EV"))
                    {
                        if (slotType == $"EV-{wheelSuffix}" || slotType == "EV")
                            return SlotAccess.Allowed;
                        if (slotType == $"REG-{wheelSuffix}" || slotType == "Regular")
                            return SlotAccess.Alternative;
                        return SlotAccess.NotAllowed;
                    }
                    if (slotType == $"REG-{wheelSuffix}" || slotType == "Regular")
                        return SlotAccess.Allowed;
                    return SlotAccess.NotAllowed;

                // --- NEW VALET RESTRICTIONS ---
                case "Valet":
                    if (vehicle.Contains("EV"))
                    {
                        if (slotType == $"EV-{wheelSuffix}" || slotType == "EV")
                            return SlotAccess.Allowed;
                        if (slotType == $"REG-{wheelSuffix}" || slotType == "Regular")
                            return SlotAccess.Alternative;
                        return SlotAccess.NotAllowed;
                    }
                    if (slotType == $"REG-{wheelSuffix}" || slotType == "Regular")
                        return SlotAccess.Allowed;

                    return SlotAccess.NotAllowed;


                default:
                    return SlotAccess.Allowed;
            }
        }
        private readonly IGuardRepository _guardRepo = new GuardRepository();

        private void LoadSlots(string gateId)
        {
            pnlSlotGrid.Controls.Clear();
            pnlSlotInfo.Controls.Clear();

            TableLayoutPanel grid = new TableLayoutPanel();
            grid.ColumnCount = 5;
            grid.AutoSize = true;
            grid.Padding = new Padding(10);
            grid.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            for (int i = 0; i < 5; i++)
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120));

            try
            {
                var slots = _guardRepo.GetSlots(gateId);

                int totalSlots = slots.Count;
                int availableSlots = slots.Count(s => !s.IsOccupied);

                foreach (var slot in slots)
                    grid.Controls.Add(CreateSlotButton(slot.SlotId, slot.IsOccupied, slot.SlotType));

                lblAvailable.Text = $"({availableSlots}/{totalSlots} Available)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading slots: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pnlSlotGrid.Controls.Add(grid);
            LoadOtherGatesAvailability();
        }

        private Guna2Button CreateSlotButton(string slotId, bool isOccupied, string slotType)
        {
            Guna2Button btn = new Guna2Button();
            btn.Size = new Size(100, 80);
            btn.Margin = new Padding(5);
            btn.BorderRadius = 10;
            btn.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
            btn.Tag = slotId;

            if (isOccupied)
            {
                btn.FillColor = Color.IndianRed;
                btn.ForeColor = Color.White;
                btn.Text = $"{slotId}\n[OCCUPIED]\n{slotType}";
                btn.Enabled = true;
                btn.Click += OccupiedSlotButton_Click;
                return btn;
            }

            SlotAccess access = !string.IsNullOrEmpty(SessionContext.PassengerType)
                ? GetSlotAccess(slotType)
                : SlotAccess.Allowed;

            switch (access)
            {
                case SlotAccess.Allowed:
                    if (slotType.StartsWith("VIP"))
                    {
                        btn.FillColor = Color.Gold;
                        btn.ForeColor = Color.DarkRed;
                    }
                    else if (slotType.StartsWith("PWD"))
                    {
                        btn.FillColor = Color.CornflowerBlue;
                        btn.ForeColor = Color.White;
                    }
                    else if (slotType.StartsWith("EV"))
                    {
                        btn.FillColor = Color.LimeGreen;
                        btn.ForeColor = Color.White;
                    }
                    else
                    {
                        btn.FillColor = Color.MediumSeaGreen;
                        btn.ForeColor = Color.White;
                    }
                    btn.Text = $"{slotId}\n[OPEN]\n{slotType}";
                    btn.Click += SlotButton_Click;
                    break;

                case SlotAccess.Alternative:
                    btn.FillColor = Color.Orange;
                    btn.ForeColor = Color.White;
                    btn.Text = $"{slotId}\n[OPEN]\n{slotType}";
                    btn.Click += AlternativeSlotButton_Click;
                    break;

                case SlotAccess.NotAllowed:
                    btn.FillColor = Color.LightGray;
                    btn.ForeColor = Color.DarkGray;
                    btn.Text = $"{slotId}\n[OPEN]\n{slotType}";
                    btn.Enabled = false;
                    break;
            }

            return btn;
        }

        private void SlotButton_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string slotId = btn.Tag.ToString();

            if (selectedButton != null)
            {
                selectedButton.FillColor = Color.MediumSeaGreen;
                selectedButton.Text = selectedButton.Tag + "\n[OPEN]";
            }

            btn.FillColor = Color.DodgerBlue;
            btn.Text = slotId + "\n[SELECTED]";
            selectedSlotId = slotId;
            selectedButton = btn;
        }

        private void AlternativeSlotButton_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string slotId = btn.Tag.ToString();

            var result = MessageBox.Show(
                $"Slot {slotId} is not your designated slot type.\n\n" +
                $"Your designated slot type is full or unavailable.\n\n" +
                $"Are you sure you want to use this slot?",
                "Alternative Slot",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (selectedButton != null)
                {
                    selectedButton.FillColor = Color.Orange;
                    selectedButton.Text = selectedButton.Tag + "\n[OPEN]";
                }

                btn.FillColor = Color.DodgerBlue;
                btn.Text = slotId + "\n[SELECTED]";
                selectedSlotId = slotId;
                selectedButton = btn;
            }
        }

        private void OccupiedSlotButton_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string slotId = btn.Tag.ToString();

            var result = MessageBox.Show(
                $"Slot {slotId} is currently occupied.\n\nDo you want to unoccupy it?",
                "Unoccupy Slot",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        var cmd = new MySqlCommand(
                            "UPDATE parking_slots SET is_occupied=FALSE WHERE slot_id=@id", conn);
                        cmd.Parameters.AddWithValue("@id", slotId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Slot {slotId} has been unoccupied!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadSlots(cmbFloor.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadOtherGatesAvailability()
        {
            pnlSlotInfo.Controls.Clear();

            FlowLayoutPanel infoFlow = new FlowLayoutPanel();
            infoFlow.FlowDirection = FlowDirection.TopDown;
            infoFlow.AutoScroll = true;
            infoFlow.Dock = DockStyle.Fill;
            infoFlow.Padding = new Padding(5);
            infoFlow.WrapContents = false;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Determine which slot types to show based on passenger + vehicle
                    string filterTypes = GetFilterForPanel();

                    // --- NEW: Grab the currently selected gate from the dropdown! ---
                    string currentGate = cmbFloor.Text;

                    string query = $@"
                SELECT slot_id, slot_type, gate_id
                FROM parking_slots
                WHERE is_occupied = FALSE
                AND gate_id = @gate
                AND slot_type IN ({filterTypes})
                ORDER BY slot_type, gate_id, 
                CAST(SUBSTRING_INDEX(slot_id, '-P', -1) AS UNSIGNED)";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@gate", currentGate); // Pass the gate to the database
                    var reader = cmd.ExecuteReader();
                    bool hasAny = false;

                    while (reader.Read())
                    {
                        hasAny = true;
                        string slotId = reader["slot_id"].ToString();
                        string slotType = reader["slot_type"].ToString();
                        string gateId = reader["gate_id"].ToString();

                        // Format: G1 | G1-P38 | EV-4W
                        string gateShort = gateId.Replace("Gate ", "G");

                        Panel card = new Panel();
                        card.Size = new Size(210, 35);
                        card.Margin = new Padding(0, 2, 0, 2);

                        // Color by slot type
                        if (slotType.StartsWith("VIP"))
                            card.BackColor = Color.Gold;
                        else if (slotType.StartsWith("PWD"))
                            card.BackColor = Color.CornflowerBlue;
                        else if (slotType.StartsWith("EV"))
                            card.BackColor = Color.LimeGreen;
                        else
                            card.BackColor = Color.MediumSeaGreen;

                        Label lbl = new Label();
                        lbl.Text = $"  {gateShort} | {slotId} | {slotType}";
                        lbl.ForeColor = Color.White;
                        lbl.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
                        lbl.Dock = DockStyle.Fill;
                        lbl.TextAlign = ContentAlignment.MiddleLeft;
                        card.Controls.Add(lbl);
                        infoFlow.Controls.Add(card);
                    }

                    if (!hasAny)
                    {
                        Label noSlots = new Label();
                        noSlots.Text = "  No available slots found";
                        noSlots.ForeColor = Color.IndianRed;
                        noSlots.Font = new Font("Segoe UI", 8f, FontStyle.Italic);
                        noSlots.Size = new Size(210, 25);
                        noSlots.Margin = new Padding(0, 5, 0, 0);
                        infoFlow.Controls.Add(noSlots);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading availability: " + ex.Message);
            }

            pnlSlotInfo.Controls.Add(infoFlow);
        }

        private string GetFilterForPanel()
        {
            string passenger = SessionContext.PassengerType ?? "";
            string vehicle = SessionContext.VehicleType ?? "";

            // --- REVISED WHEEL SUFFIX LOGIC ---
            string wheelSuffix = SessionContext.WheelCount == 2 ? "2W" : "4W";

            // If not transacting, show all
            if (string.IsNullOrEmpty(passenger))
                return "'VIP-4W','VIP-2W','PWD-4W','PWD-2W','EV-4W','EV-2W','REG-4W','REG-2W','Regular','VIP','PWD','EV'";

            switch (passenger)
            {
                case "VIP":
                    return $"'VIP-{wheelSuffix}', 'VIP'";
                case "PWD":
                    return $"'PWD-{wheelSuffix}', 'REG-{wheelSuffix}', 'PWD', 'Regular'";
                case "Standard":
                case "Student":
                    if (vehicle.Contains("EV"))
                        return $"'EV-{wheelSuffix}', 'REG-{wheelSuffix}', 'EV', 'Regular'";
                    return $"'REG-{wheelSuffix}', 'Regular'";

                // --- NEW VALET PANEL FILTER ---
                case "Valet":
                    if (vehicle.Contains("EV"))
                        return $"'EV-{wheelSuffix}', 'REG-{wheelSuffix}', 'EV', 'Regular'";
                    return $"'REG-{wheelSuffix}', 'Regular'";
                // ------------------------------

                default:
                    return "'REG-4W','REG-2W','Regular'";
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            refreshTimer?.Stop();

            // Smart Back Button Routing
            if (SessionContext.PassengerType == "Valet")
            {
                ((Dashboard)this.FindForm())?.LoadPage(new _2_3Map());
            }
            else if (SessionContext.PassengerType == "VIP")
            {
                // VIPs came directly from the VIP selection screen
                ((Dashboard)this.FindForm())?.LoadPage(new _4VIP());
            }
            else
            {
                ((Dashboard)this.FindForm())?.LoadPage(new _2_4Maps());
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedSlotId))
            {
                MessageBox.Show("Please select a slot first.", "No Slot Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SessionContext.SelectedSlotId = selectedSlotId;
            SessionContext.GateId = cmbFloor.Text; // Save the gate they selected
            refreshTimer?.Stop();

            // --- 1. UPDATE DB FOR VIP OR VALET ---
            if (SessionContext.PassengerType == "VIP" || SessionContext.PassengerType == "Valet")
            {
                if (!string.IsNullOrEmpty(SessionContext.ActiveSessionId))
                {
                    try
                    {
                        using (var conn = DatabaseHelper.GetConnection())
                        {
                            conn.Open();
                            var updateCmd = new MySqlCommand(@"
                        UPDATE parking_sessions 
                        SET plate_number = @plate, 
                            vehicle_type = @vtype, 
                            wheel_count = @wheels, 
                            slot_id = @slot, 
                            gate_id = @gate 
                        WHERE session_id = @sid", conn);

                            // VIPs skip the info pages, so we use placeholders if the data is missing
                            updateCmd.Parameters.AddWithValue("@plate", string.IsNullOrEmpty(SessionContext.PlateNumber) ? "VIP-GUEST" : SessionContext.PlateNumber);
                            updateCmd.Parameters.AddWithValue("@vtype", string.IsNullOrEmpty(SessionContext.VehicleType) ? "VIP" : SessionContext.VehicleType);
                            updateCmd.Parameters.AddWithValue("@wheels", SessionContext.WheelCount == 0 ? 4 : SessionContext.WheelCount);
                            updateCmd.Parameters.AddWithValue("@slot", SessionContext.SelectedSlotId);
                            updateCmd.Parameters.AddWithValue("@gate", SessionContext.GateId);
                            updateCmd.Parameters.AddWithValue("@sid", SessionContext.ActiveSessionId);

                            updateCmd.ExecuteNonQuery();

                            // Mark the slot as occupied so no one else can take it
                            var slotCmd = new MySqlCommand("UPDATE parking_slots SET is_occupied=TRUE WHERE slot_id=@id", conn);
                            slotCmd.Parameters.AddWithValue("@id", SessionContext.SelectedSlotId);
                            slotCmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating session: " + ex.Message, "DB Error");
                    }
                }

                // --- 2. DIRECT ROUTING ---
                // Both VIP and Valet go straight to the final confirmation screen!
                ((Dashboard)this.FindForm())?.LoadPage(new EAPaymentNowVIPB());
            }
            else
            {
                // Normal users go to the Standard Payment Choice screen
                ((Dashboard)this.FindForm())?.LoadPage(new _5_1EstimatedDuration());
            }
        }

        private void pnlSlotInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}