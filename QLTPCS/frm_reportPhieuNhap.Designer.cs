
namespace QLTPCS
{
    partial class frm_reportPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_maPhieuNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xemBaoCao = new System.Windows.Forms.Button();
            this.rpv_phieuNhap = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // txt_maPhieuNhap
            // 
            this.txt_maPhieuNhap.Location = new System.Drawing.Point(288, 46);
            this.txt_maPhieuNhap.Name = "txt_maPhieuNhap";
            this.txt_maPhieuNhap.Size = new System.Drawing.Size(208, 20);
            this.txt_maPhieuNhap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phiếu Nhâp:";
            // 
            // btn_xemBaoCao
            // 
            this.btn_xemBaoCao.Location = new System.Drawing.Point(542, 44);
            this.btn_xemBaoCao.Name = "btn_xemBaoCao";
            this.btn_xemBaoCao.Size = new System.Drawing.Size(87, 23);
            this.btn_xemBaoCao.TabIndex = 2;
            this.btn_xemBaoCao.Text = "Xem Báo Cáo";
            this.btn_xemBaoCao.UseVisualStyleBackColor = true;
            this.btn_xemBaoCao.Click += new System.EventHandler(this.btn_xemBaoCao_Click);
            // 
            // rpv_phieuNhap
            // 
            this.rpv_phieuNhap.Location = new System.Drawing.Point(12, 89);
            this.rpv_phieuNhap.Name = "rpv_phieuNhap";
            this.rpv_phieuNhap.ServerReport.BearerToken = null;
            this.rpv_phieuNhap.Size = new System.Drawing.Size(776, 349);
            this.rpv_phieuNhap.TabIndex = 3;
            // 
            // frm_reportPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpv_phieuNhap);
            this.Controls.Add(this.btn_xemBaoCao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_maPhieuNhap);
            this.Name = "frm_reportPhieuNhap";
            this.Text = "Report Phiếu Nhập";
            this.Load += new System.EventHandler(this.frm_reportPhieuNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_maPhieuNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xemBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_phieuNhap;
    }
}