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
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Main
{
    public partial class SportQuizzes : Form
    {
        public SportQuizzes(string UserName)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            MainUser = UserName;
        }

        // Global variables
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        public SoundPlayer player = new SoundPlayer();
        public SpeechSynthesizer speech = new SpeechSynthesizer();
        string[] words = { "baseball", "basketball", "boxing", "cycling", "gymnastics", "ice hockey", "skiing", 
            "soccer", "surfing", "swimming", "tennis", "volleyball"};
        string[] list = { "baseball", "basketball", "boxing", "cycling", "gymnastics", "ice hockey", "skiing", 
            "soccer", "surfing", "swimming", "tennis", "volleyball"};
        Random random = new Random();
        string s = "";
        private int correct = 0;
        private int incorrect = 0;
        public string MainUser;

        // Functions 
        public void Remove()
        {
            words = words.Where(e => e != s.ToString()).ToArray();
        }

        public void RandomImageGen()
        {
            s = words[random.Next(0, words.Length)];
            LoadImage(s);
        }

        public void LoadImage(string s)
        {
            if (s == "baseball")
                picBoxImage.BackgroundImage = Properties.Resources.baseball;
            else if (s == "basketball")
                picBoxImage.BackgroundImage = Properties.Resources.basketball;
            else if (s == "boxing")
                picBoxImage.BackgroundImage = Properties.Resources.boxing;
            else if (s == "cycling")
                picBoxImage.BackgroundImage = Properties.Resources.cycling;
            else if (s == "gymnastics")
                picBoxImage.BackgroundImage = Properties.Resources.gymnastics;
            else if (s == "ice hockey")
                picBoxImage.BackgroundImage = Properties.Resources.icehockey;
            else if (s == "skiing")
                picBoxImage.BackgroundImage = Properties.Resources.skiing;
            else if (s == "soccer")
                picBoxImage.BackgroundImage = Properties.Resources.soccer;
            else if (s == "surfing")
                picBoxImage.BackgroundImage = Properties.Resources.surfing;
            else if (s == "swimming")
                picBoxImage.BackgroundImage = Properties.Resources.swimming;
            else if (s == "tennis")
                picBoxImage.BackgroundImage = Properties.Resources.tennis;
            else if (s == "volleyball")
                picBoxImage.BackgroundImage = Properties.Resources.volleyball;
        }

        // Form Events
        private void SportQuizzes_Load(object sender, EventArgs e)
        {
            RandomImageGen();
        }

        private void txtBoxInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (words.Length > 1 && correct + incorrect != 9)
                {
                    if (txtBoxInput.Text.ToLower() == s)
                    {
                        player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\correct.wav";
                        player.Play();
                        correct++;
                        labelCorrectValue.Text = "Correct : " + correct.ToString();
                        Remove();
                        RandomImageGen();
                        txtBoxInput.Text = null;
                    }
                    else
                    {
                        player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\incorrect.wav";
                        player.Play();
                        speech.Volume = 100;
                        speech.Rate = 0;

                        int sleepTime = 1000; // in mills
                        Task.Delay(sleepTime).Wait();

                        speech.SpeakAsync("This is " + s);
                        incorrect++;
                        labelIncorrectValue.Text = "Incorrect : " + incorrect.ToString();

                        Task.Delay(sleepTime).Wait();

                        Remove();
                        RandomImageGen();
                        txtBoxInput.Text = null;
                    }
                }
                else
                {
                    words = list;
                    correct++;
                    MessageBox.Show("Kết thúc, kết quả bạn đạt được là " + correct + "/10", "Game tiếng Anh");
                    AddScore();
                    this.Close();
                }
            }
        }

        public void AddScore()
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO HighScore(PlayerName, TestTopic, Score)VALUES(@PlayerName, @TestTopic, @Score)", cn);
            cm.Parameters.AddWithValue("@PlayerName", MainUser);
            cm.Parameters.AddWithValue("@TestTopic", "Sport");
            cm.Parameters.AddWithValue("@Score", correct); ;
            cm.ExecuteNonQuery();
            cn.Close();
        }

        private void SportQuizzes_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
