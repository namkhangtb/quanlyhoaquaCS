using QLTPCS.entity;
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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QLTPCS
{
    public partial class frm_xemHoaDon : Form
    {
        public frm_xemHoaDon()
        {
            InitializeComponent();
        }

        void load_content()
        {
            txt_khachhang.Text =dgv_hoadon.CurrentRow.Cells[1].Value.ToString();
            txt_nhanvien.Text = dgv_hoadon.CurrentRow.Cells[2].Value.ToString();
            txt_ngaylap.Text = dgv_hoadon.CurrentRow.Cells[3].Value.ToString();
            txt_tongtien.Text = dgv_hoadon.CurrentRow.Cells[4].Value.ToString();
        }
        public void load_dgv()
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
                dgv_hoadon.DataSource = lst;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void load_chitiet()
        {
            string temp = dgv_hoadon.CurrentRow.Cells[0].Value.ToString();
            try
            {
                List<ChiTietHoaDon> lst = new List<ChiTietHoaDon>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "Select * from ChiTietHoaDon where MaChiTietHoaDon = '" + temp + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ChiTietHoaDon obj = new ChiTietHoaDon(dr);
                    lst.Add(obj);
                }
                conn.Close();
                dgv_chitiet.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
        private void frm_xemHoaDon_Load(object sender, EventArgs e)
        {
            load_dgv();
            load_chitiet();
            load_content();
        }

        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            load_chitiet();
            load_content();
        }

        private void exportExcel(DataGridView dgv, string duongDan, string tenTap)
        {
            try
            {
                app obj = new app();
                obj.Application.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 25;
                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                {
                    obj.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Rows[i].Cells[j].Value != null)
                        {
                            obj.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                obj.ActiveWorkbook.SaveAs(duongDan + tenTap + ".xlsx");
                obj.ActiveWorkbook.Saved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tenFile.Text != "")
                {
                    exportExcel(dgv_hoadon, @"D:\DoAnLapTrinh.NET\", txt_tenFile.Text);
                    MessageBox.Show("File đã được tạo, xem tại D:/DoAnLapTrinh.NET/" + txt_tenFile.Text + ".xlsx");
                }
                else
                {
                    MessageBox.Show("Mời nhập tên file !!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mời nhập tên file !!!");
            }
        }
    }
}
