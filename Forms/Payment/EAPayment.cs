using MySql.Data.MySqlClient;
using RESERBA_Proj.Database;
using RESERBA_Proj.Database.GuardRepository;
using RESERBA_Proj.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class EAPayment : UserControl
    {
        public EAPayment()
        {
            InitializeComponent();
        }

        private void BtnPayNow_Click_1(object sender, EventArgs e)
        {
            CreateSessionInDb("Now");

            if (SessionContext.PassengerType == "Valet")
                ((Dashboard)this.FindForm())?.LoadPage(new EAPaymentNowVIPA());
            else
                ((Dashboard)this.FindForm())?.LoadPage(new _5_1PaymentNow1_old());
        }

        private void BtnPayLater_Click_1(object sender, EventArgs e)
        {
            CreateSessionInDb("Later");
            ((Dashboard)this.FindForm())?.LoadPage(new _5_1PaymentNow2());
        }
        private readonly IGuardRepository _guardRepo = new GuardRepository();
        private void CreateSessionInDb(string paymentType)
        {
            string primaryVehicle = SessionContext.VehicleType ?? "Car";
            if (primaryVehicle.Contains(","))
                primaryVehicle = primaryVehicle.Split(',')[0].Trim();

            string passengerType = SessionContext.PassengerType ?? "Standard";

            if (_guardRepo.FetchRate(primaryVehicle, passengerType, paymentType,
                                     out ParkingSession session, out decimal amountDue))
            {
                if (session is StandardSession std && SessionContext.EstimatedDuration > 0)
                    std.SetEstimatedDuration(SessionContext.EstimatedDuration * 60);

                SessionContext.ActiveSessionId = session.SessionId;
            }
            else
            {
                MessageBox.Show("Error creating session.",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            BtnPayLater = new Guna.UI2.WinForms.Guna2Button();
            BtnPayNow = new Guna.UI2.WinForms.Guna2Button();
            panel2.SuspendLayout();
            SuspendLayout();
            panel2.BackColor = Color.FromArgb(168, 211, 252);
            panel2.Controls.Add(BtnPayLater);
            panel2.Controls.Add(BtnPayNow);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(945, 570);
            panel2.TabIndex = 20;
            BtnPayLater.BorderColor = Color.Navy;
            BtnPayLater.BorderRadius = 20;
            BtnPayLater.BorderThickness = 5;
            BtnPayLater.CustomizableEdges = customizableEdges1;
            BtnPayLater.DisabledState.BorderColor = Color.DarkGray;
            BtnPayLater.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnPayLater.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnPayLater.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnPayLater.FillColor = Color.FromArgb(168, 211, 252);
            BtnPayLater.Font = new Font("Aribau Rounded Trial", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPayLater.ForeColor = Color.Navy;
            BtnPayLater.HoverState.FillColor = Color.Navy;
            BtnPayLater.HoverState.ForeColor = Color.White;
            BtnPayLater.Location = new Point(474, 215);
            BtnPayLater.Name = "BtnPayLater";
            BtnPayLater.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnPayLater.Size = new Size(432, 128);
            BtnPayLater.TabIndex = 4;
            BtnPayLater.Text = "PAY LATER";
            BtnPayLater.Click += BtnPayLater_Click_1;
            BtnPayNow.BorderColor = Color.Navy;
            BtnPayNow.BorderRadius = 20;
            BtnPayNow.BorderThickness = 5;
            BtnPayNow.CustomizableEdges = customizableEdges3;
            BtnPayNow.DisabledState.BorderColor = Color.DarkGray;
            BtnPayNow.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnPayNow.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnPayNow.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnPayNow.FillColor = Color.FromArgb(168, 211, 252);
            BtnPayNow.Font = new Font("Aribau Rounded Trial", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPayNow.ForeColor = Color.Navy;
            BtnPayNow.HoverState.FillColor = Color.Navy;
            BtnPayNow.HoverState.ForeColor = Color.White;
            BtnPayNow.Location = new Point(42, 215);
            BtnPayNow.Name = "BtnPayNow";
            BtnPayNow.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BtnPayNow.Size = new Size(402, 128);
            BtnPayNow.TabIndex = 3;
            BtnPayNow.Text = "PAY NOW";
            BtnPayNow.Click += BtnPayNow_Click_1;
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(168, 211, 252);
            Controls.Add(panel2);
            Name = "EAPayment";
            Size = new Size(1280, 720);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button BtnPayLater;
        private Guna.UI2.WinForms.Guna2Button BtnPayNow;
    }
}