using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLTPCS.entity;

namespace QLTPCS
{
    public partial class frm_nhanVien : Form
    {
        public frm_nhanVien()
        {
            InitializeComponent();
        }
        private void clear()
        {
            loadDataToTable();
            btn_them.Enabled = true;
            txt_maNhanVien.Enabled = true;
            txt_maNhanVien.Text = "";
            txt_tenNhanVien.Text = "";
            txt_ngaySinh.Text = "";
            txt_ngayVaolam.Text = "";
            txt_diaChi.Text = "";
            txt_dienThoai.Text = "";
            txt_luongCoBan.Text = "";
        }
        private void loadDataToTable()
        {
            try 
            { 
                List<NhanVien> lst_nhanVien = new List<NhanVien>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "select * from NhanVien";
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhanVien obj_nhanVien = new NhanVien(dr);
                    lst_nhanVien.Add(obj_nhanVien);
                }
                conn.Close();
                dgv_nhanVien.DataSource = lst_nhanVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void frm_nhanVien_Load(object sender, EventArgs e)
        {
            loadDataToTable();
        }
        private void find()
        {
            try
            {
                List<NhanVien> lst_nhanVien = new List<NhanVien>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "select * from NhanVien where TenNhanVien like '%'+@tk+'%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", txt_timKiem.Text));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhanVien obj_nhanVien = new NhanVien(dr);
                    lst_nhanVien.Add(obj_nhanVien);
                }
                conn.Close();
                dgv_nhanVien.DataSource = lst_nhanVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgv_nhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
                int idx = e.RowIndex;
                btn_them.Enabled = false;
                txt_maNhanVien.Enabled = false;
                txt_maNhanVien.Text = dgv_nhanVien.Rows[idx].Cells["MaNhanVien"].Value.ToString();
                txt_tenNhanVien.Text = dgv_nhanVien.Rows[idx].Cells["TenNhanVien"].Value.ToString();
                txt_ngaySinh.Text = dgv_nhanVien.Rows[idx].Cells["NgaySinh"].Value.ToString();
                txt_ngayVaolam.Text = dgv_nhanVien.Rows[idx].Cells["NgayVaoLam"].Value.ToString();
                txt_diaChi.Text = dgv_nhanVien.Rows[idx].Cells["DiaChi"].Value.ToString();
                txt_dienThoai.Text = dgv_nhanVien.Rows[idx].Cells["Sdt"].Value.ToString();
                txt_luongCoBan.Text = dgv_nhanVien.Rows[idx].Cells["LuongCoBan"].Value.ToString();
                string check = dgv_nhanVien.Rows[idx].Cells["GioiTinh"].Value.ToString();
                if (check == "Nam" || check == "nam")
                {
                    rd_nam.Checked = true;
                }
                else if (check == "Nu" || check == "nu")
                {
                    rd_nu.Checked = true;
                }
            }
            catch
            {

            }

        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "insert into NhanVien (MaNhanVien,TenNhanVien,NgaySinh,GioiTinh,NgayVaoLam,DiaChi,Sdt,LuongCoBan) values (@ma,@ten,@ngaySinh,@gioiTinh,@ngayVaoLam,@diaChi,@sdt,@luongCoBan)";
                SqlCommand cmd = new SqlCommand(query, conn);
                string gt = "";
                if (rd_nam.Checked == true)
                {
                    gt = "Nam";
                }
                else if (rd_nu.Checked == true)
                {
                    gt = "Nu";
                }
                cmd.Parameters.Add(new SqlParameter("@ma", txt_maNhanVien.Text));
                cmd.Parameters.Add(new SqlParameter("@ten", txt_tenNhanVien.Text));
                cmd.Parameters.Add(new SqlParameter("@ngaySinh", txt_ngaySinh.Text));
                cmd.Parameters.Add(new SqlParameter("@gioiTinh", gt));
                cmd.Parameters.Add(new SqlParameter("@ngayVaoLam", txt_ngayVaolam.Text));
                cmd.Parameters.Add(new SqlParameter("@diaChi", txt_diaChi.Text));
                cmd.Parameters.Add(new SqlParameter("@sdt", txt_dienThoai.Text));
                cmd.Parameters.Add(new SqlParameter("@luongCoBan", txt_luongCoBan.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm mới thành công !!!");
                loadDataToTable();
            }
            catch(Exception ex)
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
                string query = "update NhanVien set TenNhanVien = @ten,NgaySinh = @ngaySinh,GioiTinh = @gioiTinh,NgayVaoLam = @ngayVaoLam,DiaChi = @diaChi,Sdt = @sdt, LuongCoBan = @luongCoBan where MaNhanVien = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                string gt = "";
                if (rd_nam.Checked == true)
                {
                    gt = "Nam";
                }
                else if (rd_nu.Checked == true)
                {
                    gt = "Nu";
                }
                cmd.Parameters.Add(new SqlParameter("@ma", txt_maNhanVien.Text));
                cmd.Parameters.Add(new SqlParameter("@ten", txt_tenNhanVien.Text));
                cmd.Parameters.Add(new SqlParameter("@ngaySinh", txt_ngaySinh.Text));
                cmd.Parameters.Add(new SqlParameter("@gioiTinh", gt));
                cmd.Parameters.Add(new SqlParameter("@ngayVaoLam", txt_ngayVaolam.Text));
                cmd.Parameters.Add(new SqlParameter("@diaChi", txt_diaChi.Text));
                cmd.Parameters.Add(new SqlParameter("@sdt", txt_dienThoai.Text));
                cmd.Parameters.Add(new SqlParameter("@luongCoBan", txt_luongCoBan.Text));
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
                string query = "delete from NhanVien where MaNhanVien = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", txt_maNhanVien.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa dữ liệu thành công !!!");
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            find();
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            find();
        }
    }
}
