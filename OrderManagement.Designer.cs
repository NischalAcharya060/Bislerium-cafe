namespace BrewHub
{
    partial class OrderManagement
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
            label1 = new Label();
            txtCustomerName = new TextBox();
            label2 = new Label();
            txtCoffeeType = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            label1.Click += this.label1_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.ForeColor = SystemColors.WindowFrame;
            txtCustomerName.Location = new Point(12, 56);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(190, 27);
            txtCustomerName.TabIndex = 1;
            txtCustomerName.Text = "enter your name";
            txtCustomerName.TextChanged += this.textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 28);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "Coffee Type";
            // 
            // txtCoffeeType
            // 
            txtCoffeeType.ForeColor = SystemColors.WindowFrame;
            txtCoffeeType.Location = new Point(282, 56);
            txtCoffeeType.Name = "txtCoffeeType";
            txtCoffeeType.Size = new Size(154, 27);
            txtCoffeeType.TabIndex = 3;
            txtCoffeeType.Text = "enter your coffee type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(548, 28);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 4;
            label3.Text = "Add-Ins";
            // 
            // OrderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtCoffeeType);
            Controls.Add(label2);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Name = "OrderManagement";
            Text = "OrderManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomerName;
        private Label label2;
        private TextBox txtCoffeeType;
        private Label label3;
    }
}