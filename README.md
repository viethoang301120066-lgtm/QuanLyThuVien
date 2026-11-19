# PHẦN MỀM QUẢN LÝ THƯ VIỆN — Lập trình .NET

WinForms (C#) · .NET Framework 4.8 · SQL Server · ADO.NET · Kiến trúc 3 lớp

## 1. Cấu trúc solution

```
QuanLyThuVien/
├── QuanLyThuVien.sln
├── Database/QuanLyThuVien.sql   ← Script tạo CSDL + dữ liệu mẫu
├── DTO/   Đối tượng truyền dữ liệu (TaiKhoanDTO, SachDTO, DocGiaDTO, ...)
├── DAL/   Truy cập dữ liệu (DataProvider + các lớp *DAL, câu lệnh có tham số)
├── BLL/   Nghiệp vụ & kiểm tra dữ liệu (quy định mượn trả, mã hóa mật khẩu)
└── GUI/   Giao diện WinForms (frm*.cs + frm*.Designer.cs), App.config
```

Hướng phụ thuộc: **GUI → BLL → DAL → (SQL Server)**, cả ba lớp dùng chung **DTO**.

## 2. Cách chạy

1. Mở **SQL Server Management Studio**, mở `Database/QuanLyThuVien.sql` rồi bấm **Execute**.
2. Mở `QuanLyThuVien.sln` bằng **Visual Studio 2019/2022**.
3. Sửa `Data Source` trong `GUI/App.config` cho đúng máy của bạn (`.`, `.\SQLEXPRESS`, `(localdb)\MSSQLLocalDB`, ...).
4. Chuột phải project **GUI** → *Set as Startup Project* → **F5**.

| Tài khoản | Mật khẩu | Vai trò |
|-----------|----------|---------|
| `admin`   | `123456` | Admin (thêm được menu Tài khoản) |
| `thuthu`  | `123456` | Thủ thư |

## 3. Chức năng

| Màn hình | Nội dung |
|----------|----------|
| Đăng nhập | Mật khẩu mã hóa SHA-256, phân quyền Admin / Thủ thư, đăng xuất, đổi mật khẩu |
| **Tổng quan (Dashboard)** | 6 thẻ số liệu (đầu sách, tổng cuốn, độc giả, đang mượn, quá hạn, tiền phạt), biểu đồ cột lượt mượn 6 tháng, biểu đồ tròn theo thể loại, danh sách sách quá hạn, top 5 sách mượn nhiều |
| Quản lý sách | Thêm / sửa / xóa + **bộ lọc kết hợp** (từ khóa, thể loại, tác giả, NXB, khoảng năm, còn/hết); dòng đỏ = hết sách |
| Thể loại / Tác giả / NXB | Một form dùng chung, có số đầu sách mỗi mục |
| Độc giả | Thêm / sửa / xóa, kiểm tra SĐT/email/tuổi; lọc theo thẻ còn hạn / hết hạn / đang mượn / quá hạn |
| Mượn sách | Chọn độc giả (gõ để tìm), hiện ngay tình trạng mượn của độc giả, nhấp đúp để thêm sách, lập phiếu (transaction) |
| Trả sách | Lọc sách đang mượn, chỉ hiện quá hạn, chọn nhiều cuốn trả một lần, xem trước tiền phạt; tab lịch sử |
| Tài khoản (Admin) | Thêm / sửa / xóa / đặt lại mật khẩu |
| **Xuất Excel / In ấn** | Nút *Xuất Excel* (file .xlsx thật, không cần cài Office hay NuGet) và *In / Xem trước* (khổ ngang, tự sang trang, có ngày in và người in) ở màn hình Sách, Độc giả, Sách đang mượn / quá hạn, Lịch sử trả. Xuất **theo kết quả lọc hiện tại**. Lập phiếu xong có thể **in phiếu mượn** có chỗ ký tên. |

### Tìm kiếm thông minh
- **Không phân biệt dấu & hoa/thường**: gõ `mat biec` ra *Mắt biếc* (SQL `COLLATE Vietnamese_CI_AI`).
- **Nhiều từ, thứ tự tự do**: mỗi từ chỉ cần khớp một cột bất kỳ. Ví dụ `clean martin` ra *Clean Code* của Robert C. Martin.
- **Tìm khi đang gõ**: tự lọc sau 300 ms ngừng gõ (Timer), không cần bấm nút.
- Ô năm = **0** nghĩa là không lọc theo năm.

### Quy định nghiệp vụ (`BLL/TaiKhoanBLL.cs` → lớp `QuyDinh`)
- Mỗi độc giả mượn tối đa **5 cuốn** cùng lúc; hạn mượn mặc định **14 ngày**.
- Không cho mượn khi thẻ hết hạn hoặc đang có sách quá hạn.
- Phạt **5.000 đ / ngày** trễ hạn; thẻ mới có hạn **12 tháng**.
- Không xóa được sách / độc giả / danh mục đã phát sinh dữ liệu liên quan.
- Số lượng còn được tính tự động qua view `vw_Sach`, nên không bao giờ bị lệch.

## 4. Điểm kỹ thuật nên trình bày khi bảo vệ
- Kiến trúc 3 lớp + DTO, GUI không chứa câu lệnh SQL.
- Mọi câu SQL đều dùng **SqlParameter** để chống SQL Injection.
- Lập phiếu mượn dùng **SqlTransaction** (lỗi giữa chừng thì rollback).
- Lỗi nghiệp vụ dùng `BusinessException`, GUI bắt lỗi tập trung qua `UI.Try(...)`.
- Biểu đồ dùng control `Chart` có sẵn trong .NET Framework (System.Windows.Forms.DataVisualization).
