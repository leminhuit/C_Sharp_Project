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
    public partial class TheTuxedo : Form
    {
        DataTable dt = new DataTable();
        public TheTuxedo()
        {
            InitializeComponent();
            dt.Columns.Add("SoNguoiXem", typeof(int));
            dt.Columns.Add("SoNguoiThich", typeof(int));
            dt.Columns.Add("DanhGiaSao", typeof(int));

            dt.Rows.Add(85, 67, 3);
        }

        private void HideAllStars()
        {
            pBoxStarTux1.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarTux2.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarTux3.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarTux4.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarTux5.BackgroundImage = Properties.Resources.star_empty_1;
        }

        private void pBoxStarTux1_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarTux1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarTux2_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarTux1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTux2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarTux3_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarTux1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTux2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTux3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarTux4_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarTux1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTux2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTux3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTux4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void TheTuxedo_Load(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt.Rows[0]["SoNguoiXem"]);
            int fav = Convert.ToInt32(dt.Rows[0]["SoNguoiThich"]);
            labelTuxFav.Text = fav.ToString();
            labelTuxSeen.Text = seen.ToString();
        }

        private void pBoxStarTux5_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarTux1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTux2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTux3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTux4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTux5.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void PlayButtonTux_Click(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt.Rows[0]["SoNguoiXem"]);
            seen++;
            labelTuxSeen.Text = seen.ToString();
            dt.Rows[0]["SoNguoiXem"] = seen;

            MovieTrailer.trailerTheTuxedo tlrtux = new MovieTrailer.trailerTheTuxedo();
            tlrtux.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int fav = Convert.ToInt32(dt.Rows[0]["SoNguoiThich"]);
            fav++;
            labelTuxFav.Text = fav.ToString();
            dt.Rows[0]["SoNguoiThich"] = fav;
        }
    }
}
