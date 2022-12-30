using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holiday2020.Buoi11
{
    public partial class Exam : Form
    {
        public Exam()
        {
            InitializeComponent();
            Load += new EventHandler(Exam_Load);
        }

        public void hidePanels()
        {
            panelImport.Visible = false;
            panelTest.Visible = false;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            hidePanels();
            panelImport.Visible = true;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            hidePanels();
            panelTest.Visible = true;
        }

        private void Exam_Load(object sender, EventArgs e)
        {
            hidePanels();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
