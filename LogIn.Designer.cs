namespace RESERBA
{
    partial class LogIn
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
            Hello = new Label();
            Hello2 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Hello
            // 
            Hello.BackColor = Color.DarkOrange;
            Hello.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Hello.ForeColor = Color.DarkOrange;
            Hello.Location = new Point(388, 60);
            Hello.Name = "Hello";
            Hello.Size = new Size(272, 64);
            Hello.TabIndex = 0;
            Hello.Text = ".....................";
            Hello.TextAlign = ContentAlignment.TopCenter;
            Hello.Click += Hello_Click;
            // 
            // Hello2
            // 
            Hello2.AutoSize = true;
            Hello2.BackColor = Color.DarkOrange;
            Hello2.FlatStyle = FlatStyle.Flat;
            Hello2.Font = new Font("Times New Roman", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Hello2.ForeColor = Color.Navy;
            Hello2.Location = new Point(454, 63);
            Hello2.Name = "Hello2";
            Hello2.Size = new Size(154, 57);
            Hello2.TabIndex = 1;
            Hello2.Text = "Hello!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(348, 140);
            label1.Name = "label1";
            label1.Size = new Size(355, 46);
            label1.TabIndex = 2;
            label1.Text = "Sign in your Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(166, 220);
            label2.Name = "label2";
            label2.Size = new Size(120, 29);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(388, 289);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            ClientSize = new Size(1440, 1024);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Hello2);
            Controls.Add(Hello);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Hello;
        private Label Hello2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}