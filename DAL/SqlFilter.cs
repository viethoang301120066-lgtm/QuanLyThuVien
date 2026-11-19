using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    /// <summary>
    /// Hỗ trợ tìm kiếm thông minh:
    ///  - Không phân biệt hoa/thường và dấu tiếng Việt ("mat biec" tìm ra "Mắt biếc").
    ///  - Nhiều từ khóa: mỗi từ phải xuất hiện ở ít nhất một cột (thứ tự tự do).
    /// </summary>
    internal static class SqlFilter
    {
        public static string KeywordClause(string tuKhoa, string[] columns, List<object> pars)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa)) return "";
            var words = tuKhoa.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var parts = new List<string>();
            foreach (var w in words)
            {
                string p = "@kw" + parts.Count;
                pars.Add(p);
                pars.Add("%" + w + "%");
                parts.Add("(" + string.Join(" OR ",
                    columns.Select(c => $"CAST({c} AS NVARCHAR(200)) COLLATE Vietnamese_CI_AI LIKE {p}")) + ")");
            }
            return " AND " + string.Join(" AND ", parts);
        }
    }
}
