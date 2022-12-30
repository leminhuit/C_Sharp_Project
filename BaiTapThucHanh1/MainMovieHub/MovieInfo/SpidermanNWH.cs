using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMovieHub.MovieInfo
{
    public partial class SpidermanNWH : Form
    {
        DataTable dt = new DataTable();
        public SpidermanNWH()
        {
            InitializeComponent();
            dt.Columns.Add("SoNguoiXem", typeof(int));
            dt.Columns.Add("SoNguoiThich", typeof(int));
            dt.Columns.Add("DanhGiaSao", typeof(int));

            dt.Rows.Add(586, 540, 4);
        }

        private void HideAllStars()
        {
            pBoxStarSpooder1.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarSpooder2.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarSpooder3.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarSpooder4.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarSpooder5.BackgroundImage = Properties.Resources.star_empty_1;
        }

        private void pBoxStarSpooder1_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarSpooder1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarSpooder2_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarSpooder1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarSpooder2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarSpooder3_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarSpooder1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarSpooder2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarSpooder3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarSpooder4_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarSpooder1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarSpooder2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarSpooder3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarSpooder4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarSpooder5_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarSpooder1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarSpooder2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarSpooder3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarSpooder4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarSpooder5.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void PlayButtonSpooder_Click(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt.Rows[0]["SoNguoiXem"]);
            seen++;
            labelSpooderSeen.Text = seen.ToString();
            dt.Rows[0]["SoNguoiXem"] = seen;

            MovieTrailer.trailerSpidermanNWH tlrspooder = new MovieTrailer.trailerSpidermanNWH();
            tlrspooder.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int fav = Convert.ToInt32(dt.Rows[0]["SoNguoiThich"]);
            fav++;
            labelSpooderFav.Text = fav.ToString();
            dt.Rows[0]["SoNguoiThich"] = fav;
        }

        private void SpidermanNWH_Load(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt.Rows[0]["SoNguoiXem"]);
            int fav = Convert.ToInt32(dt.Rows[0]["SoNguoiThich"]);
            labelSpooderFav.Text = fav.ToString();
            labelSpooderSeen.Text = seen.ToString();
        }
    }
}
