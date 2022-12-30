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
    public partial class trailer5cms : Form
    {
        public trailer5cms()
        {
            InitializeComponent();
        }

        private void ax5cms_Enter(object sender, EventArgs e)
        {
            ax5cms.URL = "D:\\ExampleVid\\Trailer\\5cmsTrailer.mp4";
        }
    }
}
