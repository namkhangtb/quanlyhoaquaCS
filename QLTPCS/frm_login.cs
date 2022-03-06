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
namespace QLTPCS
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        private bool checkLogin()
        {
            string tk = txt_tenDangNhap.Text;
            string mk = txt_matKhau.Text;
            if (tk == "" && mk == "" )
            {
                MessageBox.Show("Mời nhập tên đăng nhập và mật khẩu !!!");
                txt_tenDangNhap.Focus();
                return false;
            }
            else if (tk == "")
            {
                MessageBox.Show("Mời nhập tên đăng nhập !!!");
                txt_tenDangNhap.Focus();
                return false;
            }
            else if (mk == "")
            {
                MessageBox.Show("Mời nhập mật khẩu !!!");
                txt_tenDangNhap.Focus();
                return false;
            }
            return true;
        }
        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection conn = new SqlConnection("Data Source=NAM_KHANG\\SQLEXPRESS;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                string tk = txt_tenDangNhap.Text;
                string mk = txt_matKhau.Text;
                conn.Open();
                string query = "select count (*) from TaiKhoan where TenDangNhap = @tk and MatKhau = @mk";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", tk));
                cmd.Parameters.Add(new SqlParameter("@mk", mk));
                int sl = (int)cmd.ExecuteScalar();
                conn.Close();
                if (sl == 1)
                {
                    MessageBox.Show("Đăng nhập thành công !!!");
                    /*Application.Run(new frm_main());*/
                    frm_main frm = new frm_main();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    checkLogin();
                    MessageBox.Show("Đăng nhập thất bại !!! Hãy kiểm tra lại tên đăng nhập hoặc mặt khẩu");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_dangKi_Click(object sender, EventArgs e)
        {
            frm_signup frm_Signup = new frm_signup();
            frm_Signup.Show();
            this.Hide();
        }
    }
}
