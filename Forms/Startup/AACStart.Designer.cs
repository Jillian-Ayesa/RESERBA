namespace RESERBA_Proj
{
    partial class AACStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AACStart));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tbUser = new Guna.UI2.WinForms.Guna2TileButton();
            tbAdmin = new Guna.UI2.WinForms.Guna2TileButton();
            SuspendLayout();
            // 
            // tbUser
            // 
            tbUser.BorderRadius = 10;
            tbUser.BorderThickness = 3;
            tbUser.CustomizableEdges = customizableEdges1;
            tbUser.DisabledState.BorderColor = Color.DarkGray;
            tbUser.DisabledState.CustomBorderColor = Color.DarkGray;
            tbUser.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            tbUser.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            tbUser.FillColor = Color.FromArgb(214, 235, 255);
            tbUser.Font = new Font("Aribau Rounded Trial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUser.ForeColor = Color.Navy;
            tbUser.HoverState.FillColor = Color.Navy;
            tbUser.HoverState.ForeColor = Color.White;
            tbUser.Image = (Image)resources.GetObject("tbUser.Image");
            tbUser.ImageOffset = new Point(0, 150);
            tbUser.ImageSize = new Size(550, 500);
            tbUser.Location = new Point(94, 78);
            tbUser.Name = "tbUser";
            tbUser.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbUser.Size = new Size(502, 550);
            tbUser.TabIndex = 0;
            tbUser.Text = "User";
            tbUser.TextOffset = new Point(0, 20);
            tbUser.Click += tbUser_Click;
            // 
            // tbAdmin
            // 
            tbAdmin.BorderRadius = 10;
            tbAdmin.BorderThickness = 3;
            tbAdmin.CustomizableEdges = customizableEdges3;
            tbAdmin.DisabledState.BorderColor = Color.DarkGray;
            tbAdmin.DisabledState.CustomBorderColor = Color.DarkGray;
            tbAdmin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            tbAdmin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            tbAdmin.FillColor = Color.FromArgb(214, 235, 255);
            tbAdmin.Font = new Font("Aribau Rounded Trial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbAdmin.ForeColor = Color.Navy;
            tbAdmin.HoverState.FillColor = Color.Navy;
            tbAdmin.HoverState.ForeColor = Color.White;
            tbAdmin.Image = (Image)resources.GetObject("tbAdmin.Image");
            tbAdmin.ImageOffset = new Point(0, 150);
            tbAdmin.ImageSize = new Size(550, 500);
            tbAdmin.Location = new Point(668, 78);
            tbAdmin.Name = "tbAdmin";
            tbAdmin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tbAdmin.Size = new Size(502, 550);
            tbAdmin.TabIndex = 1;
            tbAdmin.Text = "Admin";
            tbAdmin.TextOffset = new Point(0, 20);
            tbAdmin.Click += tbAdmin_Click;
            // 
            // AACStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            ClientSize = new Size(1280, 720);
            Controls.Add(tbAdmin);
            Controls.Add(tbUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AACStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AACStart";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton tbUser;
        private Guna.UI2.WinForms.Guna2TileButton tbAdmin;
    }
}