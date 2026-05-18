namespace RESERBA_Proj
{
    partial class _5_1PaymentNow1_old
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_5_1PaymentNow1_old));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            panel1 = new Panel();
            Status = new Label();
            SlotID = new Label();
            DueTime = new Label();
            BtnPayNow = new Guna.UI2.WinForms.Guna2Button();
            BtnPayLater = new Guna.UI2.WinForms.Guna2Button();
            TimeOut = new Label();
            TimeIn = new Label();
            ReceiptNum = new Label();
            ReceiptDate = new Label();
            VehicleType = new Label();
            ReceiptTotal = new Label();
            PlateNumber = new Label();
            pictureBox1 = new PictureBox();
            lbTimeOut = new Label();
            lbTimeIn = new Label();
            label2 = new Label();
            label1 = new Label();
            lbPrice = new Label();
            BtnPrint = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            BtnPay = new Guna.UI2.WinForms.Guna2Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(168, 211, 252);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(lbTimeOut);
            panel2.Controls.Add(lbTimeIn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lbPrice);
            panel2.Controls.Add(BtnPrint);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(BtnPay);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(945, 570);
            panel2.TabIndex = 40;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(168, 211, 252);
            panel1.Controls.Add(Status);
            panel1.Controls.Add(SlotID);
            panel1.Controls.Add(DueTime);
            panel1.Controls.Add(BtnPayNow);
            panel1.Controls.Add(BtnPayLater);
            panel1.Controls.Add(TimeOut);
            panel1.Controls.Add(TimeIn);
            panel1.Controls.Add(ReceiptNum);
            panel1.Controls.Add(ReceiptDate);
            panel1.Controls.Add(VehicleType);
            panel1.Controls.Add(ReceiptTotal);
            panel1.Controls.Add(PlateNumber);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-8, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 580);
            panel1.TabIndex = 41;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.BackColor = Color.White;
            Status.Font = new Font("Aribau Rounded Trial", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Status.Location = new Point(434, 163);
            Status.Name = "Status";
            Status.Size = new Size(162, 43);
            Status.TabIndex = 49;
            Status.Text = "Standard";
            // 
            // SlotID
            // 
            SlotID.AutoSize = true;
            SlotID.BackColor = Color.White;
            SlotID.Font = new Font("Aribau Rounded Trial", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SlotID.Location = new Point(434, 83);
            SlotID.Name = "SlotID";
            SlotID.Size = new Size(134, 43);
            SlotID.TabIndex = 48;
            SlotID.Text = "G1 - EV";
            // 
            // DueTime
            // 
            DueTime.AutoSize = true;
            DueTime.BackColor = Color.White;
            DueTime.Font = new Font("Aribau Rounded Trial", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DueTime.Location = new Point(203, 463);
            DueTime.Name = "DueTime";
            DueTime.Size = new Size(46, 17);
            DueTime.TabIndex = 47;
            DueTime.Text = "23:00";
            DueTime.Click += DueTime_Click;
            // 
            // BtnPayNow
            // 
            BtnPayNow.BackColor = Color.White;
            BtnPayNow.BorderColor = Color.Navy;
            BtnPayNow.BorderRadius = 10;
            BtnPayNow.BorderThickness = 1;
            BtnPayNow.CustomizableEdges = customizableEdges1;
            BtnPayNow.DisabledState.BorderColor = Color.DarkGray;
            BtnPayNow.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnPayNow.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnPayNow.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnPayNow.FillColor = Color.FromArgb(168, 211, 252);
            BtnPayNow.Font = new Font("Aribau Rounded Trial", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPayNow.ForeColor = Color.Navy;
            BtnPayNow.HoverState.FillColor = Color.Navy;
            BtnPayNow.HoverState.ForeColor = Color.White;
            BtnPayNow.Location = new Point(175, 505);
            BtnPayNow.Name = "BtnPayNow";
            BtnPayNow.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnPayNow.Size = new Size(130, 40);
            BtnPayNow.TabIndex = 7;
            BtnPayNow.Text = "Pay Now";
            BtnPayNow.Click += BtnPayNow_Click;
            // 
            // BtnPayLater
            // 
            BtnPayLater.BackColor = Color.White;
            BtnPayLater.BorderColor = Color.Navy;
            BtnPayLater.BorderRadius = 10;
            BtnPayLater.BorderThickness = 1;
            BtnPayLater.CustomizableEdges = customizableEdges3;
            BtnPayLater.DisabledState.BorderColor = Color.DarkGray;
            BtnPayLater.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnPayLater.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnPayLater.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnPayLater.FillColor = Color.FromArgb(168, 211, 252);
            BtnPayLater.Font = new Font("Aribau Rounded Trial", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPayLater.ForeColor = Color.Navy;
            BtnPayLater.HoverState.FillColor = Color.Navy;
            BtnPayLater.HoverState.ForeColor = Color.White;
            BtnPayLater.Location = new Point(26, 505);
            BtnPayLater.Name = "BtnPayLater";
            BtnPayLater.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BtnPayLater.Size = new Size(130, 40);
            BtnPayLater.TabIndex = 9;
            BtnPayLater.Text = "Pay Later";
            BtnPayLater.Click += BtnPayLater_Click;
            // 
            // TimeOut
            // 
            TimeOut.AutoSize = true;
            TimeOut.BackColor = Color.White;
            TimeOut.Font = new Font("Aribau Rounded Trial", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeOut.Location = new Point(417, 473);
            TimeOut.Name = "TimeOut";
            TimeOut.Size = new Size(107, 43);
            TimeOut.TabIndex = 45;
            TimeOut.Text = "22:06";
            // 
            // TimeIn
            // 
            TimeIn.AutoSize = true;
            TimeIn.BackColor = Color.White;
            TimeIn.Font = new Font("Aribau Rounded Trial", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeIn.Location = new Point(417, 368);
            TimeIn.Name = "TimeIn";
            TimeIn.Size = new Size(109, 43);
            TimeIn.TabIndex = 43;
            TimeIn.Text = "22:00";
            // 
            // ReceiptNum
            // 
            ReceiptNum.AutoSize = true;
            ReceiptNum.BackColor = Color.White;
            ReceiptNum.Font = new Font("Aribau Rounded Trial", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReceiptNum.Location = new Point(768, 163);
            ReceiptNum.Name = "ReceiptNum";
            ReceiptNum.Size = new Size(158, 43);
            ReceiptNum.TabIndex = 44;
            ReceiptNum.Text = "PH-0001";
            // 
            // ReceiptDate
            // 
            ReceiptDate.AutoSize = true;
            ReceiptDate.BackColor = Color.White;
            ReceiptDate.Font = new Font("Aribau Rounded Trial", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReceiptDate.Location = new Point(790, 83);
            ReceiptDate.Name = "ReceiptDate";
            ReceiptDate.Size = new Size(136, 43);
            ReceiptDate.TabIndex = 43;
            ReceiptDate.Text = "5/03/26";
            // 
            // VehicleType
            // 
            VehicleType.AutoSize = true;
            VehicleType.BackColor = Color.White;
            VehicleType.Font = new Font("Aribau Rounded Trial", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VehicleType.Location = new Point(54, 164);
            VehicleType.Name = "VehicleType";
            VehicleType.Size = new Size(163, 43);
            VehicleType.TabIndex = 42;
            VehicleType.Text = "4 Wheels";
            // 
            // ReceiptTotal
            // 
            ReceiptTotal.AutoSize = true;
            ReceiptTotal.BackColor = Color.White;
            ReceiptTotal.Font = new Font("Aribau Rounded Trial", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReceiptTotal.Location = new Point(637, 245);
            ReceiptTotal.Name = "ReceiptTotal";
            ReceiptTotal.Size = new Size(280, 65);
            ReceiptTotal.TabIndex = 46;
            ReceiptTotal.Text = "PHP 1,432";
            // 
            // PlateNumber
            // 
            PlateNumber.AutoSize = true;
            PlateNumber.BackColor = Color.White;
            PlateNumber.Font = new Font("Aribau Rounded Trial", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlateNumber.Location = new Point(54, 84);
            PlateNumber.Name = "PlateNumber";
            PlateNumber.Size = new Size(152, 43);
            PlateNumber.TabIndex = 41;
            PlateNumber.Text = "ABC 123";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(937, 565);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lbTimeOut
            // 
            lbTimeOut.Font = new Font("Aribau Rounded Trial", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTimeOut.Location = new Point(492, 388);
            lbTimeOut.Name = "lbTimeOut";
            lbTimeOut.Size = new Size(208, 55);
            lbTimeOut.TabIndex = 14;
            lbTimeOut.Text = "23:11";
            // 
            // lbTimeIn
            // 
            lbTimeIn.Font = new Font("Aribau Rounded Trial", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTimeIn.Location = new Point(451, 310);
            lbTimeIn.Name = "lbTimeIn";
            lbTimeIn.Size = new Size(208, 55);
            lbTimeIn.TabIndex = 13;
            lbTimeIn.Text = "21:35";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rounded", 25.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(276, 398);
            label2.Name = "label2";
            label2.Size = new Size(210, 43);
            label2.TabIndex = 12;
            label2.Text = "TIME OUT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rounded", 25.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(276, 320);
            label1.Name = "label1";
            label1.Size = new Size(178, 43);
            label1.TabIndex = 11;
            label1.Text = "TIME IN:";
            // 
            // lbPrice
            // 
            lbPrice.Font = new Font("Aribau Rounded Trial", 70.19999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPrice.Location = new Point(80, 94);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(816, 189);
            lbPrice.TabIndex = 10;
            lbPrice.Text = "PHP 143.00";
            lbPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnPrint
            // 
            BtnPrint.BorderColor = Color.Navy;
            BtnPrint.BorderRadius = 15;
            BtnPrint.BorderThickness = 1;
            BtnPrint.CustomizableEdges = customizableEdges5;
            BtnPrint.DisabledState.BorderColor = Color.DarkGray;
            BtnPrint.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnPrint.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnPrint.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnPrint.FillColor = Color.FromArgb(168, 211, 252);
            BtnPrint.Font = new Font("Aribau Rounded Trial", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPrint.ForeColor = Color.Navy;
            BtnPrint.HoverState.FillColor = Color.Navy;
            BtnPrint.HoverState.ForeColor = Color.White;
            BtnPrint.Location = new Point(238, 500);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BtnPrint.Size = new Size(195, 55);
            BtnPrint.TabIndex = 9;
            BtnPrint.Text = "print";
            // 
            // label4
            // 
            label4.Font = new Font("Rounded", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(371, 7);
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
            BtnPay.CustomizableEdges = customizableEdges7;
            BtnPay.DisabledState.BorderColor = Color.DarkGray;
            BtnPay.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnPay.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnPay.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnPay.FillColor = Color.FromArgb(168, 211, 252);
            BtnPay.Font = new Font("Aribau Rounded Trial", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPay.ForeColor = Color.Navy;
            BtnPay.HoverState.FillColor = Color.Navy;
            BtnPay.HoverState.ForeColor = Color.White;
            BtnPay.Location = new Point(513, 500);
            BtnPay.Name = "BtnPay";
            BtnPay.ShadowDecoration.CustomizableEdges = customizableEdges8;
            BtnPay.Size = new Size(195, 55);
            BtnPay.TabIndex = 7;
            BtnPay.Text = "Pay";
            // 
            // _5_1PaymentNow1_old
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(168, 211, 252);
            Controls.Add(panel2);
            Name = "_5_1PaymentNow1_old";
            Size = new Size(1280, 720);
            Click += BtnPayLater_Click;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button BtnPay;
        private Guna.UI2.WinForms.Guna2Button BtnPrint;
        private Label lbTimeOut;
        private Label lbTimeIn;
        private Label label2;
        private Label label1;
        private Label lbPrice;
        private Panel panel1;
        private Label DueTime;
        private Label ReceiptTotal;
        private Label TimeOut;
        private Label TimeIn;
        private Label ReceiptNum;
        private Label ReceiptDate;
        private Label VehicleType;
        private Label PlateNumber;
        private Guna.UI2.WinForms.Guna2Button BtnPayLater;
        private Guna.UI2.WinForms.Guna2Button BtnPayNow;
        private PictureBox pictureBox1;
        private Label Status;
        private Label SlotID;
    }
}