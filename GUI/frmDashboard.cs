using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;

namespace GUI
{
    public partial class frmDashboard : Form
    {
        private readonly ThongKeBLL _thongKe = new ThongKeBLL();
        private readonly MuonTraBLL _muonTra = new MuonTraBLL();

        public frmDashboard()
        {
            InitializeComponent();
            UI.StyleGrid(dgvQuaHan);
            UI.StyleGrid(dgvTopSach);
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            UI.Try(TaiDuLieu);
        }

        private void TaiDuLieu()
        {
            // 1. Thẻ số liệu
            var r = _thongKe.GetTongQuan();
            flpThe.Controls.Clear();
            flpThe.Controls.Add(TaoThe("Đầu sách", r["DauSach"].ToString(), Color.FromArgb(37, 99, 235)));
            flpThe.Controls.Add(TaoThe("Tổng số cuốn", r["TongCuon"].ToString(), Color.FromArgb(14, 165, 233)));
            flpThe.Controls.Add(TaoThe("Độc giả", r["DocGia"].ToString(), Color.FromArgb(16, 185, 129)));
            flpThe.Controls.Add(TaoThe("Đang mượn", r["DangMuon"].ToString(), Color.FromArgb(245, 158, 11)));
            flpThe.Controls.Add(TaoThe("Quá hạn", r["QuaHan"].ToString(), Color.FromArgb(239, 68, 68)));
            flpThe.Controls.Add(TaoThe("Tiền phạt (đ)", Convert.ToDecimal(r["TongTienPhat"]).ToString("#,##0"),
                Color.FromArgb(139, 92, 246)));

            // 2. Biểu đồ cột: lượt mượn theo tháng
            var sMuon = chartMuon.Series[0];
            sMuon.Points.Clear();
            foreach (DataRow row in _thongKe.MuonTheoThang().Rows)
                sMuon.Points.AddXY(row["Thang"].ToString(), row["SoLuot"]);

            // 3. Biểu đồ tròn: số cuốn theo thể loại
            var sTL = chartTheLoai.Series[0];
            sTL.Points.Clear();
            foreach (DataRow row in _thongKe.SachTheoTheLoai().Rows)
                if (Convert.ToInt32(row["SoCuon"]) > 0)
                    sTL.Points.AddXY(row["TenTheLoai"].ToString(), row["SoCuon"]);

            // 4. Sách quá hạn & top sách
            dgvQuaHan.DataSource = _muonTra.GetDangMuon("", true);
            UI.Columns(dgvQuaHan, "HoTen:Độc giả", "SoDienThoai:SĐT", "TenSach:Sách", "HanTra:Hạn trả", "SoNgayTre:Trễ (ngày)");
            dgvTopSach.DataSource = _thongKe.TopSachMuon(5);
            UI.Columns(dgvTopSach, "TenSach:Tên sách", "SoLuot:Lượt mượn");
        }

        private static Panel TaoThe(string tieuDe, string giaTri, Color mau)
        {
            var pnl = new Panel { Size = new Size(165, 90), BackColor = mau, Margin = new Padding(0, 0, 12, 0) };
            pnl.Controls.Add(new Label
            {
                Text = giaTri, ForeColor = Color.White, Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                Location = new Point(12, 8), AutoSize = true
            });
            pnl.Controls.Add(new Label
            {
                Text = tieuDe, ForeColor = Color.White, Location = new Point(14, 58), AutoSize = true
            });
            return pnl;
        }
    }
}
