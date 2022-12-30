using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuaSamOnline.Modules.TBCongNgheProducts;

namespace MuaSamOnline.ListOfItems
{
    public partial class TBCongNghe : Form
    {
        public TBCongNghe()
        {
            InitializeComponent();
        }

        private void pBoxTaiNghe_Click(object sender, EventArgs e)
        {
            TaiNgheKhongDay tainghe = new TaiNgheKhongDay();
            tainghe.ShowDialog();
        }

        private void pBoxDongHo_Click(object sender, EventArgs e)
        {
            DongHoThongMinh dongho = new DongHoThongMinh();
            dongho.ShowDialog();
        }

        private void pBoxSacDuPhong_Click(object sender, EventArgs e)
        {
            SacDuPhong sac = new SacDuPhong();
            sac.ShowDialog();
        }

        private void pBoxDauDocTheNho_Click(object sender, EventArgs e)
        {
            DauDocThe daudoc = new DauDocThe();
            daudoc.ShowDialog();
        }

        private void pBoxBanPhim_Click(object sender, EventArgs e)
        {
            BanPhimK15 banphim = new BanPhimK15();
            banphim.ShowDialog();
        }

        private void pBoxGiaDoDT_Click(object sender, EventArgs e)
        {
            GiaDoDienThoai gd = new GiaDoDienThoai();
            gd.ShowDialog();
        }
    }
}
