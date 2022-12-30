using System;
using System.Windows.Forms;

namespace MainMovieHub.MovieTrailer
{
    public partial class trailerASilentVoice : Form
    {
        public trailerASilentVoice()
        {
            InitializeComponent();
        }

        private void axASV_Enter(object sender, EventArgs e)
        {
            axASV.URL = "D:\\ExampleVid\\Trailer\\ASilentVoiceTrailer.mp4";
        }
    }
}
