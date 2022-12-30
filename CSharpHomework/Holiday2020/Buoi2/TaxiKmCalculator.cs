using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holiday2020
{
    public partial class TaxiKmCalculator : Form
    {
        public TaxiKmCalculator()
        {
            InitializeComponent();
        }

        private void BangGiaCuocGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void BillPictureBox_Click(object sender, EventArgs e)
        {
            int SoKm = 0, KhuyenMai = 0, TT = 0;

            SoKm = Convert.ToInt32(SoKmValue.Text);
            KhuyenMai = Int32.Parse(KhuyenMaiValue.Text);

            if (SoKm < 5) TT = 14000 * SoKm;
            else if (SoKm < 26) TT = 14000 * 4 + (SoKm - 4) * 16000;
            else TT = 14000 * 4 + 16000 * 21 + 12000 * (SoKm - 26);

            if (SoKm != 0) TT = (100 - KhuyenMai) * TT / 100;

            ThanhToanValue.Text = TT.ToString("N");
        }

        private void ThanhToanValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
