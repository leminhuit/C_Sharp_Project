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
    public partial class trailerRushHour2 : Form
    {
        public trailerRushHour2()
        {
            InitializeComponent();
        }

        private void axWMPRH2_Enter(object sender, EventArgs e)
        {
            axWMPRH2.URL = "D:\\ExampleVid\\Trailer\\Rush Hour Trailer.mp4";
        }
    }
}
