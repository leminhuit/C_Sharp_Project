using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holiday2020.Buoi7
{
    public partial class frmPaint : Form
    {
        public Bitmap bitmap;
        public Point pointStart, pointEnd;
        public Graphics graphic;
        public bool paint = false;
        public Point temp1, temp2, temp3;
        public Pen p;
        public Rectangle rect;
        public int index;
        public int sX, sY;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            p = new Pen(clrdgPicker.Color, (float)nmrPenWidth.Value);
            if (paint)
            {
                if (rdbLine.Checked)
                    g.DrawLine(p, pointStart, pointEnd);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            p = new Pen(clrdgPicker.Color, (float)nmrPenWidth.Value);
            if (rdbLine.Checked)
                graphic.DrawLine(p, pointStart, pointEnd);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            pointStart = e.Location;
        }

        public frmPaint()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphic = Graphics.FromImage(bitmap);
            graphic.Clear(Color.White);
            pictureBox1.Image = bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clrdgPicker.ShowDialog();
            button1.BackColor = clrdgPicker.Color;
        }


    }
}
