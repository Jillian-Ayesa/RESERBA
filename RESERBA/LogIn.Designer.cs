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
            SuspendLayout();
            // 
            // Hello
            // 
            Hello.AutoSize = true;
            Hello.BackColor = Color.DarkOrange;
            Hello.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Hello.ForeColor = Color.DarkOrange;
            Hello.Location = new Point(404, 82);
            Hello.Name = "Hello";
            Hello.Size = new Size(227, 53);
            Hello.TabIndex = 0;
            Hello.Text = ".................";
            // 
            // Hello2
            // 
            Hello2.AutoSize = true;
            Hello2.BackColor = Color.DarkOrange;
            Hello2.FlatStyle = FlatStyle.Flat;
            Hello2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Hello2.ForeColor = Color.Navy;
            Hello2.Location = new Point(439, 90);
            Hello2.Name = "Hello2";
            Hello2.Size = new Size(149, 38);
            Hello2.TabIndex = 1;
            Hello2.Text = "HELLO!";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 255);
            ClientSize = new Size(1066, 602);
            Controls.Add(Hello2);
            Controls.Add(Hello);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Hello;
        private Label Hello2;
    }
}