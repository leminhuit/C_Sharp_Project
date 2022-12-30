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
    public partial class CTVDober : Form
    {
        DataTable dtCTV = new DataTable();
        public CTVDober()
        {
            InitializeComponent();
            dtCTV.Columns.Add("SoNguoiXem", typeof(int));
            dtCTV.Columns.Add("SoNguoiThich", typeof(int));
            dtCTV.Columns.Add("DanhGiaSao", typeof(int));

            dtCTV.Rows.Add(149, 109, 3);
        }

        private void HideAllStars()
        {
            pBoxStarDober1.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarDober2.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarDober3.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarDober4.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarDober5.BackgroundImage = Properties.Resources.star_empty_1;
        }

        private void pBoxStarDober1_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarDober1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarDober2_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarDober1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarDober2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarDober3_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarDober1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarDober2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarDober3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarDober4_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarDober1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarDober2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarDober3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarDober4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarDober5_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarDober1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarDober2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarDober3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarDober4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarDober5.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void PlayButtonDoberman_Click(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dtCTV.Rows[0]["SoNguoiXem"]);
            seen++;
            labelDobermanSeen.Text = seen.ToString();
            dtCTV.Rows[0]["SoNguoiXem"] = seen;

            MovieTrailer.trailerCTVQS tlrdober = new MovieTrailer.trailerCTVQS();
            tlrdober.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int fav = Convert.ToInt32(dtCTV.Rows[0]["SoNguoiThich"]);
            fav++;
            labelCTVDoberFav.Text = fav.ToString();
            dtCTV.Rows[0]["SoNguoiThich"] = fav;
        }

        private void CTVDober_Load(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dtCTV.Rows[0]["SoNguoiXem"]);
            int fav = Convert.ToInt32(dtCTV.Rows[0]["SoNguoiThich"]);
            labelDobermanSeen.Text = seen.ToString();
            labelCTVDoberFav.Text = fav.ToString();
        }
    }
}
