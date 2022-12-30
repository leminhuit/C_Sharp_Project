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
    public partial class VehicleQuizzes : Form
    {
        public VehicleQuizzes(string UserName)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            MainUser = UserName;
        }

        // Global variables
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        public SoundPlayer player = new SoundPlayer();
        public SpeechSynthesizer speech = new SpeechSynthesizer();
        DBConnection dbcon = new DBConnection();    
        public string MainUser;
        string[] words = { "bicycle", "boat", "bus", "car", "helicopter", "plane", "scooter", "tractor",
            "train", "truck"};
        string[] list = { "bicycle", "boat", "bus", "car", "helicopter", "plane", "scooter", "tractor",
            "train", "truck"};
        Random random = new Random();
        string s = "";
        private int correct = 0;
        private int incorrect = 0;

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
            if (s == "bicycle")
                picBoxImage.BackgroundImage = Properties.Resources.bicycle;
            else if (s == "boat")
                picBoxImage.BackgroundImage = Properties.Resources.boat;
            else if (s == "bus")
                picBoxImage.BackgroundImage = Properties.Resources.bus;
            else if (s == "car")
                picBoxImage.BackgroundImage = Properties.Resources.car;
            else if (s == "helicopter")
                picBoxImage.BackgroundImage = Properties.Resources.helicopter;
            else if (s == "plane")
                picBoxImage.BackgroundImage = Properties.Resources.plane;
            else if (s == "scooter")
                picBoxImage.BackgroundImage = Properties.Resources.scooter;
            else if (s == "tractor")
                picBoxImage.BackgroundImage = Properties.Resources.tractor;
            else if (s == "train")
                picBoxImage.BackgroundImage = Properties.Resources.train;
            else if (s == "truck")
                picBoxImage.BackgroundImage = Properties.Resources.truck;
        }

        private void VehicleQuizzes_Load(object sender, EventArgs e)
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
            cm.Parameters.AddWithValue("@TestTopic", "Vehicle");
            cm.Parameters.AddWithValue("@Score", correct); ;
            cm.ExecuteNonQuery();
            cn.Close();
        }

        private void VehicleQuizzes_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
