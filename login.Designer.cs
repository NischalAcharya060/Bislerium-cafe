namespace Bislerium_cafe
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.usern = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.log_in = new System.Windows.Forms.Button();
            this.passw = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // usern
            // 
            this.usern.Location = new System.Drawing.Point(0, 117);
            this.usern.Multiline = true;
            this.usern.Name = "usern";
            this.usern.Size = new System.Drawing.Size(350, 35);
            this.usern.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.usern);
            this.panel1.Controls.Add(this.log_in);
            this.panel1.Controls.Add(this.passw);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(106, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 315);
            this.panel1.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(4, 173);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(75, 16);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(4, 95);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(81, 16);
            this.UserName.TabIndex = 4;
            this.UserName.Text = "UserName";
            // 
            // log_in
            // 
            this.log_in.CausesValidation = false;
            this.log_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_in.Image = global::Bislerium_cafe.Properties.Resources.exit__2_;
            this.log_in.Location = new System.Drawing.Point(121, 250);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(107, 35);
            this.log_in.TabIndex = 3;
            this.log_in.Text = "LOGIN";
            this.log_in.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.log_in.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.log_in.UseVisualStyleBackColor = true;
            this.log_in.Click += new System.EventHandler(this.button1_Click);
            // 
            // passw
            // 
            this.passw.Location = new System.Drawing.Point(0, 192);
            this.passw.Multiline = true;
            this.passw.Name = "passw";
            this.passw.Size = new System.Drawing.Size(350, 35);
            this.passw.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(526, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(942, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usern;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button log_in;
        private System.Windows.Forms.TextBox passw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label UserName;
    }
}

