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
    public partial class Home : Form
    {
        public string MainUser;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public Home(string UserName)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            MainUser = UserName;
            LoadPersonalScore(MainUser);
        }
        public void LoadPersonalScore(string username)
        {
            dgvCurrentPlayerScore.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM HighScore WHERE PlayerName = @PlayerName", cn);
            cm.Parameters.AddWithValue("@PlayerName", MainUser);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvCurrentPlayerScore.Rows.Add(dr["PlayerName"].ToString(), dr["TestTopic"].ToString(), dr["Score"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = "Hello " + MainUser + ", ready to test your knowledge?";
        }
    }
}
