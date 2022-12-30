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
    public partial class trailerCTVQS : Form
    {
        public trailerCTVQS()
        {
            InitializeComponent();
        }

        private void axDober_Enter(object sender, EventArgs e)
        {
            axDober.URL = "D:\\ExampleVid\\Trailer\\DobermanTrailer.mp4";
        }
    }
}
