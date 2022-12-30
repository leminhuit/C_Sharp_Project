using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holiday2020.SelfStudyAndTest
{
    public partial class Another_One : Form
    {
        public Another_One()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelMediaSubMenu.Visible = false;
            PListSideMenu.Visible = false;
            ToolsSideMenu.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;
            if (PListSideMenu.Visible == true)
                PListSideMenu.Visible = false;
            if (ToolsSideMenu.Visible == true)
                ToolsSideMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #region Media Side Menu
        private void MediaButton_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //...
            // My Code
            //...
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //...
            // My Code
            //...
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //...
            // My Code
            //...
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //...
            // My Code
            //...
            hideSubMenu();
        }
#endregion

        #region Playlist Management
        private void PListManagement_Click(object sender, EventArgs e)
        {
            showSubMenu(PListSideMenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //...
            // My Code
            //...
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //...
            // My Code
            //...
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //...
            // My Code
            //...
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //...
            // My Code
            //...
            hideSubMenu();
        }
#endregion

        #region Equalizer
        private void EqualizerButton_Click(object sender, EventArgs e)
        {
            //...
            // My Code
            //...
            hideSubMenu();
        }
#endregion

        #region Tools Side Menu
        private void ToolsButton_Click(object sender, EventArgs e)
        {
            showSubMenu(ToolsSideMenu);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //...
            // My Code
            //...
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //...
            // My Code
            //...
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //...
            // My Code
            //...
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //...
            // My Code
            //...
            hideSubMenu();
        }
#endregion

        #region Help
        private void HelpButton_Click(object sender, EventArgs e)
        {
            //...
            // My Code
            //...
            hideSubMenu();
        }
        #endregion

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
