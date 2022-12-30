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
    public partial class Up : Form
    {
        DataTable dt = new DataTable();
        public Up()
        {
            InitializeComponent();
            dt.Columns.Add("SoNguoiXem", typeof(int));
            dt.Columns.Add("SoNguoiThich", typeof(int));
            dt.Columns.Add("DanhGiaSao", typeof(int));

            dt.Rows.Add(678, 670, 4);
        }

        private void HideAllStars()
        {
            pBoxStarUp1.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarUp2.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarUp3.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarUp4.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarUp5.BackgroundImage = Properties.Resources.star_empty_1;
        }

        private void pBoxStarUp1_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarUp1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarUp2_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarUp1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarUp2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarUp3_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarUp1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarUp2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarUp3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarUp4_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarUp1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarUp2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarUp3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarUp4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarUp5_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarUp1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarUp2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarUp3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarUp4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarUp5.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void PlayButtonUp_Click(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt.Rows[0]["SoNguoiXem"]);
            seen++;
            labelUpSeen.Text = seen.ToString();
            dt.Rows[0]["SoNguoiXem"] = seen;

            MovieTrailer.trailerUp tlrup = new MovieTrailer.trailerUp();
            tlrup.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int fav = Convert.ToInt32(dt.Rows[0]["SoNguoiThich"]);
            fav++;
            labelUpFav.Text = fav.ToString();
            dt.Rows[0]["SoNguoiThich"] = fav;
        }

        private void Up_Load(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt.Rows[0]["SoNguoiXem"]);
            int fav = Convert.ToInt32(dt.Rows[0]["SoNguoiThich"]);
            labelUpFav.Text = fav.ToString();
            labelUpSeen.Text = seen.ToString();
        }
    }
}
