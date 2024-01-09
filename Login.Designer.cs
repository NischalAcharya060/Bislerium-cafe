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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Username = new Label();
            Loginbtn = new Button();
            enteryourusername = new TextBox();
            enteryourpassword = new TextBox();
            Password = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(85, 160);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 0;
            Username.Text = "Username";
            Username.Click += label1_Click;
            // 
            // Loginbtn
            // 
            Loginbtn.ForeColor = SystemColors.ControlText;
            Loginbtn.Location = new Point(141, 289);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(94, 29);
            Loginbtn.TabIndex = 1;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = true;
            Loginbtn.Click += button1_Click;
            // 
            // enteryourusername
            // 
            enteryourusername.ForeColor = SystemColors.WindowFrame;
            enteryourusername.Location = new Point(85, 183);
            enteryourusername.Name = "enteryourusername";
            enteryourusername.Size = new Size(242, 27);
            enteryourusername.TabIndex = 2;
            // 
            // enteryourpassword
            // 
            enteryourpassword.ForeColor = SystemColors.WindowFrame;
            enteryourpassword.Location = new Point(85, 245);
            enteryourpassword.Name = "enteryourpassword";
            enteryourpassword.Size = new Size(242, 27);
            enteryourpassword.TabIndex = 3;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(85, 222);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 4;
            Password.Text = "Password";
            Password.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(390, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(369, 286);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(808, 430);
            Controls.Add(pictureBox1);
            Controls.Add(Password);
            Controls.Add(enteryourpassword);
            Controls.Add(enteryourusername);
            Controls.Add(Loginbtn);
            Controls.Add(Username);
            ForeColor = Color.Brown;
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Button Loginbtn;
        private TextBox enteryourusername;
        private TextBox enteryourpassword;
        private Label Password;
        private PictureBox pictureBox1;
    }
}
