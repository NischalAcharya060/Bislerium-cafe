using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BrewHub
{
    public partial class OrderForm : Form
    {
        // Define your coffee prices and add-in prices
        private Dictionary<string, decimal> coffeePrices = new Dictionary<string, decimal>
        {
            {"Cappuccino", 3.50m},
            {"Espresso", 2.50m},
            {"Latte", 4.00m},
            {"Cold Brew", 3.75m}
        };

        private Dictionary<string, decimal> addInPrices = new Dictionary<string, decimal>
        {
            {"Cinnamon", 0.50m},
            {"Honey", 0.75m},
            {"Coconut Milk", 1.00m},
            {"Cocoa Powder", 0.60m},
            {"Ginger", 0.70m},
            {"Cold Brew Add-In", 0.80m}
        };

        public OrderForm()
        {
            InitializeComponent();
            InitializeUI();
            // TODO: Initialize the UI, set default values, etc.
        }

        private void InitializeUI()
        {
            // Initialize the UI, set default values, etc.
            Cappuccino.Checked = false;
            Espresso.Checked = false;
            Latte.Checked = false;
            Cold_brew.Checked = false;
            Cappuccino_quantity.Text = "0";
            Espresso_quantity.Text = "0";
            Latte_quantity.Text = "0";
            Coldbrew_quantity.Text = "0";
            Cinnamon_ads_ins.Checked = false;
            Honey_ads_ins.Checked = false;
            Coconut_milk_ads_ins.Checked = false;
            Cocoapowder_ads_ins.Checked = false;
            Ginger_ads_ins.Checked = false;
            checkBox10.Checked = false;
            Name_txt_box.Text = "enter your name";
            Address_txt_box.Text = "enter your address";
            Contact_txt_box.Text = "enter your contact";
            total_sum.Text = "$0.00";
        }

        private void total_btn_Click(object sender, EventArgs e)
        {
            // TODO: Implement total_btn_Click logic
            decimal total = CalculateTotal();
            total_sum.Text = total.ToString("C"); 
        }

        private decimal CalculateTotal()
        {
            decimal total = 0;

            // Calculate coffee prices
            total += GetItemTotal(Cappuccino, Cappuccino_quantity.Text, coffeePrices["Cappuccino"]);
            total += GetItemTotal(Espresso, Espresso_quantity.Text, coffeePrices["Espresso"]);
            total += GetItemTotal(Latte, Latte_quantity.Text, coffeePrices["Latte"]);
            total += GetItemTotal(Cold_brew, Coldbrew_quantity.Text, coffeePrices["Cold Brew"]);

            // Calculate add-in prices
            total += GetAddInTotal(Cinnamon_ads_ins, addInPrices["Cinnamon"]);
            total += GetAddInTotal(Honey_ads_ins, addInPrices["Honey"]);
            total += GetAddInTotal(Coconut_milk_ads_ins, addInPrices["Coconut Milk"]);
            total += GetAddInTotal(Cocoapowder_ads_ins, addInPrices["Cocoa Powder"]);
            total += GetAddInTotal(Ginger_ads_ins, addInPrices["Ginger"]);
            total += GetAddInTotal(checkBox10, addInPrices["Cold Brew Add-In"]);

            return total;
        }

        private decimal GetItemTotal(CheckBox itemCheckbox, string quantityText, decimal pricePerItem)
        {
            if (itemCheckbox.Checked && decimal.TryParse(quantityText, out decimal quantity))
            {
                return quantity * pricePerItem;
            }
            return 0;
        }

        private decimal GetAddInTotal(CheckBox addInCheckbox, decimal pricePerAddIn)
        {
            return addInCheckbox.Checked ? pricePerAddIn : 0;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            // TODO: Implement exit_btn_Click logic with confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            // TODO: Implement reset_btn_Click logic
            InitializeUI();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: Show a welcome message or perform actions when the form loads
            MessageBox.Show("Welcome to BrewHub! Please enter your order details.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // TODO: Add validation methods, save order details, and handle edge cases

    }
}
