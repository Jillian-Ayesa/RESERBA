namespace RESERBA_Proj
{
    partial class _1B_User6
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
            BtnBack = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.FromArgb(168, 211, 252);
            BtnBack.BorderColor = Color.Navy;
            BtnBack.BorderRadius = 15;
            BtnBack.BorderThickness = 1;
            BtnBack.CustomizableEdges = customizableEdges1;
            BtnBack.DisabledState.BorderColor = Color.DarkGray;
            BtnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnBack.FillColor = Color.FromArgb(168, 211, 252);
            BtnBack.Font = new Font("Playfair Display", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBack.ForeColor = Color.Navy;
            BtnBack.HoverState.FillColor = Color.Navy;
            BtnBack.HoverState.ForeColor = Color.White;
            BtnBack.Location = new Point(544, 342);
            BtnBack.Name = "BtnBack";
            BtnBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnBack.Size = new Size(195, 55);
            BtnBack.TabIndex = 27;
            BtnBack.Text = "back";
            BtnBack.Click += BtnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(168, 211, 252);
            label1.Font = new Font("Playfair Display", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(370, 247);
            label1.Name = "label1";
            label1.Size = new Size(543, 67);
            label1.TabIndex = 25;
            label1.Text = "Information Recorded";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 20;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(168, 211, 252);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.FromArgb(168, 211, 252);
            guna2Button1.HoverState.FillColor = Color.FromArgb(168, 211, 252);
            guna2Button1.HoverState.ForeColor = Color.FromArgb(168, 211, 252);
            guna2Button1.Location = new Point(100, 70);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedDepth = 0;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(1080, 580);
            guna2Button1.TabIndex = 24;
            // 
            // _1B_User6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            ClientSize = new Size(1280, 720);
            Controls.Add(BtnBack);
            Controls.Add(label1);
            Controls.Add(guna2Button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "_1B_User6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_1B_User6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnBack;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}