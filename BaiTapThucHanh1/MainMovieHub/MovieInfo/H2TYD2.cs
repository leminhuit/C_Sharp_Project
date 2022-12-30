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
    public partial class H2TYD2 : Form
    {
        DataTable dt = new DataTable();
        public H2TYD2()
        {
            InitializeComponent();
            dt.Columns.Add("SoNguoiXem", typeof(int));
            dt.Columns.Add("SoNguoiThich", typeof(int));
            dt.Columns.Add("DanhGiaSao", typeof(int));

            dt.Rows.Add(251, 240, 4);
        }

        private void HideAllStars()
        {
            pBoxStarTDrag1.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarTDrag2.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarTDrag3.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarTDrag4.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarTDrag5.BackgroundImage = Properties.Resources.star_empty_1;
        }

        private void pBoxStarTDrag1_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarTDrag1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarTDrag2_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarTDrag1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTDrag2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarTDrag3_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarTDrag1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTDrag2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTDrag3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarTDrag4_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarTDrag1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTDrag2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTDrag3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTDrag4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarTDrag5_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarTDrag1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTDrag2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTDrag3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTDrag4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarTDrag5.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void labelPhimTrainDrag_Click(object sender, EventArgs e)
        {

        }

        private void labelNoiDungTrainDrag_Click(object sender, EventArgs e)
        {

        }

        private void pBoxTrainDrag_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void labelTrainDragSeen_Click(object sender, EventArgs e)
        {

        }

        private void labelTrainDragFav_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int fav = Convert.ToInt32(dt.Rows[0]["SoNguoiThich"]);
            fav++;
            labelTrainDragFav.Text = fav.ToString();
            dt.Rows[0]["SoNguoiThich"] = fav;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void PlayButtonTrainDrag_Click(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt.Rows[0]["SoNguoiXem"]);
            seen++;
            labelTrainDragSeen.Text = seen.ToString();
            dt.Rows[0]["SoNguoiXem"] = seen;

            MovieTrailer.trailerH2TYD2 tlrtraindrag = new MovieTrailer.trailerH2TYD2();
            tlrtraindrag.Show();
        }

        private void H2TYD2_Load(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt.Rows[0]["SoNguoiXem"]);
            int fav = Convert.ToInt32(dt.Rows[0]["SoNguoiThich"]);
            labelTrainDragSeen.Text = seen.ToString();
            labelTrainDragFav.Text = fav.ToString();
        }
    }
}
