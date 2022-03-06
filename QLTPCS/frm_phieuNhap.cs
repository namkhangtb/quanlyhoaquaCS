using QLTPCS.entity;
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

namespace QLTPCS
{
    public partial class frm_phieuNhap : Form
    {
        public frm_phieuNhap()
        {
            InitializeComponent();
        }
        private void clearPhieuNhap()
        {
            loadDataToTable_PhieuNhap();
            btn_themPhieuNhap.Enabled = true;
            txt_maPhieuNhap.Enabled = true;
            txt_maPhieuNhap.Text = "";
            txt_tongTien.Text = "0";
            txt_ngayNhap.Text = "";
            txt_timKiemPhieuNhap.Text = "";
        }
        private void loadDataToTable_PhieuNhap()
        {
            try
            {
                List<PhieuNhap> lst = new List<PhieuNhap>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "select * from PhieuNhap";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PhieuNhap obj = new PhieuNhap(dr);
                    lst.Add(obj);
                }
                conn.Close();
                dgv_phieuNhap.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void getcmbNhanVien()
        {
            try
            {
                List<NhanVien> lst = new List<NhanVien>();
                // Lấy dữ liệu Sản Phẩm từ Database về Lưu vào List
                // Bước 1: Khởi tạo kết nối
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "Select * from NhanVien";
                // Bước 4: Thực thi truy vấn\
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                // Bước 4.1: Đọc dữ liệu, lưu vào List
                while (dr.Read())
                {
                    NhanVien obj = new NhanVien(dr);
                    lst.Add(obj);
                }
                // Bước 5: Đóng kết nối
                conn.Close();
                // Hiển thị dữ liệu của Lst lên ComboBox
                cmb_maNhanVien.DataSource = lst;
                // Dữ liệu hiển thị trên ComboBox (DisplayMember), và giá trị tương ứng với dữ liệu đó (ValueMember)
                cmb_maNhanVien.DisplayMember = "TenNhanVien";
                cmb_maNhanVien.ValueMember = "MaNhanVien";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void getcmbNhaPhanPhoi()
        {
            try
            {
                List<NhaPhanPhoi> lst = new List<NhaPhanPhoi>();
                // Lấy dữ liệu Sản Phẩm từ Database về Lưu vào List
                // Bước 1: Khởi tạo kết nối
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "Select * from NhaPhanPhoi";
                // Bước 4: Thực thi truy vấn\
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                // Bước 4.1: Đọc dữ liệu, lưu vào List
                while (dr.Read())
                {
                    NhaPhanPhoi obj = new NhaPhanPhoi(dr);
                    lst.Add(obj);
                }
                // Bước 5: Đóng kết nối
                conn.Close();
                // Hiển thị dữ liệu của Lst lên ComboBox
                cmb_maNhaPhanPhoi.DataSource = lst;
                // Dữ liệu hiển thị trên ComboBox (DisplayMember), và giá trị tương ứng với dữ liệu đó (ValueMember)
                cmb_maNhaPhanPhoi.DisplayMember = "TenNhaPhanPhoi";
                cmb_maNhaPhanPhoi.ValueMember = "MaNhaPhanPhoi";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void findPhieuNhap()
        {
            try
            {
                List<PhieuNhap> lst = new List<PhieuNhap>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "select * from PhieuNhap where MaPhieuNhap like '%'+@tk+'%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", txt_timKiemPhieuNhap.Text));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PhieuNhap obj = new PhieuNhap(dr);
                    lst.Add(obj);
                }
                conn.Close();
                dgv_phieuNhap.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_phieuNhap_Load(object sender, EventArgs e)
        {
            loadDataToTable_PhieuNhap();
            getcmbNhanVien();
            getcmbNhaPhanPhoi();
            loadDataToTable_ChiTietPhieuNhap();
            getcmbMaPhieuNhap();
            getcmbSanPham();
        }

        private void dgv_phieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            btn_themPhieuNhap.Enabled = false;
            txt_maPhieuNhap.Enabled = false;
            txt_maPhieuNhap.Text = dgv_phieuNhap.Rows[idx].Cells["MaPhieuNhap"].Value.ToString();
            cmb_maNhanVien.SelectedValue = dgv_phieuNhap.Rows[idx].Cells["MaNhanVien"].Value.ToString();
            cmb_maNhaPhanPhoi.SelectedValue = dgv_phieuNhap.Rows[idx].Cells["MaNhaPhanPhoi"].Value.ToString();
            txt_tongTien.Text = dgv_phieuNhap.Rows[idx].Cells["TongTien"].Value.ToString();
            txt_ngayNhap.Text = dgv_phieuNhap.Rows[idx].Cells["NgayNhap"].Value.ToString();
        }

        private void btn_themPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "insert into PhieuNhap (MaPhieuNhap,MaNhanVien,MaNhaPhanPhoi,TongTien,NgayNhap) values (@ma_pn,@ma_nv,@ma_npp,@tongTien,@ngayNhap)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma_pn", txt_maPhieuNhap.Text));
                cmd.Parameters.Add(new SqlParameter("@ma_nv", cmb_maNhanVien.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@ma_npp", cmb_maNhaPhanPhoi.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@tongTien", txt_tongTien.Text));
                cmd.Parameters.Add(new SqlParameter("@ngayNhap", txt_ngayNhap.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm mới thành công !!!");
                loadDataToTable_PhieuNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_suaPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "update PhieuNhap set MaNhanVien = @ma_nv, MaNhaPhanPhoi = @ma_npp, TongTien = @tongTIen, NgayNhap = @ngayNhap where MaPhieuNhap = @ma_pn";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma_pn", txt_maPhieuNhap.Text));
                cmd.Parameters.Add(new SqlParameter("@ma_nv", cmb_maNhanVien.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@ma_npp", cmb_maNhaPhanPhoi.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@tongTien", txt_tongTien.Text));
                cmd.Parameters.Add(new SqlParameter("@ngayNhap", txt_ngayNhap.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sửa dữ liệu thành công !!!");
                loadDataToTable_PhieuNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xoaPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "delete from PhieuNhap where MaPhieuNhap = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", txt_maPhieuNhap.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa dữ liệu thành công !!!");
                clearPhieuNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_resetPhieuNhap_Click(object sender, EventArgs e)
        {
            clearPhieuNhap();
        }

        private void txt_timKiemPhieuNhap_TextChanged(object sender, EventArgs e)
        {
            findPhieuNhap();
        }



        private void clearCTPhieuNhap()
        {
            loadDataToTable_ChiTietPhieuNhap();
            btn_themCTPhieuNhap.Enabled = true;
            txt_maCTPhieuNhap.Enabled = true;
            txt_maCTPhieuNhap.Text = "";
            txt_soLuong.Text = "";
            txt_donGia.Text = "";
            txt_timKiemCTPhieuNhap.Text = "";
        }
        private void loadDataToTable_ChiTietPhieuNhap()
        {
            try
            {
                List<ChiTietPhieuNhap> lst = new List<ChiTietPhieuNhap>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "select * from ChiTietPhieuNhap";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ChiTietPhieuNhap obj = new ChiTietPhieuNhap(dr);
                    lst.Add(obj);
                }
                conn.Close();
                dgv_ctPhieuNhap.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void getcmbMaPhieuNhap()
        {
            try
            {
                List<PhieuNhap> lst = new List<PhieuNhap>();
                // Lấy dữ liệu Sản Phẩm từ Database về Lưu vào List
                // Bước 1: Khởi tạo kết nối
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "Select * from PhieuNhap";
                // Bước 4: Thực thi truy vấn\
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                // Bước 4.1: Đọc dữ liệu, lưu vào List
                while (dr.Read())
                {
                    PhieuNhap obj = new PhieuNhap(dr);
                    lst.Add(obj);
                }
                // Bước 5: Đóng kết nối
                conn.Close();
                // Hiển thị dữ liệu của Lst lên ComboBox
                cmb_maPhieuNhap.DataSource = lst;
                // Dữ liệu hiển thị trên ComboBox (DisplayMember), và giá trị tương ứng với dữ liệu đó (ValueMember)
                cmb_maPhieuNhap.DisplayMember = "MaPhieuNhap";
                cmb_maPhieuNhap.ValueMember = "MaPhieuNhap";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void getcmbSanPham()
        {
            try
            {
                List<SanPham> lst = new List<SanPham>();
                // Lấy dữ liệu Sản Phẩm từ Database về Lưu vào List
                // Bước 1: Khởi tạo kết nối
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "Select * from SanPham";
                // Bước 4: Thực thi truy vấn\
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                // Bước 4.1: Đọc dữ liệu, lưu vào List
                while (dr.Read())
                {
                    SanPham obj = new SanPham(dr);
                    lst.Add(obj);
                }
                // Bước 5: Đóng kết nối
                conn.Close();
                // Hiển thị dữ liệu của Lst lên ComboBox
                cmb_sanPham.DataSource = lst;
                // Dữ liệu hiển thị trên ComboBox (DisplayMember), và giá trị tương ứng với dữ liệu đó (ValueMember)
                cmb_sanPham.DisplayMember = "TenSanPham";
                cmb_sanPham.ValueMember = "MaSanPham";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void findCTPhieuNhap()
        {
            try
            {
                List<ChiTietPhieuNhap> lst = new List<ChiTietPhieuNhap>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "select * from ChiTietPhieuNhap where MaCTPN like '%'+@tk+'%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", txt_timKiemCTPhieuNhap.Text));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ChiTietPhieuNhap obj = new ChiTietPhieuNhap(dr);
                    lst.Add(obj);
                }
                conn.Close();
                dgv_ctPhieuNhap.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgv_ctPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            btn_themCTPhieuNhap.Enabled = false;
            txt_maCTPhieuNhap.Enabled = false;
            txt_maCTPhieuNhap.Text = dgv_ctPhieuNhap.Rows[idx].Cells["MaCTPN"].Value.ToString();
            cmb_maPhieuNhap.SelectedValue = dgv_ctPhieuNhap.Rows[idx].Cells["MaPhieuNhap"].Value.ToString();
            cmb_sanPham.SelectedValue = dgv_ctPhieuNhap.Rows[idx].Cells["MaSanPham"].Value.ToString();
            txt_soLuong.Text = dgv_ctPhieuNhap.Rows[idx].Cells["SoLuong"].Value.ToString();
            txt_donGia.Text = dgv_ctPhieuNhap.Rows[idx].Cells["DonGia"].Value.ToString();
        }

        private void btn_themCTPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "insert into ChiTietPhieuNhap (MaCTPN,MaPhieuNhap,MaSanPham,SoLuong,DonGia) values (@ma_ctpn,@ma_pn,@ma_sp,@soLuong,@donGia)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma_ctpn", txt_maCTPhieuNhap.Text));
                cmd.Parameters.Add(new SqlParameter("@ma_pn", cmb_maPhieuNhap.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@ma_sp", cmb_sanPham.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@soLuong", txt_soLuong.Text));
                cmd.Parameters.Add(new SqlParameter("@donGia", txt_donGia.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm mới thành công !!!");
                loadDataToTable_ChiTietPhieuNhap();
                loadDataToTable_PhieuNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_suaCTPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "update ChiTietPhieuNhap set MaPhieuNhap = @ma_pn, MaSanPham = @ma_sp, SoLuong = @soLuong, DonGia = @donGia where MaCTPN = @ma_ctpn";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma_ctpn", txt_maCTPhieuNhap.Text));
                cmd.Parameters.Add(new SqlParameter("@ma_pn", cmb_maPhieuNhap.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@ma_sp", cmb_sanPham.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@soLuong", txt_soLuong.Text));
                cmd.Parameters.Add(new SqlParameter("@donGia", txt_donGia.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sửa dữ liệu thành công !!!");
                loadDataToTable_ChiTietPhieuNhap();
                loadDataToTable_PhieuNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xoaCTPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "delete from ChiTietPhieuNhap where MaCTPN = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", txt_maCTPhieuNhap.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa dữ liệu thành công !!!");
                clearCTPhieuNhap();
                loadDataToTable_PhieuNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_resetCTPhieuNhap_Click(object sender, EventArgs e)
        {
            clearCTPhieuNhap();
        }

        private void txt_timKiemCTPhieuNhap_TextChanged(object sender, EventArgs e)
        {
            findCTPhieuNhap();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            frm_reportPhieuNhap frm_report = new frm_reportPhieuNhap();
            frm_report.Show();
        }
    }
}
