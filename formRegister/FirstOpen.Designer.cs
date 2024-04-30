namespace formRegister
{
    partial class FirstOpen
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            UserName = new TextBox();
            Password = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Location = new Point(51, 261);
            button1.Name = "button1";
            button1.Size = new Size(693, 29);
            button1.TabIndex = 0;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 101);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 178);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // UserName
            // 
            UserName.Location = new Point(161, 104);
            UserName.Name = "UserName";
            UserName.Size = new Size(583, 27);
            UserName.TabIndex = 3;
            UserName.TextChanged += UserName_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(161, 175);
            Password.Name = "Password";
            Password.Size = new Size(583, 27);
            Password.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowText;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(51, 311);
            button2.Name = "button2";
            button2.Size = new Size(693, 29);
            button2.TabIndex = 5;
            button2.Text = "Registr account";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FirstOpen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FirstOpen";
            Text = "FirstOpen";
            Load += FirstOpen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox UserName;
        private TextBox Password;
        private Button button2;
    }
}