using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MuaSamOnline.ListOfItems;

using AForge.Video;
using AForge.Video.DirectShow;

using BarcodeLib;
using QRCoder;
using ZXing;

namespace MuaSamOnline
{
    public partial class HubForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();

        // Fields
        private int borderSize = 2;

        // Constructor
        public HubForm()
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);

            cn = new SqlConnection(dbcon.myConnection());
            cn.Open();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Overriden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void HubForm_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        // Private Methods
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 230;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "  " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            labelTitle.Text = childForm.Text;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show(); 
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            ThucPhamForm tpf = new ThucPhamForm();
            openChildForm(tpf);
        }

        private void btnBasket_Click(object sender, EventArgs e)
        {
            GioHang gio = new GioHang();
            openChildForm(gio);
        }

        private void btnElectronic_Click(object sender, EventArgs e)
        {
            TBCongNghe tb = new TBCongNghe();
            openChildForm(tb);
        }

        private void btnFashion_Click(object sender, EventArgs e)
        {
            ThoiTrangForm ttf = new ThoiTrangForm();
            openChildForm(ttf);
        }

        private void btnLife_Click(object sender, EventArgs e)
        {
            DoiSongForm dsf = new DoiSongForm();
            openChildForm(dsf);
        }

        private void btnSport_Click(object sender, EventArgs e)
        {
            TheThaoForm thethao = new TheThaoForm();
            openChildForm(thethao);
        }

        private void HubForm_Load(object sender, EventArgs e)
        {
            HomeForm f = new HomeForm();
            openChildForm(f);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm f = new HomeForm();
            openChildForm(f);
        }

        private void btnExitAlt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
