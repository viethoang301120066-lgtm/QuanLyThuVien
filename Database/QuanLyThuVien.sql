/* =========================================================
   CƠ SỞ DỮ LIỆU: QUẢN LÝ THƯ VIỆN
   Chạy toàn bộ script này trong SQL Server Management Studio
   ========================================================= */
USE master;
GO
IF DB_ID(N'QuanLyThuVien') IS NOT NULL
BEGIN
    ALTER DATABASE QuanLyThuVien SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanLyThuVien;
END
GO
CREATE DATABASE QuanLyThuVien;
GO
USE QuanLyThuVien;
GO

/* ---------- Tài khoản ---------- */
CREATE TABLE TaiKhoan (
    TenDangNhap  VARCHAR(50)   PRIMARY KEY,
    MatKhau      VARCHAR(64)   NOT NULL,              -- SHA-256 (hex)
    HoTen        NVARCHAR(100) NOT NULL,
    VaiTro       NVARCHAR(20)  NOT NULL DEFAULT N'ThuThu'
                 CHECK (VaiTro IN (N'Admin', N'ThuThu'))
);

/* ---------- Danh mục ---------- */
CREATE TABLE TheLoai (
    MaTheLoai  INT IDENTITY(1,1) PRIMARY KEY,
    TenTheLoai NVARCHAR(100) NOT NULL UNIQUE
);
CREATE TABLE TacGia (
    MaTacGia  INT IDENTITY(1,1) PRIMARY KEY,
    TenTacGia NVARCHAR(100) NOT NULL UNIQUE
);
CREATE TABLE NhaXuatBan (
    MaNXB  INT IDENTITY(1,1) PRIMARY KEY,
    TenNXB NVARCHAR(100) NOT NULL UNIQUE
);

/* ---------- Sách ---------- */
CREATE TABLE Sach (
    MaSach    INT IDENTITY(1,1) PRIMARY KEY,
    TenSach   NVARCHAR(200) NOT NULL,
    MaTheLoai INT NOT NULL REFERENCES TheLoai(MaTheLoai),
    MaTacGia  INT NOT NULL REFERENCES TacGia(MaTacGia),
    MaNXB     INT NOT NULL REFERENCES NhaXuatBan(MaNXB),
    NamXB     INT NOT NULL,
    SoLuong   INT NOT NULL CHECK (SoLuong >= 0)       -- tổng số cuốn
);

/* ---------- Độc giả ---------- */
CREATE TABLE DocGia (
    MaDocGia    INT IDENTITY(1,1) PRIMARY KEY,
    HoTen       NVARCHAR(100) NOT NULL,
    NgaySinh    DATE NULL,
    GioiTinh    NVARCHAR(5)   NOT NULL DEFAULT N'Nam',
    DiaChi      NVARCHAR(200) NULL,
    SoDienThoai VARCHAR(15)   NULL,
    Email       VARCHAR(100)  NULL,
    NgayLapThe  DATE NOT NULL DEFAULT GETDATE(),
    NgayHetHan  DATE NOT NULL
);

/* ---------- Mượn / trả ---------- */
CREATE TABLE PhieuMuon (
    MaPhieu     INT IDENTITY(1,1) PRIMARY KEY,
    MaDocGia    INT NOT NULL REFERENCES DocGia(MaDocGia),
    TenDangNhap VARCHAR(50) NOT NULL REFERENCES TaiKhoan(TenDangNhap),
    NgayMuon    DATE NOT NULL DEFAULT GETDATE(),
    HanTra      DATE NOT NULL
);
CREATE TABLE ChiTietPhieuMuon (
    MaPhieu  INT NOT NULL REFERENCES PhieuMuon(MaPhieu),
    MaSach   INT NOT NULL REFERENCES Sach(MaSach),
    NgayTra  DATE NULL,                                -- NULL = chưa trả
    TienPhat DECIMAL(18,0) NOT NULL DEFAULT 0,
    PRIMARY KEY (MaPhieu, MaSach)
);
GO

/* Số lượng còn = tổng - số cuốn đang được mượn (tính tự động, không lo lệch dữ liệu) */
CREATE VIEW vw_Sach AS
SELECT s.MaSach, s.TenSach, s.MaTheLoai, tl.TenTheLoai, s.MaTacGia, tg.TenTacGia,
       s.MaNXB, n.TenNXB, s.NamXB, s.SoLuong,
       s.SoLuong - (SELECT COUNT(*) FROM ChiTietPhieuMuon ct
                    WHERE ct.MaSach = s.MaSach AND ct.NgayTra IS NULL) AS SoLuongCon
