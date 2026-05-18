using MySql.Data.MySqlClient;
using RESERBA_Proj.Database;
using RESERBA_Proj.Database.GuardRepository;
using RESERBA_Proj.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class ABDashboard : UserControl
    {
        // 1. Declare dynamic UI components and filters
        private FlowLayoutPanel flpVehicles;
        private System.Windows.Forms.Timer refreshTimer;
        private string currentFilter = "Unpaid";

        public ABDashboard()
        {
            InitializeComponent();
        }

        private void LoadTotalEarnings()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    // Ask the database to SUM (add up) all the amount_paid columns for Paid sessions
                    var cmd = new MySqlCommand("SELECT SUM(amount_paid) FROM parking_sessions WHERE payment_status = 'Paid'", conn);

                    object result = cmd.ExecuteScalar();
                    decimal totalEarnings = 0;

                    // If the database isn't totally empty, convert the result to a decimal
                    if (result != DBNull.Value && result != null)
                    {
                        totalEarnings = Convert.ToDecimal(result);
                    }

                    // Update UI label to show the formatted money amount!
                    lblEarnings.Text = $"PHP {totalEarnings:N2}";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading earnings: " + ex.Message);
            }
        }
        private void ABDashboard_Load_1(object sender, EventArgs e)
        {
            // Center default sub-control
            panel1.Controls.Clear();
            SlotButton mySlotButton = new SlotButton();
            panel1.Controls.Add(mySlotButton);
            mySlotButton.Anchor = AnchorStyles.None;

            // Initialize dynamic real-time list
            SetupDynamicList();
            LoadOccupiedSlots();
            LoadTotalEarnings();
            StartRealTimeUpdates();
        }


        private void SetupDynamicList()
        {
            // Create a scrolling container to hold an unlimited number of vehicles
            flpVehicles = new FlowLayoutPanel
            {
                Location = new Point(50, 89), // Aligned right under  search bar
                Size = new Size(455, 375),    // Fits perfectly above the Paid/Unpaid buttons
                AutoScroll = true,            // Allows scrolling if there are > 6 cars
                BackColor = Color.FromArgb(168, 211, 252), // Matches big background
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };

            panel2.Controls.Add(flpVehicles);
            flpVehicles.BringToFront();

            // Wire up the Search Bar dynamically so it filters as you type
            tbSearch.TextChanged += (s, e) => LoadOccupiedSlots();

            // Wire up the Paid and Unpaid Buttons
            BtnUnpaid.Click += (s, e) =>
            {
                currentFilter = "Unpaid";
                LoadOccupiedSlots();
            };

            BtnPaid.Click += (s, e) =>
            {
                currentFilter = "Paid";
                LoadOccupiedSlots();
            };

            // Hide the hardcoded designer items to prevent overlapping
            label1.Visible = label2.Visible = label5.Visible = label6.Visible = label7.Visible = label8.Visible = label9.Visible = false;
            guna2Button2.Visible = guna2Button3.Visible = guna2Button4.Visible = guna2Button5.Visible = guna2Button6.Visible = guna2Button9.Visible = false;
            BtnInfo1.Visible = BtnInfo2.Visible = BtnInfo3.Visible = BtnInfo4.Visible = BtnInfo5.Visible = BtnInfo6.Visible = false;
        }
        private readonly IGuardRepository _guardRepo = new GuardRepository();
        private void LoadOccupiedSlots()
        {
            int scrollPos = flpVehicles.VerticalScroll.Value;
            flpVehicles.SuspendLayout();
            flpVehicles.Controls.Clear();

            if (_guardRepo.MapStatus(currentFilter, tbSearch.Text.Trim(), out List<ParkingSession> sessions))
            {
                foreach (var s in sessions)
                    flpVehicles.Controls.Add(CreateVehicleRow(s.SessionId, s.SlotId, s.PlateNumber));
            }
            else
            {
                Console.WriteLine("Error loading vehicles.");
            }

            flpVehicles.ResumeLayout();
            if (scrollPos <= flpVehicles.VerticalScroll.Maximum)
                flpVehicles.VerticalScroll.Value = scrollPos;
        }

        private Control CreateVehicleRow(string sessionId, string slotId, string plate)
        {
            // Create the rounded background mimicking Guna2Button setup
            Guna.UI2.WinForms.Guna2Panel rowPanel = new Guna.UI2.WinForms.Guna2Panel
            {
                Size = new Size(430, 55),
                FillColor = Color.FromArgb(214, 235, 255),
                BorderRadius = 10,
                Margin = new Padding(0, 0, 0, 8)
            };

            // Format the text label
            Label lblInfo = new Label
            {
                Text = $"{slotId} | {plate}",
                Font = new Font("Aribau Rounded Trial", 18F, FontStyle.Regular),
                ForeColor = Color.Black,
                BackColor = Color.Transparent, // Ensures text doesn't block rounded corners
                AutoSize = true,
                Location = new Point(15, 12)
            };

            // Inject the Info Icon
            Guna.UI2.WinForms.Guna2Button btnInfo = new Guna.UI2.WinForms.Guna2Button
            {
                Size = new Size(45, 45),
                Location = new Point(375, 5),
                FillColor = Color.Transparent,
                Image = BtnInfo1.Image, // Grabs the exact icon you used in the designer
                ImageSize = new Size(40, 40),
                Cursor = Cursors.Hand,
                Tag = sessionId // Attach the Session ID to the button
            };

            // Info Button Click Event
            btnInfo.Click += (s, e) =>
            {
                // Grab the hidden session ID from the button
                string clickedSession = ((Control)s).Tag.ToString();

                // 1. Save it to memory so the next page knows which car to look up!
                SessionContext.ActiveSessionId = clickedSession;

                // 2. Stop the dashboard auto-refresh timer so it doesn't cause glitches in the background
                refreshTimer?.Stop();

                // 3. Redirect the main window to new EstimationDetails form
                ((Dashboard)this.FindForm())?.LoadPage(new EstimatedDetails());
            };

            rowPanel.Controls.Add(lblInfo);
            rowPanel.Controls.Add(btnInfo);
            return rowPanel;
        }

        private void StartRealTimeUpdates()
        {
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 5000; // Refreshes automatically every 5 seconds

            refreshTimer.Tick += (s, e) =>
            {
                LoadOccupiedSlots();
                LoadTotalEarnings(); // <-- NEW: Recalculate the money every 5 seconds!
            };

            refreshTimer.Start();
        }

        // ── Existing Intact Methods ───────────────────────────────────────

        public void LoadSub(SlotButton userControl)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);

            int centerX = (panel1.Width - userControl.Width) / 2;
            int centerY = (panel1.Height - userControl.Height) / 2;

            userControl.Location = new Point(centerX, centerY);
            userControl.Anchor = AnchorStyles.None;
            userControl.BringToFront();
        }

        private void lbStatus_Click(object sender, EventArgs e) { }
        private void guna2Button7_Click(object sender, EventArgs e) { }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void BtnMaps_Click(object sender, EventArgs e)
        {
            SessionContext.ClearSession();
            ((Dashboard)this.FindForm())?.LoadPage(new _2_2Map());
        }

        private void BtnTransact_Click(object sender, EventArgs e)
        {
            ((Dashboard)this.FindForm())?.LoadPage(new _2Map());
        }

        private void label4_Click(object sender, EventArgs e) { }
        private void guna2Button9_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnInfo1_Click(object sender, EventArgs e)
        {

        }

        private void BtnInfo2_Click(object sender, EventArgs e)
        {

        }
    }
}