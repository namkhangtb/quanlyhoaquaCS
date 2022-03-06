
namespace QLTPCS
{
    partial class frm_xemHoaDon
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
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nhanvien = new System.Windows.Forms.TextBox();
            this.txt_khachhang = new System.Windows.Forms.TextBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.txt_ngaylap = new System.Windows.Forms.TextBox();
            this.dgv_chitiet = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_tenFile = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Location = new System.Drawing.Point(12, 12);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.Size = new System.Drawing.Size(531, 179);
            this.dgv_hoadon.TabIndex = 0;
            this.dgv_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadon_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Lập";
            // 
            // txt_nhanvien
            // 
            this.txt_nhanvien.Location = new System.Drawing.Point(157, 236);
            this.txt_nhanvien.Name = "txt_nhanvien";
            this.txt_nhanvien.Size = new System.Drawing.Size(100, 20);
            this.txt_nhanvien.TabIndex = 5;
            // 
            // txt_khachhang
            // 
            this.txt_khachhang.Location = new System.Drawing.Point(157, 278);
            this.txt_khachhang.Name = "txt_khachhang";
            this.txt_khachhang.Size = new System.Drawing.Size(100, 20);
            this.txt_khachhang.TabIndex = 6;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(157, 321);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(100, 20);
            this.txt_tongtien.TabIndex = 7;
            // 
            // txt_ngaylap
            // 
            this.txt_ngaylap.Location = new System.Drawing.Point(157, 359);
            this.txt_ngaylap.Name = "txt_ngaylap";
            this.txt_ngaylap.Size = new System.Drawing.Size(100, 20);
            this.txt_ngaylap.TabIndex = 8;
            // 
            // dgv_chitiet
            // 
            this.dgv_chitiet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_chitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitiet.Location = new System.Drawing.Point(667, 12);
            this.dgv_chitiet.Name = "dgv_chitiet";
            this.dgv_chitiet.Size = new System.Drawing.Size(369, 179);
            this.dgv_chitiet.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Xuất excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_tenFile
            // 
            this.txt_tenFile.Location = new System.Drawing.Point(361, 236);
            this.txt_tenFile.Name = "txt_tenFile";
            this.txt_tenFile.Size = new System.Drawing.Size(100, 20);
            this.txt_tenFile.TabIndex = 11;
            // 
            // frm_xemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 444);
            this.Controls.Add(this.txt_tenFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_chitiet);
            this.Controls.Add(this.txt_ngaylap);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.txt_khachhang);
            this.Controls.Add(this.txt_nhanvien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_hoadon);
            this.Name = "frm_xemHoaDon";
            this.Text = "frm_xemHoaDon";
            this.Load += new System.EventHandler(this.frm_xemHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nhanvien;
        private System.Windows.Forms.TextBox txt_khachhang;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.TextBox txt_ngaylap;
        private System.Windows.Forms.DataGridView dgv_chitiet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_tenFile;
    }
}