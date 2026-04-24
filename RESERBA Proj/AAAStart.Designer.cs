namespace RESERBA_Proj
{
    partial class AAAStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AAAStart));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            BtnContinue = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(340, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnContinue
            // 
            BtnContinue.BorderColor = Color.Navy;
            BtnContinue.BorderRadius = 15;
            BtnContinue.BorderThickness = 2;
            BtnContinue.CustomizableEdges = customizableEdges1;
            BtnContinue.DisabledState.BorderColor = Color.DarkGray;
            BtnContinue.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnContinue.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnContinue.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnContinue.FillColor = Color.FromArgb(214, 235, 255);
            BtnContinue.Font = new Font("Playfair Display", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnContinue.ForeColor = Color.Navy;
            BtnContinue.HoverState.FillColor = Color.Navy;
            BtnContinue.HoverState.ForeColor = Color.White;
            BtnContinue.Location = new Point(1036, 605);
            BtnContinue.Name = "BtnContinue";
            BtnContinue.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnContinue.Size = new Size(195, 55);
            BtnContinue.TabIndex = 8;
            BtnContinue.Text = "continue";
            BtnContinue.Click += BtnContinue_Click;
            // 
            // AAAStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            ClientSize = new Size(1280, 720);
            Controls.Add(BtnContinue);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AAAStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AAStart";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button BtnContinue;
    }
}