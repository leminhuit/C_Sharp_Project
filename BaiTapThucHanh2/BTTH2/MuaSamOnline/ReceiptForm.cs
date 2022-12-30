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
using Microsoft.Reporting.WebForms.Internal.Soap.ReportingServices2005.Execution;
using Microsoft.Reporting.WinForms;

namespace MuaSamOnline
{
    public partial class ReceiptForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();

        public ReceiptForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\DBMuaSamOnline.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        public void LoadReceipt(string TenKhachHang, string DiaChi, string NgayIn, string TongTien)
        {
            cm = new SqlCommand("SELECT * FROM tbGioHang", connection);
            SqlDataAdapter d = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource dts = new ReportDataSource("DataSet1", dt);

            reportViewer1.LocalReport.ReportPath = @"D:\SelfStudy\C#\BaiTapThucHanh2\BTTH2\MuaSamOnline\Report2.rdlc";

            reportViewer1.LocalReport.DataSources.Add(dts);
            // reportViewer1.RefreshReport();

            ReportParameter para1 = new ReportParameter();
            para1.Name = "TenKhachHang";
            para1.ValidValues.(TenKhachHang);
            ReportParameter para2 = new ReportParameter();
            para2.Name = "DiaChi";
            para2.Values.Add(DiaChi);
            ReportParameter para3 = new ReportParameter();
            para3.Name = "NgayIn";
            para3.Values.Add(NgayIn);
            ReportParameter para4 = new ReportParameter();
            para4.Name = "TongTien";
            para4.Values.Add(TongTien);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { para1, para2, para3, para4 });
        }
       

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ReceiptForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("DELETE FROM tbGioHang", cn);
            cm.ExecuteNonQuery();
            cn.Close();
           
        }
    }
}
