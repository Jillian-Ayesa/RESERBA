namespace RESERBA
{
    partial class LostTicket
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Hello2 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            TbLostPlateNum = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            linkService = new LinkLabel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Hello2
            // 
            Hello2.AutoSize = true;
            Hello2.BackColor = Color.DarkOrange;
            Hello2.FlatStyle = FlatStyle.Flat;
            Hello2.Font = new Font("Times New Roman", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Hello2.ForeColor = Color.Navy;
            Hello2.Location = new Point(432, 154);
            Hello2.Name = "Hello2";
            Hello2.Size = new Size(401, 57);
            Hello2.TabIndex = 15;
            Hello2.Text = "Lost your Ticket?";
            Hello2.Click += Hello2_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.DarkOrange;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(388, 150);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(484, 64);
            guna2Button1.TabIndex = 16;
            guna2Button1.Text = "guna2Button1";
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 246);
            label1.Name = "label1";
            label1.Size = new Size(649, 49);
            label1.TabIndex = 17;
            label1.Text = "ENTER YOUR PLATE NUMBER";
            // 
            // TbLostPlateNum
            // 
            TbLostPlateNum.BorderColor = Color.Navy;
            TbLostPlateNum.BorderRadius = 15;
            TbLostPlateNum.BorderThickness = 3;
            TbLostPlateNum.CustomizableEdges = customizableEdges3;
            TbLostPlateNum.DefaultText = "";
            TbLostPlateNum.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TbLostPlateNum.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TbLostPlateNum.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TbLostPlateNum.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TbLostPlateNum.FillColor = Color.FromArgb(214, 235, 255);
            TbLostPlateNum.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TbLostPlateNum.Font = new Font("Segoe UI", 9F);
            TbLostPlateNum.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TbLostPlateNum.Location = new Point(393, 321);
            TbLostPlateNum.Margin = new Padding(3, 4, 3, 4);
            TbLostPlateNum.Name = "TbLostPlateNum";
            TbLostPlateNum.PlaceholderText = "";
            TbLostPlateNum.SelectedText = "";
            TbLostPlateNum.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TbLostPlateNum.Size = new Size(476, 107);
            TbLostPlateNum.TabIndex = 18;
            TbLostPlateNum.TextAlign = HorizontalAlignment.Center;
            TbLostPlateNum.TextChanged += TbLostPlateNum_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(501, 457);
            label2.Name = "label2";
            label2.Size = new Size(121, 19);
            label2.TabIndex = 19;
            label2.Text = "Need Assistance";
            label2.Click += label2_Click;
            // 
            // linkService
            // 
            linkService.AutoSize = true;
            linkService.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkService.Location = new Point(618, 457);
            linkService.Name = "linkService";
            linkService.Size = new Size(92, 19);
            linkService.TabIndex = 20;
            linkService.TabStop = true;
            linkService.Text = "Service Call";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BorderRadius = 20;
            guna2PictureBox1.CustomizableEdges = customizableEdges5;
            guna2PictureBox1.FillColor = Color.DarkOrange;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(12, 12);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2PictureBox1.Size = new Size(70, 70);
            guna2PictureBox1.TabIndex = 21;
            guna2PictureBox1.TabStop = false;
            // 
            // LostTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            ClientSize = new Size(1280, 720);
            Controls.Add(guna2PictureBox1);
            Controls.Add(linkService);
            Controls.Add(label2);
            Controls.Add(TbLostPlateNum);
            Controls.Add(label1);
            Controls.Add(Hello2);
            Controls.Add(guna2Button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LostTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LostTicket";
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Hello2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TbLostPlateNum;
        private Label label2;
        private LinkLabel linkService;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}