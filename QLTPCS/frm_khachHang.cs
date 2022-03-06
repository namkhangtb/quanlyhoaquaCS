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
    public partial class frm_khachHang : Form
    {
        public frm_khachHang()
        {
            InitializeComponent();
        }
        private void clear()
        {
            loadDataToTable();
            btn_them.Enabled = true;
            txt_maKhachHang.Enabled = true;
            txt_maKhachHang.Text = "";
            txt_tenKhachHang.Text = "";
            txt_ngaySinh.Text = "";
            txt_diaChi.Text = "";
            txt_dienThoai.Text = "";
        }
        private void loadDataToTable()
        {
            try
            {
                List<KhachHang> lst_khachHang = new List<KhachHang>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "select * from KhachHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    KhachHang obj_khachHang = new KhachHang(dr);
                    lst_khachHang.Add(obj_khachHang);
                }
                conn.Close();
                dgv_khachHang.DataSource = lst_khachHang;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void find()
        {
            try
            {
                List<KhachHang> lst_khachHang = new List<KhachHang>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "select * from KhachHang where TenKhachHang like '%'+@tk+'%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", txt_timKiem.Text));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    KhachHang obj_khachHang = new KhachHang(dr);
                    lst_khachHang.Add(obj_khachHang);
                }
                conn.Close();
                dgv_khachHang.DataSource = lst_khachHang;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frm_khachHang_Load(object sender, EventArgs e)
        {
            loadDataToTable();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "insert into KhachHang (MaKhachHang,TenKhachHang,NgaySinh,GioiTinh,DiaChi,Sdt) values (@ma,@ten,@ngaySinh,@gioiTinh,@diaChi,@sdt)";
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
                cmd.Parameters.Add(new SqlParameter("@ma", txt_maKhachHang.Text));
                cmd.Parameters.Add(new SqlParameter("@ten", txt_tenKhachHang.Text));
                cmd.Parameters.Add(new SqlParameter("@ngaySinh", txt_ngaySinh.Text));
                cmd.Parameters.Add(new SqlParameter("@gioiTinh", gt));
                cmd.Parameters.Add(new SqlParameter("@diaChi", txt_diaChi.Text));
                cmd.Parameters.Add(new SqlParameter("@sdt", txt_dienThoai.Text));
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
                string query = "update KhachHang set TenKhachHang = @ten,NgaySinh = @ngaySinh,GioiTinh = @gioiTinh,DiaChi = @diaChi,Sdt = @sdt where MaKhachHang = @ma";
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
                cmd.Parameters.Add(new SqlParameter("@ma", txt_maKhachHang.Text));
                cmd.Parameters.Add(new SqlParameter("@ten", txt_tenKhachHang.Text));
                cmd.Parameters.Add(new SqlParameter("@ngaySinh", txt_ngaySinh.Text));
                cmd.Parameters.Add(new SqlParameter("@gioiTinh", gt));
                cmd.Parameters.Add(new SqlParameter("@diaChi", txt_diaChi.Text));
                cmd.Parameters.Add(new SqlParameter("@sdt", txt_dienThoai.Text));
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
                string query = "delete from KhachHang where MaKhachHang = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", txt_maKhachHang.Text));
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

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            find();
        }

        private void dgv_khachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            btn_them.Enabled = false;
            txt_maKhachHang.Enabled = false;
            txt_maKhachHang.Text = dgv_khachHang.Rows[idx].Cells["MaKhachHang"].Value.ToString();
            txt_tenKhachHang.Text = dgv_khachHang.Rows[idx].Cells["TenKhachHang"].Value.ToString();
            txt_ngaySinh.Text = dgv_khachHang.Rows[idx].Cells["NgaySinh"].Value.ToString();
            txt_diaChi.Text = dgv_khachHang.Rows[idx].Cells["DiaChi"].Value.ToString();
            txt_dienThoai.Text = dgv_khachHang.Rows[idx].Cells["Sdt"].Value.ToString();
            string check = dgv_khachHang.Rows[idx].Cells["GioiTinh"].Value.ToString();
            if (check == "Nam" || check == "nam")
            {
                rd_nam.Checked = true;
            }
            else if (check == "Nu" || check == "nu")
            {
                rd_nu.Checked = true;
            }
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            find();
        }
    }
}
