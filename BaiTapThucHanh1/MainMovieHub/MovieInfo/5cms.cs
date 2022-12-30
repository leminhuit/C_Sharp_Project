using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMovieHub.MovieInfo
{
    public partial class _5cms : Form
    {
        DataTable dt5cms = new DataTable();
        public _5cms()
        {
            InitializeComponent();
            dt5cms.Columns.Add("SoNguoiXem", typeof(int));
            dt5cms.Columns.Add("SoNguoiThich", typeof(int));
            dt5cms.Columns.Add("DanhGiaSao", typeof(int));

            dt5cms.Rows.Add(152, 138, 5);
        }

        private void HideAllStars()
        {
            pBoxStar5cm1.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStar5cm2.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStar5cm3.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStar5cm4.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStar5cm5.BackgroundImage = Properties.Resources.star_empty_1;
        }

        private void pBoxStar5cm1_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStar5cm1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStar5cm2_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStar5cm1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStar5cm2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStar5cm3_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStar5cm1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStar5cm2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStar5cm3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStar5cm4_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStar5cm1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStar5cm2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStar5cm3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStar5cm4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStar5cm5_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStar5cm1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStar5cm2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStar5cm3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStar5cm4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStar5cm5.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt5cms.Rows[0]["SoNguoiXem"]);
            seen++;
            label5cmSeen.Text = seen.ToString();
            dt5cms.Rows[0]["SoNguoiXem"] = seen;

            // Play the trailer
            MovieTrailer.trailer5cms tlr5cm = new MovieTrailer.trailer5cms();
            tlr5cm.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int fav = Convert.ToInt32(dt5cms.Rows[0]["SoNguoiThich"]);
            fav++;
            label5cmFav.Text = fav.ToString();
            dt5cms.Rows[0]["SoNguoiThich"] = fav;
        }

        private void _5cms_Load(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt5cms.Rows[0]["SoNguoiXem"]);
            label5cmSeen.Text = seen.ToString();
            int fav = Convert.ToInt32(dt5cms.Rows[0]["SoNguoiThich"]);
            label5cmFav.Text = fav.ToString();
        }
    }
}
