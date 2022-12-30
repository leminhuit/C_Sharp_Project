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
    public partial class trailerKungfuPanda2 : Form
    {
        public trailerKungfuPanda2()
        {
            InitializeComponent();
        }

        private void axWMPKFP2_Enter(object sender, EventArgs e)
        {
            axWMPKFP2.URL = "D:\\ExampleVid\\Trailer\\KFPanda 2 Trailer.mp4";
        }
    }
}
