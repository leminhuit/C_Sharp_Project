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
    public partial class Cruella : Form
    {
        DataTable dtCrue = new DataTable();
        public Cruella()
        {
            InitializeComponent();
            dtCrue.Columns.Add("SoNguoiXem", typeof(int));
            dtCrue.Columns.Add("SoNguoiThich", typeof(int));
            dtCrue.Columns.Add("DanhGiaSao", typeof(int));

            dtCrue.Rows.Add(142, 119, 4);
        }

        private void HideAllStars()
        {
            pBoxStarCruella1.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarCruella2.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarCruella3.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarCruella4.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarCruella5.BackgroundImage = Properties.Resources.star_empty_1;
        }
        private void pBoxStarCruella1_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarCruella1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarCruella2_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarCruella1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarCruella2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarCruella3_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarCruella1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarCruella2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarCruella3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarCruella4_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarCruella1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarCruella2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarCruella3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarCruella4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarCruella5_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarCruella1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarCruella2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarCruella3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarCruella4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarCruella5.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void PlayButtonCruella_Click(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dtCrue.Rows[0]["SoNguoiXem"]);
            seen++;
            labelCruellaSeen.Text = seen.ToString();
            dtCrue.Rows[0]["SoNguoiXem"] = seen;

            MovieTrailer.trailerCruella tlrcrue = new MovieTrailer.trailerCruella();
            tlrcrue.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int fav = Convert.ToInt32(dtCrue.Rows[0]["SoNguoiThich"]);
            fav++;
            labelCruellaFav.Text = fav.ToString();
            dtCrue.Rows[0]["SoNguoiThich"] = fav;
        }

        private void Cruella_Load(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dtCrue.Rows[0]["SoNguoiXem"]);
            labelCruellaSeen.Text = seen.ToString();
            int fav = Convert.ToInt32(dtCrue.Rows[0]["SoNguoiThich"]);
            labelCruellaFav.Text = fav.ToString();
        }
    }
}