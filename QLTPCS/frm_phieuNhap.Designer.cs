
namespace QLTPCS
{
    partial class frm_phieuNhap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_timKiemPhieuNhap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_phieuNhap = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maPhieuNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tongTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ngayNhap = new System.Windows.Forms.TextBox();
            this.cmb_maNhaPhanPhoi = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_maNhanVien = new System.Windows.Forms.ComboBox();
            this.btn_resetPhieuNhap = new System.Windows.Forms.Button();
            this.btn_xoaPhieuNhap = new System.Windows.Forms.Button();
            this.btn_suaPhieuNhap = new System.Windows.Forms.Button();
            this.btn_themPhieuNhap = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_maPhieuNhap = new System.Windows.Forms.ComboBox();
            this.btn_resetCTPhieuNhap = new System.Windows.Forms.Button();
            this.btn_xoaCTPhieuNhap = new System.Windows.Forms.Button();
            this.btn_suaCTPhieuNhap = new System.Windows.Forms.Button();
            this.btn_themCTPhieuNhap = new System.Windows.Forms.Button();
            this.cmb_sanPham = new System.Windows.Forms.ComboBox();
            this.txt_donGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_maCTPhieuNhap = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_timKiemCTPhieuNhap = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgv_ctPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btn_report = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuNhap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ctPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_timKiemPhieuNhap);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dgv_phieuNhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 255);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Nhập";
            // 
            // txt_timKiemPhieuNhap
            // 
            this.txt_timKiemPhieuNhap.Location = new System.Drawing.Point(196, 207);
            this.txt_timKiemPhieuNhap.Name = "txt_timKiemPhieuNhap";
            this.txt_timKiemPhieuNhap.Size = new System.Drawing.Size(268, 20);
            this.txt_timKiemPhieuNhap.TabIndex = 10;
            this.txt_timKiemPhieuNhap.TextChanged += new System.EventHandler(this.txt_timKiemPhieuNhap_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tìm kiếm:";
            // 
            // dgv_phieuNhap
            // 
            this.dgv_phieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieuNhap.Location = new System.Drawing.Point(6, 19);
            this.dgv_phieuNhap.Name = "dgv_phieuNhap";
            this.dgv_phieuNhap.Size = new System.Drawing.Size(588, 168);
            this.dgv_phieuNhap.TabIndex = 0;
            this.dgv_phieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phieuNhap_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập:";
            // 
            // txt_maPhieuNhap
            // 
            this.txt_maPhieuNhap.Location = new System.Drawing.Point(107, 17);
            this.txt_maPhieuNhap.Name = "txt_maPhieuNhap";
            this.txt_maPhieuNhap.Size = new System.Drawing.Size(151, 20);
            this.txt_maPhieuNhap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhà phân phối:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng tiền:";
            // 
            // txt_tongTien
            // 
            this.txt_tongTien.Enabled = false;
            this.txt_tongTien.Location = new System.Drawing.Point(107, 120);
            this.txt_tongTien.Name = "txt_tongTien";
            this.txt_tongTien.Size = new System.Drawing.Size(151, 20);
            this.txt_tongTien.TabIndex = 7;
            this.txt_tongTien.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày nhập:";
            // 
            // txt_ngayNhap
            // 
            this.txt_ngayNhap.Location = new System.Drawing.Point(107, 154);
            this.txt_ngayNhap.Name = "txt_ngayNhap";
            this.txt_ngayNhap.Size = new System.Drawing.Size(151, 20);
            this.txt_ngayNhap.TabIndex = 9;
            // 
            // cmb_maNhaPhanPhoi
            // 
            this.cmb_maNhaPhanPhoi.FormattingEnabled = true;
            this.cmb_maNhaPhanPhoi.Location = new System.Drawing.Point(107, 87);
            this.cmb_maNhaPhanPhoi.Name = "cmb_maNhaPhanPhoi";
            this.cmb_maNhaPhanPhoi.Size = new System.Drawing.Size(151, 21);
            this.cmb_maNhaPhanPhoi.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_maNhanVien);
            this.groupBox2.Controls.Add(this.btn_resetPhieuNhap);
            this.groupBox2.Controls.Add(this.btn_xoaPhieuNhap);
            this.groupBox2.Controls.Add(this.btn_suaPhieuNhap);
            this.groupBox2.Controls.Add(this.btn_themPhieuNhap);
            this.groupBox2.Controls.Add(this.cmb_maNhaPhanPhoi);
            this.groupBox2.Controls.Add(this.txt_ngayNhap);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_tongTien);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_maPhieuNhap);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(618, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 255);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // cmb_maNhanVien
            // 
            this.cmb_maNhanVien.FormattingEnabled = true;
            this.cmb_maNhanVien.Location = new System.Drawing.Point(107, 52);
            this.cmb_maNhanVien.Name = "cmb_maNhanVien";
            this.cmb_maNhanVien.Size = new System.Drawing.Size(151, 21);
            this.cmb_maNhanVien.TabIndex = 3;
            // 
            // btn_resetPhieuNhap
            // 
            this.btn_resetPhieuNhap.Location = new System.Drawing.Point(268, 207);
            this.btn_resetPhieuNhap.Name = "btn_resetPhieuNhap";
            this.btn_resetPhieuNhap.Size = new System.Drawing.Size(55, 30);
            this.btn_resetPhieuNhap.TabIndex = 13;
            this.btn_resetPhieuNhap.Text = "Reset";
            this.btn_resetPhieuNhap.UseVisualStyleBackColor = true;
            this.btn_resetPhieuNhap.Click += new System.EventHandler(this.btn_resetPhieuNhap_Click);
            // 
            // btn_xoaPhieuNhap
            // 
            this.btn_xoaPhieuNhap.Location = new System.Drawing.Point(191, 207);
            this.btn_xoaPhieuNhap.Name = "btn_xoaPhieuNhap";
            this.btn_xoaPhieuNhap.Size = new System.Drawing.Size(55, 30);
            this.btn_xoaPhieuNhap.TabIndex = 12;
            this.btn_xoaPhieuNhap.Text = "Xóa";
            this.btn_xoaPhieuNhap.UseVisualStyleBackColor = true;
            this.btn_xoaPhieuNhap.Click += new System.EventHandler(this.btn_xoaPhieuNhap_Click);
            // 
            // btn_suaPhieuNhap
            // 
            this.btn_suaPhieuNhap.Location = new System.Drawing.Point(107, 208);
            this.btn_suaPhieuNhap.Name = "btn_suaPhieuNhap";
            this.btn_suaPhieuNhap.Size = new System.Drawing.Size(55, 30);
            this.btn_suaPhieuNhap.TabIndex = 11;
            this.btn_suaPhieuNhap.Text = "Sửa";
            this.btn_suaPhieuNhap.UseVisualStyleBackColor = true;
            this.btn_suaPhieuNhap.Click += new System.EventHandler(this.btn_suaPhieuNhap_Click);
            // 
            // btn_themPhieuNhap
            // 
            this.btn_themPhieuNhap.Location = new System.Drawing.Point(15, 208);
            this.btn_themPhieuNhap.Name = "btn_themPhieuNhap";
            this.btn_themPhieuNhap.Size = new System.Drawing.Size(55, 30);
            this.btn_themPhieuNhap.TabIndex = 10;
            this.btn_themPhieuNhap.Text = "Thêm";
            this.btn_themPhieuNhap.UseVisualStyleBackColor = true;
            this.btn_themPhieuNhap.Click += new System.EventHandler(this.btn_themPhieuNhap_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmb_maPhieuNhap);
            this.groupBox3.Controls.Add(this.btn_resetCTPhieuNhap);
            this.groupBox3.Controls.Add(this.btn_xoaCTPhieuNhap);
            this.groupBox3.Controls.Add(this.btn_suaCTPhieuNhap);
            this.groupBox3.Controls.Add(this.btn_themCTPhieuNhap);
            this.groupBox3.Controls.Add(this.cmb_sanPham);
            this.groupBox3.Controls.Add(this.txt_donGia);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_soLuong);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_maCTPhieuNhap);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(618, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 255);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // cmb_maPhieuNhap
            // 
            this.cmb_maPhieuNhap.FormattingEnabled = true;
            this.cmb_maPhieuNhap.Location = new System.Drawing.Point(107, 52);
            this.cmb_maPhieuNhap.Name = "cmb_maPhieuNhap";
            this.cmb_maPhieuNhap.Size = new System.Drawing.Size(151, 21);
            this.cmb_maPhieuNhap.TabIndex = 3;
            // 
            // btn_resetCTPhieuNhap
            // 
            this.btn_resetCTPhieuNhap.Location = new System.Drawing.Point(268, 207);
            this.btn_resetCTPhieuNhap.Name = "btn_resetCTPhieuNhap";
            this.btn_resetCTPhieuNhap.Size = new System.Drawing.Size(55, 30);
            this.btn_resetCTPhieuNhap.TabIndex = 13;
            this.btn_resetCTPhieuNhap.Text = "Reset";
            this.btn_resetCTPhieuNhap.UseVisualStyleBackColor = true;
            this.btn_resetCTPhieuNhap.Click += new System.EventHandler(this.btn_resetCTPhieuNhap_Click);
            // 
            // btn_xoaCTPhieuNhap
            // 
            this.btn_xoaCTPhieuNhap.Location = new System.Drawing.Point(191, 207);
            this.btn_xoaCTPhieuNhap.Name = "btn_xoaCTPhieuNhap";
            this.btn_xoaCTPhieuNhap.Size = new System.Drawing.Size(55, 30);
            this.btn_xoaCTPhieuNhap.TabIndex = 12;
            this.btn_xoaCTPhieuNhap.Text = "Xóa";
            this.btn_xoaCTPhieuNhap.UseVisualStyleBackColor = true;
            this.btn_xoaCTPhieuNhap.Click += new System.EventHandler(this.btn_xoaCTPhieuNhap_Click);
            // 
            // btn_suaCTPhieuNhap
            // 
            this.btn_suaCTPhieuNhap.Location = new System.Drawing.Point(107, 208);
            this.btn_suaCTPhieuNhap.Name = "btn_suaCTPhieuNhap";
            this.btn_suaCTPhieuNhap.Size = new System.Drawing.Size(55, 30);
            this.btn_suaCTPhieuNhap.TabIndex = 11;
            this.btn_suaCTPhieuNhap.Text = "Sửa";
            this.btn_suaCTPhieuNhap.UseVisualStyleBackColor = true;
            this.btn_suaCTPhieuNhap.Click += new System.EventHandler(this.btn_suaCTPhieuNhap_Click);
            // 
            // btn_themCTPhieuNhap
            // 
            this.btn_themCTPhieuNhap.Location = new System.Drawing.Point(15, 208);
            this.btn_themCTPhieuNhap.Name = "btn_themCTPhieuNhap";
            this.btn_themCTPhieuNhap.Size = new System.Drawing.Size(55, 30);
            this.btn_themCTPhieuNhap.TabIndex = 10;
            this.btn_themCTPhieuNhap.Text = "Thêm";
            this.btn_themCTPhieuNhap.UseVisualStyleBackColor = true;
            this.btn_themCTPhieuNhap.Click += new System.EventHandler(this.btn_themCTPhieuNhap_Click);
            // 
            // cmb_sanPham
            // 
            this.cmb_sanPham.FormattingEnabled = true;
            this.cmb_sanPham.Location = new System.Drawing.Point(107, 87);
            this.cmb_sanPham.Name = "cmb_sanPham";
            this.cmb_sanPham.Size = new System.Drawing.Size(151, 21);
            this.cmb_sanPham.TabIndex = 5;
            // 
            // txt_donGia
            // 
            this.txt_donGia.Location = new System.Drawing.Point(107, 154);
            this.txt_donGia.Name = "txt_donGia";
            this.txt_donGia.Size = new System.Drawing.Size(151, 20);
            this.txt_donGia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đơn giá:";
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(107, 120);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(151, 20);
            this.txt_soLuong.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Sản Phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mã phiếu nhập:";
            // 
            // txt_maCTPhieuNhap
            // 
            this.txt_maCTPhieuNhap.Location = new System.Drawing.Point(107, 17);
            this.txt_maCTPhieuNhap.Name = "txt_maCTPhieuNhap";
            this.txt_maCTPhieuNhap.Size = new System.Drawing.Size(151, 20);
            this.txt_maCTPhieuNhap.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã CT phiếu nhập:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_timKiemCTPhieuNhap);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.dgv_ctPhieuNhap);
            this.groupBox4.Location = new System.Drawing.Point(12, 322);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(600, 255);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi Tiết Phiếu Nhập";
            // 
            // txt_timKiemCTPhieuNhap
            // 
            this.txt_timKiemCTPhieuNhap.Location = new System.Drawing.Point(196, 207);
            this.txt_timKiemCTPhieuNhap.Name = "txt_timKiemCTPhieuNhap";
            this.txt_timKiemCTPhieuNhap.Size = new System.Drawing.Size(268, 20);
            this.txt_timKiemCTPhieuNhap.TabIndex = 10;
            this.txt_timKiemCTPhieuNhap.TextChanged += new System.EventHandler(this.txt_timKiemCTPhieuNhap_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Tìm kiếm:";
            // 
            // dgv_ctPhieuNhap
            // 
            this.dgv_ctPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ctPhieuNhap.Location = new System.Drawing.Point(6, 19);
            this.dgv_ctPhieuNhap.Name = "dgv_ctPhieuNhap";
            this.dgv_ctPhieuNhap.Size = new System.Drawing.Size(588, 168);
            this.dgv_ctPhieuNhap.TabIndex = 0;
            this.dgv_ctPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ctPhieuNhap_CellClick);
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(850, 12);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(91, 43);
            this.btn_report.TabIndex = 16;
            this.btn_report.Text = "Báo Cáo";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // frm_phieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 594);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_phieuNhap";
            this.Text = "frm_phieuNhap";
            this.Load += new System.EventHandler(this.frm_phieuNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuNhap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ctPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_timKiemPhieuNhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_phieuNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maPhieuNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tongTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ngayNhap;
        private System.Windows.Forms.ComboBox cmb_maNhaPhanPhoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_themPhieuNhap;
        private System.Windows.Forms.Button btn_suaPhieuNhap;
        private System.Windows.Forms.Button btn_xoaPhieuNhap;
        private System.Windows.Forms.Button btn_resetPhieuNhap;
        private System.Windows.Forms.ComboBox cmb_maNhanVien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_maPhieuNhap;
        private System.Windows.Forms.Button btn_resetCTPhieuNhap;
        private System.Windows.Forms.Button btn_xoaCTPhieuNhap;
        private System.Windows.Forms.Button btn_suaCTPhieuNhap;
        private System.Windows.Forms.Button btn_themCTPhieuNhap;
        private System.Windows.Forms.ComboBox cmb_sanPham;
        private System.Windows.Forms.TextBox txt_donGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_maCTPhieuNhap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_timKiemCTPhieuNhap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgv_ctPhieuNhap;
        private System.Windows.Forms.Button btn_report;
    }
}