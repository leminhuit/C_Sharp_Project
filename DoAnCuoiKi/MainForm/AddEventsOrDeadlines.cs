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
    public partial class AddEventsOrDeadlines : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public SqlDataReader dr2;

        public AddEventsOrDeadlines()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void btnSaveEvents_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO tbEvents(StartDayOfEvents, EventsName, EventCategory, EventDescription)VALUES(@StartDayOfEvents, @EventsName, @EventCategory, @EventDescription)", cn);
            cm.Parameters.AddWithValue("@StartDayOfEvents", txtBoxDayStart.Text);
            cm.Parameters.AddWithValue("@EventsName", txtBoxEventName.Text);
            cm.Parameters.AddWithValue("@EventCategory", cboBoxEventCategory.Text);
            cm.Parameters.AddWithValue("@EventDescription", txtBoxEventDescription.Text);
            cm.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Event/Deadline Details Saved", "Events Tracker");
            this.Close();
            
        }

        private void AddEventsOrDeadlines_Load(object sender, EventArgs e)
        {
            txtBoxDayStart.Text = UserControlDay.static_day + "/" + PlansAndDeadlines.static_month + "/" + PlansAndDeadlines.static_year;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
