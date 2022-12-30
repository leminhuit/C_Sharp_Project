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
    public partial class DailyHealthTracker : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();

        public DailyHealthTracker()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            ClearAllChecked();
        }

        private void ckBoxDrinkWater_CheckedChanged(object sender, EventArgs e)
        {
            progressBar.Value = progressBar.Value + 20;
        }

        private void ckBoxExercise_CheckedChanged(object sender, EventArgs e)
        {
            progressBar.Value = progressBar.Value + 20;
        }

        private void ckBoxMeditating_CheckedChanged(object sender, EventArgs e)
        {
            progressBar.Value = progressBar.Value + 20;
        }

        private void ckBoxGoOutside_CheckedChanged(object sender, EventArgs e)
        {
            progressBar.Value = progressBar.Value + 20;
        }

        private void ckBoxEnoughSleep_CheckedChanged(object sender, EventArgs e)
        {
            progressBar.Value = progressBar.Value + 20;
        }

        private void ckBoxWriteGrateful_CheckedChanged(object sender, EventArgs e)
        {
            progressBar.Value = progressBar.Value + 20;
        }

        private void ckBoxTalkToFriends_CheckedChanged(object sender, EventArgs e)
        {
            progressBar.Value = progressBar.Value + 20;
        }

        private void DailyCriteria()
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO tbDHT(DayOfDHT, ProgressDaily)VALUES(@DayOfDHT , @ProgressDaily)", cn);
            cm.Parameters.AddWithValue("@DayOfDHT", DateTime.Today.Date);
            cm.Parameters.AddWithValue("@ProgressDaily", progressBar.Value);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        private void EverythingFinished()
        {
            cn.Open();
            cm = new SqlCommand("UPDATE tbDHT SET ProgressDaily = @Value WHERE DayOfDHT = @Day ", cn);
            cm.Parameters.AddWithValue("@Day", DateTime.Today.Date);
            cm.Parameters.AddWithValue("@Value", progressBar.Value);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        private void ClearAllChecked()
        {
            ckBoxDrinkWater.CheckState = CheckState.Unchecked;
            ckBoxExercise.CheckState = CheckState.Unchecked;
            ckBoxMeditating.CheckState = CheckState.Unchecked;
            ckBoxGoOutside.CheckState = CheckState.Unchecked;
            ckBoxEnoughSleep.CheckState = CheckState.Unchecked;
            ckBoxWriteGrateful.CheckState = CheckState.Unchecked;
            ckBoxTalkToFriends.CheckState = CheckState.Unchecked;
        }

        private void progressBar_ValueChanged(object sender, EventArgs e)
        {
            if (progressBar.Value == 100)
            {
                DailyCriteria();
                MessageBox.Show("Congratulation!! You Finished Your Daily Criteria", "Daily Health Tracker");
            }
            if (progressBar.Value == 140)
            {
                EverythingFinished();
                MessageBox.Show("Amazing !! You Finished Everything !! Keep it up !", "Daily Health Tracker");
            }
        }

        private void DailyHealthTracker_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
