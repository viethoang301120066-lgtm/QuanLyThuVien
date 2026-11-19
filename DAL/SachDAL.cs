using System.Collections.Generic;
using System.Data;
using DTO;

namespace DAL
{
    public class SachDAL
    {
        public DataTable Search(SachFilter f)
        {
            var pars = new List<object>();
            string sql = "SELECT * FROM vw_Sach WHERE 1=1" +
                SqlFilter.KeywordClause(f.TuKhoa,
                    new[] { "MaSach", "TenSach", "TenTheLoai", "TenTacGia", "TenNXB", "NamXB" }, pars);

            if (f.MaTheLoai.HasValue) { sql += " AND MaTheLoai = @tl"; pars.Add("@tl"); pars.Add(f.MaTheLoai.Value); }
            if (f.MaTacGia.HasValue) { sql += " AND MaTacGia = @tg"; pars.Add("@tg"); pars.Add(f.MaTacGia.Value); }
            if (f.MaNXB.HasValue) { sql += " AND MaNXB = @nxb"; pars.Add("@nxb"); pars.Add(f.MaNXB.Value); }
            if (f.NamTu.HasValue) { sql += " AND NamXB >= @nt"; pars.Add("@nt"); pars.Add(f.NamTu.Value); }
            if (f.NamDen.HasValue) { sql += " AND NamXB <= @nd"; pars.Add("@nd"); pars.Add(f.NamDen.Value); }
            if (f.ConSach == true) sql += " AND SoLuongCon > 0";
            if (f.ConSach == false) sql += " AND SoLuongCon <= 0";

            return DataProvider.ExecuteQuery(sql + " ORDER BY TenSach", pars.ToArray());
        }

        public int Insert(SachDTO s) =>
            (int)DataProvider.ExecuteScalar(
                "INSERT INTO Sach (TenSach, MaTheLoai, MaTacGia, MaNXB, NamXB, SoLuong) " +
                "OUTPUT INSERTED.MaSach VALUES (@ten, @tl, @tg, @nxb, @nam, @sl)",
                "@ten", s.TenSach, "@tl", s.MaTheLoai, "@tg", s.MaTacGia, "@nxb", s.MaNXB, "@nam", s.NamXB, "@sl", s.SoLuong);

        public bool Update(SachDTO s) =>
            DataProvider.ExecuteNonQuery(
                "UPDATE Sach SET TenSach=@ten, MaTheLoai=@tl, MaTacGia=@tg, MaNXB=@nxb, NamXB=@nam, SoLuong=@sl WHERE MaSach=@ma",
                "@ten", s.TenSach, "@tl", s.MaTheLoai, "@tg", s.MaTacGia, "@nxb", s.MaNXB, "@nam", s.NamXB, "@sl", s.SoLuong,
                "@ma", s.MaSach) > 0;

        public bool Delete(int maSach) =>
            DataProvider.ExecuteNonQuery("DELETE FROM Sach WHERE MaSach = @ma", "@ma", maSach) > 0;

        public int SoCuonDangMuon(int maSach) =>
            (int)DataProvider.ExecuteScalar(
                "SELECT COUNT(*) FROM ChiTietPhieuMuon WHERE MaSach = @ma AND NgayTra IS NULL", "@ma", maSach);

        public bool CoLichSuMuon(int maSach) =>
            (int)DataProvider.ExecuteScalar("SELECT COUNT(*) FROM ChiTietPhieuMuon WHERE MaSach = @ma", "@ma", maSach) > 0;

        public int SoLuongCon(int maSach) =>
            (int)DataProvider.ExecuteScalar("SELECT SoLuongCon FROM vw_Sach WHERE MaSach = @ma", "@ma", maSach);
    }
}
