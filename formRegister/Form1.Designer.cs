namespace formRegister
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Enter = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            FullName = new TextBox();
            UserName = new TextBox();
            Password = new TextBox();
            SuspendLayout();
            // 
            // Enter
            // 
            Enter.BackColor = SystemColors.ActiveCaption;
            Enter.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Enter.ForeColor = SystemColors.ActiveCaptionText;
            Enter.Location = new Point(69, 243);
            Enter.Name = "Enter";
            Enter.Size = new Size(680, 61);
            Enter.TabIndex = 0;
            Enter.Text = "Open";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(69, 65);
            label1.Name = "label1";
            label1.Size = new Size(43, 28);
            label1.TabIndex = 1;
            label1.Text = "FIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(69, 128);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 2;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(69, 182);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // FullName
            // 
            FullName.ForeColor = SystemColors.InactiveCaption;
            FullName.Location = new Point(253, 69);
            FullName.Name = "FullName";
            FullName.Size = new Size(496, 27);
            FullName.TabIndex = 4;
            FullName.TextChanged += FullName_TextChanged;
            // 
            // UserName
            // 
            UserName.ForeColor = SystemColors.InactiveCaption;
            UserName.Location = new Point(253, 129);
            UserName.Name = "UserName";
            UserName.Size = new Size(496, 27);
            UserName.TabIndex = 5;
            UserName.TextChanged += textBox2_TextChanged;
            // 
            // Password
            // 
            Password.ForeColor = SystemColors.InactiveCaption;
            Password.Location = new Point(253, 186);
            Password.Name = "Password";
            Password.Size = new Size(496, 27);
            Password.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(FullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Enter);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox FullName;
        private TextBox UserName;
        private TextBox Password;
        public Button Enter;
    }
}
