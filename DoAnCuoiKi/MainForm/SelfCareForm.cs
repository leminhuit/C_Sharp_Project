using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class SelfCareForm : Form
    {
        private int counter = 0;
        public SoundPlayer player = new SoundPlayer();
        private int imageNumber = 1;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public SqlDataReader dr2;

        public SelfCareForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            HideAllPanels();
            numericMeditateTime.Visible = false;
            btnStartNMeditate.Visible = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //using (Font myFont = new Font("SimSun-ExtB", 14))
            //{
            //    e.Graphics.DrawString("Hello .NET Guide!", myFont, Brushes.Green, new Point(2, 2));
            //}
        }

        private void HideAllPanels()
        {
            panelDoSthFun.Visible = false;
            panelTakeBreakFromDevice.Visible = false;
            panelMeditate.Visible = false;
            panelLookAtPictures.Visible = false;
            panelMusic.Visible = false;
            panelWriteDownGrateful.Visible = false;

            panelDoSthFun.Dock = DockStyle.None;
            panelTakeBreakFromDevice.Dock = DockStyle.None;
            panelMeditate.Dock = DockStyle.None;
            panelLookAtPictures.Dock = DockStyle.None;
            panelMusic.Dock = DockStyle.None;
            panelWriteDownGrateful.Dock = DockStyle.None;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            ChangingTextBox.Text = "Try these books out :" + Environment.NewLine + "1. To Kill a Mocking Bird, by Harper Lee" + Environment.NewLine + "2. The Lord of the Rings, by J.R.R. Tolkien" + Environment.NewLine + "3. How to Win Friends and Influence People, by Dale Carnegie" + Environment.NewLine + "4. Peak" + Environment.NewLine + "5. Grit" + Environment.NewLine + "6. Ego Is The Enemy";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            HideAllPanels();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ChangingTextBox.Text = "Listen to some relaxing songs :" + Environment.NewLine + "1. Wings of Piano, by V.K" + Environment.NewLine + "2. Altale, by Sakuzyo" + Environment.NewLine + "3. Reflection (Mirror Night)" + Environment.NewLine + "4. Morning Drops" + Environment.NewLine + "5. Finding Home" + Environment.NewLine + "6. Yukibiri";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ChangingTextBox.Text = "Some yoga exercises will give you major benefits and they also don't ask you to exert too much strength. If that's not your cup of tea, try jogging around and enjoy the sceneries. Don't need to break a sweat whenever you work out <3";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            ChangingTextBox.Text = "Science has proved that being lazy is good for you :" + Environment.NewLine + "1. Lazy time encourages diffuse thinking" + Environment.NewLine + "2. Make you less prone to burnout" + Environment.NewLine + "3. Good for your mental health" + Environment.NewLine + "4. Recharge your energy stores" + Environment.NewLine + "5. Manage your own stress";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            ChangingTextBox.Text = "Try party games such as Gartic Phone, Fall Guys, ... " + Environment.NewLine + " Or if you like the all time classic, gather your friends for a DnD match, Monopoly, Battleship or even Werewolves." + Environment.NewLine + "Just remember to have fun and don't stress yourself out too much. The point is to surround yourself with old friends while making new ones.";
        }

        private void btnPressMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go Outside and Spend Some Time for yourself away from the Device. It'll be here when you're Back !!", "Self Care", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void pBoxBacking_Click(object sender, EventArgs e)
        {
            HideAllPanels();
        }

        private void pBoxDoSomethingFun_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelDoSthFun.Visible = true;
            panelDoSthFun.Dock = DockStyle.Fill;
        }

        private void pBoxTakeBreakFromDevices_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelTakeBreakFromDevice.Visible = true;
            panelTakeBreakFromDevice.Dock = DockStyle.Fill;
        }

        private void pBoxBack_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            numericMeditateTime.Visible = false;
            btnStartNMeditate.Visible = false;
        }

        private void pBoxProcastination_Click(object sender, EventArgs e)
        {
            player.Stop();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Sounds\\StopProcrastinate.wav";
            player.Play();
        }

        private void pBoxNormalMeditate_Click(object sender, EventArgs e)
        {
            numericMeditateTime.Visible = true;
            btnStartNMeditate.Visible = true;
        }

        private void pBoxSleepBetter_Click(object sender, EventArgs e)
        {
            player.Stop();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Sounds\\SleepBetter.wav";
            player.Play();
        }

        private void pBoxPeacefulNight_Click(object sender, EventArgs e)
        {
            player.Stop();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Sounds\\PeacefulEvening.wav";
            player.Play();
        }

        private void pBoxReduceStress_Click(object sender, EventArgs e)
        {
            player.Stop();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Sounds\\ReduceStress.wav";
            player.Play();
        }

        private void pBoxMeditate_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelMeditate.Visible = true;
            panelMeditate.Dock = DockStyle.Fill;
        }

        private void btnStartNMeditate_Click(object sender, EventArgs e)
        {
            counter = Convert.ToInt32(numericMeditateTime.Value) * 60;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // 1 second
            timer1.Start();
            labelCountdown.Text = counter.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Sounds\\FinishedMeditate.wav";
                player.Play();
            }
            labelCountdown.Text = counter.ToString();
        }

        private void LoadNextImage()
        {
            if (imageNumber == 10)
                imageNumber = 1;
            pBoxSlider.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void pBoxReturn_Click(object sender, EventArgs e)
        {
            HideAllPanels();
        }

        private void pBoxSpendTimeLookingAtPhotos_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelLookAtPictures.Visible = true;
            panelLookAtPictures.Dock = DockStyle.Fill;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=5mFTXbZzOAE");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=UtF6Jej8yb4");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=62d2QvWAVt4");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=pPH2zrX4-iQ");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel5.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=EyFJKKLUudc");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel6.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=HQnC1UHBvWA");
        }

        private void label12_Click(object sender, EventArgs e)
        {
            YourMusic music = new YourMusic();
            music.Show();
        }

        private void pBoxMusic_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelMusic.Visible = true;
            panelMusic.Dock = DockStyle.Fill;
        }

        private void btnSaveDescription_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO tbDiary(DiaryTime, DiaryDescription)VALUES(@DiaryTime, @DiaryDescription)", cn);
            cm.Parameters.AddWithValue("@DiaryTime", datetimeWriteDown.Value.ToShortDateString());
            cm.Parameters.AddWithValue("@DiaryDescription", writeDown.Text);
            cm.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Diary Details Saved", "Write Down Your Feelings");
            writeDown.Clear();
        }

        private void pBoxBGMMute_Click(object sender, EventArgs e)
        {
            player.Stop();

            pBoxBGMPlay.Visible = true;
            pBoxBGMMute.Visible = false;
        }

        private void pBoxBGMPlay_Click(object sender, EventArgs e)
        {
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Sounds\\bgmmusic.wav";
            player.PlayLooping();

            pBoxBGMPlay.Visible = false;
            pBoxBGMMute.Visible = true;
        }

        private void pBoxWriteDownWhatYouGrateful_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelWriteDownGrateful.Visible = true;
            panelWriteDownGrateful.Dock = DockStyle.Fill;
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Sounds\\bgmmusic.wav";
            player.PlayLooping();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            player.Stop();
            writeDown.Clear();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            HideAllPanels();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("SELECT DiaryDescription FROM tbDiary WHERE DiaryTime = @TIME", cn);
            cm.Parameters.AddWithValue("@TIME", datetimeWriteDown.Value.ToShortDateString());
            dr2 = cm.ExecuteReader();
            while (dr2.Read())
            {
                writeDown.Text = dr2["DiaryDescription"].ToString();
            }
            dr2.Close();
            cn.Close();
        }
    }
}
