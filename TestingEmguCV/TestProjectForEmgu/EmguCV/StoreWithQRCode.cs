using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace EmguCV
{
    public partial class StoreWithQRCode : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private static Bitmap screenBitmap;
        DataTable dt = new DataTable();
        DataTable data = new DataTable();
        string decoded = "";

        public StoreWithQRCode()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
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
            data.Columns.Add("MaSP", typeof(string));
            data.Columns.Add("TenSP", typeof(string));
            data.Columns.Add("Gia", typeof(int));
            data.Columns.Add("QRCode", typeof(Image));

            data.Rows.Add("001", "Dầu gội", 99000, LoadQRCode("001"));
            data.Rows.Add("002", "Sữa tắm", 135000, LoadQRCode("002"));
            data.Rows.Add("003", "Nước rửa chén", 88000, LoadQRCode("003"));
            data.Rows.Add("004", "Gạo ST25", 150000, LoadQRCode("004"));
            data.Rows.Add("005", "Nước suối lavie chai 1 lít", 21000, LoadQRCode("005"));
            data.Rows.Add("006", "Nước tăng lực sting", 9000, LoadQRCode("006"));
            data.Rows.Add("007", "Dầu ăn Simply chai 5 lít", 209000, LoadQRCode("007"));
            data.Rows.Add("008", "Kem Wall", 11000, LoadQRCode("008"));
            data.Rows.Add("009", "Bánh gạo One One", 18000, LoadQRCode("009"));
            data.Rows.Add("010", "Kẹo bạc hà", 10000, LoadQRCode("010"));

            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MaSP", typeof(string));
            dt.Columns.Add("TenSP", typeof(string));
            dt.Columns.Add("SL", typeof(int));
            dt.Columns.Add("Gia", typeof(int));
            dt.Columns.Add("TT", typeof(int));
        }

        bool Find(string MaSP)
        {
            if (dt.Rows.Count > 0)
                for (int i = 0; i < dt.Rows.Count; i++)
                    if (dt.Rows[i]["MaSP"].ToString() == MaSP)
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
                        dt.Rows.Add(dt.Rows.Count + 1
                            , data.Rows[i]["MaSP"].ToString()
                            , data.Rows[i]["TenSP"].ToString()
                            , 1
                            , Convert.ToInt32(data.Rows[i]["Gia"].ToString())
                            , Convert.ToInt32(data.Rows[i]["Gia"].ToString()));
                }
            }
            int TT = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
                TT = TT + Convert.ToInt32(dt.Rows[i]["TT"].ToString());
            textBox4.Text = TT.ToString();
            textBox5.Text = TT.ToString();
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StoreWithQRCode_Load(object sender, EventArgs e)
        {
            LoadData();

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboDevice.Items.Add(filterInfo.Name);
            cboDevice.SelectedIndex = 0;

            dataGridView1.DataSource = dt;
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ProductsForm f = new ProductsForm();
            f.LoadProduct(data);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void LoadPayment(DataTable dt)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.LoadReport(dt);
            f.Show();
        }

        //private void pictureBox3_Click(object sender, EventArgs e)
        //{
        //    Image test = LoadQRCode("001");
        //    pictureBox3.Image = test;
        //    pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
        //}
    }
}
