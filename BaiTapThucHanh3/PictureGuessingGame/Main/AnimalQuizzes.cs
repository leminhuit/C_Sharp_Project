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
    public partial class AnimalQuizzes : Form
    {
        public AnimalQuizzes(string UserName)
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
        string[] words = { "bear", "bee", "cat", "cow", "dog", "dolphin", "elephant", "jellyfish",
            "lion", "monkey", "octopus", "owl", "rabbit", "turtle", "whale" };
        string[] list = { "bear", "bee", "cat", "cow", "dog", "dolphin", "elephant", "jellyfish",
            "lion", "monkey", "octopus", "owl", "rabbit", "turtle", "whale" };
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
            if (s == "bear")
                picBoxImage.BackgroundImage = Properties.Resources.bear;
            else if (s == "bee")
                picBoxImage.BackgroundImage = Properties.Resources.bee;
            else if (s == "cat")
                picBoxImage.BackgroundImage = Properties.Resources.cat;
            else if (s == "cow")
                picBoxImage.BackgroundImage = Properties.Resources.cow;
            else if (s == "dog")
                picBoxImage.BackgroundImage = Properties.Resources.dog;
            else if (s == "dolphin")
                picBoxImage.BackgroundImage = Properties.Resources.dolphin;
            else if (s == "elephant")
                picBoxImage.BackgroundImage = Properties.Resources.elephant;
            else if (s == "jellyfish")
                picBoxImage.BackgroundImage = Properties.Resources.jellyfish;
            else if (s == "lion")
                picBoxImage.BackgroundImage = Properties.Resources.lion;
            else if (s == "monkey")
                picBoxImage.BackgroundImage = Properties.Resources.monkey;
            else if (s == "octopus")
                picBoxImage.BackgroundImage = Properties.Resources.octopus;
            else if (s == "owl")
                picBoxImage.BackgroundImage = Properties.Resources.owl;
            else if (s == "rabbit")
                picBoxImage.BackgroundImage = Properties.Resources.rabbit;
            else if (s == "turtle")
                picBoxImage.BackgroundImage = Properties.Resources.turtle;
            else if (s == "whale")
                picBoxImage.BackgroundImage = Properties.Resources.whale;
        }

        // Form Events
        private void AnimalQuizzes_Load(object sender, EventArgs e)
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
            cm.Parameters.AddWithValue("@TestTopic", "Animal");
            cm.Parameters.AddWithValue("@Score", correct); ;
            cm.ExecuteNonQuery();
            cn.Close();
        }

        private void AnimalQuizzes_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
