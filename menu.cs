using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bislerium_cafe
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
               Widget frmDashboard = new Widget()
                {
                    Dock = DockStyle.None,
                    TopLevel = false,
                    TopMost = false,
                    
                    
                };

                
                

                
                this.flowLayoutPanel1.Controls.Add(frmDashboard);

                
                frmDashboard.Show();
            }


        }
    }
}
