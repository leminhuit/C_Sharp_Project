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
    public partial class HotelT4 : Form
    {
        DataTable dt = new DataTable();
        public HotelT4()
        {
            InitializeComponent();
            dt.Columns.Add("SoNguoiXem", typeof(int));
            dt.Columns.Add("SoNguoiThich", typeof(int));
            dt.Columns.Add("DanhGiaSao", typeof(int));

            dt.Rows.Add(190, 185, 4);
        }

        private void HideAllStars()
        {
            pBoxStarHT41.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarHT42.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarHT43.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarHT44.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarHT45.BackgroundImage = Properties.Resources.star_empty_1;
        }

        private void pBoxStarHT41_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarHT41.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarHT42_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarHT41.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarHT42.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarHT43_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarHT41.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarHT42.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarHT43.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarHT44_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarHT41.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarHT42.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarHT43.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarHT44.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarHT45_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarHT41.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarHT42.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarHT43.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarHT44.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarHT45.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void labelPhimHT4_Click(object sender, EventArgs e)
        {

        }

        private void labelNoiDungHT4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void labelHT4Seen_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int fav = Convert.ToInt32(dt.Rows[0]["SoNguoiThich"]);
            fav++;
            labelHT4Seen.Text = fav.ToString();
            dt.Rows[0]["SoNguoiThich"] = fav;
        }

        private void labelHT4Fav_Click(object sender, EventArgs e)
        {

        }

        private void pBoxHT4_Click(object sender, EventArgs e)
        {

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

        private void PlayButtonHT4_Click(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt.Rows[0]["SoNguoiXem"]);
            seen++;
            labelHT4Seen.Text = seen.ToString();
            dt.Rows[0]["SoNguoiXem"] = seen;

            MovieTrailer.trailerHotelT4 tlrht4 = new MovieTrailer.trailerHotelT4();
            tlrht4.Show();
        }

        private void HotelT4_Load(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dt.Rows[0]["SoNguoiXem"]);
            int fav = Convert.ToInt32(dt.Rows[0]["SoNguoiThich"]);
            labelHT4Seen.Text = seen.ToString();
            labelHT4Fav.Text = fav.ToString();
        }
    }
}
