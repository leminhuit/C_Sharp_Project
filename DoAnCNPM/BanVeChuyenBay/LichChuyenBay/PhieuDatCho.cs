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
    public partial class PhieuDatCho : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public int MaHanhKhach = -1;
        public int MaVe = -1;
        string s = "";

        public PhieuDatCho()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            cn.Open();
            cm = new SqlCommand("SELECT MaHangVe FROM HANGVE", cn);
            SqlDataReader DR = cm.ExecuteReader();
            while (DR.Read())
            {
                cboHangVe.Items.Add(DR[0]);
            }
            cn.Close();
            s = RandomMaHanhKhach();
        }

        public string RandomMaHanhKhach()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void PhieuDatCho_Load(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("SELECT MaChuyenBay FROM CHUYENBAY", cn);
            SqlDataReader DR = cm.ExecuteReader();
            while (DR.Read())
            {
                cboChuyenBay.Items.Add(DR[0]);
            }
            cn.Close();
        }

        public void LoadDonGia()
        {
            cn.Open();
            cm = new SqlCommand("SELECT DonGia FROM DONGIA WHERE MaHangVe = @MaHangVe AND MaTuyenBay IN (SELECT MaTuyenBay FROM CHUYENBAY WHERE MaChuyenBay = @MaChuyenBay)", cn);
            cm.Parameters.AddWithValue("@MaChuyenBay", cboChuyenBay.Text);
            cm.Parameters.AddWithValue("@MaHangVe", cboHangVe.Text);
            SqlDataReader DR = cm.ExecuteReader();
            while (DR.Read())
            {
                txtBoxGiaTien.Text = DR[0].ToString();
            }
            cn.Close();
        }

        private void cboHangVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDonGia();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDonGia();
        }

        private void cboChuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDonGia();
        }

        public void DatVe()
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO VECHUYENBAY(MaChuyenBay, MaHangVe, MaHanhKhach, GiaTien)VALUES(@MaChuyenBay, @MaHangVe, @MaHanhKhach, @GiaTien)", cn);
            cm.Parameters.AddWithValue("@MaChuyenBay", cboChuyenBay.Text);
            cm.Parameters.AddWithValue("@MaHangVe", cboHangVe.Text);
            cm.Parameters.AddWithValue("@MaHanhKhach", s);
            cm.Parameters.AddWithValue("@GiaTien", txtBoxGiaTien.Text);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        public void ThemKhachHang()
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO HANHKHACH(MaHanhKhach, TenHanhKhach, CMND, DienThoai)VALUES(@MaHanhKhach, @TenHanhKhach, @CMND, @DienThoai)", cn);
            cm.Parameters.AddWithValue("@MaHanhKhach", s);
            cm.Parameters.AddWithValue("@TenHanhKhach", txtBoxHanhKhach.Text);
            cm.Parameters.AddWithValue("@CMND", txtBoxCMND.Text); ;
            cm.Parameters.AddWithValue("@DienThoai", txtBoxDienThoai.Text);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        public void ThemPhieuDatCho()
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO PHIEUDATCHO(MaChuyenBay, MaHanhKhach, MaHangVe, GiaTien, NgayDat)VALUES(@MaChuyenBay, @MaHanhKhach, @MaHangVe, @GiaTien, @NgayDat)", cn);
            cm.Parameters.AddWithValue("@MaChuyenBay", cboChuyenBay.Text);
            cm.Parameters.AddWithValue("@MaHanhKhach", s);
            cm.Parameters.AddWithValue("@MaHangVe", cboHangVe.Text);
            cm.Parameters.AddWithValue("@GiaTien", txtBoxGiaTien.Text); ;
            cm.Parameters.AddWithValue("@NgayDat", DateTime.Now);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            ThemKhachHang();
            DatVe();
            ThemPhieuDatCho();
            MessageBox.Show("Đặt vé thành công", "Phần mềm quản lí bán vé máy bay");
            this.Close();
        }
    }
}
