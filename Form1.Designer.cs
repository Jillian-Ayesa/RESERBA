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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Logo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnContinue = new Guna.UI2.WinForms.Guna2TileButton();
            label4 = new Label();
            guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.BorderStyle = BorderStyle.Fixed3D;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(642, 57);
            Logo.Name = "Logo";
            Logo.Size = new Size(570, 600);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 57);
            label1.Name = "label1";
            label1.Size = new Size(407, 76);
            label1.TabIndex = 1;
            label1.Text = "Welcome To";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(62, 111);
            label2.Name = "label2";
            label2.Size = new Size(535, 123);
            label2.TabIndex = 2;
            label2.Text = "RESERBA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 365);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // BtnContinue
            // 
            BtnContinue.BackColor = Color.FromArgb(214, 235, 255);
            BtnContinue.BackgroundImageLayout = ImageLayout.Center;
            BtnContinue.CustomizableEdges = customizableEdges1;
            BtnContinue.DisabledState.BorderColor = Color.DarkGray;
            BtnContinue.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnContinue.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnContinue.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnContinue.FillColor = Color.Transparent;
            BtnContinue.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnContinue.ForeColor = Color.Black;
            BtnContinue.Location = new Point(96, 549);
            BtnContinue.Name = "BtnContinue";
            BtnContinue.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnContinue.Size = new Size(163, 55);
            BtnContinue.TabIndex = 4;
            BtnContinue.Text = "continue";
            BtnContinue.Click += BtnContinue_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Navy;
            label4.Font = new Font("Times New Roman", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(89, 544);
            label4.Name = "label4";
            label4.Size = new Size(176, 65);
            label4.TabIndex = 5;
            label4.Text = ".......";
            // 
            // guna2TileButton1
            // 
            guna2TileButton1.BackColor = Color.FromArgb(214, 235, 255);
            guna2TileButton1.BackgroundImageLayout = ImageLayout.Center;
            guna2TileButton1.CustomizableEdges = customizableEdges3;
            guna2TileButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2TileButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2TileButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2TileButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2TileButton1.FillColor = Color.Transparent;
            guna2TileButton1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2TileButton1.ForeColor = Color.Black;
            guna2TileButton1.Location = new Point(352, 549);
            guna2TileButton1.Name = "guna2TileButton1";
            guna2TileButton1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TileButton1.Size = new Size(163, 55);
            guna2TileButton1.TabIndex = 6;
            guna2TileButton1.Text = "cancel";
            // 
            // label5
            // 
            label5.BackColor = Color.Navy;
            label5.Font = new Font("Times New Roman", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(345, 544);
            label5.Name = "label5";
            label5.Size = new Size(176, 65);
            label5.TabIndex = 7;
            label5.Text = ".......";
            // 
            // Welcome
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            ClientSize = new Size(1280, 720);
            Controls.Add(guna2TileButton1);
            Controls.Add(label5);
            Controls.Add(BtnContinue);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Logo);
            Controls.Add(label4);
            Controls.Add(label2);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private Label label5;
    }
}
