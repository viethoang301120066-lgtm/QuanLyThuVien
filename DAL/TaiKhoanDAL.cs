using System.Data;
using DTO;

namespace DAL
{
    public class TaiKhoanDAL
    {
        public TaiKhoanDTO DangNhap(string tenDangNhap, string matKhauHash)
        {
            var dt = DataProvider.ExecuteQuery(
                "SELECT * FROM TaiKhoan WHERE TenDangNhap = @u AND MatKhau = @p",
                "@u", tenDangNhap, "@p", matKhauHash);
            if (dt.Rows.Count == 0) return null;
            var r = dt.Rows[0];
            return new TaiKhoanDTO
            {
                TenDangNhap = r["TenDangNhap"].ToString(),
                HoTen = r["HoTen"].ToString(),
                VaiTro = r["VaiTro"].ToString()
            };
        }

        public DataTable GetAll() =>
            DataProvider.ExecuteQuery("SELECT TenDangNhap, HoTen, VaiTro FROM TaiKhoan ORDER BY TenDangNhap");

        public bool TonTai(string tenDangNhap) =>
            (int)DataProvider.ExecuteScalar("SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @u", "@u", tenDangNhap) > 0;

        public bool Insert(TaiKhoanDTO tk) =>
            DataProvider.ExecuteNonQuery(
                "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, HoTen, VaiTro) VALUES (@u, @p, @h, @v)",
                "@u", tk.TenDangNhap, "@p", tk.MatKhau, "@h", tk.HoTen, "@v", tk.VaiTro) > 0;

        public bool Update(TaiKhoanDTO tk) =>
            DataProvider.ExecuteNonQuery(
                "UPDATE TaiKhoan SET HoTen = @h, VaiTro = @v WHERE TenDangNhap = @u",
                "@u", tk.TenDangNhap, "@h", tk.HoTen, "@v", tk.VaiTro) > 0;

        public bool Delete(string tenDangNhap) =>
            DataProvider.ExecuteNonQuery("DELETE FROM TaiKhoan WHERE TenDangNhap = @u", "@u", tenDangNhap) > 0;

        public bool CoPhieuMuon(string tenDangNhap) =>
            (int)DataProvider.ExecuteScalar("SELECT COUNT(*) FROM PhieuMuon WHERE TenDangNhap = @u", "@u", tenDangNhap) > 0;

        public bool DoiMatKhau(string tenDangNhap, string matKhauHashMoi) =>
            DataProvider.ExecuteNonQuery("UPDATE TaiKhoan SET MatKhau = @p WHERE TenDangNhap = @u",
                "@u", tenDangNhap, "@p", matKhauHashMoi) > 0;
    }
}
