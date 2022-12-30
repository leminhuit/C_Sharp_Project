using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuaSamOnline.Modules.TheThaoProducts;

namespace MuaSamOnline.ListOfItems
{
    public partial class TheThaoForm : Form
    {
        public TheThaoForm()
        {
            InitializeComponent();
        }

        private void pBoxLeuCamTrai_Click(object sender, EventArgs e)
        {
            LeuCamTrai lct = new LeuCamTrai();
            lct.ShowDialog();
        }

        private void pBoxMayTapCoBung_Click(object sender, EventArgs e)
        {
            MayTapCoBung mtcb = new MayTapCoBung();
            mtcb.ShowDialog();
        }

        private void pBoxBaloTennis_Click(object sender, EventArgs e)
        {
            BaloTennis bt = new BaloTennis();
            bt.ShowDialog();
        }

        private void pBoxBaoTayTapGym_Click(object sender, EventArgs e)
        {
            BaoTayTapGym bttg = new BaoTayTapGym();
            bttg.ShowDialog();
        }

        private void pBoxKinhLan_Click(object sender, EventArgs e)
        {
            KinhLan kl = new KinhLan();
            kl.ShowDialog();
        }

        private void pBoxVotCauLong_Click(object sender, EventArgs e)
        {
            VotCauLong vot = new VotCauLong();
            vot.ShowDialog();
        }
    }
}
