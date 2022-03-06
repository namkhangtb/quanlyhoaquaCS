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
    public partial class frm_tkSanPham : Form
    {
        class SanPhamThongKe
        {
            string MaSanPham;
            string TenSanPham;
            int soluong;

            public SanPhamThongKe(string maSanPham, string tenSanPham, int soluong)
            {
                MaSanPham1 = maSanPham;
                TenSanPham1 = tenSanPham;
                this.Soluong = soluong;
            }

            public string MaSanPham1 { get => MaSanPham; set => MaSanPham = value; }
            public string TenSanPham1 { get => TenSanPham; set => TenSanPham = value; }
            public int Soluong { get => soluong; set => soluong = value; }
        }

        
        public frm_tkSanPham()
        {
            InitializeComponent();
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy";
            dateTimePicker2.ShowUpDown = true;
        }
        void load1()
        {
            chart_banchay.Series["BanChayNhat"].Points.Clear();
            List<SanPhamThongKe> tklst = new List<SanPhamThongKe>();
            List<SanPham> lst_sanPham = new List<SanPham>();
            List<ChiTietHoaDon> lst_cthd = new List<ChiTietHoaDon>();
            List<HoaDon> lst_hd = new List<HoaDon>();
            int mth = Convert.ToInt32(dateTimePicker1.Value.Month);
            int yr = Convert.ToInt32(dateTimePicker2.Value.Year);
            try
            {
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
                conn.Open();
                query = "select * from ChiTietHoaDon";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ChiTietHoaDon obj_ChiTietHoaDon = new ChiTietHoaDon(dr);
                    lst_cthd.Add(obj_ChiTietHoaDon);
                }
                conn.Close();
                conn.Open();
                query = "select * from HoaDon";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    HoaDon obj_hd = new HoaDon(dr);
                    lst_hd.Add(obj_hd);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (SanPham c in lst_sanPham)
            {
                SanPhamThongKe temp = new SanPhamThongKe("","",0);
                temp.MaSanPham1 = c.MaSanPham;
                temp.TenSanPham1 = c.TenSanPham;
                temp.Soluong = 0;
                tklst.Add(temp);
            }
            foreach (SanPhamThongKe c in tklst)
            {
                foreach (ChiTietHoaDon c1 in lst_cthd)
                {
                    foreach (HoaDon c2 in lst_hd)
                    {
                        if (c.MaSanPham1 == c1.MaSanPham && c1.MaChiTietHoaDon == c2.MaHoaDon && c2.NgayLapHoaDon.Month == mth && c2.NgayLapHoaDon.Year == yr) c.Soluong += c1.SoLuong;
                    }
                }
            }
            bool ok = false;
            foreach (SanPhamThongKe c in tklst)
                if (c.Soluong > 0)
                {
                    chart_banchay.Series["BanChayNhat"].Points.AddXY(c.TenSanPham1, c.Soluong);
                    ok = true;
                }
            if (ok == false) MessageBox.Show("Chua co san pham trong thang!!");
            dataGridView1.DataSource = tklst;
        }

        private void frm_tkSanPham_Load(object sender, EventArgs e)
        {
            SetMyCustomFormat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load1();
            SetMyCustomFormat();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    exportExcel(dataGridView1, @"D:\DoAnLapTrinh.NET\", textBox1.Text);
                    MessageBox.Show("File đã được tạo, xem tại D:/DoAnLapTrinh.NET/" + textBox1.Text + ".xlsx");
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
