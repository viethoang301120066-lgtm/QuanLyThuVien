using System;
using System.Collections.Generic;
using System.Data;
using DTO;

namespace DAL
{
    public class PhieuMuonDAL
    {
        /// <summary>Tạo phiếu + chi tiết trong 1 transaction (lỗi giữa chừng sẽ rollback toàn bộ).</summary>
        public int TaoPhieu(PhieuMuonDTO p, List<int> dsMaSach)
        {
            using (var conn = DataProvider.GetConnection())
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        var cmd = conn.CreateCommand();
                        cmd.Transaction = tran;
                        cmd.CommandText = "INSERT INTO PhieuMuon (MaDocGia, TenDangNhap, NgayMuon, HanTra) " +
                                          "OUTPUT INSERTED.MaPhieu VALUES (@dg, @tk, @nm, @ht)";
                        cmd.Parameters.AddWithValue("@dg", p.MaDocGia);
                        cmd.Parameters.AddWithValue("@tk", p.TenDangNhap);
                        cmd.Parameters.AddWithValue("@nm", p.NgayMuon);
                        cmd.Parameters.AddWithValue("@ht", p.HanTra);
                        int maPhieu = (int)cmd.ExecuteScalar();

                        foreach (int maSach in dsMaSach)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "INSERT INTO ChiTietPhieuMuon (MaPhieu, MaSach) VALUES (@mp, @ms)";
                            cmd.Parameters.AddWithValue("@mp", maPhieu);
                            cmd.Parameters.AddWithValue("@ms", maSach);
                            cmd.ExecuteNonQuery();
                        }
                        tran.Commit();
                        return maPhieu;
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>Danh sách sách đang được mượn (chưa trả).</summary>
        public DataTable GetDangMuon(string tuKhoa, bool chiQuaHan)
        {
            var pars = new List<object>();
            string sql =
                "SELECT ct.MaPhieu, ct.MaSach, s.TenSach, d.MaDocGia, d.HoTen, d.SoDienThoai, p.NgayMuon, p.HanTra, " +
                "       CASE WHEN DATEDIFF(DAY, p.HanTra, GETDATE()) > 0 THEN DATEDIFF(DAY, p.HanTra, GETDATE()) ELSE 0 END AS SoNgayTre " +
                "FROM ChiTietPhieuMuon ct " +
                "JOIN PhieuMuon p ON p.MaPhieu = ct.MaPhieu " +
                "JOIN Sach s ON s.MaSach = ct.MaSach " +
                "JOIN DocGia d ON d.MaDocGia = p.MaDocGia " +
                "WHERE ct.NgayTra IS NULL" +
                SqlFilter.KeywordClause(tuKhoa,
                    new[] { "ct.MaPhieu", "s.TenSach", "d.MaDocGia", "d.HoTen", "d.SoDienThoai" }, pars);
            if (chiQuaHan) sql += " AND p.HanTra < CAST(GETDATE() AS DATE)";
            return DataProvider.ExecuteQuery(sql + " ORDER BY p.HanTra", pars.ToArray());
        }

        /// <summary>Lịch sử mượn trả (đã trả).</summary>
        public DataTable GetLichSu(string tuKhoa)
        {
            var pars = new List<object>();
            string sql =
                "SELECT ct.MaPhieu, s.TenSach, d.HoTen, p.NgayMuon, p.HanTra, ct.NgayTra, ct.TienPhat " +
                "FROM ChiTietPhieuMuon ct JOIN PhieuMuon p ON p.MaPhieu = ct.MaPhieu " +
                "JOIN Sach s ON s.MaSach = ct.MaSach JOIN DocGia d ON d.MaDocGia = p.MaDocGia " +
                "WHERE ct.NgayTra IS NOT NULL" +
                SqlFilter.KeywordClause(tuKhoa, new[] { "ct.MaPhieu", "s.TenSach", "d.HoTen" }, pars);
            return DataProvider.ExecuteQuery(sql + " ORDER BY ct.NgayTra DESC", pars.ToArray());
        }

        public DateTime? GetHanTra(int maPhieu) =>
            DataProvider.ExecuteScalar("SELECT HanTra FROM PhieuMuon WHERE MaPhieu = @mp", "@mp", maPhieu) as DateTime?;

        public bool TraSach(int maPhieu, int maSach, DateTime ngayTra, decimal tienPhat) =>
            DataProvider.ExecuteNonQuery(
                "UPDATE ChiTietPhieuMuon SET NgayTra = @nt, TienPhat = @tp " +
                "WHERE MaPhieu = @mp AND MaSach = @ms AND NgayTra IS NULL",
                "@nt", ngayTra, "@tp", tienPhat, "@mp", maPhieu, "@ms", maSach) > 0;
    }
}
