namespace RESERBA_Proj
{
    partial class _5_1PaymentNow1
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
            BtnCancel = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            BtnPay = new Guna.UI2.WinForms.Guna2Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(168, 211, 252);
            panel2.Controls.Add(BtnCancel);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(BtnPay);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(945, 570);
            panel2.TabIndex = 40;
            // 
            // BtnCancel
            // 
            BtnCancel.BorderColor = Color.Navy;
            BtnCancel.BorderRadius = 15;
            BtnCancel.BorderThickness = 1;
            BtnCancel.CustomizableEdges = customizableEdges1;
            BtnCancel.DisabledState.BorderColor = Color.DarkGray;
            BtnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnCancel.FillColor = Color.FromArgb(168, 211, 252);
            BtnCancel.Font = new Font("Playfair Display", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCancel.ForeColor = Color.Navy;
            BtnCancel.HoverState.FillColor = Color.Navy;
            BtnCancel.HoverState.ForeColor = Color.White;
            BtnCancel.Location = new Point(238, 500);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnCancel.Size = new Size(195, 55);
            BtnCancel.TabIndex = 9;
            BtnCancel.Text = "cancel";
            BtnCancel.Click += guna2Button3_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Playfair Display Black", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(371, 1);
            label4.Name = "label4";
            label4.Size = new Size(229, 79);
            label4.TabIndex = 8;
            label4.Text = "Receipt: ";
            // 
            // BtnPay
            // 
            BtnPay.BorderColor = Color.Navy;
            BtnPay.BorderRadius = 15;
            BtnPay.BorderThickness = 1;
            BtnPay.CustomizableEdges = customizableEdges3;
            BtnPay.DisabledState.BorderColor = Color.DarkGray;
            BtnPay.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnPay.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnPay.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnPay.FillColor = Color.FromArgb(168, 211, 252);
            BtnPay.Font = new Font("Playfair Display", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnPay.ForeColor = Color.Navy;
            BtnPay.HoverState.FillColor = Color.Navy;
            BtnPay.HoverState.ForeColor = Color.White;
            BtnPay.Location = new Point(513, 500);
            BtnPay.Name = "BtnPay";
            BtnPay.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BtnPay.Size = new Size(195, 55);
            BtnPay.TabIndex = 7;
            BtnPay.Text = "Pay";
            // 
            // _5_1PaymentNow1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(168, 211, 252);
            Controls.Add(panel2);
            Name = "_5_1PaymentNow1";
            Size = new Size(1280, 720);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button BtnPay;
        private Guna.UI2.WinForms.Guna2Button BtnCancel;
    }
}