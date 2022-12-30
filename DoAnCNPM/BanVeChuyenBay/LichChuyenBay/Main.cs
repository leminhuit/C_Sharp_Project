using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LichChuyenBay
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PhieuDatCho phieu = new PhieuDatCho();
            phieu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DanhSachChuyenBay ds = new DanhSachChuyenBay();
            ds.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LichChuyenBay lich = new LichChuyenBay();
            lich.Show();
        }
    }
}
