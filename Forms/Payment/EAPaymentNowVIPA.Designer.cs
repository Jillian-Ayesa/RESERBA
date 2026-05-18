namespace RESERBA_Proj
{
    partial class EAPaymentNowVIPA
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EAPaymentNowVIPA));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            TimeOut = new Label();
            TimeIn = new Label();
            BtnPay = new Guna.UI2.WinForms.Guna2Button();
            BtnCancel = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            panelHideAttendant = new Panel();
            labelattendant = new Label();
            ReceiptDate = new Label();
            ReceiptNum = new Label();
            ReceiptTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(937, 565);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(TimeOut);
            panel1.Controls.Add(TimeIn);
            panel1.Controls.Add(BtnPay);
            panel1.Controls.Add(BtnCancel);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(945, 570);
            panel1.TabIndex = 1;
            // 
            // TimeOut
            // 
            TimeOut.AutoSize = true;
            TimeOut.BackColor = Color.White;
            TimeOut.Font = new Font("Aribau Rounded Trial", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeOut.Location = new Point(424, 473);
            TimeOut.Name = "TimeOut";
            TimeOut.Size = new Size(107, 43);
            TimeOut.TabIndex = 50;
            TimeOut.Text = "22:06";
            // 
            // TimeIn
            // 
            TimeIn.AutoSize = true;
            TimeIn.BackColor = Color.White;
            TimeIn.Font = new Font("Aribau Rounded Trial", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeIn.Location = new Point(422, 367);
            TimeIn.Name = "TimeIn";
            TimeIn.Size = new Size(109, 43);
            TimeIn.TabIndex = 56;
            TimeIn.Text = "22:00";
            // 
            // BtnPay
            // 
            BtnPay.BackColor = Color.White;
            BtnPay.BorderColor = Color.Navy;
            BtnPay.BorderRadius = 15;
            BtnPay.BorderThickness = 1;
            BtnPay.CustomizableEdges = customizableEdges1;
            BtnPay.DisabledState.BorderColor = Color.DarkGray;
            BtnPay.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnPay.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnPay.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnPay.FillColor = Color.FromArgb(168, 211, 252);
            BtnPay.Font = new Font("Aribau Rounded Trial", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPay.ForeColor = Color.Navy;
            BtnPay.HoverState.FillColor = Color.Navy;
            BtnPay.HoverState.ForeColor = Color.White;
            BtnPay.Location = new Point(173, 511);
            BtnPay.Name = "BtnPay";
            BtnPay.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnPay.Size = new Size(121, 40);
            BtnPay.TabIndex = 13;
            BtnPay.Text = "Pay Now";
            BtnPay.Click += BtnPay_Click_1;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.White;
            BtnCancel.BorderColor = Color.Navy;
            BtnCancel.BorderRadius = 15;
            BtnCancel.BorderThickness = 1;
            BtnCancel.CustomizableEdges = customizableEdges3;
            BtnCancel.DisabledState.BorderColor = Color.DarkGray;
            BtnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnCancel.FillColor = Color.FromArgb(168, 211, 252);
            BtnCancel.Font = new Font("Aribau Rounded Trial", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancel.ForeColor = Color.Navy;
            BtnCancel.HoverState.FillColor = Color.Navy;
            BtnCancel.HoverState.ForeColor = Color.White;
            BtnCancel.Location = new Point(35, 511);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BtnCancel.Size = new Size(121, 40);
            BtnCancel.TabIndex = 14;
            BtnCancel.Text = "Pay Later";
            BtnCancel.Click += BtnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Aribau Rounded Trial", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 85);
            label1.Name = "label1";
            label1.Size = new Size(115, 43);
            label1.TabIndex = 51;
            label1.Text = "status";
            // 
            // panelHideAttendant
            // 
            panelHideAttendant.BackColor = Color.White;
            panelHideAttendant.Location = new Point(35, 131);
            panelHideAttendant.Name = "panelHideAttendant";
            panelHideAttendant.Size = new Size(164, 24);
            panelHideAttendant.TabIndex = 52;
            // 
            // labelattendant
            // 
            labelattendant.AutoSize = true;
            labelattendant.BackColor = Color.White;
            labelattendant.Font = new Font("Aribau Rounded Trial", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelattendant.Location = new Point(35, 158);
            labelattendant.Name = "labelattendant";
            labelattendant.Size = new Size(155, 38);
            labelattendant.TabIndex = 53;
            labelattendant.Text = "attendant";
            // 
            // ReceiptDate
            // 
            ReceiptDate.AutoSize = true;
            ReceiptDate.BackColor = Color.White;
            ReceiptDate.Font = new Font("Aribau Rounded Trial", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReceiptDate.Location = new Point(776, 85);
            ReceiptDate.Name = "ReceiptDate";
            ReceiptDate.Size = new Size(136, 43);
            ReceiptDate.TabIndex = 54;
            ReceiptDate.Text = "5/03/26";
            // 
            // ReceiptNum
            // 
            ReceiptNum.AutoSize = true;
            ReceiptNum.BackColor = Color.White;
            ReceiptNum.Font = new Font("Aribau Rounded Trial", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReceiptNum.Location = new Point(754, 153);
            ReceiptNum.Name = "ReceiptNum";
            ReceiptNum.Size = new Size(158, 43);
            ReceiptNum.TabIndex = 55;
            ReceiptNum.Text = "PH-0001";
            // 
            // ReceiptTotal
            // 
            ReceiptTotal.AutoSize = true;
            ReceiptTotal.BackColor = Color.White;
            ReceiptTotal.Font = new Font("Aribau Rounded Trial", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReceiptTotal.Location = new Point(632, 218);
            ReceiptTotal.Name = "ReceiptTotal";
            ReceiptTotal.Size = new Size(280, 65);
            ReceiptTotal.TabIndex = 57;
            ReceiptTotal.Text = "PHP 1,432";
            // 
            // EAPaymentNowVIPA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(168, 211, 252);
            Controls.Add(ReceiptTotal);
            Controls.Add(ReceiptNum);
            Controls.Add(ReceiptDate);
            Controls.Add(labelattendant);
            Controls.Add(panelHideAttendant);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "EAPaymentNowVIPA";
            Size = new Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BtnCancel;
        private Label TimeOut;
        private Guna.UI2.WinForms.Guna2Button BtnPay;
        private Label label1;
        private Panel panelHideAttendant;
        private Label labelattendant;
        private Label ReceiptDate;
        private Label ReceiptNum;
        private Label TimeIn;
        private Label ReceiptTotal;
    }
}
