using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            Graphics myGraphic = e.Graphics;

            Point p = new Point(0, 0);
            Point p2 = new Point(Width, Height);
            Size size = new Size(Width, Height);

            LinearGradientBrush myBrush = new LinearGradientBrush(p, p2, Color.Cyan, Color.White);

            Rectangle r1 = new Rectangle(p, size);

            myGraphic.FillEllipse(myBrush, r1);
        }

        private void txtUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Main main = new Main(txtUserName.Text);
                main.FormClosed += (s, args) => this.Close();
                main.ShowDialog();
            }
        }
    }
}
