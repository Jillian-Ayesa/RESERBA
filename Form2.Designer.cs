namespace RESERBA
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label4 = new Label();
            BtnImgAdmin = new Guna.UI2.WinForms.Guna2ImageButton();
            BtnUser = new Button();
            label2 = new Label();
            label1 = new Label();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            BtnAdmin = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(247, 507);
            label4.Name = "label4";
            label4.Size = new Size(172, 90);
            label4.TabIndex = 5;
            label4.Text = "user";
            // 
            // BtnImgAdmin
            // 
            BtnImgAdmin.CheckedState.ImageSize = new Size(64, 64);
            BtnImgAdmin.HoverState.ImageSize = new Size(64, 64);
            BtnImgAdmin.Image = (Image)resources.GetObject("BtnImgAdmin.Image");
            BtnImgAdmin.ImageOffset = new Point(0, 0);
            BtnImgAdmin.ImageRotate = 0F;
            BtnImgAdmin.ImageSize = new Size(600, 600);
            BtnImgAdmin.Location = new Point(131, 109);
            BtnImgAdmin.Name = "BtnImgAdmin";
            BtnImgAdmin.PressedState.ImageSize = new Size(64, 64);
            BtnImgAdmin.ShadowDecoration.CustomizableEdges = customizableEdges3;
            BtnImgAdmin.Size = new Size(416, 390);
            BtnImgAdmin.TabIndex = 10;
            BtnImgAdmin.Click += BtnImgAdmin_Click;
            // 
            // BtnUser
            // 
            BtnUser.BackColor = Color.FromArgb(214, 235, 255);
            BtnUser.Location = new Point(99, 88);
            BtnUser.Name = "BtnUser";
            BtnUser.Size = new Size(480, 530);
            BtnUser.TabIndex = 13;
            BtnUser.Text = "button1";
            BtnUser.UseVisualStyleBackColor = false;
            BtnUser.Click += BtnUser_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Location = new Point(88, 78);
            label2.Name = "label2";
            label2.Size = new Size(502, 550);
            label2.TabIndex = 17;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(822, 507);
            label1.Name = "label1";
            label1.Size = new Size(237, 90);
            label1.TabIndex = 18;
            label1.Text = "admin";
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.ImageSize = new Size(600, 600);
            guna2ImageButton1.Location = new Point(731, 109);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ImageButton1.Size = new Size(416, 390);
            guna2ImageButton1.TabIndex = 19;
            // 
            // BtnAdmin
            // 
            BtnAdmin.BackColor = Color.FromArgb(214, 235, 255);
            BtnAdmin.Location = new Point(699, 88);
            BtnAdmin.Name = "BtnAdmin";
            BtnAdmin.Size = new Size(480, 530);
            BtnAdmin.TabIndex = 20;
            BtnAdmin.Text = "button1";
            BtnAdmin.UseVisualStyleBackColor = false;
            BtnAdmin.Click += BtnAdmin_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Location = new Point(688, 78);
            label3.Name = "label3";
            label3.Size = new Size(502, 550);
            label3.TabIndex = 21;
            label3.Text = "label3";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            ClientSize = new Size(1280, 720);
            Controls.Add(label1);
            Controls.Add(guna2ImageButton1);
            Controls.Add(BtnAdmin);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(BtnImgAdmin);
            Controls.Add(BtnUser);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Guna.UI2.WinForms.Guna2ImageButton BtnImgAdmin;
        private Button BtnUser;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Button BtnAdmin;
        private Label label3;
    }
}