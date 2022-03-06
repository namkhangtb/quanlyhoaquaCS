
namespace QLTPCS
{
    partial class frm_login
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tenDangNhap = new System.Windows.Forms.TextBox();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.btn_dangKi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_matKhau = new System.Windows.Forms.Label();
            this.lb_tenDangNhap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.Location = new System.Drawing.Point(173, 98);
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Size = new System.Drawing.Size(112, 20);
            this.txt_tenDangNhap.TabIndex = 1;
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Location = new System.Drawing.Point(173, 161);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.PasswordChar = '*';
            this.txt_matKhau.Size = new System.Drawing.Size(112, 20);
            this.txt_matKhau.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Location = new System.Drawing.Point(89, 224);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(75, 30);
            this.btn_dangNhap.TabIndex = 4;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // btn_dangKi
            // 
            this.btn_dangKi.Location = new System.Drawing.Point(210, 224);
            this.btn_dangKi.Name = "btn_dangKi";
            this.btn_dangKi.Size = new System.Drawing.Size(75, 30);
            this.btn_dangKi.TabIndex = 5;
            this.btn_dangKi.Text = "Đăng kí";
            this.btn_dangKi.UseVisualStyleBackColor = true;
            this.btn_dangKi.Click += new System.EventHandler(this.btn_dangKi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đăng nhập hệ thống";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_matKhau
            // 
            this.lb_matKhau.AutoSize = true;
            this.lb_matKhau.Location = new System.Drawing.Point(291, 164);
            this.lb_matKhau.Name = "lb_matKhau";
            this.lb_matKhau.Size = new System.Drawing.Size(0, 13);
            this.lb_matKhau.TabIndex = 17;
            // 
            // lb_tenDangNhap
            // 
            this.lb_tenDangNhap.AutoSize = true;
            this.lb_tenDangNhap.Location = new System.Drawing.Point(291, 101);
            this.lb_tenDangNhap.Name = "lb_tenDangNhap";
            this.lb_tenDangNhap.Size = new System.Drawing.Size(0, 13);
            this.lb_tenDangNhap.TabIndex = 16;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 367);
            this.Controls.Add(this.lb_matKhau);
            this.Controls.Add(this.lb_tenDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_dangKi);
            this.Controls.Add(this.btn_dangNhap);
            this.Controls.Add(this.txt_matKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tenDangNhap);
            this.Controls.Add(this.label1);
            this.Name = "frm_login";
            this.Text = "frm_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tenDangNhap;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.Button btn_dangKi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_matKhau;
        private System.Windows.Forms.Label lb_tenDangNhap;
    }
}