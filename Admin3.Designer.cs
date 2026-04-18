namespace RESERBA
{
    partial class Admin3
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
            label3 = new Label();
            label2 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            CboxGate = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(401, 260);
            label3.Name = "label3";
            label3.Size = new Size(509, 38);
            label3.TabIndex = 5;
            label3.Text = "ENTER YOUR GATE NUMBER";
            // 
            // label2
            // 
            label2.BackColor = Color.DarkOrange;
            label2.Font = new Font("Times New Roman", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(444, 175);
            label2.Name = "label2";
            label2.Size = new Size(428, 57);
            label2.TabIndex = 4;
            label2.Text = "Hello, ";
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
            guna2Button1.ForeColor = Color.DarkOrange;
            guna2Button1.Location = new Point(379, 171);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(552, 64);
            guna2Button1.TabIndex = 6;
            guna2Button1.Text = "guna2Button1";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BorderRadius = 20;
            guna2PictureBox1.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.FillColor = Color.DarkOrange;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(12, 12);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.Size = new Size(70, 70);
            guna2PictureBox1.TabIndex = 7;
            guna2PictureBox1.TabStop = false;
            // 
            // CboxGate
            // 
            CboxGate.AllowDrop = true;
            CboxGate.BackColor = Color.FromArgb(214, 235, 255);
            CboxGate.BorderColor = Color.Navy;
            CboxGate.BorderRadius = 20;
            CboxGate.BorderThickness = 5;
            CboxGate.CustomizableEdges = customizableEdges5;
            CboxGate.DrawMode = DrawMode.OwnerDrawFixed;
            CboxGate.DropDownHeight = 110;
            CboxGate.DropDownStyle = ComboBoxStyle.DropDownList;
            CboxGate.DropDownWidth = 490;
            CboxGate.FillColor = Color.FromArgb(214, 235, 255);
            CboxGate.FocusedColor = Color.FromArgb(94, 148, 255);
            CboxGate.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            CboxGate.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CboxGate.ForeColor = Color.Navy;
            CboxGate.HoverState.ForeColor = Color.DarkOrange;
            CboxGate.IntegralHeight = false;
            CboxGate.ItemHeight = 70;
            CboxGate.Items.AddRange(new object[] { "GATE 1", "GATE 2", "GATE 3" });
            CboxGate.Location = new Point(413, 328);
            CboxGate.MaxDropDownItems = 3;
            CboxGate.Name = "CboxGate";
            CboxGate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            CboxGate.Size = new Size(490, 76);
            CboxGate.TabIndex = 8;
            CboxGate.SelectedIndexChanged += CboxGate_SelectedIndexChanged;
            // 
            // Admin3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            ClientSize = new Size(1280, 720);
            Controls.Add(CboxGate);
            Controls.Add(guna2PictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(guna2Button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin3";
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox CboxGate;
    }
}