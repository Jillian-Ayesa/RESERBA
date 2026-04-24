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
            label4 = new Label();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            BtnBack = new Guna.UI2.WinForms.Guna2Button();
            label5 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Font = new Font("Playfair Display", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 4);
            label4.Name = "label4";
            label4.Size = new Size(365, 71);
            label4.TabIndex = 0;
            label4.Text = "GROUND FLOOR";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
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
            panel2.Controls.Add(BtnBack);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(945, 570);
            panel2.TabIndex = 19;
            // 
            // BtnBack
            // 
            BtnBack.BorderColor = Color.Navy;
            BtnBack.BorderRadius = 15;
            BtnBack.BorderThickness = 1;
            BtnBack.CustomizableEdges = customizableEdges3;
            BtnBack.DisabledState.BorderColor = Color.DarkGray;
            BtnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnBack.FillColor = Color.FromArgb(168, 211, 252);
            BtnBack.Font = new Font("Playfair Display", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBack.ForeColor = Color.Navy;
            BtnBack.HoverState.FillColor = Color.Navy;
            BtnBack.HoverState.ForeColor = Color.White;
            BtnBack.Location = new Point(742, 506);
            BtnBack.Name = "BtnBack";
            BtnBack.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BtnBack.Size = new Size(195, 55);
            BtnBack.TabIndex = 3;
            BtnBack.Text = "back";
            BtnBack.Click += BtnBack_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Playfair Display", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(578, 4);
            label5.Name = "label5";
            label5.Size = new Size(365, 71);
            label5.TabIndex = 1;
            label5.Text = "(00/00 Available)";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _2_2Map
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(168, 211, 252);
            Controls.Add(panel2);
            Controls.Add(guna2Button2);
            Name = "_2_2Map";
            Size = new Size(1280, 720);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Panel panel2;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button BtnBack;
    }
}