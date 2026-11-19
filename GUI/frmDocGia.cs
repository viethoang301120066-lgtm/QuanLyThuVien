using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmDocGia : Form
    {
        private readonly DocGiaBLL _bll = new DocGiaBLL();

        // Giá trị lọc tương ứng với từng mục trong cbTinhTrang
        private static readonly string[] MaTinhTrang = { "", "ConHan", "HetHan", "DangMuon", "QuaHan" };

        public frmDocGia()
        {
            InitializeComponent();
            UI.StyleGrid(dgvDocGia);
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbTinhTrang.Items.AddRange(new object[]
                { "Tất cả", "Thẻ còn hạn", "Thẻ hết hạn", "Đang mượn sách", "Có sách quá hạn" });
            cbTinhTrang.SelectedIndex = 0;   // gọi TaiDanhSach qua sự kiện
            btnLamMoi_Click(null, null);
            txtTimKiem.TextChanged += (s, ev) => { tmrTimKiem.Stop(); tmrTimKiem.Start(); };
        }

        private void TaiDanhSach()
        {
            UI.Try(() =>
            {
                dgvDocGia.DataSource = _bll.Search(txtTimKiem.Text, MaTinhTrang[Math.Max(0, cbTinhTrang.SelectedIndex)]);
                UI.Columns(dgvDocGia, "MaDocGia:Mã", "HoTen:Họ tên", "GioiTinh:Giới tính", "NgaySinh:Ngày sinh",
                    "SoDienThoai:SĐT", "Email:Email", "NgayHetHan:Hết hạn thẻ", "DangMuon:Đang mượn", "QuaHan:Quá hạn");
                dgvDocGia.Columns["HoTen"].FillWeight = 180;
                lblKetQua.Text = $"  {dgvDocGia.Rows.Count} độc giả. (Đỏ = có sách quá hạn, xám = thẻ hết hạn)";
            });
        }

        private void tmrTimKiem_Tick(object sender, EventArgs e)
        {
            tmrTimKiem.Stop();
            TaiDanhSach();
        }

        private void cbTinhTrang_SelectedIndexChanged(object sender, EventArgs e) => TaiDanhSach();

        private void dgvDocGia_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDocGia.Rows)
            {
                if (Convert.ToInt32(r.Cells["QuaHan"].Value) > 0)
                    r.DefaultCellStyle.BackColor = UI.MauCanhBao;
                else if ((DateTime)r.Cells["NgayHetHan"].Value < DateTime.Today)
                    r.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void dgvDocGia_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDocGia.CurrentRow == null) return;
            var r = ((DataRowView)dgvDocGia.CurrentRow.DataBoundItem).Row;
            txtMaDocGia.Text = r["MaDocGia"].ToString();
            txtHoTen.Text = r["HoTen"].ToString();
            cbGioiTinh.SelectedItem = r["GioiTinh"].ToString();
            if (r["NgaySinh"] == DBNull.Value) dtpNgaySinh.Checked = false;
            else { dtpNgaySinh.Value = (DateTime)r["NgaySinh"]; dtpNgaySinh.Checked = true; }
            txtSoDienThoai.Text = r["SoDienThoai"].ToString();
            txtEmail.Text = r["Email"].ToString();
            txtDiaChi.Text = r["DiaChi"].ToString();
            dtpNgayLapThe.Value = (DateTime)r["NgayLapThe"];
            dtpNgayHetHan.Value = (DateTime)r["NgayHetHan"];
        }

        private DocGiaDTO DocForm() => new DocGiaDTO
        {
            MaDocGia = int.TryParse(txtMaDocGia.Text, out int ma) ? ma : 0,
            HoTen = txtHoTen.Text,
            GioiTinh = cbGioiTinh.Text,
            NgaySinh = dtpNgaySinh.Checked ? dtpNgaySinh.Value.Date : (DateTime?)null,
            SoDienThoai = txtSoDienThoai.Text.Trim(),
            Email = txtEmail.Text.Trim(),
            DiaChi = txtDiaChi.Text.Trim(),
            NgayLapThe = dtpNgayLapThe.Value.Date,
            NgayHetHan = dtpNgayHetHan.Value.Date
        };

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (UI.Try(() => _bll.Them(DocForm()))) { UI.Info("Đã thêm độc giả."); TaiDanhSach(); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text == "") { UI.Warn("Hãy chọn độc giả cần sửa."); return; }
            if (UI.Try(() => _bll.Sua(DocForm()))) { UI.Info("Đã cập nhật."); TaiDanhSach(); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text == "") { UI.Warn("Hãy chọn độc giả cần xóa."); return; }
            if (!UI.Confirm($"Xóa độc giả \"{txtHoTen.Text}\"?")) return;
            if (UI.Try(() => _bll.Xoa(int.Parse(txtMaDocGia.Text)))) { TaiDanhSach(); btnLamMoi_Click(null, null); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDocGia.ClearSelection();
            txtMaDocGia.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            cbGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Today.AddYears(-18);
            dtpNgaySinh.Checked = false;
            dtpNgayLapThe.Value = DateTime.Today;
            dtpNgayHetHan.Value = DateTime.Today.AddMonths(QuyDinh.ThoiHanTheThang);
            txtHoTen.Focus();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e) => XuatFile.XuatExcel(dgvDocGia, "Danh sách độc giả");
        private void btnIn_Click(object sender, EventArgs e) => XuatFile.InBang(dgvDocGia, "Danh sách độc giả");
    }
}
