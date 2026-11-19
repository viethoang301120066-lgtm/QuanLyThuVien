using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    /// <summary>Một form dùng chung cho Thể loại / Tác giả / Nhà xuất bản.</summary>
    public partial class frmDanhMuc : Form
    {
        private readonly DanhMucBLL _bll;
        private readonly string _tenLoai;

        public frmDanhMuc() : this(LoaiDanhMuc.TheLoai) { }   // cần cho VS Designer

        public frmDanhMuc(LoaiDanhMuc loai)
        {
            InitializeComponent();
            _bll = new DanhMucBLL(loai);
            _tenLoai = loai == LoaiDanhMuc.TheLoai ? "thể loại" : loai == LoaiDanhMuc.TacGia ? "tác giả" : "nhà xuất bản";
            grpThongTin.Text = "Thông tin " + _tenLoai;
            lblTen.Text = "Tên " + _tenLoai;
            txtTen.Left = lblTen.Right + 10;
            UI.StyleGrid(dgvDanhMuc);
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            TaiDanhSach();
            txtTimKiem.TextChanged += (s, ev) => { tmrTimKiem.Stop(); tmrTimKiem.Start(); };
        }

        private void TaiDanhSach()
        {
            UI.Try(() =>
            {
                dgvDanhMuc.DataSource = _bll.Search(txtTimKiem.Text);
                UI.Columns(dgvDanhMuc, "Ma:Mã", "Ten:Tên " + _tenLoai, "SoDauSach:Số đầu sách");
                dgvDanhMuc.Columns["Ten"].FillWeight = 300;
                lblKetQua.Text = $"  {dgvDanhMuc.Rows.Count} {_tenLoai}";
            });
        }

        private void tmrTimKiem_Tick(object sender, EventArgs e)
        {
            tmrTimKiem.Stop();
            TaiDanhSach();
        }

        private void dgvDanhMuc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhMuc.CurrentRow == null) return;
            var r = ((DataRowView)dgvDanhMuc.CurrentRow.DataBoundItem).Row;
            txtMa.Text = r["Ma"].ToString();
            txtTen.Text = r["Ten"].ToString();
        }

        private DanhMucDTO DocForm() => new DanhMucDTO
        {
            Ma = int.TryParse(txtMa.Text, out int ma) ? ma : 0,
            Ten = txtTen.Text
        };

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (UI.Try(() => _bll.Them(DocForm()))) { UI.Info("Đã thêm " + _tenLoai + "."); TaiDanhSach(); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "") { UI.Warn("Hãy chọn dòng cần sửa."); return; }
            if (UI.Try(() => _bll.Sua(DocForm()))) { UI.Info("Đã cập nhật."); TaiDanhSach(); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "") { UI.Warn("Hãy chọn dòng cần xóa."); return; }
            if (!UI.Confirm($"Xóa {_tenLoai} \"{txtTen.Text}\"?")) return;
            if (UI.Try(() => _bll.Xoa(int.Parse(txtMa.Text)))) { TaiDanhSach(); btnLamMoi_Click(null, null); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDanhMuc.ClearSelection();
            txtMa.Clear();
            txtTen.Clear();
            txtTen.Focus();
        }
    }
}
