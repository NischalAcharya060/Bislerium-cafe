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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            this.ControlBox = true;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            string excelPath = "C:\\Users\\Nisch\\OneDrive\\Desktop\\3rd year\\Coursework\\Application Development\\login_details.xlsx";

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(excelPath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

                int rowCount = worksheet.Dimension.Rows;
               
                for (int row = 2; row <= rowCount; row++)
                {
                    string quantity = worksheet.Cells[row, 3].Text;

                    if (int.TryParse(quantity, out int quantityValue))
                    {
                       quantityValue += quantityValue;
                        rrr.Text = quantityValue.ToString();
                    }
                    else
                    {
                        // Handle the case where quantity cannot be parsed as an integer
                        Console.WriteLine($"Invalid quantity format in row {row}");
                    }
                }

                
            }
        }
    }
}

