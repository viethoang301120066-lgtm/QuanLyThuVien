using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    /// <summary>Quản lý tài khoản (chỉ Admin).</summary>
    public partial class frmTaiKhoan : Form
    {
        private readonly TaiKhoanBLL _bll = new TaiKhoanBLL();

        public frmTaiKhoan()
        {
            InitializeComponent();
            UI.StyleGrid(dgvTaiKhoan);
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            cbVaiTro.Items.AddRange(new object[] { "ThuThu", "Admin" });
            cbVaiTro.SelectedIndex = 0;
            TaiDanhSach();
        }

        private void TaiDanhSach()
        {
            UI.Try(() =>
            {
                dgvTaiKhoan.DataSource = _bll.GetAll();
                UI.Columns(dgvTaiKhoan, "TenDangNhap:Tên đăng nhập", "HoTen:Họ tên", "VaiTro:Vai trò");
            });
        }

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow == null) return;
            var r = ((DataRowView)dgvTaiKhoan.CurrentRow.DataBoundItem).Row;
            txtTenDangNhap.Text = r["TenDangNhap"].ToString();
            txtTenDangNhap.ReadOnly = true;          // khóa chính, không cho sửa
            txtHoTen.Text = r["HoTen"].ToString();
            cbVaiTro.SelectedItem = r["VaiTro"].ToString();
            txtMatKhau.Clear();
        }

        private TaiKhoanDTO DocForm() => new TaiKhoanDTO
        {
            TenDangNhap = txtTenDangNhap.Text.Trim(),
            HoTen = txtHoTen.Text.Trim(),
            VaiTro = cbVaiTro.Text
        };

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (UI.Try(() => _bll.Them(DocForm(), txtMatKhau.Text)))
            {
                UI.Info("Đã thêm tài khoản.");
                TaiDanhSach();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!txtTenDangNhap.ReadOnly) { UI.Warn("Hãy chọn tài khoản cần sửa."); return; }
            if (UI.Try(() => _bll.Sua(DocForm()))) { UI.Info("Đã cập nhật."); TaiDanhSach(); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!txtTenDangNhap.ReadOnly) { UI.Warn("Hãy chọn tài khoản cần xóa."); return; }
            if (!UI.Confirm($"Xóa tài khoản \"{txtTenDangNhap.Text}\"?")) return;
            if (UI.Try(() => _bll.Xoa(txtTenDangNhap.Text))) { TaiDanhSach(); btnLamMoi_Click(null, null); }
        }

        private void btnDatLaiMK_Click(object sender, EventArgs e)
        {
            if (!txtTenDangNhap.ReadOnly) { UI.Warn("Hãy chọn tài khoản."); return; }
            if (UI.Try(() => _bll.DatLaiMatKhau(txtTenDangNhap.Text, txtMatKhau.Text)))
            {
                UI.Info("Đã đặt lại mật khẩu.");
                txtMatKhau.Clear();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan.ClearSelection();
            txtTenDangNhap.ReadOnly = false;
            txtTenDangNhap.Clear();
            txtHoTen.Clear();
            txtMatKhau.Clear();
            cbVaiTro.SelectedIndex = 0;
            txtTenDangNhap.Focus();
        }
    }
}
