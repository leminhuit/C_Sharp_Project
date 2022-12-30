
namespace Holiday2020
{
    partial class TaxiKmCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxiKmCalculator));
            this.BangGiaCuocGroupBox = new System.Windows.Forms.GroupBox();
            this.GiaKmThu26Value = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GiaKmTiepTheoValue = new System.Windows.Forms.Label();
            this.GiaKmTiepTheoLabel = new System.Windows.Forms.Label();
            this.GiaMoCuaValue = new System.Windows.Forms.Label();
            this.GiaMoCuaLabel = new System.Windows.Forms.Label();
            this.BangGiaCuocLabel = new System.Windows.Forms.Label();
            this.SoKmLabel = new System.Windows.Forms.Label();
            this.KhuyenMaiLabel = new System.Windows.Forms.Label();
            this.SoKmValue = new System.Windows.Forms.TextBox();
            this.KhuyenMaiValue = new System.Windows.Forms.TextBox();
            this.ThanhToanLabel = new System.Windows.Forms.Label();
            this.ThanhToanValue = new System.Windows.Forms.TextBox();
            this.VndLabel = new System.Windows.Forms.Label();
            this.BillPictureBox = new System.Windows.Forms.PictureBox();
            this.BangGiaCuocGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BangGiaCuocGroupBox
            // 
            this.BangGiaCuocGroupBox.BackColor = System.Drawing.Color.Green;
            this.BangGiaCuocGroupBox.Controls.Add(this.GiaKmThu26Value);
            this.BangGiaCuocGroupBox.Controls.Add(this.label1);
            this.BangGiaCuocGroupBox.Controls.Add(this.GiaKmTiepTheoValue);
            this.BangGiaCuocGroupBox.Controls.Add(this.GiaKmTiepTheoLabel);
            this.BangGiaCuocGroupBox.Controls.Add(this.GiaMoCuaValue);
            this.BangGiaCuocGroupBox.Controls.Add(this.GiaMoCuaLabel);
            this.BangGiaCuocGroupBox.Controls.Add(this.BangGiaCuocLabel);
            this.BangGiaCuocGroupBox.Location = new System.Drawing.Point(2, 2);
            this.BangGiaCuocGroupBox.Name = "BangGiaCuocGroupBox";
            this.BangGiaCuocGroupBox.Size = new System.Drawing.Size(632, 310);
            this.BangGiaCuocGroupBox.TabIndex = 0;
            this.BangGiaCuocGroupBox.TabStop = false;
            this.BangGiaCuocGroupBox.Enter += new System.EventHandler(this.BangGiaCuocGroupBox_Enter);
            // 
            // GiaKmThu26Value
            // 
            this.GiaKmThu26Value.AutoSize = true;
            this.GiaKmThu26Value.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaKmThu26Value.ForeColor = System.Drawing.Color.White;
            this.GiaKmThu26Value.Location = new System.Drawing.Point(423, 187);
            this.GiaKmThu26Value.Name = "GiaKmThu26Value";
            this.GiaKmThu26Value.Size = new System.Drawing.Size(161, 32);
            this.GiaKmThu26Value.TabIndex = 6;
            this.GiaKmThu26Value.Text = "12.000 / 1 km";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giá từ km thứ 26:";
            // 
            // GiaKmTiepTheoValue
            // 
            this.GiaKmTiepTheoValue.AutoSize = true;
            this.GiaKmTiepTheoValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaKmTiepTheoValue.ForeColor = System.Drawing.Color.White;
            this.GiaKmTiepTheoValue.Location = new System.Drawing.Point(423, 145);
            this.GiaKmTiepTheoValue.Name = "GiaKmTiepTheoValue";
            this.GiaKmTiepTheoValue.Size = new System.Drawing.Size(161, 32);
            this.GiaKmTiepTheoValue.TabIndex = 4;
            this.GiaKmTiepTheoValue.Text = "16.000 / 1 km";
            // 
            // GiaKmTiepTheoLabel
            // 
            this.GiaKmTiepTheoLabel.AutoSize = true;
            this.GiaKmTiepTheoLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaKmTiepTheoLabel.ForeColor = System.Drawing.Color.White;
            this.GiaKmTiepTheoLabel.Location = new System.Drawing.Point(45, 145);
            this.GiaKmTiepTheoLabel.Name = "GiaKmTiepTheoLabel";
            this.GiaKmTiepTheoLabel.Size = new System.Drawing.Size(340, 32);
            this.GiaKmTiepTheoLabel.TabIndex = 3;
            this.GiaKmTiepTheoLabel.Text = "Giá km tiếp theo (dưới 26 km):";
            // 
            // GiaMoCuaValue
            // 
            this.GiaMoCuaValue.AutoSize = true;
            this.GiaMoCuaValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaMoCuaValue.ForeColor = System.Drawing.Color.White;
            this.GiaMoCuaValue.Location = new System.Drawing.Point(423, 103);
            this.GiaMoCuaValue.Name = "GiaMoCuaValue";
            this.GiaMoCuaValue.Size = new System.Drawing.Size(161, 32);
            this.GiaMoCuaValue.TabIndex = 2;
            this.GiaMoCuaValue.Text = "14.000 / 1 km";
            // 
            // GiaMoCuaLabel
            // 
            this.GiaMoCuaLabel.AutoSize = true;
            this.GiaMoCuaLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaMoCuaLabel.ForeColor = System.Drawing.Color.White;
            this.GiaMoCuaLabel.Location = new System.Drawing.Point(45, 103);
            this.GiaMoCuaLabel.Name = "GiaMoCuaLabel";
            this.GiaMoCuaLabel.Size = new System.Drawing.Size(269, 32);
            this.GiaMoCuaLabel.TabIndex = 1;
            this.GiaMoCuaLabel.Text = "Giá mở cửa (dưới 5 km):";
            // 
            // BangGiaCuocLabel
            // 
            this.BangGiaCuocLabel.AutoSize = true;
            this.BangGiaCuocLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BangGiaCuocLabel.ForeColor = System.Drawing.Color.White;
            this.BangGiaCuocLabel.Location = new System.Drawing.Point(172, 42);
            this.BangGiaCuocLabel.Name = "BangGiaCuocLabel";
            this.BangGiaCuocLabel.Size = new System.Drawing.Size(281, 45);
            this.BangGiaCuocLabel.TabIndex = 0;
            this.BangGiaCuocLabel.Text = "BẢNG GIÁ CƯỚC";
            // 
            // SoKmLabel
            // 
            this.SoKmLabel.AutoSize = true;
            this.SoKmLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoKmLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SoKmLabel.Location = new System.Drawing.Point(80, 355);
            this.SoKmLabel.Name = "SoKmLabel";
            this.SoKmLabel.Size = new System.Drawing.Size(92, 32);
            this.SoKmLabel.TabIndex = 1;
            this.SoKmLabel.Text = "Số km:";
            // 
            // KhuyenMaiLabel
            // 
            this.KhuyenMaiLabel.AutoSize = true;
            this.KhuyenMaiLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhuyenMaiLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.KhuyenMaiLabel.Location = new System.Drawing.Point(80, 425);
            this.KhuyenMaiLabel.Name = "KhuyenMaiLabel";
            this.KhuyenMaiLabel.Size = new System.Drawing.Size(185, 32);
            this.KhuyenMaiLabel.TabIndex = 2;
            this.KhuyenMaiLabel.Text = "Khuyến mãi %:";
            // 
            // SoKmValue
            // 
            this.SoKmValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoKmValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SoKmValue.Location = new System.Drawing.Point(272, 352);
            this.SoKmValue.Name = "SoKmValue";
            this.SoKmValue.Size = new System.Drawing.Size(191, 38);
            this.SoKmValue.TabIndex = 3;
            this.SoKmValue.Text = "0";
            this.SoKmValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KhuyenMaiValue
            // 
            this.KhuyenMaiValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhuyenMaiValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.KhuyenMaiValue.Location = new System.Drawing.Point(272, 422);
            this.KhuyenMaiValue.Name = "KhuyenMaiValue";
            this.KhuyenMaiValue.Size = new System.Drawing.Size(191, 38);
            this.KhuyenMaiValue.TabIndex = 4;
            this.KhuyenMaiValue.Text = "0";
            this.KhuyenMaiValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ThanhToanLabel
            // 
            this.ThanhToanLabel.AutoSize = true;
            this.ThanhToanLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanhToanLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ThanhToanLabel.Location = new System.Drawing.Point(80, 527);
            this.ThanhToanLabel.Name = "ThanhToanLabel";
            this.ThanhToanLabel.Size = new System.Drawing.Size(151, 32);
            this.ThanhToanLabel.TabIndex = 5;
            this.ThanhToanLabel.Text = "Thanh toán:";
            // 
            // ThanhToanValue
            // 
            this.ThanhToanValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanhToanValue.ForeColor = System.Drawing.Color.Red;
            this.ThanhToanValue.Location = new System.Drawing.Point(272, 524);
            this.ThanhToanValue.Name = "ThanhToanValue";
            this.ThanhToanValue.ReadOnly = true;
            this.ThanhToanValue.Size = new System.Drawing.Size(191, 38);
            this.ThanhToanValue.TabIndex = 6;
            this.ThanhToanValue.Text = "0";
            this.ThanhToanValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThanhToanValue.TextChanged += new System.EventHandler(this.ThanhToanValue_TextChanged);
            // 
            // VndLabel
            // 
            this.VndLabel.AutoSize = true;
            this.VndLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VndLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.VndLabel.Location = new System.Drawing.Point(469, 527);
            this.VndLabel.Name = "VndLabel";
            this.VndLabel.Size = new System.Drawing.Size(68, 32);
            this.VndLabel.TabIndex = 7;
            this.VndLabel.Text = "VNĐ";
            // 
            // BillPictureBox
            // 
            this.BillPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BillPictureBox.BackgroundImage")));
            this.BillPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BillPictureBox.Location = new System.Drawing.Point(331, 466);
            this.BillPictureBox.Name = "BillPictureBox";
            this.BillPictureBox.Size = new System.Drawing.Size(70, 52);
            this.BillPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BillPictureBox.TabIndex = 8;
            this.BillPictureBox.TabStop = false;
            this.BillPictureBox.Click += new System.EventHandler(this.BillPictureBox_Click);
            // 
            // TaxiKmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(635, 595);
            this.Controls.Add(this.BillPictureBox);
            this.Controls.Add(this.VndLabel);
            this.Controls.Add(this.ThanhToanValue);
            this.Controls.Add(this.ThanhToanLabel);
            this.Controls.Add(this.KhuyenMaiValue);
            this.Controls.Add(this.SoKmValue);
            this.Controls.Add(this.KhuyenMaiLabel);
            this.Controls.Add(this.SoKmLabel);
            this.Controls.Add(this.BangGiaCuocGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TaxiKmCalculator";
            this.Text = "Taxi";
            this.BangGiaCuocGroupBox.ResumeLayout(false);
            this.BangGiaCuocGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BangGiaCuocGroupBox;
        private System.Windows.Forms.Label GiaKmThu26Value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GiaKmTiepTheoValue;
        private System.Windows.Forms.Label GiaKmTiepTheoLabel;
        private System.Windows.Forms.Label GiaMoCuaValue;
        private System.Windows.Forms.Label GiaMoCuaLabel;
        private System.Windows.Forms.Label BangGiaCuocLabel;
        private System.Windows.Forms.Label SoKmLabel;
        private System.Windows.Forms.Label KhuyenMaiLabel;
        private System.Windows.Forms.TextBox SoKmValue;
        private System.Windows.Forms.TextBox KhuyenMaiValue;
        private System.Windows.Forms.Label ThanhToanLabel;
        private System.Windows.Forms.TextBox ThanhToanValue;
        private System.Windows.Forms.Label VndLabel;
        private System.Windows.Forms.PictureBox BillPictureBox;
    }
}