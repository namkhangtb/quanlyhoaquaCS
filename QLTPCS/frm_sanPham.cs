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
using QLTPCS.entity;
namespace QLTPCS
{
    public partial class frm_sanPham : Form
    {
        public frm_sanPham()
        {
            InitializeComponent();
        }
        private void clear()
        {
            loadDataToTable();
            btn_them.Enabled = true;
            txt_maSanPham.Enabled = true;
            txt_maSanPham.Text = "";
            txt_tenSanPham.Text = "";
            //txt_maLoaiSanPham.Text = "";
            //cmb_loaiSanPham.SelectedIndex(0);
            txt_noiSanXuat.Text = "";
            txt_giaNhap.Text = "";
            txt_giaBan.Text = "";
            txt_tonKho.Text = "0";
            txt_timKiem.Text = "";
        }
        private void loadDataToTable()
        {
            try
            {
                List<SanPham> lst_sanPham = new List<SanPham>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "select * from SanPham";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SanPham obj_sanPham = new SanPham(dr);
                    lst_sanPham.Add(obj_sanPham);
                }
                conn.Close();
                dgv_sanPham.DataSource = lst_sanPham;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void getcmbLoaiSP()
        {
            try
            {
                List<entity.LoaiSanPham> lst_loaiSanPham = new List<entity.LoaiSanPham>();
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
                    entity.LoaiSanPham obj_loaiSanPham = new entity.LoaiSanPham(dr);
                    lst_loaiSanPham.Add(obj_loaiSanPham);
                }
                // Bước 5: Đóng kết nối
                conn.Close();
                // Hiển thị dữ liệu của Lst lên ComboBox
                cmb_loaiSanPham.DataSource = lst_loaiSanPham;
                // Dữ liệu hiển thị trên ComboBox (DisplayMember), và giá trị tương ứng với dữ liệu đó (ValueMember)
                cmb_loaiSanPham.DisplayMember = "TenLoaiSanPham";
                cmb_loaiSanPham.ValueMember = "MaLoaiSanPham";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void find()
        {
            try
            {
                List<SanPham> lst_sanPham = new List<SanPham>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "select * from SanPham where TenSanPham like '%'+@tk+'%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", txt_timKiem.Text));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SanPham obj_sanPham = new SanPham(dr);
                    lst_sanPham.Add(obj_sanPham);
                }
                conn.Close();
                dgv_sanPham.DataSource = lst_sanPham;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frm_sanPham_Load(object sender, EventArgs e)
        {
            loadDataToTable();
            getcmbLoaiSP();
        }

        private void dgv_sanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            btn_them.Enabled = false;
            txt_maSanPham.Enabled = false;
            txt_maSanPham.Text = dgv_sanPham.Rows[idx].Cells["MaSanPham"].Value.ToString();
            txt_tenSanPham.Text = dgv_sanPham.Rows[idx].Cells["TenSanPham"].Value.ToString();
            //txt_maLoaiSanPham.Text = dgv_sanPham.Rows[idx].Cells["MaLoaiSanPham"].Value.ToString();
            cmb_loaiSanPham.SelectedValue = dgv_sanPham.Rows[idx].Cells["MaLoaiSanPham"].Value.ToString();
            txt_noiSanXuat.Text = dgv_sanPham.Rows[idx].Cells["NoiSanXuat"].Value.ToString();
            txt_giaNhap.Text = dgv_sanPham.Rows[idx].Cells["GiaNhap"].Value.ToString();
            txt_giaBan.Text = dgv_sanPham.Rows[idx].Cells["GiaBan"].Value.ToString();
            txt_tonKho.Text = dgv_sanPham.Rows[idx].Cells["TonKho"].Value.ToString();            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "insert into SanPham (MaSanPham,TenSanPham,MaLoaiSanPham,NoiSanXuat,GiaNhap,GiaBan,TonKho) values (@ma,@ten,@ma_lsp,@noiSanXuat,@giaNhap,@giaBan,@tonKho)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", txt_maSanPham.Text));
                cmd.Parameters.Add(new SqlParameter("@ten", txt_tenSanPham.Text));
                cmd.Parameters.Add(new SqlParameter("@ma_lsp", cmb_loaiSanPham.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@noiSanXuat", txt_noiSanXuat.Text));
                cmd.Parameters.Add(new SqlParameter("@giaNhap", txt_giaNhap.Text));
                cmd.Parameters.Add(new SqlParameter("@giaBan", txt_giaBan.Text));
                cmd.Parameters.Add(new SqlParameter("@tonKho", txt_tonKho.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm mới thành công !!!");
                loadDataToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "update SanPham set TenSanPham = @ten, MaLoaiSanPham = @ma_lsp, NoiSanXuat = @noiSanXuat, GiaNhap = @giaNhap, GiaBan = @giaBan, tonKho = @tonKho where MaSanPham = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", txt_maSanPham.Text));
                cmd.Parameters.Add(new SqlParameter("@ten", txt_tenSanPham.Text));
                cmd.Parameters.Add(new SqlParameter("@ma_lsp", cmb_loaiSanPham.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@noiSanXuat", txt_noiSanXuat.Text));
                cmd.Parameters.Add(new SqlParameter("@giaNhap", txt_giaNhap.Text));
                cmd.Parameters.Add(new SqlParameter("@giaBan", txt_giaBan.Text));
                cmd.Parameters.Add(new SqlParameter("@tonKho", txt_tonKho.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sửa dữ liệu thành công !!!");
                loadDataToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "delete from SanPham where MaSanPham = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", txt_maSanPham.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa dữ liệu thành công !!!");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            find();
        }
    }
}
