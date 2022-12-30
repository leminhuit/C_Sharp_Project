﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuaSamOnline.Modules.TheThaoProducts
{
    public partial class MayTapCoBung : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();

        public MayTapCoBung()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void AmountOfOrder_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pBoxAddToCart_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO tbGioHang(ProductId, ProductName, Price, Amount)VALUES(@ProductId, @ProductName, @Price, @Amount)", cn);
            cm.Parameters.AddWithValue("@ProductId", "S002");
            cm.Parameters.AddWithValue("@ProductName", "Máy tập cơ bụng");
            cm.Parameters.AddWithValue("@Price", "1249000"); ;
            cm.Parameters.AddWithValue("@Amount", AmountOfOrder.Text);
            cm.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Thêm vào giỏ hàng thành công", "Shopping Spree");
            this.Close();
        }
    }
}