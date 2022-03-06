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
    public partial class frm_diemDanh : Form
    {
        List<NhanVien> lst_nhanVien = new List<NhanVien>();
        public frm_diemDanh()
        {
            InitializeComponent();
        }
        public void load_cmb()
        {

            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "select * from NhanVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhanVien nv = new NhanVien(dr);
                    lst_nhanVien.Add(nv);
                }
                conn.Close();
                cmb_maNV.DataSource = lst_nhanVien;
                cmb_maNV.DisplayMember = "MaNhanVien";
                cmb_maNV.ValueMember = "MaNhanVien";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool checkValid()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "select count (*) from DiemDanh where MaNhanVien = @manv and NgayDiLam = FORMAT(GETDATE(),'yyyy-MM-dd')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@manv", cmb_maNV.SelectedValue));
                int sl = (int)cmd.ExecuteScalar();
                conn.Close();
                if (sl >= 1)
                {
                    MessageBox.Show("Hôm nay bạn đã điểm danh rồi !!!");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }
        private void btn_diemDanh_Click(object sender, EventArgs e)
        {
            if (checkValid())
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                    conn.Open();
                    string query = "insert into DiemDanh (MaNhanVien,TenNhanVien,NgayDiLam) values (@ma,@ten,GETDATE())";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add(new SqlParameter("@ma", cmb_maNV.SelectedValue));
                    cmd.Parameters.Add(new SqlParameter("@ten", txt_tenNhanVien.Text));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Điểm danh thành công !!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frm_diemDanh_Load(object sender, EventArgs e)
        {
            load_cmb();
        }

        private void cmb_maNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tenNV = "";
                string maNV = cmb_maNV.SelectedValue.ToString();
                for (int i = 0; i < lst_nhanVien.Count; i++)
                {
                    if (maNV == lst_nhanVien[i].MaNhanVien)
                    {
                        tenNV = lst_nhanVien[i].TenNhanVien;
                    }
                }
                txt_tenNhanVien.Text = tenNV;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
