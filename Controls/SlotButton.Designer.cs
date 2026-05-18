namespace RESERBA_Proj
{
    partial class SlotButton
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlotButton));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            BtnPrev = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            BtnNext = new Guna.UI2.WinForms.Guna2Button();
            panelSlot = new Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panelSlot.SuspendLayout();
            SuspendLayout();
            // 
            // BtnPrev
            // 
            BtnPrev.CustomizableEdges = customizableEdges1;
            BtnPrev.DisabledState.BorderColor = Color.DarkGray;
            BtnPrev.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnPrev.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnPrev.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnPrev.FillColor = Color.FromArgb(118, 181, 255);
            BtnPrev.Font = new Font("Segoe UI", 9F);
            BtnPrev.ForeColor = Color.White;
            BtnPrev.Image = (Image)resources.GetObject("BtnPrev.Image");
            BtnPrev.ImageSize = new Size(30, 30);
            BtnPrev.Location = new Point(9, 100);
            BtnPrev.Name = "BtnPrev";
            BtnPrev.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnPrev.Size = new Size(46, 44);
            BtnPrev.TabIndex = 0;
            BtnPrev.Click += BtnPrev_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(118, 181, 255);
            label2.Font = new Font("Rounded", 25.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 7);
            label2.Name = "label2";
            label2.Size = new Size(260, 48);
            label2.TabIndex = 18;
            label2.Text = "Gate 1";
            label2.Click += label2_Click;
            // 
            // BtnNext
            // 
            BtnNext.CustomizableEdges = customizableEdges3;
            BtnNext.DisabledState.BorderColor = Color.DarkGray;
            BtnNext.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnNext.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnNext.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnNext.FillColor = Color.FromArgb(118, 181, 255);
            BtnNext.Font = new Font("Segoe UI", 9F);
            BtnNext.ForeColor = Color.White;
            BtnNext.Image = (Image)resources.GetObject("BtnNext.Image");
            BtnNext.ImageSize = new Size(30, 30);
            BtnNext.Location = new Point(368, 100);
            BtnNext.Name = "BtnNext";
            BtnNext.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BtnNext.Size = new Size(46, 44);
            BtnNext.TabIndex = 19;
            BtnNext.Click += BtnNext_Click;
            // 
            // panelSlot
            // 
            panelSlot.Controls.Add(guna2HtmlLabel1);
            panelSlot.Controls.Add(label2);
            panelSlot.Controls.Add(BtnPrev);
            panelSlot.Controls.Add(BtnNext);
            panelSlot.Location = new Point(3, 2);
            panelSlot.Name = "panelSlot";
            panelSlot.Size = new Size(417, 251);
            panelSlot.TabIndex = 20;
            panelSlot.Paint += panelSlot_Paint;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Aribau Rounded Trial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(151, 100);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(118, 54);
            guna2HtmlLabel1.TabIndex = 21;
            guna2HtmlLabel1.Text = "33/40";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // SlotButton
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(118, 181, 255);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panelSlot);
            Name = "SlotButton";
            Size = new Size(1000, 700);
            panelSlot.ResumeLayout(false);
            panelSlot.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnPrev;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button BtnNext;
        private Panel panelSlot;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
