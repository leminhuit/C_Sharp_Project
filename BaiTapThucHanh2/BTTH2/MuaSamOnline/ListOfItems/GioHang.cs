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

using AForge.Video;
using AForge.Video.DirectShow;

using BarcodeLib;
using QRCoder;
using ZXing;

namespace MuaSamOnline
{
    public partial class GioHang : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        //private static Bitmap screenBitmap;
        DataTable dt = new DataTable();
        DataTable data = new DataTable();
        string decoded = "";

        public GioHang()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        public void LoadGioHang()
        {
            dgvGioHang.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbGiohang ORDER BY ProductId", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvGioHang.Rows.Add(dr["ProductId"].ToString(), dr["ProductName"].ToString(), dr["Price"].ToString(), dr["Amount"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void GioHang_Load(object sender, EventArgs e)
        {
            LoadGioHang();
            LoadData();

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboDevice.Items.Add(filterInfo.Name);
            cboDevice.SelectedIndex = 0;

            int sum = 0;

            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                int a = Convert.ToInt32(row.Cells["Price"].Value.ToString());
                int b = Convert.ToInt32(row.Cells["Amount"].Value.ToString());

                sum = sum + a * b;
            }

            txtTongTien.Text = sum.ToString();
        }

        private void btnPayWithReceipt_Click(object sender, EventArgs e)
        {
            ReceiptForm f = new ReceiptForm();
            DateTime now = DateTime.Now;
            string NgayIn = now.ToString("dd-MM-yyyy");
            f.LoadReceipt(txtBox_TenKhachHang.Text, txtBox_DiaChi.Text, NgayIn, txtTongTien.Text);
            f.Show();

            dgvGioHang.Rows.Clear();
            LoadGioHang();
            txtTongTien.Text = Convert.ToInt32("0").ToString();
        }

        Image LoadQRCode(string s)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(s, QRCodeGenerator.ECCLevel.Q));
            Image im = qrCode.GetGraphic(2, Color.Black, Color.White, false);
            qrGenerator.Dispose();
            qrCode.Dispose();
            return im;
        }

        void LoadData()
        {
            // DataTable luu thong tin cac mon hang
            data.Columns.Add("MaSP", typeof(string));
            data.Columns.Add("TenSP", typeof(string));
            data.Columns.Add("Gia", typeof(int));
            data.Columns.Add("QRCode", typeof(Image));

            // Data cho Thiet bi cong nghe
            data.Rows.Add("E001", "Tai nghe không dây F9", 139000, LoadQRCode("E001"));
            data.Rows.Add("E002", "Đồng hồ thông minh T500", 500000, LoadQRCode("E002"));
            data.Rows.Add("E003", "Sạc dự phòng chính hãng", 269000, LoadQRCode("E003"));
            data.Rows.Add("E004", "Đầu đọc thẻ nhớ đa năng", 296000, LoadQRCode("E004"));
            data.Rows.Add("E005", "Bàn phím K15 Wolf", 149000, LoadQRCode("E005"));
            data.Rows.Add("E006", "Giá đỡ điện thoại", 69000, LoadQRCode("E006"));
            // Data cho Thuc pham
            data.Rows.Add("F001", "Tôm thẻ tươi", 120000, LoadQRCode("F001"));
            data.Rows.Add("F002", "Mini Cream Cheese Pie", 129000, LoadQRCode("F002"));
            data.Rows.Add("F003", "Lườn cá hồi", 79000, LoadQRCode("F003"));
            data.Rows.Add("F004", "Salami tiêu đỏ", 108000, LoadQRCode("F004"));
            data.Rows.Add("F005", "Nho đen không hạt", 105000, LoadQRCode("F005"));
            data.Rows.Add("F006", "Cá hổ tẩm ướp nắng", 79000, LoadQRCode("F006"));
            // Data cho Cuoc song
            data.Rows.Add("L001", "Hộp bút 2 tầng", 50000, LoadQRCode("L001"));
            data.Rows.Add("L002", "Combo 40 bút bi FlexOffice", 88000, LoadQRCode("L002"));
            data.Rows.Add("L003", "Máy tính Casio", 784000, LoadQRCode("L003"));
            data.Rows.Add("L004", "Bảng viết LCD", 115000, LoadQRCode("L004"));
            data.Rows.Add("L005", "Giấy in mã vạch", 45000, LoadQRCode("L005"));
            data.Rows.Add("L006", "Bìa còng FlexOffice", 39000, LoadQRCode("L006"));
            // Data cho The thao
            data.Rows.Add("S001", "Lều cắm trại", 560000, LoadQRCode("S001"));
            data.Rows.Add("S002", "Máy tập cơ bụng", 1249000, LoadQRCode("S002"));
            data.Rows.Add("S003", "Balo Tennis", 1499000, LoadQRCode("S003"));
            data.Rows.Add("S004", "Bao tay tập gym", 85000, LoadQRCode("S004"));
            data.Rows.Add("S005", "Kính lặn kèm ống thở", 199000, LoadQRCode("S005"));
            data.Rows.Add("S006", "Vợt cầu lông Guangyu", 419000, LoadQRCode("S006"));
            // Data cho Thoi trang
            data.Rows.Add("W001", "Áo sơ mi nam tay dài", 98000, LoadQRCode("W001"));
            data.Rows.Add("W002", "Quần tây âu nam", 99000, LoadQRCode("W002"));
            data.Rows.Add("W003", "Áo khoác da lót lông", 260000, LoadQRCode("W003"));
            data.Rows.Add("W004", "Áo hoodie nữ", 125000, LoadQRCode("W004"));
            data.Rows.Add("W005", "Quần công sở Zenic", 249000, LoadQRCode("W005"));
            data.Rows.Add("W006", "Áo thời trang Eden Caro", 149000, LoadQRCode("W006"));
        }

        bool Find(string MaSP)
        {
            if (dgvGioHang.Rows.Count > 0)
                foreach (DataGridViewRow row in dgvGioHang.Rows)
                    if (row.Cells["ProductId"].Value.ToString() == MaSP)
                        return true;
            return false;
        }

        void CheckQRCode(string decode)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["MaSP"].ToString() == decode)
                {
                    if (!Find(decode))
                    {
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tbGioHang SELECT * FROM tableProducts WHERE ProductId = @ProductId; ", cn);
                        cm.Parameters.AddWithValue("@ProductId", decode);
                        cm.ExecuteNonQuery();
                        timer1.Stop();
                        cn.Close();
                    }
                }
            }

            int TT = TinhTien();

            txtTongTien.Text = TT.ToString();

            LoadGioHang();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnCameraQR_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    decoded = result.ToString().Trim();
                    CheckQRCode(decoded);
                }
            }
        }

        private int TinhTien()
        {
            int sum = 0;

            for (int i = 0; i < dgvGioHang.Rows.Count; i++)
            {
                int a = Convert.ToInt32(dgvGioHang.Rows[i].Cells["Price"].Value.ToString());
                int b = Convert.ToInt32(dgvGioHang.Rows[i].Cells["Amount"].Value.ToString());

                sum = sum + a * b;
            }
            return sum;
        }

        private void txtBox_TenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
