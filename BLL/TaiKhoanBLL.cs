using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using DAL;
using DTO;

namespace BLL
{
    /// <summary>Lỗi nghiệp vụ: GUI chỉ cần bắt và hiển thị Message.</summary>
    public class BusinessException : Exception
    {
        public BusinessException(string message) : base(message) { }
    }

    /// <summary>Quy định của thư viện (đặt tập trung để dễ thay đổi).</summary>
    public static class QuyDinh
    {
        public const int SoSachMuonToiDa = 5;
        public const int SoNgayMuonMacDinh = 14;
        public const decimal TienPhatMoiNgay = 5000;
        public const int ThoiHanTheThang = 12;
    }

    /// <summary>Lưu tài khoản đang đăng nhập.</summary>
    public static class PhienDangNhap
    {
        public static TaiKhoanDTO TaiKhoan { get; set; }
        public static bool LaAdmin => TaiKhoan != null && TaiKhoan.VaiTro == "Admin";
    }

    public class TaiKhoanBLL
    {
        private readonly TaiKhoanDAL _dal = new TaiKhoanDAL();

        public static string MaHoa(string matKhau)
        {
            using (var sha = SHA256.Create())
            {
                var sb = new StringBuilder();
                foreach (byte b in sha.ComputeHash(Encoding.UTF8.GetBytes(matKhau)))
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        public TaiKhoanDTO DangNhap(string tenDangNhap, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrEmpty(matKhau))
                throw new BusinessException("Vui lòng nhập tên đăng nhập và mật khẩu.");
            var tk = _dal.DangNhap(tenDangNhap.Trim(), MaHoa(matKhau));
            if (tk == null) throw new BusinessException("Sai tên đăng nhập hoặc mật khẩu.");
            return tk;
        }

        public DataTable GetAll() => _dal.GetAll();

        private static void KiemTra(TaiKhoanDTO tk)
        {
            if (string.IsNullOrWhiteSpace(tk.TenDangNhap)) throw new BusinessException("Tên đăng nhập không được trống.");
            if (string.IsNullOrWhiteSpace(tk.HoTen)) throw new BusinessException("Họ tên không được trống.");
            if (tk.VaiTro != "Admin" && tk.VaiTro != "ThuThu") throw new BusinessException("Vai trò không hợp lệ.");
        }

        public void Them(TaiKhoanDTO tk, string matKhau)
        {
            KiemTra(tk);
            if (string.IsNullOrEmpty(matKhau) || matKhau.Length < 6)
                throw new BusinessException("Mật khẩu phải có ít nhất 6 ký tự.");
            if (_dal.TonTai(tk.TenDangNhap)) throw new BusinessException("Tên đăng nhập đã tồn tại.");
            tk.MatKhau = MaHoa(matKhau);
            _dal.Insert(tk);
        }

        public void Sua(TaiKhoanDTO tk)
        {
            KiemTra(tk);
            if (tk.TenDangNhap == PhienDangNhap.TaiKhoan.TenDangNhap && tk.VaiTro != "Admin")
                throw new BusinessException("Không thể tự hạ quyền tài khoản đang đăng nhập.");
            _dal.Update(tk);
        }

        public void Xoa(string tenDangNhap)
        {
            if (tenDangNhap == PhienDangNhap.TaiKhoan.TenDangNhap)
                throw new BusinessException("Không thể xóa tài khoản đang đăng nhập.");
            if (_dal.CoPhieuMuon(tenDangNhap))
                throw new BusinessException("Tài khoản đã lập phiếu mượn, không thể xóa.");
            _dal.Delete(tenDangNhap);
        }

        public void DatLaiMatKhau(string tenDangNhap, string matKhauMoi)
        {
            if (string.IsNullOrEmpty(matKhauMoi) || matKhauMoi.Length < 6)
                throw new BusinessException("Mật khẩu phải có ít nhất 6 ký tự.");
            _dal.DoiMatKhau(tenDangNhap, MaHoa(matKhauMoi));
        }

        public void DoiMatKhau(string matKhauCu, string matKhauMoi, string xacNhan)
        {
            var tk = PhienDangNhap.TaiKhoan;
            if (_dal.DangNhap(tk.TenDangNhap, MaHoa(matKhauCu ?? "")) == null)
                throw new BusinessException("Mật khẩu cũ không đúng.");
            if (matKhauMoi != xacNhan) throw new BusinessException("Xác nhận mật khẩu không khớp.");
            DatLaiMatKhau(tk.TenDangNhap, matKhauMoi);
        }
    }
}
