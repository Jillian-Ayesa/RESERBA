namespace RESERBA_Proj
{
    partial class _2_3Map
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
            label4 = new Label();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            rbEV = new RadioButton();
            rb4W = new RadioButton();
            rb2W = new RadioButton();
            rbRIV = new RadioButton();
            rbPUV = new RadioButton();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Font = new Font("Playfair Display", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(315, 4);
            label4.Name = "label4";
            label4.Size = new Size(330, 71);
            label4.TabIndex = 0;
            label4.Text = "VEHICLE TYPE";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 20;
            guna2Button2.CustomizableEdges = customizableEdges1;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(168, 211, 252);
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.FromArgb(214, 235, 255);
            guna2Button2.HoverState.FillColor = Color.FromArgb(168, 211, 252);
            guna2Button2.HoverState.ForeColor = Color.FromArgb(168, 211, 252);
            guna2Button2.Location = new Point(296, 120);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.PressedDepth = 0;
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(960, 587);
            guna2Button2.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(168, 211, 252);
            panel2.Controls.Add(rbEV);
            panel2.Controls.Add(rb4W);
            panel2.Controls.Add(rb2W);
            panel2.Controls.Add(rbRIV);
            panel2.Controls.Add(rbPUV);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(945, 570);
            panel2.TabIndex = 19;
            // 
            // rbEV
            // 
            rbEV.Appearance = Appearance.Button;
            rbEV.FlatStyle = FlatStyle.Flat;
            rbEV.Font = new Font("Playfair Display", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbEV.ForeColor = Color.Navy;
            rbEV.Location = new Point(328, 232);
            rbEV.Name = "rbEV";
            rbEV.Size = new Size(300, 100);
            rbEV.TabIndex = 5;
            rbEV.TabStop = true;
            rbEV.Text = "EV";
            rbEV.TextAlign = ContentAlignment.MiddleRight;
            rbEV.UseVisualStyleBackColor = false;
            rbEV.CheckedChanged += rbEV_CheckedChanged;
            // 
            // rb4W
            // 
            rb4W.Appearance = Appearance.Button;
            rb4W.FlatStyle = FlatStyle.Flat;
            rb4W.Font = new Font("Times New Roman", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb4W.ForeColor = Color.Navy;
            rb4W.Location = new Point(584, 366);
            rb4W.Name = "rb4W";
            rb4W.Size = new Size(300, 100);
            rb4W.TabIndex = 4;
            rb4W.TabStop = true;
            rb4W.Text = "4 Wheels";
            rb4W.TextAlign = ContentAlignment.MiddleRight;
            rb4W.UseVisualStyleBackColor = false;
            rb4W.CheckedChanged += rb4W_CheckedChanged;
            // 
            // rb2W
            // 
            rb2W.Appearance = Appearance.Button;
            rb2W.FlatStyle = FlatStyle.Flat;
            rb2W.Font = new Font("Times New Roman", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb2W.ForeColor = Color.Navy;
            rb2W.Location = new Point(50, 366);
            rb2W.Name = "rb2W";
            rb2W.Size = new Size(300, 100);
            rb2W.TabIndex = 3;
            rb2W.TabStop = true;
            rb2W.Text = "2 Wheels";
            rb2W.TextAlign = ContentAlignment.MiddleRight;
            rb2W.UseVisualStyleBackColor = false;
            rb2W.CheckedChanged += rb2W_CheckedChanged;
            // 
            // rbRIV
            // 
            rbRIV.Appearance = Appearance.Button;
            rbRIV.FlatStyle = FlatStyle.Flat;
            rbRIV.Font = new Font("Playfair Display", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbRIV.ForeColor = Color.Navy;
            rbRIV.Location = new Point(584, 94);
            rbRIV.Name = "rbRIV";
            rbRIV.Size = new Size(300, 100);
            rbRIV.TabIndex = 2;
            rbRIV.TabStop = true;
            rbRIV.Text = "PRIV";
            rbRIV.TextAlign = ContentAlignment.MiddleRight;
            rbRIV.UseVisualStyleBackColor = false;
            rbRIV.CheckedChanged += rbRIV_CheckedChanged;
            // 
            // rbPUV
            // 
            rbPUV.Appearance = Appearance.Button;
            rbPUV.FlatStyle = FlatStyle.Flat;
            rbPUV.Font = new Font("Playfair Display", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbPUV.ForeColor = Color.Navy;
            rbPUV.Location = new Point(50, 94);
            rbPUV.Name = "rbPUV";
            rbPUV.Size = new Size(300, 100);
            rbPUV.TabIndex = 1;
            rbPUV.TabStop = true;
            rbPUV.Text = "PUV";
            rbPUV.TextAlign = ContentAlignment.MiddleRight;
            rbPUV.UseVisualStyleBackColor = false;
            rbPUV.CheckedChanged += rbPUV_CheckedChanged;
            // 
            // _2_3Map
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(168, 211, 252);
            Controls.Add(panel2);
            Controls.Add(guna2Button2);
            Name = "_2_3Map";
            Size = new Size(1280, 720);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Panel panel2;
        private RadioButton rbPUV;
        private RadioButton rbEV;
        private RadioButton rb4W;
        private RadioButton rb2W;
        private RadioButton rbRIV;
    }
}