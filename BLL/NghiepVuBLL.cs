using System;
using System.Collections.Generic;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class DanhMucBLL
    {
        private readonly DanhMucDAL _dal;
        public DanhMucBLL(LoaiDanhMuc loai) { _dal = new DanhMucDAL(loai); }

        public DataTable Search(string tuKhoa = "") => _dal.Search(tuKhoa);

        private void KiemTra(DanhMucDTO dm)
        {
            dm.Ten = (dm.Ten ?? "").Trim();
            if (dm.Ten == "") throw new BusinessException("Tên không được để trống.");
            if (dm.Ten.Length > 100) throw new BusinessException("Tên tối đa 100 ký tự.");
            if (_dal.TrungTen(dm.Ten, dm.Ma)) throw new BusinessException("Tên này đã tồn tại.");
        }

        public void Them(DanhMucDTO dm) { dm.Ma = 0; KiemTra(dm); _dal.Insert(dm.Ten); }
        public void Sua(DanhMucDTO dm) { KiemTra(dm); _dal.Update(dm); }

        public void Xoa(int ma)
        {
            if (_dal.DangDuocDung(ma)) throw new BusinessException("Đang có sách thuộc mục này, không thể xóa.");
            _dal.Delete(ma);
        }
    }

    public class SachBLL
    {
        private readonly SachDAL _dal = new SachDAL();

        public DataTable Search(SachFilter f) => _dal.Search(f ?? new SachFilter());

        private static void KiemTra(SachDTO s)
        {
            s.TenSach = (s.TenSach ?? "").Trim();
            if (s.TenSach == "") throw new BusinessException("Tên sách không được để trống.");
            if (s.MaTheLoai <= 0 || s.MaTacGia <= 0 || s.MaNXB <= 0)
                throw new BusinessException("Vui lòng chọn thể loại, tác giả và nhà xuất bản.");
            if (s.NamXB < 1900 || s.NamXB > DateTime.Now.Year)
                throw new BusinessException($"Năm xuất bản phải từ 1900 đến {DateTime.Now.Year}.");
            if (s.SoLuong < 0) throw new BusinessException("Số lượng không được âm.");
        }

        public int Them(SachDTO s) { KiemTra(s); return _dal.Insert(s); }

        public void Sua(SachDTO s)
        {
            KiemTra(s);
            int dangMuon = _dal.SoCuonDangMuon(s.MaSach);
            if (s.SoLuong < dangMuon)
                throw new BusinessException($"Đang có {dangMuon} cuốn được mượn, số lượng không thể nhỏ hơn {dangMuon}.");
            _dal.Update(s);
        }

        public void Xoa(int maSach)
        {
            if (_dal.CoLichSuMuon(maSach))
                throw new BusinessException("Sách đã có lịch sử mượn, không thể xóa (có thể đặt số lượng = 0).");
            _dal.Delete(maSach);
        }
    }

    public class DocGiaBLL
    {
        private readonly DocGiaDAL _dal = new DocGiaDAL();

        public DataTable Search(string tuKhoa, string tinhTrang) => _dal.Search(tuKhoa, tinhTrang);
        public DataRow GetById(int ma) => _dal.GetById(ma);

        private static void KiemTra(DocGiaDTO d)
        {
            d.HoTen = (d.HoTen ?? "").Trim();
            if (d.HoTen == "") throw new BusinessException("Họ tên không được để trống.");
            if (d.NgaySinh.HasValue && d.NgaySinh.Value.AddYears(6) > DateTime.Today)
                throw new BusinessException("Độc giả phải từ 6 tuổi trở lên.");
            if (!string.IsNullOrWhiteSpace(d.SoDienThoai) &&
                !System.Text.RegularExpressions.Regex.IsMatch(d.SoDienThoai, @"^0\d{9,10}$"))
                throw new BusinessException("Số điện thoại không hợp lệ (10-11 số, bắt đầu bằng 0).");
            if (!string.IsNullOrWhiteSpace(d.Email) &&
                !System.Text.RegularExpressions.Regex.IsMatch(d.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new BusinessException("Email không hợp lệ.");
            if (d.NgayHetHan <= d.NgayLapThe) throw new BusinessException("Ngày hết hạn phải sau ngày lập thẻ.");
        }

        public void Them(DocGiaDTO d) { KiemTra(d); _dal.Insert(d); }
        public void Sua(DocGiaDTO d) { KiemTra(d); _dal.Update(d); }

        public void Xoa(int ma)
        {
            if (_dal.CoPhieuMuon(ma)) throw new BusinessException("Độc giả đã có phiếu mượn, không thể xóa.");
            _dal.Delete(ma);
        }
    }

    public class MuonTraBLL
    {
        private readonly PhieuMuonDAL _dal = new PhieuMuonDAL();
        private readonly DocGiaDAL _docGiaDal = new DocGiaDAL();
        private readonly SachDAL _sachDal = new SachDAL();

        public DataTable GetDangMuon(string tuKhoa, bool chiQuaHan) => _dal.GetDangMuon(tuKhoa, chiQuaHan);
        public DataTable GetLichSu(string tuKhoa) => _dal.GetLichSu(tuKhoa);

        /// <summary>Kiểm tra quy định và lập phiếu mượn. Trả về mã phiếu.</summary>
        public int MuonSach(int maDocGia, DateTime hanTra, List<int> dsMaSach)
        {
            var dg = _docGiaDal.GetById(maDocGia);
            if (dg == null) throw new BusinessException("Vui lòng chọn độc giả.");
            if ((DateTime)dg["NgayHetHan"] < DateTime.Today) throw new BusinessException("Thẻ độc giả đã hết hạn.");
            if ((int)dg["QuaHan"] > 0) throw new BusinessException("Độc giả đang có sách quá hạn chưa trả.");
            if (dsMaSach == null || dsMaSach.Count == 0) throw new BusinessException("Chưa chọn sách nào.");
            if (new HashSet<int>(dsMaSach).Count != dsMaSach.Count)
                throw new BusinessException("Mỗi đầu sách chỉ được mượn 1 cuốn trong một phiếu.");
            if (hanTra.Date <= DateTime.Today) throw new BusinessException("Hạn trả phải sau ngày hôm nay.");

            int tong = (int)dg["DangMuon"] + dsMaSach.Count;
            if (tong > QuyDinh.SoSachMuonToiDa)
                throw new BusinessException(
                    $"Mỗi độc giả mượn tối đa {QuyDinh.SoSachMuonToiDa} cuốn (đang mượn {dg["DangMuon"]}).");
            foreach (int ma in dsMaSach)
                if (_sachDal.SoLuongCon(ma) <= 0) throw new BusinessException($"Sách mã {ma} đã hết.");

            return _dal.TaoPhieu(new PhieuMuonDTO
            {
                MaDocGia = maDocGia,
                TenDangNhap = PhienDangNhap.TaiKhoan.TenDangNhap,
                NgayMuon = DateTime.Today,
                HanTra = hanTra.Date
            }, dsMaSach);
        }

        public static decimal TinhTienPhat(DateTime hanTra, DateTime ngayTra)
        {
            int tre = (ngayTra.Date - hanTra.Date).Days;
            return tre > 0 ? tre * QuyDinh.TienPhatMoiNgay : 0;
        }

        /// <summary>Trả sách, trả về tiền phạt.</summary>
        public decimal TraSach(int maPhieu, int maSach)
        {
            var hanTra = _dal.GetHanTra(maPhieu) ?? throw new BusinessException("Không tìm thấy phiếu mượn.");
            decimal phat = TinhTienPhat(hanTra, DateTime.Today);
            if (!_dal.TraSach(maPhieu, maSach, DateTime.Today, phat))
                throw new BusinessException("Sách này đã được trả trước đó.");
            return phat;
        }
    }

    public class ThongKeBLL
    {
        private readonly ThongKeDAL _dal = new ThongKeDAL();
        public DataRow GetTongQuan() => _dal.GetTongQuan();
        public DataTable MuonTheoThang() => _dal.MuonTheoThang();
        public DataTable TopSachMuon(int top = 5) => _dal.TopSachMuon(top);
        public DataTable SachTheoTheLoai() => _dal.SachTheoTheLoai();
    }
}
