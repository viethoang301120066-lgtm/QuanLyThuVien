using System;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frmDoiMatKhau : Form
    {
        private readonly TaiKhoanBLL _bll = new TaiKhoanBLL();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (UI.Try(() => _bll.DoiMatKhau(txtMatKhauCu.Text, txtMatKhauMoi.Text, txtXacNhan.Text)))
            {
                UI.Info("Đổi mật khẩu thành công.");
                Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e) => Close();
    }
}
