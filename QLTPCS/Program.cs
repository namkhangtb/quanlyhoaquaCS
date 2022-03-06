using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTPCS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*frm_login frm_Login = new frm_login();
            Application.Run(frm_Login);
            
            if (frm_Login.isLogin == true)
            {
                // finish thì cho dòng run form main vào đây
                Application.Run(new frm_main());
            }*/
            Application.Run(new frm_login());
            //Application.Run(new frm_reportPhieuNhap());
        }
    }
}
