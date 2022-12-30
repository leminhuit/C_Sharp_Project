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
    public partial class UserControlDay : UserControl
    {
        public static string static_day;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public SqlDataReader dr2;

        public UserControlDay()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {
            displayEvent();
        }

        public void days(int numday)
        {
            labelDay.Text = numday + "";
        }

        private void UserControlDay_Click(object sender, EventArgs e)
        {
            static_day = labelDay.Text;
            timer1.Start();
            AddEventsOrDeadlines form = new AddEventsOrDeadlines();
            form.Show();
        }

        private void displayEvent()
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbEvents WHERE StartDayOfEvents = @DAY", cn);
            cm.Parameters.AddWithValue("@DAY", labelDay.Text + "/" + PlansAndDeadlines.static_month + "/" + PlansAndDeadlines.static_year);
            dr2 = cm.ExecuteReader();
            if (dr2.Read())
            {
                labelEvents.Text = dr2["EventsName"].ToString();
                txtBoxDescription.Text = dr2["EventDescription"].ToString();
                if (dr2["EventCategory"].ToString() == "Deadline")
                {
                    BackColor = Color.FromArgb(248, 115, 21);
                    txtBoxDescription.BackColor = Color.FromArgb(248, 115, 21);
                }
                else if (dr2["EventCategory"].ToString() == "Short-term Goal")
                {
                    BackColor = Color.FromArgb(52, 212, 153);
                    txtBoxDescription.BackColor = Color.FromArgb(52, 212, 153);
                }
                else if (dr2["EventCategory"].ToString() == "Long-term Goal")
                {
                    BackColor = Color.FromArgb(99, 101, 239);
                    txtBoxDescription.BackColor = Color.FromArgb(99, 101, 239);
                }
                   
                else if (dr2["EventCategory"].ToString() == "Others")
                {
                    BackColor = Color.FromArgb(163, 230, 53);
                    txtBoxDescription.BackColor = Color.FromArgb(163, 230, 53);
                }
            }
            dr2.Close();
            cn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
