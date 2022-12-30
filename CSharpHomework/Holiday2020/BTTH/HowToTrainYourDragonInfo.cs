using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holiday2020.BTTH
{
    public partial class HowToTrainYourDragonInfo : Form
    {
        public HowToTrainYourDragonInfo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BTTH.HowToTrainYourDragonTrailer trailer = new HowToTrainYourDragonTrailer();
            trailer.Show();
        }

        private void PlayButton_MouseHover(object sender, EventArgs e)
        {
            PlayButton.BackColor = Color.Yellow;
        }

        private void PlayButton_MouseLeave(object sender, EventArgs e)
        {
            PlayButton.BackColor = Color.Black;
        }

        private void StarPBox1_Click(object sender, EventArgs e)
        {
            StarPBox1.BackgroundImage = Properties.Resources.FilledStar;
        }

        private void StarPBox2_Click(object sender, EventArgs e)
        {
            StarPBox1.BackgroundImage = Properties.Resources.FilledStar;
            StarPBox2.BackgroundImage = Properties.Resources.FilledStar;
        }
    }
}
