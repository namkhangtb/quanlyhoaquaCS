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
    public partial class frm_tkDoanhThu : Form
    {
        public frm_tkDoanhThu()
        {
            InitializeComponent();
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy";
            dateTimePicker2.ShowUpDown = true;
        }

        public void load()
        {
            SetMyCustomFormat();
            chart1.Series["BanRa"].Points.Clear();
            chart1.Series["MuaVao"].Points.Clear();
            List<PhieuNhap> lst_pn = new List<PhieuNhap>();
            List<HoaDon> lst_hd = new List<HoaDon>();
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "select * from PhieuNhap";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PhieuNhap obj = new PhieuNhap(dr);
                    lst_pn.Add(obj);
                }
                conn.Close();
                dataGridView2.DataSource = lst_pn;
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
                dataGridView1.DataSource = lst_hd;
                for (int i=1; i<=12; ++i)
                {
                    int sumhd = 0;
                    foreach (HoaDon c in lst_hd)
                    {
                        if (c.NgayLapHoaDon.Month == i && c.NgayLapHoaDon.Year == dateTimePicker2.Value.Year) sumhd += Convert.ToInt32(c.TongTien);
                    }
                    int sumpn = 0;
                    foreach (PhieuNhap c in lst_pn)
                    {
                        if (c.NgayNhap.Month == i && c.NgayNhap.Year == dateTimePicker2.Value.Year) sumpn += Convert.ToInt32(c.TongTien);
                    }
                    chart1.Series["BanRa"].Points.AddXY(i, sumhd);
                    chart1.Series["MuaVao"].Points.AddXY(i, sumpn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_tkDoanhThu_Load(object sender, EventArgs e)
        {
            SetMyCustomFormat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetMyCustomFormat();
            load();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != "")
                {
                    exportExcel(dataGridView2, @"D:\DoAnLapTrinh.NET\", textBox2.Text);
                    MessageBox.Show("File đã được tạo, xem tại D:/DoAnLapTrinh.NET/" + textBox2.Text + ".xlsx");
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
