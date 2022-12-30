using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMovieHub
{
    public partial class Hub : Form
    {
        public Hub()
        {
            InitializeComponent();
        }

        private void HideAllPanel()
        {
            panelPhimBo.Visible = false;
            panelPhimHoatHinh.Visible = false;
            panelPhimChieuRap.Visible = false;
        }

        private void labelPhimHoatHinh_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            panelPhimHoatHinh.Visible = true;
            panelPhimHoatHinh.Dock = DockStyle.Fill;
        }

        private void labelMovieHub_Click(object sender, EventArgs e)
        {
            HideAllPanel();
        }

        private void labelPhimBo_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            panelPhimBo.Visible = true;
            panelPhimBo.Dock = DockStyle.Fill;
        }

        private void labelPhimChieuRap_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            panelPhimChieuRap.Visible = true;
            panelPhimChieuRap.Dock = DockStyle.Fill;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            // Chuyen thong tin nhap thanh lowercase
            string FindFilm = "";
            FindFilm = SearchTextbox.Text.ToLower();

            if (FindFilm.Contains("rush") || FindFilm.Contains("hour 2") || 
                FindFilm.Contains("rush hour 2") || FindFilm.Contains("rush hour"))
            {
                MovieInfo.RushHour2 rh2 = new MovieInfo.RushHour2();
                rh2.Show();
            }
            else if (FindFilm.Contains("kungfu panda 2") || FindFilm.Contains("kungfu") || 
                FindFilm.Contains("panda") || FindFilm.Contains("panda 2") ||
                FindFilm.Contains("kungfu panda"))
            {
                MovieInfo.KungfuPanda2 kp2 = new MovieInfo.KungfuPanda2();
                kp2.Show();
            }
            else if (FindFilm.Contains("how to train your dragon 2") || FindFilm.Contains("how to train") ||
                FindFilm.Contains("dragon 2") || FindFilm.Contains("train your dragon"))
            {
                MovieInfo.H2TYD2 howto = new MovieInfo.H2TYD2();
                howto.Show();
            }
            else if (FindFilm.Contains("pachinko") || FindFilm.Contains("pachi") || FindFilm.Contains("chinko"))
            {
                MovieInfo.Pachinko pck = new MovieInfo.Pachinko();
                pck.Show();
            }
            else if (FindFilm.Contains("up"))
            {
                MovieInfo.Up up = new MovieInfo.Up();
                up.Show();
            }
            else if (FindFilm.Contains("doberman") || FindFilm.Contains("công tố viên") || FindFilm.Contains("quân sự"))
            {
                MovieInfo.CTVDober ctv = new MovieInfo.CTVDober();
                ctv.Show();
            }
            else if (FindFilm.Contains("tuxedo") || FindFilm.Contains("the tuxedo"))
            {
                MovieInfo.TheTuxedo letuxedo = new MovieInfo.TheTuxedo();
                letuxedo.Show();
            }
            else if (FindFilm.Contains("dáng hình") || FindFilm.Contains("âm thanh") || 
                FindFilm.Contains("dáng hình âm thanh") || FindFilm.Contains("a silent voice") ||
                FindFilm.Contains("silent voice"))
            {
                MovieInfo.ASilentVoice asv = new MovieInfo.ASilentVoice();
                asv.Show();
            }
            else if (FindFilm.Contains("5cm") || FindFilm.Contains("cm/s") || FindFilm.Contains("cms"))
            {
                MovieInfo._5cms film5cm = new MovieInfo._5cms();
                film5cm.Show();
            }
            else if (FindFilm.Contains("spiderman") || FindFilm.Contains("no way home") || 
                FindFilm.Contains("spider man") || FindFilm.Contains("spiderman no way home"))
            {
                MovieInfo.SpidermanNWH nwh = new MovieInfo.SpidermanNWH();
                nwh.Show();
            }
            else if (FindFilm.Contains("hotel") || FindFilm.Contains("hotel transylvania") || 
                FindFilm.Contains("transylvania 4"))
            {
                MovieInfo.HotelT4 ht4 = new MovieInfo.HotelT4();
                ht4.Show();
            }
            else if (FindFilm.Contains("cruella"))
            {
                MovieInfo.Cruella crue = new MovieInfo.Cruella();
                crue.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Sorry, there's no film with that name. Try again");
            }
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            SearchTextbox.ForeColor = Color.Black;
        }

        private void pBoxSpiderMan_Click(object sender, EventArgs e)
        {
            MovieInfo.SpidermanNWH spooder = new MovieInfo.SpidermanNWH();
            spooder.Show();
        }

        private void pBoxHotelTransylvania_Click(object sender, EventArgs e)
        {
            MovieInfo.HotelT4 ht4 = new MovieInfo.HotelT4();
            ht4.Show();
        }

        private void pBoxCruella_Click(object sender, EventArgs e)
        {
            MovieInfo.Cruella crue = new MovieInfo.Cruella();
            crue.Show();
        }

        private void pBoxUpRec_Click(object sender, EventArgs e)
        {
            MovieInfo.Up up = new MovieInfo.Up();
            up.Show();
        }

        private void pBoxASilentVoice_Click(object sender, EventArgs e)
        {
            MovieInfo.ASilentVoice asv = new MovieInfo.ASilentVoice();
            asv.Show();
        }

        private void pBox5cms_Click(object sender, EventArgs e)
        {
            MovieInfo._5cms cms = new MovieInfo._5cms();
            cms.Show();
        }

        private void pBoxPachinko_Click(object sender, EventArgs e)
        {
            MovieInfo.Pachinko pck = new MovieInfo.Pachinko();
            pck.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MovieInfo.CTVDober ctv = new MovieInfo.CTVDober();
            ctv.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MovieInfo.TheTuxedo tux = new MovieInfo.TheTuxedo();
            tux.Show();
        }

        private void pBoxMovieOne_Click(object sender, EventArgs e)
        {
            MovieInfo.RushHour2 rh = new MovieInfo.RushHour2();
            rh.Show();
        }

        private void pBoxMovie2_Click(object sender, EventArgs e)
        {
            MovieInfo.KungfuPanda2 kfp = new MovieInfo.KungfuPanda2();
            kfp.Show();
        }

        private void pBoxMovie3_Click(object sender, EventArgs e)
        {
            MovieInfo.H2TYD2 traindrag = new MovieInfo.H2TYD2();
            traindrag.Show();
        }

        private void pBoxMovie4_Click(object sender, EventArgs e)
        {
            MovieInfo.Up up = new MovieInfo.Up();
            up.Show();
        }
    }
}
