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
    public partial class frm_loaiSanPham : Form
    {
        public frm_loaiSanPham()
        {
            InitializeComponent();
        }
        private void clear()
        {
            loadDataToTable_SanPham();
            loadDataToTable_LoaiSanPham();
            btn_them.Enabled = true;
            txt_maLoaiSanPham.Enabled = true;
            txt_maLoaiSanPham.Text = "";
            txt_tenLoaiSanPham.Text = "";
        }
        private void find()
        {
            try
            {
                List<LoaiSanPham> lst = new List<LoaiSanPham>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "select * from LoaiSanPham where TenLoaiSanPham like '%'+@tk+'%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", txt_timKiem.Text));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LoaiSanPham obj = new LoaiSanPham(dr);
                    lst.Add(obj);
                }
                conn.Close();
                dgv_loaiSanPham.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadDataToTable_SanPham_After_Click_Table_LoaiSanPham()
        {
            try
            {
                List<SanPham_LoaiSanPham> lst = new List<SanPham_LoaiSanPham>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "Select * from v_sanpham where TenLoaiSanPham like '%'+@tk+'%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", txt_tenLoaiSanPham.Text));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SanPham_LoaiSanPham obj_SanPham_LoaiSanPham = new SanPham_LoaiSanPham(dr);
                    lst.Add(obj_SanPham_LoaiSanPham);
                }
                conn.Close();
                dgv_sanPham.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void loadDataToTable_SanPham()
        {
            try
            {
                List<SanPham_LoaiSanPham> lst = new List<SanPham_LoaiSanPham>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "Select * from v_sanpham";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SanPham_LoaiSanPham obj_SanPham_LoaiSanPham = new SanPham_LoaiSanPham(dr);
                    lst.Add(obj_SanPham_LoaiSanPham);
                }
                conn.Close();
                dgv_sanPham.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void loadDataToTable_LoaiSanPham()
        {
            try
            {
                List<LoaiSanPham> lst_loaiSanPham = new List<LoaiSanPham>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();


                string query = "Select * from LoaiSanPham";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LoaiSanPham obj_loaiSanPham = new LoaiSanPham(dr);
                    lst_loaiSanPham.Add(obj_loaiSanPham);
                }
                conn.Close();
                dgv_loaiSanPham.DataSource = lst_loaiSanPham;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frm_loaiSanPham_Load(object sender, EventArgs e)
        {
            loadDataToTable_SanPham();
            loadDataToTable_LoaiSanPham();
        }

        private void dgv_loaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            btn_them.Enabled = false;
            txt_maLoaiSanPham.Enabled = false;
            txt_maLoaiSanPham.Text = dgv_loaiSanPham.Rows[idx].Cells["MaLoaiSanPham"].Value.ToString();
            txt_tenLoaiSanPham.Text = dgv_loaiSanPham.Rows[idx].Cells["TenLoaiSanPham"].Value.ToString();
            loadDataToTable_SanPham_After_Click_Table_LoaiSanPham();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "insert into LoaiSanPham (MaLoaiSanPham,TenLoaiSanPham) values (@ma,@ten)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", txt_maLoaiSanPham.Text));
                cmd.Parameters.Add(new SqlParameter("@ten", txt_tenLoaiSanPham.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm mới thành công !!!");
                loadDataToTable_LoaiSanPham();
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
                string query = "update LoaiSanPham set TenLoaiSanPham = @ten where MaLoaiSanPham = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", txt_maLoaiSanPham.Text));
                cmd.Parameters.Add(new SqlParameter("@ten", txt_tenLoaiSanPham.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sửa dữ liệu thành công !!!");
                loadDataToTable_LoaiSanPham();
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
                string query = "delete from LoaiSanPham where MaLoaiSanPham = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", txt_maLoaiSanPham.Text));
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
