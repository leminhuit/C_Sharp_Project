using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMovieHub.MovieTrailer
{
    public partial class trailerH2TYD2 : Form
    {
        public trailerH2TYD2()
        {
            InitializeComponent();
        }

        private void axWMPTrainDrag2_Enter(object sender, EventArgs e)
        {
            axWMPTrainDrag2.URL = "D:\\ExampleVid\\Trailer\\H2TYD Trailer.mp4";
        }
    }
}
