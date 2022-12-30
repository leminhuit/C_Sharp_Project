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
    public partial class trailerPachinko : Form
    {
        public trailerPachinko()
        {
            InitializeComponent();
        }

        private void axPachinko_Enter(object sender, EventArgs e)
        {
            axPachinko.URL = "D:\\ExampleVid\\Trailer\\PachinkoTrailer.mp4";
        }
    }
}
