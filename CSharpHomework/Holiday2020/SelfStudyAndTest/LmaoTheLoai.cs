﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holiday2020.SelfStudyAndTest
{
    public partial class LmaoTheLoai : Form
    {
        public LmaoTheLoai()
        {
            InitializeComponent();
        }

        private void LmaoTheLoai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duLieu.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.duLieu.Sach);
            // TODO: This line of code loads data into the 'duLieu.TheLoai' table. You can move, or remove it, as needed.
            this.theLoaiTableAdapter.Fill(this.duLieu.TheLoai);

        }
    }
}
