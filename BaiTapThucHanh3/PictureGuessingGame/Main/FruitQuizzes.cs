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
    public partial class FruitQuizzes : Form
    {
        public FruitQuizzes(string UserName)
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
        string[] words = { "banana", "strawberry", "apple", "cherry", "durian", "blueberries", "grapes", "kiwi",
            "lemon", "coconut", "mango", "orange", "peaches", "pineapple", "watermelon" };
        string[] list = { "banana", "strawberry", "apple", "cherry", "durian", "blueberries", "grapes", "kiwi",
            "lemon", "coconut", "mango", "orange", "peaches", "pineapple", "watermelon" };
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
            if (s == "strawberry")
                picBoxImage.BackgroundImage = Properties.Resources.strawberry;
            else if (s == "cherry")
                picBoxImage.BackgroundImage = Properties.Resources.cherry;
            else if (s == "durian")
                picBoxImage.BackgroundImage = Properties.Resources.durian;
            else if (s == "apple")
                picBoxImage.BackgroundImage = Properties.Resources.apple;
            else if (s == "banana")
                picBoxImage.BackgroundImage = Properties.Resources.banana;
            else if (s == "blueberries")
                picBoxImage.BackgroundImage = Properties.Resources.blueberries;
            else if (s == "grapes")
                picBoxImage.BackgroundImage = Properties.Resources.grapes;
            else if (s == "kiwi")
                picBoxImage.BackgroundImage = Properties.Resources.kiwi;
            else if (s == "lemon")
                picBoxImage.BackgroundImage = Properties.Resources.lemon;
            else if (s == "coconut")
                picBoxImage.BackgroundImage = Properties.Resources.coconut;
            else if (s == "mango")
                picBoxImage.BackgroundImage = Properties.Resources.mango;
            else if (s == "orange")
                picBoxImage.BackgroundImage = Properties.Resources.orange;
            else if (s == "peaches")
                picBoxImage.BackgroundImage = Properties.Resources.peaches;
            else if (s == "pineapple")
                picBoxImage.BackgroundImage = Properties.Resources.pineapple;
            else if (s == "watermelon")
                picBoxImage.BackgroundImage = Properties.Resources.watermelon;
        }

        // Form Events

        public void AddScore()
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO HighScore(PlayerName, TestTopic, Score)VALUES(@PlayerName, @TestTopic, @Score)", cn);
            cm.Parameters.AddWithValue("@PlayerName", MainUser);
            cm.Parameters.AddWithValue("@TestTopic", "Fruit");
            cm.Parameters.AddWithValue("@Score", correct); ;
            cm.ExecuteNonQuery();
            cn.Close();
        }

        private void FruitQuizzes_Load(object sender, EventArgs e)
        {
            RandomImageGen();
        }

        private void txtBoxInput_KeyUpAsync(object sender, KeyEventArgs e)
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
                    MessageBox.Show("Kết thúc, kết quả bạn đạt được là " + correct  + "/10", "Game tiếng Anh");
                    AddScore();
                    this.Close();
                }
            }
        }

        private void FruitQuizzes_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddScore();
        }
    }
}
