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
    public partial class ASilentVoice : Form
    {
        DataTable dtASV = new DataTable();
        
        public ASilentVoice()
        {
            InitializeComponent();
            dtASV.Columns.Add("SoNguoiXem", typeof(int));
            dtASV.Columns.Add("SoNguoiThich", typeof(int));
            dtASV.Columns.Add("DanhGiaSao", typeof(int));

            dtASV.Rows.Add(126, 120, 4);
        }

        private void HideAllStars()
        {
            pBoxStarASV1.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarASV2.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarASV3.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarASV4.BackgroundImage = Properties.Resources.star_empty_1;
            pBoxStarASV5.BackgroundImage = Properties.Resources.star_empty_1;
        }

        private void pBoxStarASV1_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarASV1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarASV2_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarASV1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarASV2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarASV3_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarASV1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarASV2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarASV3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarASV4_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarASV1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarASV2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarASV3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarASV4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void pBoxStarASV5_Click(object sender, EventArgs e)
        {
            HideAllStars();
            pBoxStarASV1.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarASV2.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarASV3.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarASV4.BackgroundImage = Properties.Resources.christmas_star_png_33907;
            pBoxStarASV5.BackgroundImage = Properties.Resources.christmas_star_png_33907;
        }

        private void labelPhimASVoice_Click(object sender, EventArgs e)
        {

        }

        private void labelNoiDungASV1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void labelASVSeen_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int fav = Convert.ToInt32(dtASV.Rows[0]["SoNguoiThich"]);
            fav++;
            labelASVFav.Text = fav.ToString();
            dtASV.Rows[0]["SoNguoiThich"] = fav;
        }

        private void labelASVFav_Click(object sender, EventArgs e)
        {

        }

        private void pBoxDangHinhAmThanh_Click(object sender, EventArgs e)
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

        private void PlayButtonASV_Click(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dtASV.Rows[0]["SoNguoiXem"]);
            seen++;
            labelASVSeen.Text = seen.ToString();
            dtASV.Rows[0]["SoNguoiXem"] = seen;

            MovieTrailer.trailerASilentVoice tlrasv = new MovieTrailer.trailerASilentVoice();
            tlrasv.Show();
        }

        private void ASilentVoice_Load(object sender, EventArgs e)
        {
            int seen = Convert.ToInt32(dtASV.Rows[0]["SoNguoiXem"]);
            labelASVSeen.Text = seen.ToString();
            int fav = Convert.ToInt32(dtASV.Rows[0]["SoNguoiThich"]);
            labelASVFav.Text = fav.ToString();
        }
    }
}
