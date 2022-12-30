
namespace LichChuyenBay
{
    partial class DanhSachChuyenBay
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
            this.dgvDSChuyenBay = new System.Windows.Forms.DataGridView();
            this.MaChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanBayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanBayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGheDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChuyenBay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSChuyenBay
            // 
            this.dgvDSChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSChuyenBay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuyenBay,
            this.SanBayDi,
            this.SanBayDen,
            this.ThoiGianBay,
            this.SoGheDat,
            this.TongSoGhe});
            this.dgvDSChuyenBay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSChuyenBay.Location = new System.Drawing.Point(0, 0);
            this.dgvDSChuyenBay.Name = "dgvDSChuyenBay";
            this.dgvDSChuyenBay.RowHeadersWidth = 51;
            this.dgvDSChuyenBay.RowTemplate.Height = 24;
            this.dgvDSChuyenBay.Size = new System.Drawing.Size(982, 553);
            this.dgvDSChuyenBay.TabIndex = 0;
            // 
            // MaChuyenBay
            // 
            this.MaChuyenBay.HeaderText = "Mã chuyến bay";
            this.MaChuyenBay.MinimumWidth = 6;
            this.MaChuyenBay.Name = "MaChuyenBay";
            this.MaChuyenBay.Width = 125;
            // 
            // SanBayDi
            // 
            this.SanBayDi.HeaderText = "Sân bay đi";
            this.SanBayDi.MinimumWidth = 6;
            this.SanBayDi.Name = "SanBayDi";
            this.SanBayDi.Width = 125;
            // 
            // SanBayDen
            // 
            this.SanBayDen.HeaderText = "Sân bay đến";
            this.SanBayDen.MinimumWidth = 6;
            this.SanBayDen.Name = "SanBayDen";
            this.SanBayDen.Width = 125;
            // 
            // ThoiGianBay
            // 
            this.ThoiGianBay.HeaderText = "Thời gian bay";
            this.ThoiGianBay.MinimumWidth = 6;
            this.ThoiGianBay.Name = "ThoiGianBay";
            this.ThoiGianBay.Width = 125;
            // 
            // SoGheDat
            // 
            this.SoGheDat.HeaderText = "Số ghế đặt";
            this.SoGheDat.MinimumWidth = 6;
            this.SoGheDat.Name = "SoGheDat";
            this.SoGheDat.Width = 125;
            // 
            // TongSoGhe
            // 
            this.TongSoGhe.HeaderText = "Tổng số ghế";
            this.TongSoGhe.MinimumWidth = 6;
            this.TongSoGhe.Name = "TongSoGhe";
            this.TongSoGhe.Width = 125;
            // 
            // DanhSachChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dgvDSChuyenBay);
            this.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DanhSachChuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách chuyến bay";
            this.Load += new System.EventHandler(this.DanhSachChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChuyenBay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanBayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanBayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGheDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoGhe;
    }
}