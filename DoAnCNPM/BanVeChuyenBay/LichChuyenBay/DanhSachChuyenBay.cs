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

namespace LichChuyenBay
{
    public partial class DanhSachChuyenBay : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public DanhSachChuyenBay()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadDanhSach();
            XuLiDanhSach();
        }

        public void LoadDanhSach()
        {
            dgvDSChuyenBay.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT DISTINCT CB.MaChuyenBay, TB.SanBayDi, TB.SanBayDen, CB.ThoiGianBay, (CB.SoLuongGheHang1 + CB.SoLuongGheHang2) AS TongSoGhe FROM TUYENBAY TB, CHUYENBAY CB, VECHUYENBAY VCB WHERE TB.MaTuyenBay = CB.MaTuyenBay", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvDSChuyenBay.Rows.Add(dr["MaChuyenBay"].ToString(),
                    dr["SanBayDi"].ToString(),
                    dr["SanBayDen"].ToString(),
                    dr["ThoiGianBay"].ToString(),
                    0,
                    dr["TongSoGhe"].ToString());

            }
            dr.Close();
            cn.Close();
        }

        public void XuLiDanhSach()
        {
            cn.Open();
            cm = new SqlCommand("SELECT DISTINCT MaChuyenBay, COUNT(MaChuyenBay) as SoGheDat FROM VECHUYENBAY GROUP BY MaChuyenBay", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                for (int i = 0; i < dgvDSChuyenBay.Rows.Count; i++)
                {
                    string s1 = dgvDSChuyenBay.Rows[i].Cells[0].Value?.ToString();
                    if (s1 == dr["MaChuyenBay"].ToString())
                    {
                        int value = Convert.ToInt32(dr["SoGheDat"].ToString());
                        dgvDSChuyenBay.Rows[i].Cells["SoGheDat"].Value = value;
                    }
                }
            }
            dr.Close();
            cn.Close();
        }

        private void DanhSachChuyenBay_Load(object sender, EventArgs e)
        {

        }
    }
}
