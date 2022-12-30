
namespace Holiday2020.Buoi3
{
    partial class HotelForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelForm));
            this.lstViewHotelRooms = new System.Windows.Forms.ListView();
            this.gBoxThongTinPhong = new System.Windows.Forms.GroupBox();
            this.gBoxChucNang = new System.Windows.Forms.GroupBox();
            this.label_MaPhong = new System.Windows.Forms.Label();
            this.label_LoaiPhong = new System.Windows.Forms.Label();
            this.label_GiaPhong = new System.Windows.Forms.Label();
            this.label_TinhTrangPhong = new System.Windows.Forms.Label();
            this.label_SoNgayO = new System.Windows.Forms.Label();
            this.txtBox_MaPhong = new System.Windows.Forms.TextBox();
            this.txtBox_GiaPhong = new System.Windows.Forms.TextBox();
            this.cboBox_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.radButton_Trong = new System.Windows.Forms.RadioButton();
            this.radButton_Day = new System.Windows.Forms.RadioButton();
            this.numUpDown_SoNgayO = new System.Windows.Forms.NumericUpDown();
            this.pBox_HotelPic = new System.Windows.Forms.PictureBox();
            this.btn_ThemPhong = new System.Windows.Forms.Button();
            this.btn_DatPhong = new System.Windows.Forms.Button();
            this.btn_HuyPhong = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.imgList_LoaiPhong = new System.Windows.Forms.ImageList(this.components);
            this.gBoxThongTinPhong.SuspendLayout();
            this.gBoxChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_SoNgayO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_HotelPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lstViewHotelRooms
            // 
            this.lstViewHotelRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstViewHotelRooms.HideSelection = false;
            this.lstViewHotelRooms.Location = new System.Drawing.Point(383, 12);
            this.lstViewHotelRooms.Name = "lstViewHotelRooms";
            this.lstViewHotelRooms.Size = new System.Drawing.Size(882, 695);
            this.lstViewHotelRooms.TabIndex = 0;
            this.lstViewHotelRooms.UseCompatibleStateImageBehavior = false;
            // 
            // gBoxThongTinPhong
            // 
            this.gBoxThongTinPhong.BackColor = System.Drawing.Color.Moccasin;
            this.gBoxThongTinPhong.Controls.Add(this.numUpDown_SoNgayO);
            this.gBoxThongTinPhong.Controls.Add(this.radButton_Day);
            this.gBoxThongTinPhong.Controls.Add(this.radButton_Trong);
            this.gBoxThongTinPhong.Controls.Add(this.cboBox_LoaiPhong);
            this.gBoxThongTinPhong.Controls.Add(this.txtBox_GiaPhong);
            this.gBoxThongTinPhong.Controls.Add(this.txtBox_MaPhong);
            this.gBoxThongTinPhong.Controls.Add(this.label_SoNgayO);
            this.gBoxThongTinPhong.Controls.Add(this.label_TinhTrangPhong);
            this.gBoxThongTinPhong.Controls.Add(this.label_GiaPhong);
            this.gBoxThongTinPhong.Controls.Add(this.label_LoaiPhong);
            this.gBoxThongTinPhong.Controls.Add(this.label_MaPhong);
            this.gBoxThongTinPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxThongTinPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(245)))));
            this.gBoxThongTinPhong.Location = new System.Drawing.Point(12, 12);
            this.gBoxThongTinPhong.Name = "gBoxThongTinPhong";
            this.gBoxThongTinPhong.Size = new System.Drawing.Size(365, 283);
            this.gBoxThongTinPhong.TabIndex = 1;
            this.gBoxThongTinPhong.TabStop = false;
            this.gBoxThongTinPhong.Text = "Thông tin phòng";
            // 
            // gBoxChucNang
            // 
            this.gBoxChucNang.BackColor = System.Drawing.Color.White;
            this.gBoxChucNang.Controls.Add(this.btn_ThanhToan);
            this.gBoxChucNang.Controls.Add(this.btn_HuyPhong);
            this.gBoxChucNang.Controls.Add(this.btn_DatPhong);
            this.gBoxChucNang.Controls.Add(this.btn_ThemPhong);
            this.gBoxChucNang.Controls.Add(this.pBox_HotelPic);
            this.gBoxChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxChucNang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(245)))));
            this.gBoxChucNang.Location = new System.Drawing.Point(12, 301);
            this.gBoxChucNang.Name = "gBoxChucNang";
            this.gBoxChucNang.Size = new System.Drawing.Size(365, 233);
            this.gBoxChucNang.TabIndex = 2;
            this.gBoxChucNang.TabStop = false;
            this.gBoxChucNang.Text = "Chức năng";
            // 
            // label_MaPhong
            // 
            this.label_MaPhong.AutoSize = true;
            this.label_MaPhong.ForeColor = System.Drawing.Color.Black;
            this.label_MaPhong.Location = new System.Drawing.Point(7, 51);
            this.label_MaPhong.Name = "label_MaPhong";
            this.label_MaPhong.Size = new System.Drawing.Size(121, 25);
            this.label_MaPhong.TabIndex = 0;
            this.label_MaPhong.Text = "Mã phòng :";
            // 
            // label_LoaiPhong
            // 
            this.label_LoaiPhong.AutoSize = true;
            this.label_LoaiPhong.ForeColor = System.Drawing.Color.Black;
            this.label_LoaiPhong.Location = new System.Drawing.Point(7, 93);
            this.label_LoaiPhong.Name = "label_LoaiPhong";
            this.label_LoaiPhong.Size = new System.Drawing.Size(132, 25);
            this.label_LoaiPhong.TabIndex = 1;
            this.label_LoaiPhong.Text = "Loại phòng :";
            // 
            // label_GiaPhong
            // 
            this.label_GiaPhong.AutoSize = true;
            this.label_GiaPhong.ForeColor = System.Drawing.Color.Black;
            this.label_GiaPhong.Location = new System.Drawing.Point(7, 135);
            this.label_GiaPhong.Name = "label_GiaPhong";
            this.label_GiaPhong.Size = new System.Drawing.Size(130, 25);
            this.label_GiaPhong.TabIndex = 2;
            this.label_GiaPhong.Text = "Giá phòng : ";
            // 
            // label_TinhTrangPhong
            // 
            this.label_TinhTrangPhong.AutoSize = true;
            this.label_TinhTrangPhong.ForeColor = System.Drawing.Color.Black;
            this.label_TinhTrangPhong.Location = new System.Drawing.Point(7, 177);
            this.label_TinhTrangPhong.Name = "label_TinhTrangPhong";
            this.label_TinhTrangPhong.Size = new System.Drawing.Size(189, 25);
            this.label_TinhTrangPhong.TabIndex = 3;
            this.label_TinhTrangPhong.Text = "Tình trạng phòng :";
            // 
            // label_SoNgayO
            // 
            this.label_SoNgayO.AutoSize = true;
            this.label_SoNgayO.ForeColor = System.Drawing.Color.Black;
            this.label_SoNgayO.Location = new System.Drawing.Point(7, 246);
            this.label_SoNgayO.Name = "label_SoNgayO";
            this.label_SoNgayO.Size = new System.Drawing.Size(123, 25);
            this.label_SoNgayO.TabIndex = 4;
            this.label_SoNgayO.Text = "Số ngày ở :";
            // 
            // txtBox_MaPhong
            // 
            this.txtBox_MaPhong.Location = new System.Drawing.Point(212, 48);
            this.txtBox_MaPhong.Name = "txtBox_MaPhong";
            this.txtBox_MaPhong.Size = new System.Drawing.Size(147, 30);
            this.txtBox_MaPhong.TabIndex = 5;
            this.txtBox_MaPhong.Text = "A1";
            // 
            // txtBox_GiaPhong
            // 
            this.txtBox_GiaPhong.Location = new System.Drawing.Point(212, 132);
            this.txtBox_GiaPhong.Name = "txtBox_GiaPhong";
            this.txtBox_GiaPhong.Size = new System.Drawing.Size(147, 30);
            this.txtBox_GiaPhong.TabIndex = 6;
            this.txtBox_GiaPhong.Text = "150000";
            // 
            // cboBox_LoaiPhong
            // 
            this.cboBox_LoaiPhong.FormattingEnabled = true;
            this.cboBox_LoaiPhong.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cboBox_LoaiPhong.Location = new System.Drawing.Point(212, 90);
            this.cboBox_LoaiPhong.Name = "cboBox_LoaiPhong";
            this.cboBox_LoaiPhong.Size = new System.Drawing.Size(147, 33);
            this.cboBox_LoaiPhong.TabIndex = 7;
            this.cboBox_LoaiPhong.Text = "A";
            // 
            // radButton_Trong
            // 
            this.radButton_Trong.AutoSize = true;
            this.radButton_Trong.Checked = true;
            this.radButton_Trong.Location = new System.Drawing.Point(212, 177);
            this.radButton_Trong.Name = "radButton_Trong";
            this.radButton_Trong.Size = new System.Drawing.Size(90, 29);
            this.radButton_Trong.TabIndex = 8;
            this.radButton_Trong.TabStop = true;
            this.radButton_Trong.Text = "Trống";
            this.radButton_Trong.UseVisualStyleBackColor = true;
            // 
            // radButton_Day
            // 
            this.radButton_Day.AutoSize = true;
            this.radButton_Day.Location = new System.Drawing.Point(212, 212);
            this.radButton_Day.Name = "radButton_Day";
            this.radButton_Day.Size = new System.Drawing.Size(71, 29);
            this.radButton_Day.TabIndex = 9;
            this.radButton_Day.Text = "Đầy";
            this.radButton_Day.UseVisualStyleBackColor = true;
            // 
            // numUpDown_SoNgayO
            // 
            this.numUpDown_SoNgayO.Location = new System.Drawing.Point(212, 248);
            this.numUpDown_SoNgayO.Name = "numUpDown_SoNgayO";
            this.numUpDown_SoNgayO.Size = new System.Drawing.Size(147, 30);
            this.numUpDown_SoNgayO.TabIndex = 10;
            // 
            // pBox_HotelPic
            // 
            this.pBox_HotelPic.BackColor = System.Drawing.Color.Transparent;
            this.pBox_HotelPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBox_HotelPic.BackgroundImage")));
            this.pBox_HotelPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBox_HotelPic.Location = new System.Drawing.Point(12, 42);
            this.pBox_HotelPic.Name = "pBox_HotelPic";
            this.pBox_HotelPic.Size = new System.Drawing.Size(170, 182);
            this.pBox_HotelPic.TabIndex = 0;
            this.pBox_HotelPic.TabStop = false;
            // 
            // btn_ThemPhong
            // 
            this.btn_ThemPhong.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_ThemPhong.ForeColor = System.Drawing.Color.White;
            this.btn_ThemPhong.Location = new System.Drawing.Point(188, 42);
            this.btn_ThemPhong.Name = "btn_ThemPhong";
            this.btn_ThemPhong.Size = new System.Drawing.Size(171, 41);
            this.btn_ThemPhong.TabIndex = 1;
            this.btn_ThemPhong.Text = "Thêm phòng";
            this.btn_ThemPhong.UseVisualStyleBackColor = false;
            this.btn_ThemPhong.Click += new System.EventHandler(this.btn_ThemPhong_Click);
            // 
            // btn_DatPhong
            // 
            this.btn_DatPhong.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_DatPhong.ForeColor = System.Drawing.Color.White;
            this.btn_DatPhong.Location = new System.Drawing.Point(188, 89);
            this.btn_DatPhong.Name = "btn_DatPhong";
            this.btn_DatPhong.Size = new System.Drawing.Size(171, 41);
            this.btn_DatPhong.TabIndex = 2;
            this.btn_DatPhong.Text = "Đặt phòng";
            this.btn_DatPhong.UseVisualStyleBackColor = false;
            // 
            // btn_HuyPhong
            // 
            this.btn_HuyPhong.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_HuyPhong.ForeColor = System.Drawing.Color.White;
            this.btn_HuyPhong.Location = new System.Drawing.Point(188, 136);
            this.btn_HuyPhong.Name = "btn_HuyPhong";
            this.btn_HuyPhong.Size = new System.Drawing.Size(171, 41);
            this.btn_HuyPhong.TabIndex = 3;
            this.btn_HuyPhong.Text = "Hủy phòng";
            this.btn_HuyPhong.UseVisualStyleBackColor = false;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_ThanhToan.Location = new System.Drawing.Point(188, 183);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(171, 41);
            this.btn_ThanhToan.TabIndex = 4;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            // 
            // imgList_LoaiPhong
            // 
            this.imgList_LoaiPhong.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_LoaiPhong.ImageStream")));
            this.imgList_LoaiPhong.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_LoaiPhong.Images.SetKeyName(0, "51919_home_house_icon.png");
            this.imgList_LoaiPhong.Images.SetKeyName(1, "37331_home_house_icon.png");
            this.imgList_LoaiPhong.Images.SetKeyName(2, "18688_home_house_icon.png");
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(134)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1277, 719);
            this.Controls.Add(this.gBoxChucNang);
            this.Controls.Add(this.gBoxThongTinPhong);
            this.Controls.Add(this.lstViewHotelRooms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HotelForm";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.HotelForm_Load);
            this.gBoxThongTinPhong.ResumeLayout(false);
            this.gBoxThongTinPhong.PerformLayout();
            this.gBoxChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_SoNgayO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_HotelPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstViewHotelRooms;
        private System.Windows.Forms.GroupBox gBoxThongTinPhong;
        private System.Windows.Forms.NumericUpDown numUpDown_SoNgayO;
        private System.Windows.Forms.RadioButton radButton_Day;
        private System.Windows.Forms.RadioButton radButton_Trong;
        private System.Windows.Forms.ComboBox cboBox_LoaiPhong;
        private System.Windows.Forms.TextBox txtBox_GiaPhong;
        private System.Windows.Forms.TextBox txtBox_MaPhong;
        private System.Windows.Forms.Label label_SoNgayO;
        private System.Windows.Forms.Label label_TinhTrangPhong;
        private System.Windows.Forms.Label label_GiaPhong;
        private System.Windows.Forms.Label label_LoaiPhong;
        private System.Windows.Forms.Label label_MaPhong;
        private System.Windows.Forms.GroupBox gBoxChucNang;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_HuyPhong;
        private System.Windows.Forms.Button btn_DatPhong;
        private System.Windows.Forms.Button btn_ThemPhong;
        private System.Windows.Forms.PictureBox pBox_HotelPic;
        private System.Windows.Forms.ImageList imgList_LoaiPhong;
    }
}