using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bislerium_cafe
{
    public partial class Staffnav : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
   (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse

    );
        public Staffnav()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            pnlNavIndicator.Height = btnDashboard.Height;
            pnlNavIndicator.Top = btnDashboard.Top;
            pnlNavIndicator.Left = btnDashboard.Left;
            ButtonColorReset(btnDashboard);

            lblTabTitle.Text = "Dashboard";
            this.StaffpnlContent.Controls.Clear();
            StaffDashboard FrmDashboard_Vrb = new StaffDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.StaffpnlContent.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();

            this.ControlBox = true;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            pnlNavIndicator.Height = btnDashboard.Height;
            pnlNavIndicator.Top = btnDashboard.Top;
            pnlNavIndicator.Left = btnDashboard.Left;
            ButtonColorReset(btnDashboard);

            lblTabTitle.Text = "Dashboard";
            this.StaffpnlContent.Controls.Clear();
            StaffDashboard FrmDashboard_Vrb = new StaffDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.StaffpnlContent.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }
        private void ButtonColorReset(Button button)
        {
            Color activeColor = Color.FromArgb(31, 27, 48);
            Color btnColor = Color.FromArgb(26, 23, 40);
            btnDashboard.BackColor = btnColor;

            btnOrder.BackColor = btnColor;

            //btnReprts.BackColor = btnColor;
            btnCoffee.BackColor = btnColor;
            btnAddons.BackColor = btnColor;


            btnSettings.BackColor = btnColor;
            button.BackColor = activeColor;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            pnlNavIndicator.Height = btnOrder.Height;
            pnlNavIndicator.Top = btnOrder.Top;
            pnlNavIndicator.Left = btnOrder.Left;
            ButtonColorReset(btnOrder);

            lblTabTitle.Text = "Order";
            this.StaffpnlContent.Controls.Clear();
            order FrmDashboard_Vrb = new order() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.StaffpnlContent.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void StaffpnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
