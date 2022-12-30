using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class HabitForm : Form
    {
        public HabitForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnStartYourDay_Click(object sender, EventArgs e)
        {
            StartYourDay start = new StartYourDay();
            openChildForm(start);
        }

        private void btnSelfCare_Click(object sender, EventArgs e)
        {
            SelfCareForm selfCare = new SelfCareForm();
            openChildForm(selfCare);
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            DailyHealthTracker dht = new DailyHealthTracker();
            openChildForm(dht);
        }
    }
}
