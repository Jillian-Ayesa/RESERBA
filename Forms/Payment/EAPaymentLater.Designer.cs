namespace RESERBA_Proj
{
    partial class _5_1PaymentLater
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
            panel2 = new Panel();
            label4 = new Label();
            BtnBack = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(168, 211, 252);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(BtnBack);
            panel2.Location = new Point(304, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(945, 570);
            panel2.TabIndex = 33;
            // 
            // label4
            // 
            label4.Font = new Font("Rounded", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(203, 181);
            label4.Name = "label4";
            label4.Size = new Size(662, 73);
            label4.TabIndex = 8;
            label4.Text = "Information Recorded";
            // 
            // BtnBack
            // 
            BtnBack.BorderColor = Color.Navy;
            BtnBack.BorderRadius = 10;
            BtnBack.BorderThickness = 1;
            BtnBack.CustomizableEdges = customizableEdges1;
            BtnBack.DisabledState.BorderColor = Color.DarkGray;
            BtnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnBack.FillColor = Color.FromArgb(168, 211, 252);
            BtnBack.Font = new Font("Aribau Rounded Trial", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBack.ForeColor = Color.Navy;
            BtnBack.HoverState.FillColor = Color.Navy;
            BtnBack.HoverState.ForeColor = Color.White;
            BtnBack.Location = new Point(453, 257);
            BtnBack.Name = "BtnBack";
            BtnBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnBack.Size = new Size(130, 40);
            BtnBack.TabIndex = 7;
            BtnBack.Text = "done";
            BtnBack.Click += BtnBack_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 20;
            guna2Button2.CustomizableEdges = customizableEdges3;
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
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(960, 587);
            guna2Button2.TabIndex = 32;
            // 
            // _5_1PaymentLater
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(214, 235, 255);
            Controls.Add(panel2);
            Controls.Add(guna2Button2);
            Name = "_5_1PaymentLater";
            Size = new Size(1280, 720);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button BtnBack;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}