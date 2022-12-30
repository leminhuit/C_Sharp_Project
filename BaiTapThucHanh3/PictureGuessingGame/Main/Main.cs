using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Main
{
    public partial class Main : Form
    {
        public string MainUser;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        public SoundPlayer player = new SoundPlayer();
        public Main(string Username)
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);
            MainUser = Username;

            cn = new SqlConnection(dbcon.myConnection());
        }

        // Fields
        private int borderSize = 2;

        // Function

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Form Events
        private void btnAnimal_Click(object sender, EventArgs e)
        {
            AnimalQuizzes animal = new AnimalQuizzes(MainUser);
            openChildForm(animal);
        }

        private void btnFruit_Click(object sender, EventArgs e)
        {
            FruitQuizzes fruit = new FruitQuizzes(MainUser);
            openChildForm(fruit);
        }

        private void btnSport_Click(object sender, EventArgs e)
        {
            SportQuizzes sport = new SportQuizzes(MainUser);
            openChildForm(sport);
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            VehicleQuizzes vehicle = new VehicleQuizzes(MainUser);
            openChildForm(vehicle);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Home home = new Home(MainUser);
            openChildForm(home);
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\bgmmusic.wav";
            player.Play();
        }

        private void picBoxHome_Click(object sender, EventArgs e)
        {
            Home home = new Home(MainUser);
            openChildForm(home);
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            HighScore score = new HighScore();
            openChildForm(score);
        }

        private void picBoxMusicPlay_Click(object sender, EventArgs e)
        {
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\bgmmusic.wav";
            player.PlayLooping();

            picBoxMusicPlay.Visible = false;
            picBoxMusicMute.Visible = true;
        }

        private void picBoxMusicMute_Click(object sender, EventArgs e)
        {
            player.Stop();

            picBoxMusicPlay.Visible = true;
            picBoxMusicMute.Visible = false;
        }
    }
}
