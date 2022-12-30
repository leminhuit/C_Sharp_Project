using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Dashboard : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Random random = new Random();
        public string s = "";

        public SqlDataReader dr;
        string[] words = { "Eat A Healthy Diet", "Consume Less Salt and Sugar", "Reduce Intake of Harmful Fats",
            "Avoid Harmful Use of Alcohol", "Don't Smoke", "Be Active", "Check Your Blood Pressure Regularly",
            "Drink Enough Water for the Day", "Get Enough Sleep", "Keep Healthy Relationship",
            "Cultivate A Positive Mindset", "Spend Some Time For Yourself"};

        public Dashboard()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadDeadlines();
            LoadTodayHabitScore();
            LoadTodayExpense();
        }

        private void LoadDeadlines()
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            int day = DateTime.Now.Day;

            cn.Open();
            cm = new SqlCommand("SELECT StartDayOfEvents, EventsName, EventDescription FROM tbEvents WHERE StartDayOfEvents = '@Day'", cn);
            cm.Parameters.AddWithValue("@Day", day + "/" + month + "/" + year);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtBoxDeadlineRemaining.Text += dr["StartDayOfEvents"].ToString() + "-" + dr["EventsName"].ToString() + "-" + dr["EventDescription"].ToString() + Environment.NewLine;
            }
            dr.Close();
            cn.Close();
        }

        private void LoadTodayHabitScore()
        {
            cn.Open();
            cm = new SqlCommand("SELECT ProgressDaily FROM tbDHT WHERE DayOfDHT = @Day", cn);
            cm.Parameters.AddWithValue("@Day", DateTime.Now.ToShortDateString());
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                progressbarHabitScore.Value = Convert.ToInt32(dr["ProgressDaily"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void LoadTodayExpense()
        {
            cn.Open();
            cm = new SqlCommand("SELECT SUM(ExpenseAmount) AS Total FROM tbExpense WHERE ExpenseDate = @Day", cn);
            cm.Parameters.AddWithValue("@Day", DateTime.Now.ToShortDateString());
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                todayExpenseLabel.Text = dr["Total"].ToString();
            }
            dr.Close();
            cn.Close();
        }
        
        private void RandomWordGen()
        {
            s = words[random.Next(0, words.Length)];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RandomWordGen();
            labelChangingTips.Text = s.ToString();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 5000; // 1 second
            timer1.Start();
        }
    }
}
