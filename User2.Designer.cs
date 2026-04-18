namespace RESERBA
{
    partial class User2
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnBackInfoRecord = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 58);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(168, 211, 252);
            label2.Location = new Point(129, 97);
            label2.Name = "label2";
            label2.Size = new Size(1022, 526);
            label2.TabIndex = 1;
            label2.Text = " ";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(168, 211, 252);
            label3.Font = new Font("Times New Roman", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(441, 294);
            label3.Name = "label3";
            label3.Size = new Size(423, 58);
            label3.TabIndex = 2;
            label3.Text = "Information Recorded";
            // 
            // BtnBackInfoRecord
            // 
            BtnBackInfoRecord.BackColor = Color.FromArgb(168, 211, 252);
            BtnBackInfoRecord.BorderColor = Color.Navy;
            BtnBackInfoRecord.BorderRadius = 15;
            BtnBackInfoRecord.BorderThickness = 1;
            BtnBackInfoRecord.CustomizableEdges = customizableEdges3;
            BtnBackInfoRecord.DisabledState.BorderColor = Color.DarkGray;
            BtnBackInfoRecord.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnBackInfoRecord.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnBackInfoRecord.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnBackInfoRecord.FillColor = Color.FromArgb(168, 211, 252);
            BtnBackInfoRecord.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBackInfoRecord.ForeColor = Color.Black;
            BtnBackInfoRecord.Location = new Point(579, 363);
            BtnBackInfoRecord.Name = "BtnBackInfoRecord";
            BtnBackInfoRecord.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BtnBackInfoRecord.Size = new Size(138, 30);
            BtnBackInfoRecord.TabIndex = 3;
            BtnBackInfoRecord.Text = "back";
            // 
            // User2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            ClientSize = new Size(1280, 720);
            Controls.Add(BtnBackInfoRecord);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button BtnBackInfoRecord;
    }
}