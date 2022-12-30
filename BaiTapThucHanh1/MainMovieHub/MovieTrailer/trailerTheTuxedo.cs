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
    public partial class trailerTheTuxedo : Form
    {
        public trailerTheTuxedo()
        {
            InitializeComponent();
        }

        private void axTux_Enter(object sender, EventArgs e)
        {
            axTux.URL = "D:\\ExampleVid\\Trailer\\TheTuxedoTrailer.mp4";
        }
    }
}
