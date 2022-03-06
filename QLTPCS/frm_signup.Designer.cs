
namespace QLTPCS
{
    partial class frm_signup
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dangKi = new System.Windows.Forms.Button();
            this.btn_quayLai = new System.Windows.Forms.Button();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_tenDangNhap = new System.Windows.Forms.Label();
            this.lb_matKhau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Đăng kí tài khoản";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_dangKi
            // 
            this.btn_dangKi.Location = new System.Drawing.Point(87, 238);
            this.btn_dangKi.Name = "btn_dangKi";
            this.btn_dangKi.Size = new System.Drawing.Size(75, 30);
            this.btn_dangKi.TabIndex = 12;
            this.btn_dangKi.Text = "Đăng kí";
            this.btn_dangKi.UseVisualStyleBackColor = true;
            this.btn_dangKi.Click += new System.EventHandler(this.btn_dangKi_Click);
            // 
            // btn_quayLai
            // 
            this.btn_quayLai.Location = new System.Drawing.Point(208, 238);
            this.btn_quayLai.Name = "btn_quayLai";
            this.btn_quayLai.Size = new System.Drawing.Size(75, 30);
            this.btn_quayLai.TabIndex = 11;
            this.btn_quayLai.Text = "Quay lại";
            this.btn_quayLai.UseVisualStyleBackColor = true;
            this.btn_quayLai.Click += new System.EventHandler(this.btn_quayLai_Click);
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Location = new System.Drawing.Point(171, 181);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.PasswordChar = '*';
            this.txt_matKhau.Size = new System.Drawing.Size(112, 20);
            this.txt_matKhau.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu";
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.Location = new System.Drawing.Point(171, 126);
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Size = new System.Drawing.Size(112, 20);
            this.txt_tenDangNhap.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên đăng nhập";
            // 
            // lb_tenDangNhap
            // 
            this.lb_tenDangNhap.AutoSize = true;
            this.lb_tenDangNhap.Location = new System.Drawing.Point(289, 129);
            this.lb_tenDangNhap.Name = "lb_tenDangNhap";
            this.lb_tenDangNhap.Size = new System.Drawing.Size(0, 13);
            this.lb_tenDangNhap.TabIndex = 14;
            // 
            // lb_matKhau
            // 
            this.lb_matKhau.AutoSize = true;
            this.lb_matKhau.Location = new System.Drawing.Point(289, 184);
            this.lb_matKhau.Name = "lb_matKhau";
            this.lb_matKhau.Size = new System.Drawing.Size(0, 13);
            this.lb_matKhau.TabIndex = 15;
            // 
            // frm_signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 330);
            this.Controls.Add(this.lb_matKhau);
            this.Controls.Add(this.lb_tenDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_dangKi);
            this.Controls.Add(this.btn_quayLai);
            this.Controls.Add(this.txt_matKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tenDangNhap);
            this.Controls.Add(this.label1);
            this.Name = "frm_signup";
            this.Text = "frm_signup";
            this.Load += new System.EventHandler(this.frm_signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_dangKi;
        private System.Windows.Forms.Button btn_quayLai;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_tenDangNhap;
        private System.Windows.Forms.Label lb_matKhau;
    }
}