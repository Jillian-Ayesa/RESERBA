namespace RESERBA_Proj
{
    partial class _1Admin3
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
            label1 = new Label();
            BtnLabel = new Guna.UI2.WinForms.Guna2Button();
            cbGateNum = new Guna.UI2.WinForms.Guna2ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Playfair Display", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 310);
            label1.Name = "label1";
            label1.Size = new Size(601, 56);
            label1.TabIndex = 10;
            label1.Text = "ENTER YOUR GATE NUMBER";
            // 
            // BtnLabel
            // 
            BtnLabel.BorderRadius = 15;
            BtnLabel.CustomizableEdges = customizableEdges1;
            BtnLabel.DisabledState.BorderColor = Color.DarkGray;
            BtnLabel.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnLabel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnLabel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnLabel.FillColor = Color.DarkOrange;
            BtnLabel.Font = new Font("Playfair Display Black", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLabel.ForeColor = Color.Navy;
            BtnLabel.Location = new Point(334, 200);
            BtnLabel.Name = "BtnLabel";
            BtnLabel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnLabel.Size = new Size(601, 86);
            BtnLabel.TabIndex = 9;
            BtnLabel.Text = "Hello, User!";
            // 
            // cbGateNum
            // 
            cbGateNum.AllowDrop = true;
            cbGateNum.BackColor = Color.FromArgb(214, 235, 255);
            cbGateNum.BorderColor = Color.Navy;
            cbGateNum.BorderRadius = 15;
            cbGateNum.BorderThickness = 5;
            cbGateNum.CustomizableEdges = customizableEdges3;
            cbGateNum.DrawMode = DrawMode.OwnerDrawFixed;
            cbGateNum.DropDownHeight = 150;
            cbGateNum.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGateNum.DropDownWidth = 480;
            cbGateNum.FillColor = Color.FromArgb(214, 235, 255);
            cbGateNum.FocusedColor = Color.FromArgb(94, 148, 255);
            cbGateNum.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbGateNum.Font = new Font("Playfair Display Black", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbGateNum.ForeColor = Color.Navy;
            cbGateNum.HoverState.ForeColor = Color.DarkOrange;
            cbGateNum.IntegralHeight = false;
            cbGateNum.ItemHeight = 70;
            cbGateNum.Items.AddRange(new object[] { "Gate 1", "Gate 2", "Gate 3" });
            cbGateNum.Location = new Point(393, 388);
            cbGateNum.MaxDropDownItems = 3;
            cbGateNum.Name = "cbGateNum";
            cbGateNum.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbGateNum.Size = new Size(479, 76);
            cbGateNum.TabIndex = 11;
            cbGateNum.TextOffset = new Point(5, 0);
            cbGateNum.SelectedIndexChanged += cbGateNum_SelectedIndexChanged;
            // 
            // _1Admin3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            ClientSize = new Size(1280, 720);
            Controls.Add(cbGateNum);
            Controls.Add(label1);
            Controls.Add(BtnLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "_1Admin3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_1Admin3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnLabel;
        private Guna.UI2.WinForms.Guna2ComboBox cbGateNum;
    }
}