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
    public partial class trailerUp : Form
    {
        public trailerUp()
        {
            InitializeComponent();
        }

        private void axWMPUp_Enter(object sender, EventArgs e)
        {
            axWMPUp.URL = "D:\\ExampleVid\\Trailer\\Up Trailer.mp4";
        }
    }
}
