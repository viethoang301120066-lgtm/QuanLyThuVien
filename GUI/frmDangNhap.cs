using System;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        private readonly TaiKhoanBLL _bll = new TaiKhoanBLL();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            UI.Try(() =>
            {
                PhienDangNhap.TaiKhoan = _bll.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text);
                DialogResult = DialogResult.OK;
            });
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
