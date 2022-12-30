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
    public partial class LichChuyenBay : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public LichChuyenBay()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }
        
        public void LoadThongTin()
        {
            cn.Open();
            cm = new SqlCommand("SELECT CB.MaChuyenBay, DG.DONGIA, TB.SanBayDi, TB.SanBayDen, NgayGio, CB.ThoiGianBay, CB.SoLuongGheHang1, CB.SoLuongGheHang2 FROM TUYENBAY TB, CHUYENBAY CB, DONGIA DG WHERE CB.MaTuyenBay = TB.MaTuyenBay AND DG.MaTuyenBay = CB.MaTuyenBay AND DG.MaHangVe = 2 AND CB.MaChuyenBay = @MaChuyenBay", cn);
            cm.Parameters.AddWithValue("@MaChuyenBay", cboMaChuyenBay.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

            }
            dr.Close();
            cn.Close();
        }

        public void LoadMaChuyenBay()
        {
            cn.Open();
            cm = new SqlCommand("SELECT MaChuyenBay FROM CHUYENBAY", cn);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cboMaChuyenBay.Items.Add(dr[0]);
            }
            dr.Close();
            cn.Close();
        }

        private void LichChuyenBay_Load(object sender, EventArgs e)
        {
            LoadMaChuyenBay();
        }

        private void cboMaChuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("SELECT CB.MaChuyenBay, DG.DonGia, TB.SanBayDi, TB.SanBayDen, NgayGio, CB.ThoiGianBay, CB.SoLuongGheHang1, CB.SoLuongGheHang2 FROM TUYENBAY TB, CHUYENBAY CB, DONGIA DG WHERE CB.MaTuyenBay = TB.MaTuyenBay AND DG.MaTuyenBay = CB.MaTuyenBay AND DG.MaHangVe = 2 AND CB.MaChuyenBay = @MaChuyenBay", cn);
            cm.Parameters.AddWithValue("@MaChuyenBay", cboMaChuyenBay.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtBoxSanBayDi.Text = dr["SanBayDi"].ToString();
                txtSanBayDen.Text = dr["SanBayDen"].ToString();
                txtThoiGianBay.Text = dr["ThoiGianBay"].ToString();
                txtGiaVe.Text = dr["DonGia"].ToString();
                txtNgayGio.Text = dr["NgayGio"].ToString();
                txtSLGH1.Text = dr["SoLuongGheHang1"].ToString();
                txtSLGH2.Text = dr["SoLuongGheHang2"].ToString();
            }
            dr.Close();
            cn.Close();
        }
    }
}
