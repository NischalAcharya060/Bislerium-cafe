namespace BrewHub
{
    partial class Login
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
            Username = new Label();
            Loginbtn = new Button();
            enteryourusername = new TextBox();
            enteryourpassword = new TextBox();
            Password = new Label();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(290, 106);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 0;
            Username.Text = "Username";
            Username.Click += label1_Click;
            // 
            // Loginbtn
            // 
            Loginbtn.ForeColor = SystemColors.ControlText;
            Loginbtn.Location = new Point(361, 225);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(94, 29);
            Loginbtn.TabIndex = 1;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = true;
            Loginbtn.Click += button1_Click;
            // 
            // enteryourusername
            // 
            enteryourusername.Location = new Point(290, 129);
            enteryourusername.Name = "enteryourusername";
            enteryourusername.Size = new Size(242, 27);
            enteryourusername.TabIndex = 2;
            // 
            // enteryourpassword
            // 
            enteryourpassword.Location = new Point(290, 192);
            enteryourpassword.Name = "enteryourpassword";
            enteryourpassword.Size = new Size(242, 27);
            enteryourpassword.TabIndex = 3;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(290, 169);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 4;
            Password.Text = "Password";
            Password.Click += label2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Password);
            Controls.Add(enteryourpassword);
            Controls.Add(enteryourusername);
            Controls.Add(Loginbtn);
            Controls.Add(Username);
            ForeColor = Color.Brown;
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Button Loginbtn;
        private TextBox enteryourusername;
        private TextBox enteryourpassword;
        private Label Password;
    }
}
