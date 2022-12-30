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

namespace Main
{
    public partial class HighScore : Form
    {
        public string MainUser;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        List<string> s = new List<string>();

        public HighScore()
        {
            InitializeComponent();

            cn = new SqlConnection(dbcon.myConnection());
        }

        public void LoadHighScore()
        {
            dgvLeaderboard.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT TOP 10 * FROM HighScore WHERE TestTopic = @TestTopic ORDER BY Score DESC", cn);
            cm.Parameters.AddWithValue("@TestTopic", cboTopic.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvLeaderboard.Rows.Add(dr["PlayerName"].ToString(), dr["TestTopic"].ToString(), dr["Score"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void ClearAllTop()
        {
            labelTop1Value.Text = "none";
            labelTop2Value.Text = "none";
            labelTop3Value.Text = "none";
        }

        public void LoadTop3()
        {
            cn.Open();
            cm = new SqlCommand("SELECT TOP 3 PlayerName FROM HighScore WHERE TestTopic = @TestTopic ORDER BY Score DESC", cn);
            cm.Parameters.AddWithValue("@TestTopic", cboTopic.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                s.Add(dr["PlayerName"].ToString());
            }
            dr.Close();
            cn.Close();
            if (s.Count() == 0)
            {
                ClearAllTop();
            }
            else if (s.Count() == 1)
            {
                ClearAllTop();
                labelTop1Value.Text = s[0].ToString();
            }
            else if (s.Count() == 2)
            {
                ClearAllTop();
                labelTop1Value.Text = s[0].ToString();
                labelTop2Value.Text = s[1].ToString();
            }
            else
            {
                ClearAllTop();
                labelTop1Value.Text = s[0].ToString();
                labelTop2Value.Text = s[1].ToString();
                labelTop3Value.Text = s[2].ToString();
            }
        }

        private void HighScore_Load(object sender, EventArgs e)
        {
            
        }

        private void cboTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.Clear();
            LoadHighScore();
            LoadTop3();
        }
    }
}
