using System;
using System.Windows.Forms;
using Project_QuanLiSinhVien_DoAn.GUI;
namespace Project_QuanLiSinhVien_DoAn
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
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new frm_Login());
        }
    }
}
