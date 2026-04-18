namespace RESERBA
{
    partial class Map1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map1));
            panelSidebar = new Panel();
            button6 = new Button();
            imageList2 = new ImageList(components);
            button5 = new Button();
            button4 = new Button();
            imageList1 = new ImageList(components);
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Navy;
            panelSidebar.Controls.Add(button6);
            panelSidebar.Controls.Add(button5);
            panelSidebar.Controls.Add(button4);
            panelSidebar.Controls.Add(button3);
            panelSidebar.Controls.Add(button2);
            panelSidebar.Controls.Add(button1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(275, 720);
            panelSidebar.TabIndex = 0;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Times New Roman", 20F);
            button6.ForeColor = Color.White;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.ImageIndex = 0;
            button6.ImageList = imageList2;
            button6.Location = new Point(0, 594);
            button6.Name = "button6";
            button6.Size = new Size(268, 89);
            button6.TabIndex = 5;
            button6.Text = "Information";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "white_info-removebg-preview.png");
            imageList2.Images.SetKeyName(1, "white_payment-removebg-preview.png");
            imageList2.Images.SetKeyName(2, "white_search_bar-removebg-preview.png");
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 20F);
            button5.ForeColor = Color.White;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.ImageIndex = 1;
            button5.ImageList = imageList2;
            button5.Location = new Point(0, 498);
            button5.Name = "button5";
            button5.Size = new Size(247, 62);
            button5.TabIndex = 1;
            button5.Text = " Payment";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 20F);
            button4.ForeColor = Color.White;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.ImageIndex = 2;
            button4.ImageList = imageList1;
            button4.Location = new Point(12, 410);
            button4.Name = "button4";
            button4.Size = new Size(218, 56);
            button4.TabIndex = 4;
            button4.Text = "  VIP";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "white_dashboard-removebg-preview.png");
            imageList1.Images.SetKeyName(1, "white_map-removebg-preview.png");
            imageList1.Images.SetKeyName(2, "vip_white-removebg-preview.png");
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 20F);
            button3.ForeColor = Color.White;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageIndex = 2;
            button3.ImageList = imageList2;
            button3.Location = new Point(3, 313);
            button3.Name = "button3";
            button3.Size = new Size(218, 64);
            button3.TabIndex = 3;
            button3.Text = " Search";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageIndex = 1;
            button2.ImageList = imageList1;
            button2.Location = new Point(12, 226);
            button2.Name = "button2";
            button2.Size = new Size(209, 68);
            button2.TabIndex = 2;
            button2.Text = "  Map";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 0;
            button1.ImageList = imageList1;
            button1.Location = new Point(12, 131);
            button1.Name = "button1";
            button1.Size = new Size(235, 63);
            button1.TabIndex = 1;
            button1.Text = " Dashboard";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Map1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            ClientSize = new Size(1280, 720);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Map1";
            Text = "Map1";
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Button button1;
        private ImageList imageList1;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button4;
        private Button button6;
        private ImageList imageList2;
    }
}