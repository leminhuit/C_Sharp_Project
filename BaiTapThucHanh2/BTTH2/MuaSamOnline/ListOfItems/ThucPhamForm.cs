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
using MuaSamOnline.Modules;

namespace MuaSamOnline.ListOfItems
{
    public partial class ThucPhamForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public ThucPhamForm()
        {
            InitializeComponent();
        }

        private void pBoxFish_Click(object sender, EventArgs e)
        { 
            TomTheTuoi tom = new TomTheTuoi();
            tom.ShowDialog();
        }

        private void pBoxPie_Click(object sender, EventArgs e)
        {
            CheesePie cp = new CheesePie();
            cp.ShowDialog();
        }

        private void pBoxCaHoi_Click(object sender, EventArgs e)
        {
            LuonCaHoi lch = new LuonCaHoi();
            lch.ShowDialog();
        }

        private void pBoxSalami_Click(object sender, EventArgs e)
        {
            SalamiTieuDo salami = new SalamiTieuDo();
            salami.ShowDialog();
        }

        private void pBoxNhoDen_Click(object sender, EventArgs e)
        {
            NhoDenKhongHat nho = new NhoDenKhongHat();
            nho.ShowDialog();
        }

        private void pBoxCaHo_Click(object sender, EventArgs e)
        {
            CaHoUop ca = new CaHoUop();
            ca.ShowDialog(); ;
        }
    }
}
