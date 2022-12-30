using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holiday2020.Buoi3
{
    public partial class HotelForm : Form
    {
        string money = "";
        int ItemIndex;

        DataTable dt = new DataTable();

        public HotelForm()
        {
            InitializeComponent();

            dt.Columns.Add("Ma", typeof(string));
            dt.Columns.Add("Loai", typeof(string));
            dt.Columns.Add("Gia", typeof(double));
            dt.Columns.Add("TT", typeof(string));
            dt.Columns.Add("Ngay", typeof(int));
        }

        void AddRoom(string IDRoom)
        {
            if (IDRoom.Contains("A"))
                lstViewHotelRooms.Items.Add(IDRoom, 0);
            if (IDRoom.Contains("B"))
                lstViewHotelRooms.Items.Add(IDRoom, 1);
            if (IDRoom.Contains("C"))
                lstViewHotelRooms.Items.Add(IDRoom, 2);
            lstViewHotelRooms.LargeImageList = imgList_LoaiPhong;
            lstViewHotelRooms.View = View.LargeIcon;
        }

        string AutoIDRoom(string TypeRoom)
        {
            string ID = "";
            if (TypeRoom == "A")
                ID = "A";
            else if (TypeRoom == "B")
                ID = "B";
            else if (TypeRoom == "C")
                ID = "C";

            int max = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string s = dt.Rows[i]["Ma"].ToString();
                if (s.Contains(TypeRoom))
                {
                    if (max < Convert.ToInt32(s.Substring(1, s.Length - 1)))
                        max = Convert.ToInt32(s.Substring(1, s.Length - 1));
                }
            }
            ID = ID + (max + 1).ToString();
            return ID;
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_ThemPhong_Click(object sender, EventArgs e)
        {
            try
            {
                string ma, loai, tt;
                int ngay;
                double gia;
                ma = label_MaPhong.Text;
                loai = cboBox_LoaiPhong.Text;
                gia = Convert.ToDouble(txtBox_GiaPhong.Text);

                if (radButton_Trong.Checked)
                    tt = "Trống";
                else tt = "Đầy";

                ngay = Convert.ToInt32(numUpDown_SoNgayO.Value);

                ma = AutoIDRoom(cboBox_LoaiPhong.Text);
                txtBox_MaPhong.Text = ma;
                dt.Rows.Add(ma, loai, gia, tt, ngay);
                AddRoom(ma);
            }
            catch { MessageBox.Show("Dữ liệu nhập vào có lỗi !!"); };
        }
    }
}
