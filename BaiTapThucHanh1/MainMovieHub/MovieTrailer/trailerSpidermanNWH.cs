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
    public partial class trailerSpidermanNWH : Form
    {
        public trailerSpidermanNWH()
        {
            InitializeComponent();
        }

        private void axSpooder_Enter(object sender, EventArgs e)
        {
            axSpooder.URL = "D:\\ExampleVid\\Trailer\\SpidermanNWHTrailer.mp4";
        }
    }
}
