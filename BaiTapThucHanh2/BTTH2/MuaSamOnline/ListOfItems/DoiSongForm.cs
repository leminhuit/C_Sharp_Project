using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuaSamOnline.Modules.DoiSongProducts;

namespace MuaSamOnline.ListOfItems
{
    public partial class DoiSongForm : Form
    {
        public DoiSongForm()
        {
            InitializeComponent();
        }

        private void pBoxHopBut2Tang_Click(object sender, EventArgs e)
        {
            HopBut hb = new HopBut();
            hb.ShowDialog();
        }

        private void pBoxComboButBi_Click(object sender, EventArgs e)
        {
            ButBi bb = new ButBi();
            bb.ShowDialog();
        }

        private void pBoxMayTinh_Click(object sender, EventArgs e)
        {
            MayTinhCasio mt = new MayTinhCasio();
            mt.ShowDialog();
        }

        private void pBoxBangLCD_Click(object sender, EventArgs e)
        {
            BangVietLCD bv = new BangVietLCD();
            bv.ShowDialog();
        }

        private void pBoxGiayInMaVach_Click(object sender, EventArgs e)
        {
            GiayInMaVach giay = new GiayInMaVach();
            giay.ShowDialog();
        }

        private void pBoxBiaCong_Click(object sender, EventArgs e)
        {
            BiaCong bia = new BiaCong();
            bia.ShowDialog();
        }
    }
}
