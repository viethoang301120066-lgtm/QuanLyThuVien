using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmMuonSach : Form
    {
        private readonly MuonTraBLL _muonTra = new MuonTraBLL();
        private readonly DocGiaBLL _docGia = new DocGiaBLL();
        private readonly SachBLL _sach = new SachBLL();

        /// <summary>Một cuốn sách trong danh sách chuẩn bị mượn.</summary>
        private class SachChon
        {
            public int Ma { get; set; }
            public string Ten { get; set; }
            public override string ToString() => $"[{Ma}] {Ten}";
        }

        public frmMuonSach()
        {
            InitializeComponent();
            UI.StyleGrid(dgvSach);
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            dtpHanTra.Value = DateTime.Today.AddDays(QuyDinh.SoNgayMuonMacDinh);
            TaiDocGia();
            TaiSach();
            txtTimSach.TextChanged += (s, ev) => { tmrTimKiem.Stop(); tmrTimKiem.Start(); };
        }

        private void TaiDocGia()
        {
            UI.Try(() =>
            {
                var dt = new DataTable();
                dt.Columns.Add("Ma", typeof(int));
                dt.Columns.Add("Ten", typeof(string));
                foreach (DataRow r in _docGia.Search("", "ConHan").Rows)
                    dt.Rows.Add(r["MaDocGia"], $"{r["MaDocGia"]} - {r["HoTen"]} - {r["SoDienThoai"]}");
                UI.BindCombo(cbDocGia, dt);
                cbDocGia.SelectedIndex = -1;
                lblThongTinDG.Text = "Gõ tên / mã / SĐT để tìm nhanh (chỉ hiện độc giả có thẻ còn hạn).";
            });
        }

        private void TaiSach()
        {
            UI.Try(() =>
            {
                dgvSach.DataSource = _sach.Search(new SachFilter { TuKhoa = txtTimSach.Text });
                UI.Columns(dgvSach, "MaSach:Mã", "TenSach:Tên sách", "TenTacGia:Tác giả", "SoLuongCon:Còn");
                dgvSach.Columns["TenSach"].FillWeight = 250;
            });
        }

        private void tmrTimKiem_Tick(object sender, EventArgs e)
        {
            tmrTimKiem.Stop();
            TaiSach();
        }

        private void dgvSach_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvSach.Rows)
                if (Convert.ToInt32(r.Cells["SoLuongCon"].Value) <= 0)
                    r.DefaultCellStyle.ForeColor = Color.Silver;
        }

        private void cbDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? ma = cbDocGia.SelectedIndex >= 0 ? UI.SelectedId(cbDocGia) : null;
            if (ma == null) return;
            UI.Try(() =>
            {
                var r = _docGia.GetById(ma.Value);
                int dangMuon = (int)r["DangMuon"], quaHan = (int)r["QuaHan"];
                lblThongTinDG.Text = $"Thẻ hết hạn: {(DateTime)r["NgayHetHan"]:dd/MM/yyyy}   |   " +
                                     $"Đang mượn: {dangMuon}/{QuyDinh.SoSachMuonToiDa}   |   Quá hạn: {quaHan}" +
                                     (quaHan > 0 ? "   -> KHÔNG ĐƯỢC MƯỢN" : "");
                lblThongTinDG.ForeColor = quaHan > 0 || dangMuon >= QuyDinh.SoSachMuonToiDa
                    ? Color.FromArgb(185, 28, 28) : Color.FromArgb(21, 128, 61);
            });
        }

        private void ThemSachDangChon()
        {
            if (dgvSach.CurrentRow == null) return;
            var r = ((DataRowView)dgvSach.CurrentRow.DataBoundItem).Row;
            int ma = (int)r["MaSach"];
            if (Convert.ToInt32(r["SoLuongCon"]) <= 0) { UI.Warn("Sách này đã hết."); return; }
            if (lstSachMuon.Items.Cast<SachChon>().Any(s => s.Ma == ma)) { UI.Warn("Sách đã có trong danh sách."); return; }
            lstSachMuon.Items.Add(new SachChon { Ma = ma, Ten = r["TenSach"].ToString() });
            CapNhatSoLuong();
        }

        private void CapNhatSoLuong() => lblSoLuong.Text = $"{lstSachMuon.Items.Count} cuốn";

        private void dgvSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) ThemSachDangChon();
        }

        private void btnThemSach_Click(object sender, EventArgs e) => ThemSachDangChon();

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            if (lstSachMuon.SelectedItem != null) lstSachMuon.Items.Remove(lstSachMuon.SelectedItem);
            CapNhatSoLuong();
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            int? maDocGia = cbDocGia.SelectedIndex >= 0 ? UI.SelectedId(cbDocGia) : null;
            var ds = lstSachMuon.Items.Cast<SachChon>().Select(s => s.Ma).ToList();
            int maPhieu = 0;
            if (!UI.Try(() => maPhieu = _muonTra.MuonSach(maDocGia ?? 0, dtpHanTra.Value, ds))) return;

            UI.Info($"Lập phiếu mượn số {maPhieu} thành công.\nHạn trả: {dtpHanTra.Value:dd/MM/yyyy}");
            if (UI.Confirm("In phiếu mượn?"))
                XuatFile.InPhieuMuon(maPhieu, cbDocGia.Text, dtpHanTra.Value,
                    lstSachMuon.Items.Cast<SachChon>().Select(s => s.ToString()).ToList());
            lstSachMuon.Items.Clear();
            CapNhatSoLuong();
            TaiSach();
            cbDocGia_SelectedIndexChanged(null, null);
        }
    }
}
