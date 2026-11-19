using System;
using System.Collections.Generic;
using System.Data;
using DTO;

namespace DAL
{
    public class DocGiaDAL
    {
        private const string SelectSql =
            "SELECT d.*, " +
            " (SELECT COUNT(*) FROM ChiTietPhieuMuon ct JOIN PhieuMuon p ON p.MaPhieu = ct.MaPhieu " +
            "  WHERE p.MaDocGia = d.MaDocGia AND ct.NgayTra IS NULL) AS DangMuon, " +
            " (SELECT COUNT(*) FROM ChiTietPhieuMuon ct JOIN PhieuMuon p ON p.MaPhieu = ct.MaPhieu " +
            "  WHERE p.MaDocGia = d.MaDocGia AND ct.NgayTra IS NULL AND p.HanTra < CAST(GETDATE() AS DATE)) AS QuaHan " +
            "FROM DocGia d";

        /// <param name="tinhTrang">"" = tất cả, "ConHan", "HetHan", "DangMuon", "QuaHan"</param>
        public DataTable Search(string tuKhoa, string tinhTrang)
        {
            var pars = new List<object>();
            string sql = "SELECT * FROM (" + SelectSql + ") x WHERE 1=1" +
                SqlFilter.KeywordClause(tuKhoa, new[] { "MaDocGia", "HoTen", "SoDienThoai", "Email", "DiaChi" }, pars);
            switch (tinhTrang)
            {
                case "ConHan": sql += " AND NgayHetHan >= CAST(GETDATE() AS DATE)"; break;
                case "HetHan": sql += " AND NgayHetHan < CAST(GETDATE() AS DATE)"; break;
                case "DangMuon": sql += " AND DangMuon > 0"; break;
                case "QuaHan": sql += " AND QuaHan > 0"; break;
            }
            return DataProvider.ExecuteQuery(sql + " ORDER BY HoTen", pars.ToArray());
        }

        public DataRow GetById(int ma)
        {
            var dt = DataProvider.ExecuteQuery("SELECT * FROM (" + SelectSql + ") x WHERE MaDocGia = @ma", "@ma", ma);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        private static object[] Params(DocGiaDTO d) => new object[]
        {
            "@ten", d.HoTen, "@ns", (object)d.NgaySinh ?? DBNull.Value, "@gt", d.GioiTinh, "@dc", d.DiaChi,
            "@sdt", d.SoDienThoai, "@email", d.Email, "@nlt", d.NgayLapThe, "@nhh", d.NgayHetHan, "@ma", d.MaDocGia
        };

        public bool Insert(DocGiaDTO d) =>
            DataProvider.ExecuteNonQuery(
                "INSERT INTO DocGia (HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, NgayLapThe, NgayHetHan) " +
                "VALUES (@ten, @ns, @gt, @dc, @sdt, @email, @nlt, @nhh)", Params(d)) > 0;

        public bool Update(DocGiaDTO d) =>
            DataProvider.ExecuteNonQuery(
                "UPDATE DocGia SET HoTen=@ten, NgaySinh=@ns, GioiTinh=@gt, DiaChi=@dc, SoDienThoai=@sdt, Email=@email, " +
                "NgayLapThe=@nlt, NgayHetHan=@nhh WHERE MaDocGia=@ma", Params(d)) > 0;

        public bool Delete(int ma) =>
            DataProvider.ExecuteNonQuery("DELETE FROM DocGia WHERE MaDocGia = @ma", "@ma", ma) > 0;

        public bool CoPhieuMuon(int ma) =>
            (int)DataProvider.ExecuteScalar("SELECT COUNT(*) FROM PhieuMuon WHERE MaDocGia = @ma", "@ma", ma) > 0;
    }
}
