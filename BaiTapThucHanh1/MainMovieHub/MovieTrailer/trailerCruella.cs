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
    public partial class trailerCruella : Form
    {
        public trailerCruella()
        {
            InitializeComponent();
        }

        private void axCruella_Enter(object sender, EventArgs e)
        {
            axCruella.URL = "D:\\ExampleVid\\Trailer\\CruellaTrailer.mp4";
        }
    }
}
