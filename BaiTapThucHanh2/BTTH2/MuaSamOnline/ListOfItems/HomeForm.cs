using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuaSamOnline.Modules;
using MuaSamOnline.Modules.TBCongNgheProducts;
using MuaSamOnline.Modules.TheThaoProducts;
using MuaSamOnline.Modules.ThoiTrangProducts;

namespace MuaSamOnline.ListOfItems
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void LoadProduct()
        {
            listView1.Items.Add("Cá hổ tẩm ướp", 0);
            listView1.Items.Add("Nho đen không hạt", 1);
            listView1.Items.Add("Lườn cá hồi", 2);
            listView1.Items.Add("Mini Cream Cheese Pie", 3);
            listView1.Items.Add("Salami tiêu đỏ", 4);
            listView1.Items.Add("Balo Tennis", 5);
            listView1.Items.Add("Bảng viết LCD", 6);
            listView1.Items.Add("Bao tay tập gym", 7);
            listView1.Items.Add("Bìa còng FlexOffice", 8);
            listView1.Items.Add("Combo 40 bút bi", 9);
            listView1.Items.Add("Tôm thẻ tươi", 10);
            listView1.Items.Add("Giấy in mã vạch", 11);
            listView1.Items.Add("Hộp bút 2 tầng", 12);
            listView1.Items.Add("Kính lặn kèm ống thở", 13);
            listView1.Items.Add("Lều cắm trại", 14);
            listView1.Items.Add("Máy tập cơ bụng", 15);
            listView1.Items.Add("Máy tính Casio FX580-VN X", 16);
            listView1.Items.Add("Tai nghe F9 Pro", 17);
            listView1.Items.Add("Đồng hồ thông minh T500", 18);
            listView1.Items.Add("Sạc dự phòng", 19);
            listView1.Items.Add("Đầu đọc thẻ nhớ đa năng", 20);
            listView1.Items.Add("Bàn phím K15 Wolf", 21);
            listView1.Items.Add("Giá đỡ điện thoại", 22);
            listView1.Items.Add("Áo tay dài nam", 23);
            listView1.Items.Add("Áo hoodie nữ", 24);
            listView1.Items.Add("Quần công sở", 25);
            listView1.Items.Add("Áo thời trang Eden Caro", 26);
            listView1.Items.Add("Quần tây Âu nam", 27);
            listView1.Items.Add("Áo khoác da lót lông", 28);
            listView1.Items.Add("Vợt cầu lông Guangyu", 29);
            listView1.LargeImageList = this.imageList1;
            listView1.View = View.LargeIcon;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BanPhimK15 bp = new BanPhimK15();
            bp.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NhoDenKhongHat nho = new NhoDenKhongHat();
            nho.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TaiNgheKhongDay tainghe = new TaiNgheKhongDay();
            tainghe.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AoKhoacNam ao = new AoKhoacNam();
            ao.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LeuCamTrai leu = new LeuCamTrai();
            leu.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SalamiTieuDo salami = new SalamiTieuDo();
            salami.Show();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Search.Text))
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (!item.Text.ToLower().Contains(txt_Search.Text.ToLower()))
                        listView1.Items.Remove(item);
                }
                if (listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }
            }
            else
                LoadProduct();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void txt_Search_Enter(object sender, EventArgs e)
        {
            listView1.Visible = true;
        }

        private void txt_Search_Leave(object sender, EventArgs e)
        {
            listView1.Visible = false;
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {

        }
    }
}
