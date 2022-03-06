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
    public partial class frm_tkDiemDanh : Form
    {
        public frm_tkDiemDanh()
        {
            InitializeComponent();
        }
        private void loadDataToTable()
        {
            try
            {
                List<tkdd> lst_diemDanh = new List<tkdd>();
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "select DiemDanh.TenNhanVien, count (DiemDanh.MaNhanVien) as SoNgayDiLam, count (DiemDanh.MaNhanVien) * avg(NhanVien.LuongCoBan) as Luong from DiemDanh,NhanVien " +
                    "where MONTH(NgayDiLam) = @thang and YEAR(NgayDiLam) = @nam and DiemDanh.MaNhanVien = NhanVien.MaNhanVien " +
                    "group by DiemDanh.TenNhanVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@thang", txt_thang.Text));
                cmd.Parameters.Add(new SqlParameter("@nam", txt_nam.Text));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tkdd obj = new tkdd(dr);
                    lst_diemDanh.Add(obj);
                }
                conn.Close();
                dgv_tkdd.DataSource = lst_diemDanh;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        private void frm_tkDiemDanh_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_thongKe_Click(object sender, EventArgs e)
        {
            loadDataToTable();
        }

        private void btn_xuatExcel_Click(object sender, EventArgs e)
        {
            try 
            {
                if (txt_tenFile.Text != "")
                {
                    exportExcel(dgv_tkdd, @"D:\", txt_tenFile.Text);
                }
                else
                {
                    MessageBox.Show("Mời nhập tên file !!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Mời nhập tên file !!!");
            }
            
        }
    }
}
