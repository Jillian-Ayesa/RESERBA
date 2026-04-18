namespace RESERBA
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Logo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnContinue = new Guna.UI2.WinForms.Guna2TileButton();
            label4 = new Label();
            BtnCancel = new Guna.UI2.WinForms.Guna2TileButton();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.BorderStyle = BorderStyle.Fixed3D;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(529, 52);
            Logo.Name = "Logo";
            Logo.Size = new Size(477, 491);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 68);
            label1.Name = "label1";
            label1.Size = new Size(274, 57);
            label1.TabIndex = 1;
            label1.Text = "Welcome To";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 52.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(40, 125);
            label2.Name = "label2";
            label2.Size = new Size(453, 98);
            label2.TabIndex = 2;
            label2.Text = "RESERBA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 336);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // BtnContinue
            // 
            BtnContinue.BackColor = Color.FromArgb(214, 235, 255);
            BtnContinue.BackgroundImageLayout = ImageLayout.Center;
            BtnContinue.BorderRadius = 10;
            BtnContinue.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            BtnContinue.CustomizableEdges = customizableEdges9;
            BtnContinue.DisabledState.BorderColor = Color.DarkGray;
            BtnContinue.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnContinue.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnContinue.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnContinue.FillColor = Color.Transparent;
            BtnContinue.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnContinue.ForeColor = Color.Black;
            BtnContinue.Location = new Point(81, 480);
            BtnContinue.Name = "BtnContinue";
            BtnContinue.ShadowDecoration.CustomizableEdges = customizableEdges10;
            BtnContinue.Size = new Size(118, 55);
            BtnContinue.TabIndex = 4;
            BtnContinue.Text = "continue";
            BtnContinue.Click += BtnContinue_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(59, 89, 152);
            label4.Font = new Font("Times New Roman", 34.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(77, 475);
            label4.Name = "label4";
            label4.Size = new Size(126, 65);
            label4.TabIndex = 5;
            label4.Text = ".......";
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(214, 235, 255);
            BtnCancel.BackgroundImageLayout = ImageLayout.Center;
            BtnCancel.BorderRadius = 10;
            BtnCancel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            BtnCancel.CustomizableEdges = customizableEdges11;
            BtnCancel.DisabledState.BorderColor = Color.DarkGray;
            BtnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnCancel.FillColor = Color.Transparent;
            BtnCancel.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancel.ForeColor = Color.Black;
            BtnCancel.Location = new Point(276, 480);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            BtnCancel.Size = new Size(118, 55);
            BtnCancel.TabIndex = 6;
            BtnCancel.Text = "cancel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(59, 89, 152);
            label5.Font = new Font("Times New Roman", 34.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(272, 475);
            label5.Name = "label5";
            label5.Size = new Size(126, 65);
            label5.TabIndex = 7;
            label5.Text = ".......";
            // 
            // Welcome
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            ClientSize = new Size(1066, 602);
            Controls.Add(BtnCancel);
            Controls.Add(label5);
            Controls.Add(BtnContinue);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Logo);
            Controls.Add(label4);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Welcome";
            Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TileButton BtnContinue;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TileButton BtnCancel;
        private Label label5;
    }
}
