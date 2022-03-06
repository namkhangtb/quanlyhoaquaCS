using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTPCS.entity;
using System.Data.SqlClient;

namespace QLTPCS
{
    public partial class frm_taoHoaDon : Form
    {
        public frm_taoHoaDon()
        {
            InitializeComponent();
        }

        public void get_cbbNhanVien()
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
                cbb_nhanvien.DataSource = lst;
                // Dữ liệu hiển thị trên ComboBox (DisplayMember), và giá trị tương ứng với dữ liệu đó (ValueMember)
                cbb_nhanvien.DisplayMember = "TenNhanVien";
                cbb_nhanvien.ValueMember = "MaNhanVien";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void get_cbbKhachHang()
        {
            try
            {
                List<KhachHang> lst = new List<KhachHang>();
                // Lấy dữ liệu Sản Phẩm từ Database về Lưu vào List
                // Bước 1: Khởi tạo kết nối
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "Select * from KhachHang";
                // Bước 4: Thực thi truy vấn\
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                // Bước 4.1: Đọc dữ liệu, lưu vào List
                while (dr.Read())
                {
                    KhachHang obj = new KhachHang(dr);
                    lst.Add(obj);
                }
                // Bước 5: Đóng kết nối
                conn.Close();
                // Hiển thị dữ liệu của Lst lên ComboBox
                cbb_khachhang.DataSource = lst;
                // Dữ liệu hiển thị trên ComboBox (DisplayMember), và giá trị tương ứng với dữ liệu đó (ValueMember)
                cbb_khachhang.DisplayMember = "TenKhachHang";
                cbb_khachhang.ValueMember = "MaKhachHang";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void get_cbbLoaiSanPham()
        {
            try
            {
                List<LoaiSanPham> lst = new List<LoaiSanPham>();
                // Lấy dữ liệu Sản Phẩm từ Database về Lưu vào List
                // Bước 1: Khởi tạo kết nối
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "Select * from LoaiSanPham";
                // Bước 4: Thực thi truy vấn\
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                // Bước 4.1: Đọc dữ liệu, lưu vào List
                while (dr.Read())
                {
                    LoaiSanPham obj = new LoaiSanPham(dr);
                    lst.Add(obj);
                }
                // Bước 5: Đóng kết nối
                conn.Close();
                // Hiển thị dữ liệu của Lst lên ComboBox
                cbb_loaisanpham.DataSource = lst;
                // Dữ liệu hiển thị trên ComboBox (DisplayMember), và giá trị tương ứng với dữ liệu đó (ValueMember)
                cbb_loaisanpham.DisplayMember = "TenLoaiSanPham";
                cbb_loaisanpham.ValueMember = "MaLoaiSanPham";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        void load_dgv_SanPham()
        {
            List<SanPham> lst = new List<SanPham>();
            int i = cbb_loaisanpham.SelectedIndex;
            SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
            // Bước 2: Mở kết nối
            conn.Open();
            // Bước 3: Tạo truy vấn
            string query = "Select * from SanPham";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SanPham obj = new SanPham(dr);
                lst.Add(obj);
            }
            string temp = cbb_loaisanpham.GetItemText(cbb_loaisanpham.SelectedValue);
            List<SanPham> lst2 = new List<SanPham>();
            foreach (SanPham c in lst)
            {
                if (c.MaLoaiSanPham == temp) lst2.Add(c);
            }
            gdv_sptheoloai.DataSource = lst2;
        }

        public void load_dgv_GioHang()
        {
            try
            {
                List<ChiTietHoaDon> lst = new List<ChiTietHoaDon>();
                // Lấy dữ liệu Sản Phẩm từ Database về Lưu vào List
                // Bước 1: Khởi tạo kết nối
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "Select * from ChiTietHoaDon where MaChiTietHoaDon = @ma";
                // Bước 4: Thực thi truy vấn\
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add(new SqlParameter("@ma", txt_mahoadon.Text));
                SqlDataReader dr = cmd.ExecuteReader();
                // Bước 4.1: Đọc dữ liệu, lưu vào List
                while (dr.Read())
                {
                    ChiTietHoaDon obj = new ChiTietHoaDon(dr);
                    lst.Add(obj);
                }
                // Bước 5: Đóng kết nối
                conn.Close();
                List<SanPham> lst2 = new List<SanPham>();
                conn.Open();
                // Bước 3: Tạo truy vấn
                query = "Select * from SanPham";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SanPham obj = new SanPham(dr);
                    lst2.Add(obj);
                }
                int tong = 0;
                foreach (ChiTietHoaDon c in lst)
                {
                    foreach (SanPham c1 in lst2) 
                        if (c.MaSanPham == c1.MaSanPham)
                        {
                            tong += c.SoLuong * Convert.ToInt32(c1.GiaBan);
                            break;
                        }
                }
                txt_tongtien.Text = tong.ToString();
                gdv_sptrongio.DataSource = lst;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void frm_taoHoaDon_Load(object sender, EventArgs e)
        {
            get_cbbNhanVien();
            get_cbbKhachHang();
            get_cbbLoaiSanPham();
            load_dgv_SanPham();
        }

        private void cbb_loaisanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_dgv_SanPham();
        }

        private void btn_themsanpham_Click(object sender, EventArgs e)
        {
            string temp = gdv_sptheoloai.CurrentRow.Cells[0].Value.ToString();
            int sl = Convert.ToInt32(txt_soluong.Text);
            List<SanPham> lst = new List<SanPham>();
            SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
            // Bước 2: Mở kết nối
            conn.Open();
            // Bước 3: Tạo truy vấn
            string query = "Select * from SanPham";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SanPham obj = new SanPham(dr);
                lst.Add(obj);
            }
            conn.Close();
            List<ChiTietHoaDon> lst2 = new List<ChiTietHoaDon>();
            foreach (SanPham c in lst)
            {
                if (c.MaSanPham == temp)
                {
                    if (c.TonKho < sl) MessageBox.Show("Số lượng không đủ!!");
                    else
                    {
                        try
                        {
                            conn.Open();
                            query = "insert into ChiTietHoaDon (MaChiTietHoaDon,MaSanPham,SoLuong) values (@ct,@sp,@sl)";
                            cmd = new SqlCommand(query, conn);
                            cmd.Parameters.Add(new SqlParameter("@ct", txt_mahoadon.Text));
                            cmd.Parameters.Add(new SqlParameter("@sp", gdv_sptheoloai.CurrentRow.Cells[0].Value.ToString()));
                            cmd.Parameters.Add(new SqlParameter("@sl", txt_soluong.Text));
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Thêm mới thành công !!!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message);
                        }
                    }
                }
            }
            load_dgv_GioHang();
            
        }

        private void btn_xoasanpham_Click(object sender, EventArgs e)
        {
            string temp = gdv_sptrongio.CurrentRow.Cells[0].Value.ToString();
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "delete from ChiTietHoaDon where MaSanPham = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", temp));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa dữ liệu thành công !!!");
                load_dgv_GioHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_taohoadon_Click(object sender, EventArgs e)
        {
            load_dgv_GioHang();
            load_dgv_SanPham();
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "insert into HoaDon (MaHoaDon,MaKhachHang,MaNhanVien,TongTien,NgayLapHoaDon) values (@hd,@kh,@nv,@tt,@nl)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@hd", txt_mahoadon.Text));
                cmd.Parameters.Add(new SqlParameter("@kh", cbb_khachhang.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@nv", cbb_nhanvien.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@tt", txt_tongtien.Text));
                string theDate = date1.Value.ToString("yyyy/MM/dd");
                cmd.Parameters.Add(new SqlParameter("@nl", theDate));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Tổng tiền là: "+ txt_tongtien.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_kiemtra_Click(object sender, EventArgs e)
        {
            try
            {
                List<HoaDon> lst = new List<HoaDon>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "Select * from HoaDon";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    HoaDon obj = new HoaDon(dr);
                    lst.Add(obj);
                }
                conn.Close();
                /*bool ok = true;
                foreach (HoaDon c in lst)
                {
                    if (txt_mahoadon.Text == c.MaHoaDon) ok = false;
                }
                if (ok == false)
                    MessageBox.Show("Mã hoá đơn không hợp lệ");
                else MessageBox.Show("Mã hoá đơn hợp lệ");*/
                int cnt = lst.Count+1;
                txt_mahoadon.Text = "HD" + cnt.ToString("00");
                txt_mahoadon.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_dgv_GioHang();
            load_dgv_SanPham();
        }
    }
}