FROM Sach s
JOIN TheLoai tl   ON tl.MaTheLoai = s.MaTheLoai
JOIN TacGia tg    ON tg.MaTacGia  = s.MaTacGia
JOIN NhaXuatBan n ON n.MaNXB      = s.MaNXB;
GO

/* ================= DỮ LIỆU MẪU ================= */
-- Mật khẩu mặc định của cả 2 tài khoản: 123456
INSERT INTO TaiKhoan VALUES
('admin',  '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'Quản trị viên', N'Admin'),
('thuthu', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'Nguyễn Thị Thủ Thư', N'ThuThu');

INSERT INTO TheLoai (TenTheLoai) VALUES
(N'Công nghệ thông tin'), (N'Văn học'), (N'Kinh tế'), (N'Khoa học'), (N'Kỹ năng sống');
INSERT INTO TacGia (TenTacGia) VALUES
(N'Nguyễn Nhật Ánh'), (N'Robert C. Martin'), (N'Dale Carnegie'), (N'Stephen Hawking'), (N'Phạm Hữu Khang');
INSERT INTO NhaXuatBan (TenNXB) VALUES
(N'NXB Trẻ'), (N'NXB Giáo dục'), (N'NXB Tổng hợp TP.HCM'), (N'Prentice Hall'), (N'NXB Lao động');

INSERT INTO Sach (TenSach, MaTheLoai, MaTacGia, MaNXB, NamXB, SoLuong) VALUES
(N'Mắt biếc',                         2, 1, 1, 2019, 5),
(N'Cho tôi xin một vé đi tuổi thơ',   2, 1, 1, 2018, 4),
(N'Clean Code',                       1, 2, 4, 2008, 3),
(N'Clean Architecture',               1, 2, 4, 2017, 2),
(N'Đắc nhân tâm',                     5, 3, 3, 2020, 6),
(N'Lược sử thời gian',                4, 4, 3, 2016, 3),
(N'Lập trình C# từ cơ bản đến nâng cao', 1, 5, 5, 2021, 4),
(N'Lập trình SQL Server',             1, 5, 5, 2019, 2);

INSERT INTO DocGia (HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, NgayLapThe, NgayHetHan) VALUES
(N'Trần Văn An',   '2003-05-12', N'Nam', N'Quận 1, TP.HCM',  '0901234567', 'an@gmail.com',   DATEADD(MONTH,-6,GETDATE()), DATEADD(MONTH, 6,GETDATE())),
(N'Lê Thị Bình',   '2004-08-20', N'Nữ',  N'Thủ Đức, TP.HCM', '0912345678', 'binh@gmail.com', DATEADD(MONTH,-3,GETDATE()), DATEADD(MONTH, 9,GETDATE())),
(N'Phạm Minh Cường','2002-01-03', N'Nam', N'Quận 7, TP.HCM', '0987654321', 'cuong@gmail.com',DATEADD(YEAR,-2,GETDATE()),  DATEADD(DAY,-10,GETDATE())),
(N'Võ Thu Dung',   '2003-11-30', N'Nữ',  N'Bình Thạnh, TP.HCM','0934567890','dung@gmail.com',DATEADD(MONTH,-1,GETDATE()), DATEADD(MONTH,11,GETDATE()));

-- Phiếu 1: đã trả đủ; Phiếu 2: đang mượn, QUÁ HẠN; Phiếu 3: đang mượn, còn hạn
INSERT INTO PhieuMuon (MaDocGia, TenDangNhap, NgayMuon, HanTra) VALUES
(1, 'thuthu', DATEADD(DAY,-60,GETDATE()), DATEADD(DAY,-46,GETDATE())),
(2, 'thuthu', DATEADD(DAY,-20,GETDATE()), DATEADD(DAY,-6,GETDATE())),
(4, 'admin',  DATEADD(DAY,-3,GETDATE()),  DATEADD(DAY,11,GETDATE()));
INSERT INTO ChiTietPhieuMuon (MaPhieu, MaSach, NgayTra, TienPhat) VALUES
(1, 3, DATEADD(DAY,-50,GETDATE()), 0),
(1, 5, DATEADD(DAY,-44,GETDATE()), 10000),
(2, 1, NULL, 0),
(2, 7, NULL, 0),
(3, 5, NULL, 0);
GO
