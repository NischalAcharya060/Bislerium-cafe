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
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Bislerium_cafe
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            this.ControlBox = true;
        }

        // Move the AuthenticateUser method inside the login class
        private static bool AuthenticateUser(string username, string password, out string role)
        {
            role = null;

            string excelPath = "C:\\Users\\Nisch\\OneDrive\\Desktop\\3rd year\\Coursework\\Application Development\\login_details.xlsx";


            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(excelPath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                int rowCount = worksheet.Dimension.Rows;

                for (int row = 1; row <= rowCount; row++)
                {
                    string username_ = worksheet.Cells[row, 6].Text;
                    string password_ = worksheet.Cells[row, 7].Text;

                    if (!string.IsNullOrEmpty(username_) && username_ == username && password_ == password)
                    {
                        role = worksheet.Cells[row, 8].Text;
                        return true;
                    }
                }
            }

            return false;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            new nav().Show();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usern.Text;
                string password = passw.Text;
                string role;

                if (AuthenticateUser(username, password, out role))
                {
                    if (role.Equals("Admin"))
                    {
                        new nav().Show();
                        this.Hide();
                    }
                    else
                    {
                        new Staffnav().Show();
                        this.Hide();
                    }
                }
                else
                {
                    // Authentication failed
                    MessageBox.Show("Invalid username or password", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
