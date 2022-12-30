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
    public partial class RushHour2 : Form
    {
        DataTable dt = new DataTable();
        public RushHour2()
        {
            InitializeComponent();
            dt.Columns.Add("SoNguoiXem", typeof(int));
            dt.Columns.Add("SoNguoiThich", typeof(int));
            dt.Columns.Add("DanhGiaSao", typeof(int));

            dt.Rows.Add(241, 211, 4);
        }

        private void HideAllStars()
        {
            pBoxStarRH1.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarRH2.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarRH3.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarRH4.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarRH5.BackgroundImage = Properties.Resources.star_empty_1;
        }

        private void pBoxStarRH1_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarRH1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarRH2_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarRH1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarRH2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarRH3_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarRH1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarRH2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarRH3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarRH4_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarRH1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarRH2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarRH3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarRH4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarRH5_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarRH1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarRH2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarRH3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarRH4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarRH5.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void PlayButtonRH_Click(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt.Rows[0]["SoNguoiXem"]);
            seen++;
            labelRHSeen.Text = seen.ToString();
            dt.Rows[0]["SoNguoiXem"] = seen;

            MovieTrailer.trailerRushHour2 tlrRH2 = new MovieTrailer.trailerRushHour2();
            tlrRH2.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int fav = Convert.ToInt32(dt.Rows[0]["SoNguoiThich"]);
            fav++;
            labelRHFav.Text = fav.ToString();
            dt.Rows[0]["SoNguoiThich"] = fav;
        }

        private void RushHour2_Load(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt.Rows[0]["SoNguoiXem"]);
            int fav = Convert.ToInt32(dt.Rows[0]["SoNguoiThich"]);
            labelRHFav.Text = fav.ToString();
            labelRHSeen.Text = seen.ToString();
        }
    }
}
