namespace Bislerium_cafe
{
    partial class Adminemployee
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddEmployees = new System.Windows.Forms.Button();
            this.AddEmployee = new System.Windows.Forms.Panel();
            this.Role = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.pn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.pd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.un = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ln = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.AddEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Controls.Add(this.AddEmployees);
            this.flowLayoutPanel1.Controls.Add(this.AddEmployee);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1011, 737);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // AddEmployees
            // 
            this.AddEmployees.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.AddEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployees.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployees.ForeColor = System.Drawing.Color.Lime;
            this.AddEmployees.Location = new System.Drawing.Point(4, 4);
            this.AddEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.AddEmployees.Name = "AddEmployees";
            this.AddEmployees.Size = new System.Drawing.Size(107, 52);
            this.AddEmployees.TabIndex = 36;
            this.AddEmployees.Text = "Add";
            this.AddEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddEmployees.UseVisualStyleBackColor = false;
            this.AddEmployees.Click += new System.EventHandler(this.button15_Click);
            // 
            // AddEmployee
            // 
            this.AddEmployee.AutoScroll = true;
            this.AddEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AddEmployee.Controls.Add(this.Role);
            this.AddEmployee.Controls.Add(this.label8);
            this.AddEmployee.Controls.Add(this.btncancel);
            this.AddEmployee.Controls.Add(this.pn);
            this.AddEmployee.Controls.Add(this.label7);
            this.AddEmployee.Controls.Add(this.btnadd);
            this.AddEmployee.Controls.Add(this.pd);
            this.AddEmployee.Controls.Add(this.label5);
            this.AddEmployee.Controls.Add(this.un);
            this.AddEmployee.Controls.Add(this.label6);
            this.AddEmployee.Controls.Add(this.email);
            this.AddEmployee.Controls.Add(this.label3);
            this.AddEmployee.Controls.Add(this.dob);
            this.AddEmployee.Controls.Add(this.label4);
            this.AddEmployee.Controls.Add(this.ln);
            this.AddEmployee.Controls.Add(this.label2);
            this.AddEmployee.Controls.Add(this.fn);
            this.AddEmployee.Controls.Add(this.label1);
            this.AddEmployee.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AddEmployee.Location = new System.Drawing.Point(118, 3);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(802, 439);
            this.AddEmployee.TabIndex = 37;
            this.AddEmployee.Visible = false;
            // 
            // Role
            // 
            this.Role.AllowDrop = true;
            this.Role.FormattingEnabled = true;
            this.Role.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.Role.Location = new System.Drawing.Point(466, 269);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(276, 24);
            this.Role.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(401, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "Role";
            // 
            // btncancel
            // 
            this.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Red;
            this.btncancel.Location = new System.Drawing.Point(480, 351);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(107, 52);
            this.btncancel.TabIndex = 39;
            this.btncancel.Text = "Cancel";
            this.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // pn
            // 
            this.pn.Location = new System.Drawing.Point(392, 55);
            this.pn.Multiline = true;
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(350, 35);
            this.pn.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(401, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Phone Number";
            // 
            // btnadd
            // 
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Lime;
            this.btnadd.Location = new System.Drawing.Point(275, 351);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(107, 52);
            this.btnadd.TabIndex = 38;
            this.btnadd.Text = "Add";
            this.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // pd
            // 
            this.pd.Location = new System.Drawing.Point(18, 269);
            this.pd.Multiline = true;
            this.pd.Name = "pd";
            this.pd.Size = new System.Drawing.Size(350, 35);
            this.pd.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(27, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password";
            // 
            // un
            // 
            this.un.Location = new System.Drawing.Point(18, 198);
            this.un.Multiline = true;
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(350, 35);
            this.un.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(27, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "UserName";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(392, 126);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(350, 35);
            this.email.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(401, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(392, 198);
            this.dob.Multiline = true;
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(350, 35);
            this.dob.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(401, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date of Birth";
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(17, 126);
            this.ln.Multiline = true;
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(350, 35);
            this.ln.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(26, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // fn
            // 
            this.fn.Location = new System.Drawing.Point(17, 55);
            this.fn.Multiline = true;
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(350, 35);
            this.fn.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // Adminemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 737);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adminemployee";
            this.Text = "Adminemployee";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.AddEmployee.ResumeLayout(false);
            this.AddEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AddEmployees;
        private System.Windows.Forms.Panel AddEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ln;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.TextBox pn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox un;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Role;
    }
}