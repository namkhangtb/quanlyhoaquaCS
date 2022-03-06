using Microsoft.Reporting.WinForms;
using QLTPCS.DataAcessLayer;
using QLTPCS.Reportings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTPCS
{
    public partial class frm_reportPhieuNhap : Form
    {
        public frm_reportPhieuNhap()
        {
            InitializeComponent();
        }

        private void frm_reportPhieuNhap_Load(object sender, EventArgs e)
        {
            HienThiKetQuaReportPhieuNhap();
        }

        private void HienThiKetQuaReportPhieuNhap()
        {
            using (var _dbContext = new QuanLyPhieuNhapDbContext())
            {
                string truyVanSQL = "Select ctpn.MaCTPN, ctpn.MaPhieuNhap, ctpn.MaSanPham, sp.TenSanPham, ctpn.SoLuong, ctpn.DonGia " +
                    "From PhieuNhap pn, ChiTietPhieuNhap ctpn, SanPham sp " +
                    "where pn.MaPhieuNhap = ctpn.MaPhieuNhap and ctpn.MaSanPham = sp.MaSanPham";

                List<ReportPhieuNhap> danhSach = _dbContext.Database.SqlQuery<ReportPhieuNhap>(truyVanSQL).ToList();

                if (txt_maPhieuNhap.Text != "")
                {
                    danhSach = danhSach.Where(pn => pn.MaPhieuNhap.ToLower() == txt_maPhieuNhap.Text.ToLower()).ToList();
                }
                this.rpv_phieuNhap.LocalReport.ReportPath = "ReportPhieuNhapSanPham.rdlc";
                var reportDataSource = new ReportDataSource("ReportPhieuNhapDataSet", danhSach);
                this.rpv_phieuNhap.LocalReport.DataSources.Clear();
                this.rpv_phieuNhap.LocalReport.DataSources.Add(reportDataSource);
                this.rpv_phieuNhap.RefreshReport();
            }
        }

        private void btn_xemBaoCao_Click(object sender, EventArgs e)
        {
            HienThiKetQuaReportPhieuNhap();
        }
    }
}
