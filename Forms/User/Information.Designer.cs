namespace RESERBA_Proj
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            _7_Info = new Panel();
            pictureBox1 = new PictureBox();
            _7_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // _7_Info
            // 
            _7_Info.AutoScroll = true;
            _7_Info.BackColor = Color.White;
            _7_Info.Controls.Add(pictureBox1);
            _7_Info.Dock = DockStyle.Fill;
            _7_Info.Location = new Point(0, 0);
            _7_Info.Name = "_7_Info";
            _7_Info.Size = new Size(1280, 720);
            _7_Info.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(945, 2200);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Information
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(168, 211, 252);
            Controls.Add(_7_Info);
            Name = "Information";
            Size = new Size(1280, 720);
            _7_Info.ResumeLayout(false);
            _7_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel _7_Info;
        private PictureBox pictureBox1;
    }
}
