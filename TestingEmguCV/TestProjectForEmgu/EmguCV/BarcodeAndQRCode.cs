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
    public partial class BarcodeAndQRCode : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;


        BarcodeLib.Barcode code128;
        private static Bitmap screenBitmap;
        string decoded = "";
        public BarcodeAndQRCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            code128 = new Barcode();
            Image barcode = code128.Encode(BarcodeLib.TYPE.CODE128, textBox1.Text);
            BarCodeImage.Image = barcode;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(textBox2.Text,
            QRCodeGenerator.ECCLevel.Q));
            QRCodeImage.Image = qrCode.GetGraphic(2, Color.Black, Color.White, false);
            qrGenerator.Dispose();
            qrCode.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap imgBarCode = (Bitmap)BarCodeImage.Image;
            Bitmap imgQRCode = (Bitmap)QRCodeImage.Image;
            if (BarCodeImage != null || QRCodeImage != null)
            {
                try
                {
                    ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                    Result resultBarCode = Reader.Decode(imgBarCode);
                    Result resultQRCode = Reader.Decode(imgQRCode);
                    string decodedBarcode = resultBarCode.ToString().Trim();
                    string decodedQRCode = resultQRCode.ToString().Trim();
                    richTextBox1.Text = decodedBarcode + " " + decodedQRCode;
                    imgBarCode.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "");
                }
            }
        }

        private void BarcodeAndQRCode_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboDevice.Items.Add(filterInfo.Name);
            cboDevice.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    textBox2.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void BarcodeAndQRCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }
    }
}
