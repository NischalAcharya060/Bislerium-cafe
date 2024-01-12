using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Bislerium_cafe
{
    public partial class addcoffee : Form
    {
        private Panel mainPanel;
        public addcoffee()
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
                ExcelWorksheet worksheet = package.Workbook.Worksheets[2];

                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    string name = worksheet.Cells[row, 1].Text;
                    string price = worksheet.Cells[row, 2].Text;



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
                        Image = Image.FromFile("C:\\Users\\Nisch\\source\\repos\\test\\photo\\pngwing.com (1).png"),



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
                    Label label1 = new Label()
                    {
                        Text = "Price",
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
                    Button Edit = new Button()
                    {
                        BackColor = Color.FromArgb(26, 23, 40),
                        BackgroundImageLayout = ImageLayout.Tile,
                        FlatAppearance =
                {
                    BorderColor=Color.FromArgb(90,190,240),
                    BorderSize=1,


                },
                        FlatStyle = FlatStyle.Flat,
                        ForeColor = Color.FromArgb(90, 190, 240),
                        ImageAlign = ContentAlignment.MiddleCenter,
                        Location = new Point(549, 23),
                        Margin = new Padding(4, 4, 4, 4),
                        Size = new Size(62, 52),
                        ImageIndex = 29,
                        TextAlign = ContentAlignment.MiddleCenter,
                        TabStop = true,
                        TextImageRelation = TextImageRelation.ImageBeforeText,
                        Text = "Edit",
                        Font = new Font("Nirmala UI", 10, FontStyle.Bold)




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



                    users_name.Text = name;
                    role.Text = price;

                }
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
           
        }

        private void RefreshUI()
        {
            flowLayoutPanel1.Controls.Clear();
            InitializeComponents();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AddEmployee.Visible = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            AddEmployee.Visible = false;
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            String add_coffee = fn.Text;
            String addprice = ln.Text;
           
            string excelPath = "C:\\Users\\Nisch\\OneDrive\\Desktop\\3rd year\\Coursework\\Application Development\\login_details.xlsx";
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(excelPath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[2];

                // Find the next available row
                int rowCount = worksheet.Dimension.Rows;
                int newRow = rowCount + 1;
                worksheet.Cells[newRow, 1].Value = add_coffee;
                worksheet.Cells[newRow, 2].Value = addprice;
               

                package.Save();
                AddEmployee.Visible = false;
                RefreshUI();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddEmployee_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

