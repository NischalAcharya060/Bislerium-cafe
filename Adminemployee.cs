using OfficeOpenXml;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Bislerium_cafe
{
    public partial class Adminemployee : Form
    {
        private Panel mainPanel;

        public Adminemployee()
        {
            InitializeComponent();
            InitializeComponents();

            this.ControlBox = true;
        }

        private void InitializeComponents()
        {
            string excelPath = "C:\\Users\\Nisch\\OneDrive\\Desktop\\3rd year\\Coursework\\Application Development\\login_details.xlsx";

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(excelPath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    string firstName = worksheet.Cells[row, 1].Text;
                    string lastName = worksheet.Cells[row, 2].Text;
                    string dob = worksheet.Cells[row, 3].Text;
                    string email = worksheet.Cells[row, 4].Text;
                    string phoneno = worksheet.Cells[row, 5].Text;
                    string userName = worksheet.Cells[row, 6].Text;
                    string password = worksheet.Cells[row, 7].Text;
                    string roles = worksheet.Cells[row, 8].Text;
                    string Full_Name = firstName + " " + lastName;

                    // Create a main Panel
                    mainPanel = new Panel
                    {
                        Location = new Point(32, 91),
                        Size = new Size(742, 95),
                        BackColor = Color.FromArgb(26, 23, 40),
                    };

                    // Buttons
                    PictureBox userphoto = new PictureBox()
                    {
                        Location = new Point(17, 9),
                        Size = new Size(87, 78),
                        Margin = new Padding(4, 4, 4, 4),
                        Anchor = AnchorStyles.Top | AnchorStyles.Left,
                        BackColor = Color.FromArgb(26, 23, 40),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Image = Image.FromFile("C:\\Users\\Nisch\\source\\repos\\test\\photo\\employee.png"),
                    };

                    Label users_name = new Label()
                    {
                        Text = "Username",
                        Anchor = AnchorStyles.Top | AnchorStyles.Left,
                        BackColor = Color.FromArgb(26, 23, 40),
                        ForeColor = Color.White,
                        ImageAlign = ContentAlignment.MiddleLeft,
                        Location = new Point(112, 23),
                        Margin = new Padding(4, 0, 4, 0),
                        Size = new Size(136, 26),
                        TabIndex = 1,
                        TextAlign = ContentAlignment.TopLeft,
                        AutoSize = true,
                        Font = new Font("Microsoft Sans Serif", 13)
                    };

                    mainPanel.Click += (sender, e) =>
                    {
                        String username = users_name.Text;
                        un.ReadOnly = true;
                        string excelPath_ = "C:\\Users\\Nisch\\OneDrive\\Desktop\\3rd year\\Coursework\\Application Development\\staff_login_data.xlsx";
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                        using (var package_ = new ExcelPackage(new FileInfo(excelPath_)))
                        {
                            ExcelWorksheet worksheet_ = package_.Workbook.Worksheets[0];

                            // Find the row with the matching username
                            for (int row_ = 2; row_ <= worksheet_.Dimension.Rows; row_++)
                            {
                                if (worksheet_.Cells[row_, 6].Text == username)
                                {
                                     string First_Name=fn.ToString();
                                    string Last_Name=ln.ToString();
                                    string Dob=dob.ToString();
                                    string Email=email.ToString();
                                    string phnumber=pn.ToString();
                                    string User_name=un.ToString();
                                    string Password=pd.ToString();
                                    string Roless=Role.ToString();
                                    AddEmployee.Visible = true;
                                    fn.Text = worksheet_.Cells[row_, 1].Value.ToString();
                                    ln.Text = worksheet_.Cells[row_, 2].Value.ToString();
                                    pn.Text= worksheet_.Cells[row_, 5].Value.ToString();
                                    un.Text= worksheet_.Cells[row_, 6].Value.ToString();
                                    pd.Text= worksheet_.Cells[row_, 7].Value.ToString();
                                    Role.Text= worksheet_.Cells[row_, 8].Value.ToString();
                                    btnadd.Text = "update";






                                    /*worksheet.Cells[row, 1].Value = "First_Name";
                                     worksheet.Cells[row, 2].Value = "Last_Name";
                                     worksheet.Cells[row, 3].Value = "Dob";
                                     worksheet.Cells[row, 4].Value = "Email";
                                     worksheet.Cells[row, 5].Value = "phnumber";
                                     worksheet.Cells[row, 6].Value = "User_Name";
                                     worksheet.Cells[row, 7].Value = "Password";
                                     worksheet.Cells[row, 8].Value = "Roless";*/
                                    break;
                                }
                            }
                        }
                    };

                    Label label1 = new Label()
                    {
                        Text = "Role",
                        Anchor = AnchorStyles.Top | AnchorStyles.Left,
                        BackColor = Color.FromArgb(26, 23, 40),
                        ForeColor = Color.FromArgb(127, 124, 146),
                        ImageAlign = ContentAlignment.MiddleCenter,
                        Location = new Point(113, 60),
                        Margin = new Padding(4, 0, 4, 0),
                        Size = new Size(43, 20),
                        TabIndex = 1,
                        TextAlign = ContentAlignment.TopLeft,
                        AutoSize = true,
                        Font = new Font("Microsoft Sans Serif", 10)
                    };

                    Label role = new Label()
                    {
                        Text = "Admin",
                        Anchor = AnchorStyles.Top | AnchorStyles.Left,
                        BackColor = Color.FromArgb(26, 23, 40),
                        ForeColor = Color.White,
                        ImageAlign = ContentAlignment.MiddleCenter,
                        Location = new Point(176, 60),
                        Margin = new Padding(4, 0, 4, 0),
                        Size = new Size(56, 20),
                        TabIndex = 31,
                        TextAlign = ContentAlignment.TopLeft,
                        AutoSize = true,
                        Font = new Font("Microsoft Sans Serif", 10)
                    };

                    Button Delete = new Button()
                    {
                        BackColor = Color.FromArgb(26, 23, 40),
                        BackgroundImageLayout = ImageLayout.Tile,
                        FlatAppearance =
                        {
                            BorderColor = Color.FromArgb(229, 99, 135),
                            BorderSize = 1,
                        },
                        FlatStyle = FlatStyle.Flat,
                        ForeColor = Color.FromArgb(229, 99, 135),
                        ImageAlign = ContentAlignment.MiddleCenter,
                        Location = new Point(633, 23),
                        Margin = new Padding(4, 4, 4, 4),
                        Size = new Size(92, 52),
                        ImageIndex = 30,
                        TextAlign = ContentAlignment.MiddleCenter,
                        TabStop = true,
                        TextImageRelation = TextImageRelation.ImageBeforeText,
                        Text = "Delete",
                        Font = new Font("Nirmala UI", 10, FontStyle.Bold)
                        // for deleting a employees
                    };

                    users_name.Text = userName;
                    role.Text = roles;

                    mainPanel.Controls.Add(users_name);
                    mainPanel.Controls.Add(label1);
                    mainPanel.Controls.Add(userphoto);
                    mainPanel.Controls.Add(role);
                    mainPanel.Controls.Add(Delete);

                    flowLayoutPanel1.Controls.Add(mainPanel);
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AddEmployee.Visible = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            AddEmployee.Visible = false;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e, String username)
        {
            // Your code for checkedListBox1_SelectedIndexChanged
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String first_name = fn.Text;
            String last_name = ln.Text;
            String username = un.Text;
            String password = pd.Text;
            String phone_number = pn.Text;
            String dateob = dob.Text;
            String email_address = email.Text;
            String role = Role.Text;
            string excelPath = "C:\\Users\\Nisch\\OneDrive\\Desktop\\3rd year\\Coursework\\Application Development\\login_details.xlsx";
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(excelPath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                // Find the next available row
                int rowCount = worksheet.Dimension.Rows;
                int newRow = rowCount + 1;
                worksheet.Cells[newRow, 1].Value = first_name;
                worksheet.Cells[newRow, 2].Value = last_name;
                worksheet.Cells[newRow, 3].Value = dateob;
                worksheet.Cells[newRow, 4].Value = email_address;
                worksheet.Cells[newRow, 5].Value = phone_number;
                worksheet.Cells[newRow, 6].Value = username;
                worksheet.Cells[newRow, 7].Value = password;
                worksheet.Cells[newRow, 8].Value = role;

                package.Save();
                AddEmployee.Visible = false;
                RefreshUI();



            

        }
    }

        private void RefreshUI()
        {
            flowLayoutPanel1.Controls.Clear();
            InitializeComponents();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
