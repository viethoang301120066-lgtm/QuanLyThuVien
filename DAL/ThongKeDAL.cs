using System.Data;

namespace DAL
{
    public class ThongKeDAL
    {
        /// <summary>Một dòng gồm các số liệu tổng quan cho Dashboard.</summary>
        public DataRow GetTongQuan() =>
            DataProvider.ExecuteQuery(
                "SELECT " +
                " (SELECT COUNT(*) FROM Sach) AS DauSach, " +
                " (SELECT ISNULL(SUM(SoLuong),0) FROM Sach) AS TongCuon, " +
                " (SELECT COUNT(*) FROM DocGia) AS DocGia, " +
                " (SELECT COUNT(*) FROM ChiTietPhieuMuon WHERE NgayTra IS NULL) AS DangMuon, " +
                " (SELECT COUNT(*) FROM ChiTietPhieuMuon ct JOIN PhieuMuon p ON p.MaPhieu = ct.MaPhieu " +
                "   WHERE ct.NgayTra IS NULL AND p.HanTra < CAST(GETDATE() AS DATE)) AS QuaHan, " +
                " (SELECT ISNULL(SUM(TienPhat),0) FROM ChiTietPhieuMuon) AS TongTienPhat").Rows[0];

        /// <summary>Số lượt mượn theo tháng trong 6 tháng gần nhất.</summary>
        public DataTable MuonTheoThang() =>
            DataProvider.ExecuteQuery(
                "SELECT FORMAT(p.NgayMuon, 'MM/yyyy') AS Thang, COUNT(*) AS SoLuot " +
                "FROM PhieuMuon p JOIN ChiTietPhieuMuon ct ON ct.MaPhieu = p.MaPhieu " +
                "WHERE p.NgayMuon >= DATEADD(MONTH, -5, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)) " +
                "GROUP BY FORMAT(p.NgayMuon, 'MM/yyyy'), YEAR(p.NgayMuon), MONTH(p.NgayMuon) " +
                "ORDER BY YEAR(p.NgayMuon), MONTH(p.NgayMuon)");

        public DataTable TopSachMuon(int top) =>
            DataProvider.ExecuteQuery(
                "SELECT TOP (@top) s.TenSach, COUNT(*) AS SoLuot " +
                "FROM ChiTietPhieuMuon ct JOIN Sach s ON s.MaSach = ct.MaSach " +
                "GROUP BY s.TenSach ORDER BY SoLuot DESC", "@top", top);

        public DataTable SachTheoTheLoai() =>
            DataProvider.ExecuteQuery(
                "SELECT tl.TenTheLoai, ISNULL(SUM(s.SoLuong),0) AS SoCuon " +
                "FROM TheLoai tl LEFT JOIN Sach s ON s.MaTheLoai = tl.MaTheLoai " +
                "GROUP BY tl.TenTheLoai ORDER BY SoCuon DESC");
    }
}
