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
    public partial class Pachinko : Form
    {
        DataTable dt = new DataTable();
        public Pachinko()
        {
            InitializeComponent();
            dt.Columns.Add("SoNguoiXem", typeof(int));
            dt.Columns.Add("SoNguoiThich", typeof(int));
            dt.Columns.Add("DanhGiaSao", typeof(int));

            dt.Rows.Add(105, 94, 2);
        }

        private void HideAllStars()
        {
            pBoxStarPachi1.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarPachi2.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarPachi3.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarPachi4.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarPachi5.BackgroundImage = Properties.Resources.star_empty_1;
        }

        private void pBoxStarPachi1_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarPachi1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarPachi2_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarPachi1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarPachi2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarPachi3_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarPachi1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarPachi2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarPachi3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarPachi4_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarPachi1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarPachi2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarPachi3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarPachi4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarPachi5_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarPachi1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarPachi2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarPachi3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarPachi4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarPachi5.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void PlayButtonPachi_Click(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt.Rows[0]["SoNguoiXem"]);
            seen++;
            labelPachiSeen.Text = seen.ToString();
            dt.Rows[0]["SoNguoiXem"] = seen;

            MovieTrailer.trailerPachinko tlrpck = new MovieTrailer.trailerPachinko();
            tlrpck.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int fav = Convert.ToInt32(dt.Rows[0]["SoNguoiThich"]);
            fav++;
            labelPachiFav.Text = fav.ToString();
            dt.Rows[0]["SoNguoiThich"] = fav;
        }

        private void Pachinko_Load(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt.Rows[0]["SoNguoiXem"]);
            int fav = Convert.ToInt32(dt.Rows[0]["SoNguoiThich"]);
            labelPachiSeen.Text = seen.ToString();
            labelPachiFav.Text = fav.ToString();
        }
    }
}
