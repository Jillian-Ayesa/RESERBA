namespace RESERBA_Proj
{
    partial class EAPaymentNowVIPB
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            BtnContinue = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(168, 211, 252);
            panel2.Controls.Add(BtnContinue);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(945, 570);
            panel2.TabIndex = 0;
            // 
            // BtnContinue
            // 
            BtnContinue.BorderColor = Color.Navy;
            BtnContinue.BorderRadius = 10;
            BtnContinue.BorderThickness = 1;
            BtnContinue.CustomizableEdges = customizableEdges1;
            BtnContinue.DisabledState.BorderColor = Color.DarkGray;
            BtnContinue.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnContinue.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnContinue.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnContinue.FillColor = Color.FromArgb(168, 211, 252);
            BtnContinue.Font = new Font("Aribau Rounded Trial", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnContinue.ForeColor = Color.Navy;
            BtnContinue.HoverState.FillColor = Color.Navy;
            BtnContinue.HoverState.ForeColor = Color.White;
            BtnContinue.Location = new Point(419, 285);
            BtnContinue.Name = "BtnContinue";
            BtnContinue.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnContinue.Size = new Size(130, 40);
            BtnContinue.TabIndex = 10;
            BtnContinue.Text = "continue";
            BtnContinue.Click += BtnContinue_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(168, 211, 252);
            label4.Font = new Font("Rounded", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(174, 223);
            label4.Name = "label4";
            label4.Size = new Size(571, 53);
            label4.TabIndex = 11;
            label4.Text = "Information Recorded";
            // 
            // EAPaymentNowVIPB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            Controls.Add(label4);
            Controls.Add(panel2);
            Name = "EAPaymentNowVIPB";
            Size = new Size(1280, 720);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button BtnContinue;
        private Label label4;
    }
}
