namespace RESERBA_Proj
{
    partial class _2_2Map
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            btnContinue = new Guna.UI2.WinForms.Guna2Button();
            pnlSlotInfo = new Guna.UI2.WinForms.Guna2GradientPanel();
            pnlSlotGrid = new Guna.UI2.WinForms.Guna2Panel();
            cmbFloor = new Guna.UI2.WinForms.Guna2ComboBox();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            lblAvailable = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(168, 211, 252);
            panel2.Controls.Add(btnContinue);
            panel2.Controls.Add(pnlSlotInfo);
            panel2.Controls.Add(pnlSlotGrid);
            panel2.Controls.Add(cmbFloor);
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(lblAvailable);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(945, 570);
            panel2.TabIndex = 19;
            // 
            // btnContinue
            // 
            btnContinue.BorderColor = Color.Navy;
            btnContinue.BorderRadius = 10;
            btnContinue.BorderThickness = 1;
            btnContinue.CustomizableEdges = customizableEdges1;
            btnContinue.DisabledState.BorderColor = Color.DarkGray;
            btnContinue.DisabledState.CustomBorderColor = Color.DarkGray;
            btnContinue.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnContinue.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnContinue.FillColor = Color.FromArgb(168, 211, 252);
            btnContinue.Font = new Font("Aribau Rounded Trial", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinue.ForeColor = Color.Navy;
            btnContinue.HoverState.FillColor = Color.Navy;
            btnContinue.HoverState.ForeColor = Color.White;
            btnContinue.Location = new Point(732, 461);
            btnContinue.Name = "btnContinue";
            btnContinue.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnContinue.Size = new Size(130, 40);
            btnContinue.TabIndex = 7;
            btnContinue.Text = "continue";
            btnContinue.Click += btnContinue_Click;
            // 
            // pnlSlotInfo
            // 
            pnlSlotInfo.CustomizableEdges = customizableEdges3;
            pnlSlotInfo.Location = new Point(670, 78);
            pnlSlotInfo.Name = "pnlSlotInfo";
            pnlSlotInfo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlSlotInfo.Size = new Size(242, 363);
            pnlSlotInfo.TabIndex = 6;
            pnlSlotInfo.Paint += pnlSlotInfo_Paint;
            // 
            // pnlSlotGrid
            // 
            pnlSlotGrid.AutoScroll = true;
            pnlSlotGrid.CustomizableEdges = customizableEdges5;
            pnlSlotGrid.Location = new Point(14, 70);
            pnlSlotGrid.Name = "pnlSlotGrid";
            pnlSlotGrid.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlSlotGrid.Size = new Size(639, 478);
            pnlSlotGrid.TabIndex = 5;
            // 
            // cmbFloor
            // 
            cmbFloor.BackColor = Color.Transparent;
            cmbFloor.CustomizableEdges = customizableEdges7;
            cmbFloor.DisplayMember = "Hello";
            cmbFloor.DrawMode = DrawMode.OwnerDrawFixed;
            cmbFloor.DropDownHeight = 170;
            cmbFloor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFloor.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbFloor.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbFloor.Font = new Font("Segoe UI", 10F);
            cmbFloor.ForeColor = Color.FromArgb(68, 88, 112);
            cmbFloor.IntegralHeight = false;
            cmbFloor.ItemHeight = 30;
            cmbFloor.Items.AddRange(new object[] { "Gate 1", "Gate 2", "Gate 3" });
            cmbFloor.Location = new Point(14, 14);
            cmbFloor.Name = "cmbFloor";
            cmbFloor.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cmbFloor.Size = new Size(369, 36);
            cmbFloor.TabIndex = 4;
            cmbFloor.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.BorderColor = Color.Navy;
            btnBack.BorderRadius = 10;
            btnBack.BorderThickness = 1;
            btnBack.CustomizableEdges = customizableEdges9;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.FromArgb(168, 211, 252);
            btnBack.Font = new Font("Aribau Rounded Trial", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Navy;
            btnBack.HoverState.FillColor = Color.Navy;
            btnBack.HoverState.ForeColor = Color.White;
            btnBack.Location = new Point(732, 508);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnBack.Size = new Size(130, 40);
            btnBack.TabIndex = 3;
            btnBack.Text = "back";
            btnBack.Click += BtnBack_Click;
            // 
            // lblAvailable
            // 
            lblAvailable.Font = new Font("Rounded", 25.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailable.Location = new Point(568, 4);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(376, 71);
            lblAvailable.TabIndex = 1;
            lblAvailable.Text = "(00/00 Available)";
            lblAvailable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _2_2Map
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(168, 211, 252);
            Controls.Add(panel2);
            Name = "_2_2Map";
            Size = new Size(1280, 720);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lblAvailable;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFloor;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlSlotInfo;
        private Guna.UI2.WinForms.Guna2Panel pnlSlotGrid;
        private Guna.UI2.WinForms.Guna2Button btnContinue;
    }
}