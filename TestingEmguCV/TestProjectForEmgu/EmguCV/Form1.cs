using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace EmguCV
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataTable data = new DataTable();
            //data.Columns.Add("MaSP", typeof(string));
            //data.Columns.Add("TenSP", typeof(string));
            //data.Columns.Add("Gia", typeof(int));

            //data.Rows.Add("001", "Dầu gội", 99000);
            //data.Rows.Add("002", "Sữa tắm", 135000);
            //data.Rows.Add("003", "Nước rửa chén", 88000);
            //data.Rows.Add("004", "Gạo ST25", 150000);
            //data.Rows.Add("005", "Nước suối lavie chai 1 lít", 21000);
            //data.Rows.Add("006", "Nước tăng lực sting", 9000);
            //data.Rows.Add("007", "Dầu ăn Simply chai 5 lít", 209000);
            //data.Rows.Add("008", "Kem Wall", 11000);
            //data.Rows.Add("009", "Bánh gạo One One", 18000);
            //data.Rows.Add("010", "Kẹo bạc hà", 10000);

            //timer1.Enabled = true;

        //ds.Tables.Add(data);

        // D:\\SelfStudy\\C#\\TestingEmguCV\\TestProjectForEmgu\\EmguCV\\Report1.rdlc

            this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        
        private void ReportBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        public void LoadReport(DataTable dt)
        {
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "D:\\SelfStudy\\C#\\TestingEmguCV\\TestProjectForEmgu\\EmguCV\\Report1.rdlc";

            ReportDataSource dts = new ReportDataSource();
            dts.Name = "DataSet1";
            dts.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dts);

            //ReportParameter para1 = new ReportParameter();
            //para1.Name = "MaSP";
            //para1.Values.Add(MaSP);
            //ReportParameter para2 = new ReportParameter();
            //para2.Name = "TenSP";
            //para2.Values.Add(TenSP);
            //ReportParameter para3 = new ReportParameter();
            //para3.Name = "SL";
            //para3.Values.Add(SoLuong);
            //ReportParameter para4 = new ReportParameter();
            //para4.Name = "Gia";
            //para4.Values.Add(Gia);
            //reportViewer1.LocalReport.SetParameters(new ReportParameter[] { para1, para2, para3, para4 });
        }
    }
}
