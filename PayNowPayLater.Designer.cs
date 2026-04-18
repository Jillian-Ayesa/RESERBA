namespace RESERBA
{
    partial class PayNowPayLater
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
            label1 = new Label();
            BtnPayNow = new Guna.UI2.WinForms.Guna2Button();
            BtnPayLater = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(168, 211, 252);
            label1.Location = new Point(120, 95);
            label1.Name = "label1";
            label1.Size = new Size(1022, 526);
            label1.TabIndex = 0;
            label1.Text = " ";
            label1.Click += label1_Click;
            // 
            // BtnPayNow
            // 
            BtnPayNow.BackColor = Color.FromArgb(168, 211, 252);
            BtnPayNow.BorderColor = Color.Navy;
            BtnPayNow.BorderRadius = 15;
            BtnPayNow.BorderThickness = 3;
            BtnPayNow.CustomizableEdges = customizableEdges1;
            BtnPayNow.DisabledState.BorderColor = Color.DarkGray;
            BtnPayNow.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnPayNow.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnPayNow.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnPayNow.FillColor = Color.FromArgb(168, 211, 252);
            BtnPayNow.Font = new Font("Times New Roman", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPayNow.ForeColor = Color.Black;
            BtnPayNow.Location = new Point(228, 266);
            BtnPayNow.Name = "BtnPayNow";
            BtnPayNow.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnPayNow.Size = new Size(375, 188);
            BtnPayNow.TabIndex = 1;
            BtnPayNow.Text = "Pay Now";
            // 
            // BtnPayLater
            // 
            BtnPayLater.BackColor = Color.FromArgb(168, 211, 252);
            BtnPayLater.BorderColor = Color.Navy;
            BtnPayLater.BorderRadius = 15;
            BtnPayLater.BorderThickness = 3;
            BtnPayLater.CustomizableEdges = customizableEdges3;
            BtnPayLater.DisabledState.BorderColor = Color.DarkGray;
            BtnPayLater.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnPayLater.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnPayLater.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnPayLater.FillColor = Color.FromArgb(168, 211, 252);
            BtnPayLater.Font = new Font("Times New Roman", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPayLater.ForeColor = Color.Black;
            BtnPayLater.Location = new Point(676, 266);
            BtnPayLater.Name = "BtnPayLater";
            BtnPayLater.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BtnPayLater.Size = new Size(375, 188);
            BtnPayLater.TabIndex = 2;
            BtnPayLater.Text = "Pay Later";
            BtnPayLater.Click += guna2Button1_Click;
            // 
            // PayNowPayLater
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            ClientSize = new Size(1280, 720);
            Controls.Add(BtnPayLater);
            Controls.Add(BtnPayNow);
            Controls.Add(label1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PayNowPayLater";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PayNowPayLater";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnPayNow;
        private Guna.UI2.WinForms.Guna2Button BtnPayLater;
    }
}