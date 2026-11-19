using System;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Vòng lặp: đăng nhập -> màn hình chính -> (đăng xuất) -> đăng nhập lại
            while (true)
            {
                using (var login = new frmDangNhap())
                {
                    if (login.ShowDialog() != DialogResult.OK) return;
                }
                var main = new frmMain();
                Application.Run(main);
                if (!main.DangXuat) return;
            }
        }
    }
}
