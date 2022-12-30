using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuaSamOnline.Modules.TBCongNgheProducts
{
    public partial class SacDuPhong : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();

        public SacDuPhong()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void pBoxAddToCart_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO tbGioHang(ProductId, ProductName, Price, Amount)VALUES(@ProductId, @ProductName, @Price, @Amount)", cn);
            cm.Parameters.AddWithValue("@ProductId", "E003");
            cm.Parameters.AddWithValue("@ProductName", "Sạc dự phòng chính hãng");
            cm.Parameters.AddWithValue("@Price", "269000"); ;
            cm.Parameters.AddWithValue("@Amount", AmountOfOrder.Text);
            cm.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Thêm vào giỏ hàng thành công", "Shopping Spree");
            this.Close();
        }
    }
}
