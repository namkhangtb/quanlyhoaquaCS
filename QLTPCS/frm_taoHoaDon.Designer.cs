
namespace QLTPCS
{
    partial class frm_taoHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_loaisanpham = new System.Windows.Forms.ComboBox();
            this.btn_themsanpham = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_nhanvien = new System.Windows.Forms.ComboBox();
            this.cbb_khachhang = new System.Windows.Forms.ComboBox();
            this.txt_mahoadon = new System.Windows.Forms.TextBox();
            this.btn_xoasanpham = new System.Windows.Forms.Button();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_taohoadon = new System.Windows.Forms.Button();
            this.gdv_sptheoloai = new System.Windows.Forms.DataGridView();
            this.gdv_sptrongio = new System.Windows.Forms.DataGridView();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.lbngay = new System.Windows.Forms.Label();
            this.btn_kiemtra = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_sptheoloai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_sptrongio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hoá Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại sản phẩm";
            // 
            // cbb_loaisanpham
            // 
            this.cbb_loaisanpham.FormattingEnabled = true;
            this.cbb_loaisanpham.Location = new System.Drawing.Point(530, 13);
            this.cbb_loaisanpham.Name = "cbb_loaisanpham";
            this.cbb_loaisanpham.Size = new System.Drawing.Size(121, 21);
            this.cbb_loaisanpham.TabIndex = 4;
            this.cbb_loaisanpham.SelectedIndexChanged += new System.EventHandler(this.cbb_loaisanpham_SelectedIndexChanged);
            // 
            // btn_themsanpham
            // 
            this.btn_themsanpham.Location = new System.Drawing.Point(783, 172);
            this.btn_themsanpham.Name = "btn_themsanpham";
            this.btn_themsanpham.Size = new System.Drawing.Size(94, 23);
            this.btn_themsanpham.TabIndex = 6;
            this.btn_themsanpham.Text = "Thêm sản phẩm";
            this.btn_themsanpham.UseVisualStyleBackColor = true;
            this.btn_themsanpham.Click += new System.EventHandler(this.btn_themsanpham_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giỏ hàng";
            // 
            // cbb_nhanvien
            // 
            this.cbb_nhanvien.FormattingEnabled = true;
            this.cbb_nhanvien.Location = new System.Drawing.Point(178, 63);
            this.cbb_nhanvien.Name = "cbb_nhanvien";
            this.cbb_nhanvien.Size = new System.Drawing.Size(121, 21);
            this.cbb_nhanvien.TabIndex = 9;
            // 
            // cbb_khachhang
            // 
            this.cbb_khachhang.FormattingEnabled = true;
            this.cbb_khachhang.Location = new System.Drawing.Point(178, 109);
            this.cbb_khachhang.Name = "cbb_khachhang";
            this.cbb_khachhang.Size = new System.Drawing.Size(121, 21);
            this.cbb_khachhang.TabIndex = 10;
            // 
            // txt_mahoadon
            // 
            this.txt_mahoadon.Enabled = false;
            this.txt_mahoadon.Location = new System.Drawing.Point(178, 28);
            this.txt_mahoadon.Name = "txt_mahoadon";
            this.txt_mahoadon.Size = new System.Drawing.Size(121, 20);
            this.txt_mahoadon.TabIndex = 11;
            // 
            // btn_xoasanpham
            // 
            this.btn_xoasanpham.Location = new System.Drawing.Point(433, 472);
            this.btn_xoasanpham.Name = "btn_xoasanpham";
            this.btn_xoasanpham.Size = new System.Drawing.Size(92, 23);
            this.btn_xoasanpham.TabIndex = 12;
            this.btn_xoasanpham.Text = "Xoá sản phẩm";
            this.btn_xoasanpham.UseVisualStyleBackColor = true;
            this.btn_xoasanpham.Click += new System.EventHandler(this.btn_xoasanpham_Click);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(777, 393);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(100, 20);
            this.txt_tongtien.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(774, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tổng tiền";
            // 
            // btn_taohoadon
            // 
            this.btn_taohoadon.Location = new System.Drawing.Point(256, 216);
            this.btn_taohoadon.Name = "btn_taohoadon";
            this.btn_taohoadon.Size = new System.Drawing.Size(115, 23);
            this.btn_taohoadon.TabIndex = 15;
            this.btn_taohoadon.Text = "Thanh toán";
            this.btn_taohoadon.UseVisualStyleBackColor = true;
            this.btn_taohoadon.Click += new System.EventHandler(this.btn_taohoadon_Click);
            // 
            // gdv_sptheoloai
            // 
            this.gdv_sptheoloai.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gdv_sptheoloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_sptheoloai.Location = new System.Drawing.Point(433, 71);
            this.gdv_sptheoloai.Name = "gdv_sptheoloai";
            this.gdv_sptheoloai.Size = new System.Drawing.Size(335, 158);
            this.gdv_sptheoloai.TabIndex = 16;
            // 
            // gdv_sptrongio
            // 
            this.gdv_sptrongio.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gdv_sptrongio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_sptrongio.Location = new System.Drawing.Point(433, 280);
            this.gdv_sptrongio.Name = "gdv_sptrongio";
            this.gdv_sptrongio.Size = new System.Drawing.Size(335, 159);
            this.gdv_sptrongio.TabIndex = 17;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(777, 133);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(100, 20);
            this.txt_soluong.TabIndex = 18;
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(178, 155);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(180, 20);
            this.date1.TabIndex = 19;
            // 
            // lbngay
            // 
            this.lbngay.AutoSize = true;
            this.lbngay.Location = new System.Drawing.Point(82, 162);
            this.lbngay.Name = "lbngay";
            this.lbngay.Size = new System.Drawing.Size(32, 13);
            this.lbngay.TabIndex = 20;
            this.lbngay.Text = "Ngày";
            // 
            // btn_kiemtra
            // 
            this.btn_kiemtra.Location = new System.Drawing.Point(69, 216);
            this.btn_kiemtra.Name = "btn_kiemtra";
            this.btn_kiemtra.Size = new System.Drawing.Size(115, 23);
            this.btn_kiemtra.TabIndex = 21;
            this.btn_kiemtra.Text = "Thêm mới hoá đơn";
            this.btn_kiemtra.UseVisualStyleBackColor = true;
            this.btn_kiemtra.Click += new System.EventHandler(this.btn_kiemtra_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(774, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Số lượng";
            // 
            // frm_taoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 507);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_kiemtra);
            this.Controls.Add(this.lbngay);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.gdv_sptrongio);
            this.Controls.Add(this.gdv_sptheoloai);
            this.Controls.Add(this.btn_taohoadon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.btn_xoasanpham);
            this.Controls.Add(this.txt_mahoadon);
            this.Controls.Add(this.cbb_khachhang);
            this.Controls.Add(this.cbb_nhanvien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_themsanpham);
            this.Controls.Add(this.cbb_loaisanpham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_taoHoaDon";
            this.Text = "frm_taoHoaDon";
            this.Load += new System.EventHandler(this.frm_taoHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_sptheoloai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_sptrongio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_loaisanpham;
        private System.Windows.Forms.Button btn_themsanpham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_nhanvien;
        private System.Windows.Forms.ComboBox cbb_khachhang;
        private System.Windows.Forms.TextBox txt_mahoadon;
        private System.Windows.Forms.Button btn_xoasanpham;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_taohoadon;
        private System.Windows.Forms.DataGridView gdv_sptheoloai;
        private System.Windows.Forms.DataGridView gdv_sptrongio;
        public System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label lbngay;
        private System.Windows.Forms.Button btn_kiemtra;
        private System.Windows.Forms.Label label7;
    }
}