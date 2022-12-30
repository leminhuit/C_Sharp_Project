using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holiday2020.BTTH
{
    public partial class HowToTrainYourDragonTrailer : Form
    {
        public HowToTrainYourDragonTrailer()
        {
            InitializeComponent();
        }

        private void WMP_H2TYD_Enter(object sender, EventArgs e)
        {
            WMP_H2TYD.URL = "D:\\ExampleVid\\H2TYD Trailer.mp4";
        }
    }
}
