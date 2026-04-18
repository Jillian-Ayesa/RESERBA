namespace RESERBA
{
    partial class User3
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
            label2 = new Label();
            BtnRecieptCancel = new Guna.UI2.WinForms.Guna2Button();
            BtnRecieptPay = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(168, 211, 252);
            label1.Location = new Point(129, 97);
            label1.Name = "label1";
            label1.Size = new Size(1022, 526);
            label1.TabIndex = 1;
            label1.Text = " ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(168, 211, 252);
            label2.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(573, 135);
            label2.Name = "label2";
            label2.Size = new Size(148, 42);
            label2.TabIndex = 2;
            label2.Text = "Reciept:";
            // 
            // BtnRecieptCancel
            // 
            BtnRecieptCancel.BackColor = Color.FromArgb(168, 211, 252);
            BtnRecieptCancel.BorderColor = Color.Navy;
            BtnRecieptCancel.BorderRadius = 15;
            BtnRecieptCancel.BorderThickness = 1;
            BtnRecieptCancel.CustomizableEdges = customizableEdges1;
            BtnRecieptCancel.DisabledState.BorderColor = Color.DarkGray;
            BtnRecieptCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnRecieptCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnRecieptCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnRecieptCancel.FillColor = Color.FromArgb(168, 211, 252);
            BtnRecieptCancel.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnRecieptCancel.ForeColor = Color.Black;
            BtnRecieptCancel.Location = new Point(370, 541);
            BtnRecieptCancel.Name = "BtnRecieptCancel";
            BtnRecieptCancel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnRecieptCancel.Size = new Size(149, 33);
            BtnRecieptCancel.TabIndex = 3;
            BtnRecieptCancel.Text = "Cancel";
            // 
            // BtnRecieptPay
            // 
            BtnRecieptPay.BackColor = Color.FromArgb(168, 211, 252);
            BtnRecieptPay.BorderColor = Color.Navy;
            BtnRecieptPay.BorderRadius = 15;
            BtnRecieptPay.BorderThickness = 1;
            BtnRecieptPay.CustomizableEdges = customizableEdges3;
            BtnRecieptPay.DisabledState.BorderColor = Color.DarkGray;
            BtnRecieptPay.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnRecieptPay.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnRecieptPay.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnRecieptPay.FillColor = Color.FromArgb(168, 211, 252);
            BtnRecieptPay.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnRecieptPay.ForeColor = Color.Black;
            BtnRecieptPay.Location = new Point(739, 541);
            BtnRecieptPay.Name = "BtnRecieptPay";
            BtnRecieptPay.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BtnRecieptPay.Size = new Size(149, 33);
            BtnRecieptPay.TabIndex = 4;
            BtnRecieptPay.Text = "Pay";
            // 
            // User3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            ClientSize = new Size(1280, 720);
            Controls.Add(BtnRecieptPay);
            Controls.Add(BtnRecieptCancel);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User3";
            Text = "User3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button BtnRecieptCancel;
        private Guna.UI2.WinForms.Guna2Button BtnRecieptPay;
    }
}