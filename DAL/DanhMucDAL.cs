using System.Collections.Generic;
using System.Data;
using DTO;

namespace DAL
{
    /// <summary>Thể loại / Tác giả / Nhà xuất bản có cùng cấu trúc nên dùng chung một lớp.</summary>
    public class DanhMucDAL
    {
        private readonly string _bang, _cotMa, _cotTen;

        public DanhMucDAL(LoaiDanhMuc loai)
        {
            switch (loai)
            {
                case LoaiDanhMuc.TheLoai: _bang = "TheLoai"; _cotMa = "MaTheLoai"; _cotTen = "TenTheLoai"; break;
                case LoaiDanhMuc.TacGia: _bang = "TacGia"; _cotMa = "MaTacGia"; _cotTen = "TenTacGia"; break;
                default: _bang = "NhaXuatBan"; _cotMa = "MaNXB"; _cotTen = "TenNXB"; break;
            }
        }

        public DataTable Search(string tuKhoa)
        {
            var pars = new List<object>();
            string sql = $"SELECT {_cotMa} AS Ma, {_cotTen} AS Ten, " +
                         $"(SELECT COUNT(*) FROM Sach s WHERE s.{_cotMa} = d.{_cotMa}) AS SoDauSach " +
                         $"FROM {_bang} d WHERE 1=1" +
                         SqlFilter.KeywordClause(tuKhoa, new[] { _cotTen }, pars) +
                         $" ORDER BY {_cotTen}";
            return DataProvider.ExecuteQuery(sql, pars.ToArray());
        }

        public bool TrungTen(string ten, int boQuaMa) =>
            (int)DataProvider.ExecuteScalar(
                $"SELECT COUNT(*) FROM {_bang} WHERE {_cotTen} = @t AND {_cotMa} <> @m",
                "@t", ten, "@m", boQuaMa) > 0;

        public bool Insert(string ten) =>
            DataProvider.ExecuteNonQuery($"INSERT INTO {_bang} ({_cotTen}) VALUES (@t)", "@t", ten) > 0;

        public bool Update(DanhMucDTO dm) =>
            DataProvider.ExecuteNonQuery($"UPDATE {_bang} SET {_cotTen} = @t WHERE {_cotMa} = @m",
                "@t", dm.Ten, "@m", dm.Ma) > 0;

        public bool Delete(int ma) =>
            DataProvider.ExecuteNonQuery($"DELETE FROM {_bang} WHERE {_cotMa} = @m", "@m", ma) > 0;

        public bool DangDuocDung(int ma) =>
            (int)DataProvider.ExecuteScalar($"SELECT COUNT(*) FROM Sach WHERE {_cotMa} = @m", "@m", ma) > 0;
    }
}
