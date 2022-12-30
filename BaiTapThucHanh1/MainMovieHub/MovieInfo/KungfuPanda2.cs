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
    public partial class KungfuPanda2 : Form
    {
        DataTable dt = new DataTable();
        public KungfuPanda2()
        {
            InitializeComponent();
            dt.Columns.Add("SoNguoiXem", typeof(int));
            dt.Columns.Add("SoNguoiThich", typeof(int));
            dt.Columns.Add("DanhGiaSao", typeof(int));

            dt.Rows.Add(478, 452, 4);
        }

        private void HideAllStars()
        {
            pBoxStarKFP1.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarKFP2.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarKFP3.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarKFP4.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarKFP5.BackgroundImage = Properties.Resources.star_empty_1;
        }

        private void pBoxStarKFP1_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarKFP1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarKFP2_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarKFP1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarKFP2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarKFP3_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarKFP1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarKFP2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarKFP3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarKFP4_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarKFP1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarKFP2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarKFP3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarKFP4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarKFP5_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarKFP1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarKFP2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarKFP3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarKFP4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarKFP5.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void PlayButtonKFP_Click(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt.Rows[0]["SoNguoiXem"]);
            seen++;
            labelKFPSeen.Text = seen.ToString();
            dt.Rows[0]["SoNguoiXem"] = seen;

            MovieTrailer.trailerKungfuPanda2 tlrkfp2 = new MovieTrailer.trailerKungfuPanda2();
            tlrkfp2.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int fav = Convert.ToInt32(dt.Rows[0]["SoNguoiThich"]);
            fav++;
            labelKFPFav.Text = fav.ToString();
            dt.Rows[0]["SoNguoiThich"] = fav;
        }

        private void KungfuPanda2_Load(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt.Rows[0]["SoNguoiXem"]);
            int fav = Convert.ToInt32(dt.Rows[0]["SoNguoiThich"]);
            labelKFPFav.Text = fav.ToString();
            labelKFPSeen.Text = seen.ToString();
        }
    }
}
