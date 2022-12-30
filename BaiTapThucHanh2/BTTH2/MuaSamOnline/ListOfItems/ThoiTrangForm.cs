using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuaSamOnline.Modules.ThoiTrangProducts;

namespace MuaSamOnline.ListOfItems
{
    public partial class ThoiTrangForm : Form
    {
        public ThoiTrangForm()
        {
            InitializeComponent();
        }

        private void pBoxAoSoMiNam_Click(object sender, EventArgs e)
        {
            AoSoMiNam aonam = new AoSoMiNam();
            aonam.ShowDialog();
        }

        private void pBoxQuanNam_Click(object sender, EventArgs e)
        {
            QuanTayNam quannam = new QuanTayNam();
            quannam.ShowDialog();
        }

        private void pBoxAoKhoacNam_Click(object sender, EventArgs e)
        {
            AoKhoacNam aokhoacnam = new AoKhoacNam();
            aokhoacnam.ShowDialog();
        }

        private void pBoxAoKhoacNu_Click(object sender, EventArgs e)
        {
            AoHoodieNu aoHoodie = new AoHoodieNu();
            aoHoodie.ShowDialog();
        }

        private void pBoxQuanNu_Click(object sender, EventArgs e)
        {
            QuanCongSo quanCongSo = new QuanCongSo();
            quanCongSo.ShowDialog();
        }

        private void pBoxAoNu_Click(object sender, EventArgs e)
        {
            AoThoiTrang aoThoiTrang = new AoThoiTrang();
            aoThoiTrang.ShowDialog();
        }
    }
}
