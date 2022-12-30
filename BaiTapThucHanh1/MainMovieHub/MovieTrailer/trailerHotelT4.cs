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
    public partial class trailerHotelT4 : Form
    {
        public trailerHotelT4()
        {
            InitializeComponent();
        }

        private void axHT4_Enter(object sender, EventArgs e)
        {
            axHT4.URL = "D:\\ExampleVid\\Trailer\\HT4Trailer.mp4";
        }
    }
}
