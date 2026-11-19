using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmSach : Form
    {
        private readonly SachBLL _bll = new SachBLL();
        private bool _dangTai = true;   // chặn sự kiện lọc khi đang khởi tạo combobox

        public frmSach()
        {
            InitializeComponent();
            UI.StyleGrid(dgvSach);
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            UI.Try(() =>
            {
                var tl = new DanhMucBLL(LoaiDanhMuc.TheLoai);
                var tg = new DanhMucBLL(LoaiDanhMuc.TacGia);
                var nxb = new DanhMucBLL(LoaiDanhMuc.NhaXuatBan);
                UI.BindCombo(cbTheLoai, tl.Search());
                UI.BindCombo(cbTacGia, tg.Search());
                UI.BindCombo(cbNXB, nxb.Search());
                UI.BindCombo(cbLocTheLoai, tl.Search(), "-- Mọi thể loại --");
                UI.BindCombo(cbLocTacGia, tg.Search(), "-- Mọi tác giả --");
                UI.BindCombo(cbLocNXB, nxb.Search(), "-- Mọi NXB --");
                cbTinhTrang.Items.AddRange(new object[] { "Tất cả", "Còn sách", "Hết sách" });
                cbTinhTrang.SelectedIndex = 0;
                numNamXB.Maximum = DateTime.Now.Year;
                numNamXB.Value = DateTime.Now.Year;
            });
            _dangTai = false;
            TaiDanhSach();
            txtTimKiem.TextChanged += (s, ev) => { tmrTimKiem.Stop(); tmrTimKiem.Start(); };
        }

        // ---------------- Lọc ----------------
        private SachFilter LayBoLoc() => new SachFilter
        {
            TuKhoa = txtTimKiem.Text,
            MaTheLoai = UI.SelectedId(cbLocTheLoai),
            MaTacGia = UI.SelectedId(cbLocTacGia),
            MaNXB = UI.SelectedId(cbLocNXB),
            NamTu = numNamTu.Value > 0 ? (int?)numNamTu.Value : null,
            NamDen = numNamDen.Value > 0 ? (int?)numNamDen.Value : null,
            ConSach = cbTinhTrang.SelectedIndex == 1 ? true : cbTinhTrang.SelectedIndex == 2 ? false : (bool?)null
        };

        private void TaiDanhSach()
        {
            if (_dangTai) return;
            UI.Try(() =>
            {
                dgvSach.DataSource = _bll.Search(LayBoLoc());
                UI.Columns(dgvSach, "MaSach:Mã", "TenSach:Tên sách", "TenTheLoai:Thể loại", "TenTacGia:Tác giả",
                    "TenNXB:Nhà XB", "NamXB:Năm", "SoLuong:Tổng", "SoLuongCon:Còn");
                dgvSach.Columns["TenSach"].FillWeight = 250;
                lblKetQua.Text = $"  Tìm thấy {dgvSach.Rows.Count} đầu sách. (Dòng tô đỏ = đã hết sách)";
            });
        }

        // Gõ phím: đợi 300ms sau lần gõ cuối mới tìm (tránh truy vấn liên tục)
        private void tmrTimKiem_Tick(object sender, EventArgs e)
        {
            tmrTimKiem.Stop();
            TaiDanhSach();
        }

        private void BoLoc_Changed(object sender, EventArgs e) => TaiDanhSach();

        private void btnXoaLoc_Click(object sender, EventArgs e)
        {
            _dangTai = true;
            txtTimKiem.Clear();
            cbLocTheLoai.SelectedIndex = cbLocTacGia.SelectedIndex = cbLocNXB.SelectedIndex = 0;
            numNamTu.Value = numNamDen.Value = 0;
            cbTinhTrang.SelectedIndex = 0;
            _dangTai = false;
            tmrTimKiem.Stop();
            TaiDanhSach();
        }

        private void dgvSach_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvSach.Rows)
                if (Convert.ToInt32(r.Cells["SoLuongCon"].Value) <= 0)
                    r.DefaultCellStyle.BackColor = UI.MauCanhBao;
        }

        // ---------------- CRUD ----------------
        private void dgvSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSach.CurrentRow == null) return;
            var r = ((DataRowView)dgvSach.CurrentRow.DataBoundItem).Row;
            txtMaSach.Text = r["MaSach"].ToString();
            txtTenSach.Text = r["TenSach"].ToString();
            cbTheLoai.SelectedValue = r["MaTheLoai"];
            cbTacGia.SelectedValue = r["MaTacGia"];
            cbNXB.SelectedValue = r["MaNXB"];
            numNamXB.Value = Math.Min(numNamXB.Maximum, Convert.ToDecimal(r["NamXB"]));
            numSoLuong.Value = Convert.ToDecimal(r["SoLuong"]);
        }

        private SachDTO DocForm() => new SachDTO
        {
            MaSach = int.TryParse(txtMaSach.Text, out int ma) ? ma : 0,
            TenSach = txtTenSach.Text,
            MaTheLoai = UI.SelectedId(cbTheLoai) ?? 0,
            MaTacGia = UI.SelectedId(cbTacGia) ?? 0,
            MaNXB = UI.SelectedId(cbNXB) ?? 0,
            NamXB = (int)numNamXB.Value,
            SoLuong = (int)numSoLuong.Value
        };

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (UI.Try(() => _bll.Them(DocForm()))) { UI.Info("Đã thêm sách."); TaiDanhSach(); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "") { UI.Warn("Hãy chọn sách cần sửa."); return; }
            if (UI.Try(() => _bll.Sua(DocForm()))) { UI.Info("Đã cập nhật."); TaiDanhSach(); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "") { UI.Warn("Hãy chọn sách cần xóa."); return; }
            if (!UI.Confirm($"Xóa sách \"{txtTenSach.Text}\"?")) return;
            if (UI.Try(() => _bll.Xoa(int.Parse(txtMaSach.Text)))) { TaiDanhSach(); btnLamMoi_Click(null, null); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvSach.ClearSelection();
            txtMaSach.Clear();
            txtTenSach.Clear();
            numSoLuong.Value = 1;
            numNamXB.Value = numNamXB.Maximum;
            txtTenSach.Focus();
        }

        // ---------------- Xuất file (theo kết quả lọc hiện tại) ----------------
        private void btnXuatExcel_Click(object sender, EventArgs e) => XuatFile.XuatExcel(dgvSach, "Danh sách sách");
        private void btnIn_Click(object sender, EventArgs e) => XuatFile.InBang(dgvSach, "Danh sách sách");
    }
}
