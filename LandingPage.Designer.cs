namespace BrewHub
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            label1 = new Label();
            OrderForm_link = new LinkLabel();
            Login_page_link = new LinkLabel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 31);
            label1.TabIndex = 0;
            label1.Text = "BrewHub";
            // 
            // OrderForm_link
            // 
            OrderForm_link.AutoSize = true;
            OrderForm_link.LinkColor = Color.Navy;
            OrderForm_link.Location = new Point(583, 20);
            OrderForm_link.Name = "OrderForm_link";
            OrderForm_link.Size = new Size(81, 20);
            OrderForm_link.TabIndex = 1;
            OrderForm_link.TabStop = true;
            OrderForm_link.Text = "OrderForm";
            // 
            // Login_page_link
            // 
            Login_page_link.AutoSize = true;
            Login_page_link.LinkColor = Color.Navy;
            Login_page_link.Location = new Point(707, 20);
            Login_page_link.Name = "Login_page_link";
            Login_page_link.Size = new Size(46, 20);
            Login_page_link.TabIndex = 2;
            Login_page_link.TabStop = true;
            Login_page_link.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 103);
            label2.Name = "label2";
            label2.Size = new Size(264, 28);
            label2.TabIndex = 3;
            label2.Text = "Welcome to BrewHub Cafe";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(370, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 292);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 192);
            label3.Name = "label3";
            label3.Size = new Size(284, 27);
            label3.TabIndex = 5;
            label3.Text = "Best Coffee Make Your ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(90, 234);
            label4.Name = "label4";
            label4.Size = new Size(130, 27);
            label4.TabIndex = 6;
            label4.Text = "Day great";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 285);
            label5.Name = "label5";
            label5.Size = new Size(199, 27);
            label5.TabIndex = 7;
            label5.Text = " with our Coffee";
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(Login_page_link);
            Controls.Add(OrderForm_link);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "LandingPage";
            Text = "LandingPage";
            Load += LandingPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel OrderForm_link;
        private LinkLabel Login_page_link;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}