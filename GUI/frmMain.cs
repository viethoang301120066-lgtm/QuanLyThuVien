using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmMain : Form
    {
        private Form _formHienTai;
        private Button _nutHienTai;

        /// <summary>true nếu người dùng bấm Đăng xuất (Program sẽ hiện lại form đăng nhập).</summary>
        public bool DangXuat { get; private set; }

        public frmMain()
        {
            InitializeComponent();
            lblXinChao.Text = $"Xin chào, {PhienDangNhap.TaiKhoan.HoTen} ({PhienDangNhap.TaiKhoan.VaiTro})";
            btnTaiKhoan.Visible = PhienDangNhap.LaAdmin;   // Chỉ Admin được quản lý tài khoản
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Menu_Click(btnTongQuan, EventArgs.Empty);
        }

        /// <summary>Hiển thị một form con bên trong vùng nội dung.</summary>
        private void MoForm(Form f, Button nut)
        {
            _formHienTai?.Close();
            _formHienTai = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnlNoiDung.Controls.Add(f);
            f.Show();

            if (_nutHienTai != null) _nutHienTai.BackColor = pnlMenu.BackColor;
            _nutHienTai = nut;
            nut.BackColor = UI.MauChinh;
            lblTieuDe.Text = nut.Text.Trim();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            var nut = (Button)sender;
            if (nut == btnTongQuan) MoForm(new frmDashboard(), nut);
            else if (nut == btnSach) MoForm(new frmSach(), nut);
            else if (nut == btnTheLoai) MoForm(new frmDanhMuc(LoaiDanhMuc.TheLoai), nut);
            else if (nut == btnTacGia) MoForm(new frmDanhMuc(LoaiDanhMuc.TacGia), nut);
            else if (nut == btnNXB) MoForm(new frmDanhMuc(LoaiDanhMuc.NhaXuatBan), nut);
            else if (nut == btnDocGia) MoForm(new frmDocGia(), nut);
            else if (nut == btnMuonSach) MoForm(new frmMuonSach(), nut);
            else if (nut == btnTraSach) MoForm(new frmTraSach(), nut);
            else if (nut == btnTaiKhoan) MoForm(new frmTaiKhoan(), nut);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            using (var f = new frmDoiMatKhau()) f.ShowDialog(this);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (!UI.Confirm("Bạn có muốn đăng xuất?")) return;
            PhienDangNhap.TaiKhoan = null;
            DangXuat = true;
            Close();
        }
    }
}
