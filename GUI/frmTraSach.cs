using System;
using System.Data;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frmTraSach : Form
    {
        private readonly MuonTraBLL _bll = new MuonTraBLL();

        public frmTraSach()
        {
            InitializeComponent();
            UI.StyleGrid(dgvDangMuon);
            UI.StyleGrid(dgvLichSu);
            dgvDangMuon.MultiSelect = true;   // cho phép trả nhiều cuốn một lúc
        }

        private void frmTraSach_Load(object sender, EventArgs e)
        {
            TaiDangMuon();
            TaiLichSu();
            txtTimKiem.TextChanged += (s, ev) => { tmrTimKiem.Stop(); tmrTimKiem.Start(); };
            txtTimLichSu.TextChanged += (s, ev) => { tmrTimKiem.Stop(); tmrTimKiem.Start(); };
        }

        private void TaiDangMuon()
        {
            UI.Try(() =>
            {
                dgvDangMuon.DataSource = _bll.GetDangMuon(txtTimKiem.Text, chkQuaHan.Checked);
                UI.Columns(dgvDangMuon, "MaPhieu:Phiếu", "HoTen:Độc giả", "SoDienThoai:SĐT", "TenSach:Tên sách",
                    "NgayMuon:Ngày mượn", "HanTra:Hạn trả", "SoNgayTre:Trễ (ngày)");
                dgvDangMuon.Columns["TenSach"].FillWeight = 200;
            });
        }

        private void TaiLichSu()
        {
            UI.Try(() =>
            {
                dgvLichSu.DataSource = _bll.GetLichSu(txtTimLichSu.Text);
                UI.Columns(dgvLichSu, "MaPhieu:Phiếu", "HoTen:Độc giả", "TenSach:Tên sách", "NgayMuon:Ngày mượn",
                    "HanTra:Hạn trả", "NgayTra:Ngày trả", "TienPhat:Tiền phạt");
                dgvLichSu.Columns["TenSach"].FillWeight = 200;
                decimal tong = 0;
                foreach (DataRow r in ((DataTable)dgvLichSu.DataSource).Rows) tong += (decimal)r["TienPhat"];
                lblKetQuaLS.Text = $"  {dgvLichSu.Rows.Count} lượt trả, tổng tiền phạt: {tong:#,##0} đ";
            });
        }

        private void tmrTimKiem_Tick(object sender, EventArgs e)
        {
            tmrTimKiem.Stop();
            if (tabMain.SelectedTab == tabDangMuon) TaiDangMuon(); else TaiLichSu();
        }

        private void chkQuaHan_CheckedChanged(object sender, EventArgs e) => TaiDangMuon();

        private void dgvDangMuon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDangMuon.Rows)
                if (Convert.ToInt32(r.Cells["SoNgayTre"].Value) > 0)
                    r.DefaultCellStyle.BackColor = UI.MauCanhBao;
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (dgvDangMuon.SelectedRows.Count == 0) { UI.Warn("Hãy chọn sách cần trả."); return; }

            // Xem trước tiền phạt để thủ thư xác nhận
            decimal duKien = 0;
            foreach (DataGridViewRow row in dgvDangMuon.SelectedRows)
                duKien += MuonTraBLL.TinhTienPhat((DateTime)row.Cells["HanTra"].Value, DateTime.Today);
            if (!UI.Confirm($"Trả {dgvDangMuon.SelectedRows.Count} cuốn sách?\nTiền phạt: {duKien:#,##0} đ")) return;

            decimal tongPhat = 0;
            int soCuon = 0;
            UI.Try(() =>
            {
                foreach (DataGridViewRow row in dgvDangMuon.SelectedRows)
                {
                    var r = ((DataRowView)row.DataBoundItem).Row;
                    tongPhat += _bll.TraSach((int)r["MaPhieu"], (int)r["MaSach"]);
                    soCuon++;
                }
            });
            if (soCuon > 0)
                UI.Info($"Đã trả {soCuon} cuốn." + (tongPhat > 0 ? $"\nThu tiền phạt: {tongPhat:#,##0} đ" : ""));
            TaiDangMuon();
            TaiLichSu();
        }

        private string TieuDeDangMuon => chkQuaHan.Checked ? "Sách quá hạn" : "Sách đang mượn";
        private void btnXuatExcel_Click(object sender, EventArgs e) => XuatFile.XuatExcel(dgvDangMuon, TieuDeDangMuon);
        private void btnIn_Click(object sender, EventArgs e) => XuatFile.InBang(dgvDangMuon, TieuDeDangMuon);
        private void btnXuatExcelLS_Click(object sender, EventArgs e) => XuatFile.XuatExcel(dgvLichSu, "Lịch sử trả sách");
        private void btnInLS_Click(object sender, EventArgs e) => XuatFile.InBang(dgvLichSu, "Lịch sử trả sách");
    }
}
