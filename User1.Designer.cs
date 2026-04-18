namespace RESERBA
{
    partial class User1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User1));
            label1 = new Label();
            Hello2 = new Label();
            linkClick = new LinkLabel();
            label3 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            TbParkingID = new Guna.UI2.WinForms.Guna2TextBox();
            BtnConfirmParkId = new Guna.UI2.WinForms.Guna2Button();
            Logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(357, 236);
            label1.Name = "label1";
            label1.Size = new Size(567, 49);
            label1.TabIndex = 6;
            label1.Text = "ENTER YOUR PARKING ID";
            label1.Click += label1_Click;
            // 
            // Hello2
            // 
            Hello2.AutoSize = true;
            Hello2.BackColor = Color.DarkOrange;
            Hello2.FlatStyle = FlatStyle.Flat;
            Hello2.Font = new Font("Times New Roman", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Hello2.ForeColor = Color.Navy;
            Hello2.Location = new Point(559, 142);
            Hello2.Name = "Hello2";
            Hello2.Size = new Size(154, 57);
            Hello2.TabIndex = 5;
            Hello2.Text = "Hello!";
            Hello2.Click += Hello2_Click;
            // 
            // linkClick
            // 
            linkClick.ActiveLinkColor = Color.DarkOrange;
            linkClick.AutoSize = true;
            linkClick.DisabledLinkColor = Color.Navy;
            linkClick.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkClick.LinkColor = Color.Blue;
            linkClick.Location = new Point(641, 489);
            linkClick.Name = "linkClick";
            linkClick.Size = new Size(80, 19);
            linkClick.TabIndex = 9;
            linkClick.TabStop = true;
            linkClick.Text = "Click here";
            linkClick.VisitedLinkColor = Color.Black;
            linkClick.LinkClicked += linkClick_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(554, 489);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 11;
            label3.Text = "Lost ticket?";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.DarkOrange;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(502, 138);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(272, 64);
            guna2Button1.TabIndex = 12;
            guna2Button1.Text = "guna2Button1";
            // 
            // TbParkingID
            // 
            TbParkingID.BorderColor = Color.Navy;
            TbParkingID.BorderRadius = 15;
            TbParkingID.BorderThickness = 3;
            TbParkingID.CustomizableEdges = customizableEdges3;
            TbParkingID.DefaultText = "";
            TbParkingID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TbParkingID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TbParkingID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TbParkingID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TbParkingID.FillColor = Color.FromArgb(214, 235, 255);
            TbParkingID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TbParkingID.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbParkingID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TbParkingID.Location = new Point(388, 303);
            TbParkingID.Name = "TbParkingID";
            TbParkingID.PlaceholderText = "";
            TbParkingID.SelectedText = "";
            TbParkingID.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TbParkingID.Size = new Size(476, 107);
            TbParkingID.TabIndex = 13;
            TbParkingID.TextChanged += TbParkingID_TextChanged;
            // 
            // BtnConfirmParkId
            // 
            BtnConfirmParkId.BorderColor = Color.Navy;
            BtnConfirmParkId.BorderRadius = 15;
            BtnConfirmParkId.BorderThickness = 1;
            BtnConfirmParkId.CustomizableEdges = customizableEdges5;
            BtnConfirmParkId.DisabledState.BorderColor = Color.DarkGray;
            BtnConfirmParkId.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnConfirmParkId.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnConfirmParkId.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnConfirmParkId.FillColor = Color.FromArgb(214, 235, 255);
            BtnConfirmParkId.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnConfirmParkId.ForeColor = Color.Black;
            BtnConfirmParkId.Location = new Point(545, 433);
            BtnConfirmParkId.Name = "BtnConfirmParkId";
            BtnConfirmParkId.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BtnConfirmParkId.Size = new Size(191, 40);
            BtnConfirmParkId.TabIndex = 14;
            BtnConfirmParkId.Text = "confirm";
            BtnConfirmParkId.Click += BtnConfirmParkId_Click;
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(12, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(60, 60);
            Logo.TabIndex = 15;
            Logo.TabStop = false;
            // 
            // User1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            ClientSize = new Size(1280, 720);
            Controls.Add(Logo);
            Controls.Add(BtnConfirmParkId);
            Controls.Add(TbParkingID);
            Controls.Add(label3);
            Controls.Add(linkClick);
            Controls.Add(label1);
            Controls.Add(Hello2);
            Controls.Add(guna2Button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User1";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label Hello2;
        private LinkLabel linkClick;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox TbParkingID;
        private Guna.UI2.WinForms.Guna2Button BtnConfirmParkId;
        private PictureBox Logo;
    }
}