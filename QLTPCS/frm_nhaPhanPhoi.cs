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
    public partial class frm_nhaPhanPhoi : Form
    {
        public frm_nhaPhanPhoi()
        {
            InitializeComponent();
        }
        private void clear()
        {
            loadDataToTable();
            btn_them.Enabled = true;
            txt_maNhaPhanPhoi.Enabled = true;
            txt_maNhaPhanPhoi.Text = "";
            txt_tenNhaPhanPhoi.Text = "";
            txt_diaChi.Text = "";
            txt_sdt.Text = "";
            txt_email.Text = "";
        }
        private void loadDataToTable()
        {
            try
            {
                List<NhaPhanPhoi> lst= new List<NhaPhanPhoi>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "select * from NhaPhanPhoi";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhaPhanPhoi obj = new NhaPhanPhoi(dr);
                    lst.Add(obj);
                }
                conn.Close();
                dgv_nhaPhanPhoi.DataSource = lst;
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
                List<NhaPhanPhoi> lst= new List<NhaPhanPhoi>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "select * from NhaPhanPhoi where TenNhaPhanPhoi like '%'+@tk+'%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", txt_timKiem.Text));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhaPhanPhoi obj = new NhaPhanPhoi(dr);
                    lst.Add(obj);
                }
                conn.Close();
                dgv_nhaPhanPhoi.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_nhaPhanPhoi_Load(object sender, EventArgs e)
        {
            loadDataToTable();
        }

        private void dgv_nhaPhanPhoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            btn_them.Enabled = false;
            txt_maNhaPhanPhoi.Enabled = false;
            txt_maNhaPhanPhoi.Text = dgv_nhaPhanPhoi.Rows[idx].Cells["MaNhaPhanPhoi"].Value.ToString();
            txt_tenNhaPhanPhoi.Text = dgv_nhaPhanPhoi.Rows[idx].Cells["TenNhaPhanPhoi"].Value.ToString();
            txt_diaChi.Text = dgv_nhaPhanPhoi.Rows[idx].Cells["DiaChi"].Value.ToString();
            txt_sdt.Text = dgv_nhaPhanPhoi.Rows[idx].Cells["Sdt"].Value.ToString();
            txt_email.Text = dgv_nhaPhanPhoi.Rows[idx].Cells["Email"].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "insert into NhaPhanPhoi (MaNhaPhanPhoi,TenNhaPhanPhoi,DiaChi,Sdt,Email) values (@ma,@ten,@diaChi,@sdt,@email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", txt_maNhaPhanPhoi.Text));
                cmd.Parameters.Add(new SqlParameter("@ten", txt_tenNhaPhanPhoi.Text));
                cmd.Parameters.Add(new SqlParameter("@diaChi", txt_diaChi.Text));
                cmd.Parameters.Add(new SqlParameter("@sdt", txt_sdt.Text));
                cmd.Parameters.Add(new SqlParameter("@email", txt_email.Text));
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
                string query = "update NhaPhanPhoi set TenNhaPhanPhoi = @ten, DiaChi = @diaChi, Sdt = @sdt, Email = @email where MaNhaPhanPhoi = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", txt_maNhaPhanPhoi.Text));
                cmd.Parameters.Add(new SqlParameter("@ten", txt_tenNhaPhanPhoi.Text));
                cmd.Parameters.Add(new SqlParameter("@diaChi", txt_diaChi.Text));
                cmd.Parameters.Add(new SqlParameter("@sdt", txt_sdt.Text));
                cmd.Parameters.Add(new SqlParameter("@email", txt_email.Text));
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
                string query = "delete from NhaPhanPhoi where MaNhaPhanPhoi = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", txt_maNhaPhanPhoi.Text));
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
