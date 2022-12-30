using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;



namespace Holiday2020.Buoi5
{
    public partial class FrmWebcam : Form
    {

        public FrmWebcam()
        {
            InitializeComponent();
        }

        private void FrmWebcam_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
