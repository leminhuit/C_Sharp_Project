using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holiday2020.Buoi2
{
    public partial class HouseKeeperForm : Form
    {
        public HouseKeeperForm()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeButton.BackColor = Color.ForestGreen;
            ChoresGroupBox.Visible = true;
            TotalPanel.Visible = false;
            CartButton.BackColor = Color.White;
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            CartButton.BackColor = Color.ForestGreen;
            TotalPanel.Visible = true;
            HomeButton.BackColor = Color.White;
        }
    }
}
