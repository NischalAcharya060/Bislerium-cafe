using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Bislerium_cafe
{
    public partial class order : Form
    {
        private List<OrderedItem> orderedItems = new List<OrderedItem>();
        private int quantity = 0;
        private Dictionary<Panel, int> buttonClickCount = new Dictionary<Panel, int>();
        private Label billqnty; // Declare billqnty at the class level

        private const string ExcelPath = "C:\\Users\\Nisch\\OneDrive\\Desktop\\3rd year\\Coursework\\Application Development\\login_details.xlsx";

        public order()
        {

            InitializeComponent();
            InitializeItemPanels();

            this.ControlBox = true;
        }

        public void InitializeItemPanels()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(ExcelPath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[2];

                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    string name = worksheet.Cells[row, 1].Text;
                    string price = worksheet.Cells[row, 2].Text;

                    string[] itemNames = { name };
                    string[] itemPrices = { price };
                    string[] imagePaths = { "path_to_image" }; // Update with the actual image paths

                    for (int i = 0; i < itemNames.Length; i++)
                    {
                        Panel itemPanel = CreateItemPanel(itemNames[i], itemPrices[i], imagePaths[i]);
                        flowLayoutPanel1.Controls.Add(itemPanel);
                    }
                }
            }
        }

        private Panel CreateItemPanel(string itemName, string itemPrice, string imagePath)
        {
            Panel panel = new Panel();
            panel.Size = new Size(200, 120);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Margin = new Padding(10);
            panel.BackColor = Color.Brown;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(80, 80);
            pictureBox.Location = new Point(10, 10);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = Image.FromFile("C:\\Users\\Nisch\\source\\repos\\test\\photo\\pngwing.com (1).png");

            Label nameLabel = new Label();
            nameLabel.Text = itemName;
            nameLabel.Location = new Point(100, 10);
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            nameLabel.ForeColor = Color.Black;

            Label priceLabel = new Label();
            priceLabel.Text = $"Price: ${itemPrice:F2}";
            priceLabel.Location = new Point(100, 40);
            priceLabel.AutoSize = true;
            priceLabel.ForeColor = Color.Black;

            panel.Click += (sender, e) =>
            {
                // Store the details of the previously clicked panel in the list
                if (billqnty != null)
                {
                    orderedItems.Add(new OrderedItem(nameLabel.Text, priceLabel.Text, quantity));
                }

                // Update button click count for the current panel
                if (!buttonClickCount.ContainsKey(panel))
                {
                    buttonClickCount[panel] = 1;
                }
                else
                {
                    buttonClickCount[panel]++;
                }

                Panel billpanel = new Panel();
                billpanel.Size = new Size(400, 50); // Increase width to accommodate quantity label
                billpanel.BorderStyle = BorderStyle.FixedSingle;
                billpanel.Margin = new Padding(10);
                billpanel.BackColor = Color.White;

                Label billname = new Label();
                billname.Text = itemName;
                billname.Location = new Point(3, 10);
                billname.AutoSize = true;
                billname.Font = new Font("Arial", 12, FontStyle.Bold);

                Label billprice = new Label();
                billprice.Text = itemPrice;
                billprice.Location = new Point(130, 10);
                billprice.AutoSize = true;
                billprice.Font = new Font("Arial", 12, FontStyle.Bold);

                Button addqnty = new Button()
                {
                    Text = "+",
                    Size = new Size(30, 20),
                    Location = new Point(190, 10)
                };

                Button subqnty = new Button()
                {
                    Text = "-",
                    Size = new Size(30, 20),
                    Location = new Point(250, 10)
                };

                addqnty.Click += (s, ev) => BtnAdd_Click(s, ev, billqnty);
                subqnty.Click += (s, ev) => BtnSubtract_Click(s, ev, billqnty);

                billqnty = new Label();
                billqnty.Text = buttonClickCount[panel].ToString();
                billqnty.Location = new Point(230, 10);
                billqnty.AutoSize = true;
                billqnty.Font = new Font("Arial", 12, FontStyle.Bold);

                billpanel.Controls.Add(billname);
                billpanel.Controls.Add(billprice);
                billpanel.Controls.Add(billqnty);
                billpanel.Controls.Add(addqnty);
                billpanel.Controls.Add(subqnty);
                Controls.Add(btnFinalizeOrder);

                flowLayoutPanel2.Controls.Add(billpanel);
            };

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(priceLabel);

            return panel;
        }
        Button btnFinalizeOrder = new Button
        {
            Text = "Finalize Order",
            Size = new Size(600, 30),
            Location = new Point(10, 10) // Adjust the location as needed
        };
       

        private void BtnAdd_Click(object sender, EventArgs e, Label quantityLabel)
        {
            quantity++;
            UpdateQuantityTextBox(quantityLabel);
        }

        private void BtnSubtract_Click(object sender, EventArgs e, Label quantityLabel)
        {
            if (quantity > 0)
            {
                quantity--;
                UpdateQuantityTextBox(quantityLabel);
            }
        }

        private void UpdateQuantityTextBox(Label quantityLabel)
        {
            quantityLabel.Text = quantity.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnFinalizeOrder_Click(object sender, EventArgs e)
        {
            SaveOrderToExcel();
            MessageBox.Show("Order has been saved successfully!");
        }

        private void SaveOrderToExcel()
        {
            using (var package = new ExcelPackage(new FileInfo(ExcelPath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                int startRow = worksheet.Dimension?.Rows ?? 1;

                foreach (var orderedItem in orderedItems)
                {
                    worksheet.Cells[worksheet.Dimension.Rows , 2].Value = orderedItem.ItemName;
                    worksheet.Cells[worksheet.Dimension.Rows , 3].Value = orderedItem.ItemPrice;
                    worksheet.Cells[worksheet.Dimension.Rows , 4].Value = orderedItem.Quantity;
                    startRow++;
                }

                package.Save();
            }
        }

        private class OrderedItem
        {
            public string ItemName { get; }
            public string ItemPrice { get; }
            public int Quantity { get; }

            public OrderedItem(string itemName, string itemPrice, int quantity)
            {
                ItemName = itemName;
                ItemPrice = itemPrice;
                Quantity = quantity;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveOrderToExcel();
            MessageBox.Show("Order has been saved successfully!");

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}