namespace RESERBA_Proj
{
    partial class AABStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AABStart));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            BtnContinue = new Guna.UI2.WinForms.Guna2Button();
            BtnCancel = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Playfair Display", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 253);
            label1.Name = "label1";
            label1.Size = new Size(421, 79);
            label1.TabIndex = 0;
            label1.Text = "Route. Relax.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Playfair Display Black", 49.8000031F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(91, 160);
            label2.Name = "label2";
            label2.Size = new Size(379, 112);
            label2.TabIndex = 1;
            label2.Text = "Reserve.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(733, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // BtnContinue
            // 
            BtnContinue.BorderColor = Color.Navy;
            BtnContinue.BorderRadius = 25;
            BtnContinue.BorderThickness = 2;
            BtnContinue.CustomizableEdges = customizableEdges1;
            BtnContinue.DisabledState.BorderColor = Color.DarkGray;
            BtnContinue.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnContinue.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnContinue.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnContinue.FillColor = Color.FromArgb(214, 235, 255);
            BtnContinue.Font = new Font("Playfair Display", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnContinue.ForeColor = Color.Navy;
            BtnContinue.HoverState.FillColor = Color.Navy;
            BtnContinue.HoverState.ForeColor = Color.White;
            BtnContinue.Location = new Point(132, 489);
            BtnContinue.Name = "BtnContinue";
            BtnContinue.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnContinue.Size = new Size(195, 55);
            BtnContinue.TabIndex = 7;
            BtnContinue.Text = "continue";
            BtnContinue.Click += BtnContinue_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.BorderColor = Color.Navy;
            BtnCancel.BorderRadius = 25;
            BtnCancel.BorderThickness = 2;
            BtnCancel.CustomizableEdges = customizableEdges3;
            BtnCancel.DisabledState.BorderColor = Color.DarkGray;
            BtnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnCancel.FillColor = Color.FromArgb(214, 235, 255);
            BtnCancel.Font = new Font("Playfair Display", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancel.ForeColor = Color.Navy;
            BtnCancel.HoverState.FillColor = Color.Navy;
            BtnCancel.HoverState.ForeColor = Color.White;
            BtnCancel.Location = new Point(376, 489);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BtnCancel.Size = new Size(195, 55);
            BtnCancel.TabIndex = 8;
            BtnCancel.Text = "cancel";
            BtnCancel.Click += BtnCancel_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Playfair Display", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 345);
            label3.Name = "label3";
            label3.Size = new Size(548, 127);
            label3.TabIndex = 2;
            label3.Text = "A centralized parking management system that \r\neliminates driver frustration by proving real - time\r\nspot availability, smart payment options, and a\r\nbuilt - in vehicle locator.\r\n";
            // 
            // AABStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            ClientSize = new Size(1280, 720);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnCancel);
            Controls.Add(BtnContinue);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AABStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AABStart";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button BtnContinue;
        private Guna.UI2.WinForms.Guna2Button BtnCancel;
        private Label label3;
    }
}