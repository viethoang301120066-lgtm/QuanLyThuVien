using System;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string VaiTro { get; set; }   // "Admin" | "ThuThu"
    }

    /// <summary>Dùng chung cho Thể loại / Tác giả / Nhà xuất bản (cùng cấu trúc Mã - Tên).</summary>
    public class DanhMucDTO
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
    }

    public enum LoaiDanhMuc { TheLoai, TacGia, NhaXuatBan }

    public class SachDTO
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public int MaTheLoai { get; set; }
        public int MaTacGia { get; set; }
        public int MaNXB { get; set; }
        public int NamXB { get; set; }
        public int SoLuong { get; set; }
    }

    /// <summary>Điều kiện lọc sách. Giá trị null = không lọc theo tiêu chí đó.</summary>
    public class SachFilter
    {
        public string TuKhoa { get; set; }
        public int? MaTheLoai { get; set; }
        public int? MaTacGia { get; set; }
        public int? MaNXB { get; set; }
        public int? NamTu { get; set; }
        public int? NamDen { get; set; }
        public bool? ConSach { get; set; }   // true = còn, false = hết
    }

    public class DocGiaDTO
    {
        public int MaDocGia { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public DateTime NgayLapThe { get; set; }
        public DateTime NgayHetHan { get; set; }
    }

    public class PhieuMuonDTO
    {
        public int MaPhieu { get; set; }
        public int MaDocGia { get; set; }
        public string TenDangNhap { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
    }
}
