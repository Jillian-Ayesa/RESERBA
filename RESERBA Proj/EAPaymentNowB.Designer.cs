namespace RESERBA_Proj
{
    partial class _5_1PaymentNow2
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
            panel2 = new Panel();
            label4 = new Label();
            BtnContinue = new Guna.UI2.WinForms.Guna2Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(168, 211, 252);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(BtnContinue);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(945, 570);
            panel2.TabIndex = 40;
            // 
            // label4
            // 
            label4.Font = new Font("Playfair Display Black", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(203, 163);
            label4.Name = "label4";
            label4.Size = new Size(557, 79);
            label4.TabIndex = 8;
            label4.Text = "Information Recorded";
            // 
            // BtnContinue
            // 
            BtnContinue.BorderColor = Color.Navy;
            BtnContinue.BorderRadius = 15;
            BtnContinue.BorderThickness = 1;
            BtnContinue.CustomizableEdges = customizableEdges1;
            BtnContinue.DisabledState.BorderColor = Color.DarkGray;
            BtnContinue.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnContinue.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnContinue.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnContinue.FillColor = Color.FromArgb(168, 211, 252);
            BtnContinue.Font = new Font("Playfair Display", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnContinue.ForeColor = Color.Navy;
            BtnContinue.HoverState.FillColor = Color.Navy;
            BtnContinue.HoverState.ForeColor = Color.White;
            BtnContinue.Location = new Point(384, 257);
            BtnContinue.Name = "BtnContinue";
            BtnContinue.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnContinue.Size = new Size(195, 55);
            BtnContinue.TabIndex = 7;
            BtnContinue.Text = "continue";
            BtnContinue.Click += BtnContinue_Click;
            // 
            // _5_1PaymentNow2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(168, 211, 252);
            Controls.Add(panel2);
            Name = "_5_1PaymentNow2";
            Size = new Size(1280, 720);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button BtnContinue;
    }
}