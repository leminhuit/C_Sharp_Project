
namespace LichChuyenBay
{
    partial class PhieuDatCho
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
            this.txtBoxGiaTien = new System.Windows.Forms.TextBox();
            this.txtBoxDienThoai = new System.Windows.Forms.TextBox();
            this.txtBoxHanhKhach = new System.Windows.Forms.TextBox();
            this.txtBoxCMND = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboHangVe = new System.Windows.Forms.ComboBox();
            this.cboChuyenBay = new System.Windows.Forms.ComboBox();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxGiaTien
            // 
            this.txtBoxGiaTien.Location = new System.Drawing.Point(570, 154);
            this.txtBoxGiaTien.Name = "txtBoxGiaTien";
            this.txtBoxGiaTien.ReadOnly = true;
            this.txtBoxGiaTien.Size = new System.Drawing.Size(283, 29);
            this.txtBoxGiaTien.TabIndex = 23;
            // 
            // txtBoxDienThoai
            // 
            this.txtBoxDienThoai.Location = new System.Drawing.Point(570, 87);
            this.txtBoxDienThoai.Name = "txtBoxDienThoai";
            this.txtBoxDienThoai.Size = new System.Drawing.Size(283, 29);
            this.txtBoxDienThoai.TabIndex = 22;
            // 
            // txtBoxHanhKhach
            // 
            this.txtBoxHanhKhach.Location = new System.Drawing.Point(570, 25);
            this.txtBoxHanhKhach.Name = "txtBoxHanhKhach";
            this.txtBoxHanhKhach.Size = new System.Drawing.Size(283, 29);
            this.txtBoxHanhKhach.TabIndex = 21;
            // 
            // txtBoxCMND
            // 
            this.txtBoxCMND.Location = new System.Drawing.Point(142, 87);
            this.txtBoxCMND.Name = "txtBoxCMND";
            this.txtBoxCMND.Size = new System.Drawing.Size(283, 29);
            this.txtBoxCMND.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giá tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hành khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hạng vé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "CMND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chuyến bay";
            // 
            // cboHangVe
            // 
            this.cboHangVe.FormattingEnabled = true;
            this.cboHangVe.Location = new System.Drawing.Point(142, 154);
            this.cboHangVe.Name = "cboHangVe";
            this.cboHangVe.Size = new System.Drawing.Size(283, 30);
            this.cboHangVe.TabIndex = 24;
            this.cboHangVe.SelectedIndexChanged += new System.EventHandler(this.cboHangVe_SelectedIndexChanged);
            // 
            // cboChuyenBay
            // 
            this.cboChuyenBay.FormattingEnabled = true;
            this.cboChuyenBay.Location = new System.Drawing.Point(142, 24);
            this.cboChuyenBay.Name = "cboChuyenBay";
            this.cboChuyenBay.Size = new System.Drawing.Size(283, 30);
            this.cboChuyenBay.TabIndex = 25;
            this.cboChuyenBay.SelectedIndexChanged += new System.EventHandler(this.cboChuyenBay_SelectedIndexChanged);
            // 
            // btnDatVe
            // 
            this.btnDatVe.Location = new System.Drawing.Point(752, 199);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(101, 42);
            this.btnDatVe.TabIndex = 26;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // PhieuDatCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(882, 253);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.cboChuyenBay);
            this.Controls.Add(this.cboHangVe);
            this.Controls.Add(this.txtBoxGiaTien);
            this.Controls.Add(this.txtBoxDienThoai);
            this.Controls.Add(this.txtBoxHanhKhach);
            this.Controls.Add(this.txtBoxCMND);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhieuDatCho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu đặt chỗ";
            this.Load += new System.EventHandler(this.PhieuDatCho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxGiaTien;
        private System.Windows.Forms.TextBox txtBoxDienThoai;
        private System.Windows.Forms.TextBox txtBoxHanhKhach;
        private System.Windows.Forms.TextBox txtBoxCMND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboHangVe;
        private System.Windows.Forms.ComboBox cboChuyenBay;
        private System.Windows.Forms.Button btnDatVe;
    }
}