using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    /// <summary>Các hàm tiện ích giao diện dùng chung.</summary>
    public static class UI
    {
        public static readonly Color MauChinh = Color.FromArgb(37, 99, 235);
        public static readonly Color MauNen = Color.FromArgb(243, 244, 246);
        public static readonly Color MauCanhBao = Color.FromArgb(254, 226, 226);

        public static void Info(string msg) =>
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static void Warn(string msg) =>
            MessageBox.Show(msg, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public static bool Confirm(string msg) =>
            MessageBox.Show(msg, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

        /// <summary>Chạy một thao tác, tự bắt lỗi và hiển thị thông báo phù hợp.</summary>
        public static bool Try(Action action)
        {
            try { action(); return true; }
            catch (BusinessException ex) { Warn(ex.Message); }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu:\n" + ex.Message +
                    "\n\nKiểm tra SQL Server và chuỗi kết nối trong App.config.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return false;
        }

        public static void StyleGrid(DataGridView g)
        {
            g.ReadOnly = true;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.BackgroundColor = Color.White;
            g.BorderStyle = BorderStyle.None;
            g.RowHeadersVisible = false;
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersDefaultCellStyle.BackColor = MauChinh;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            g.ColumnHeadersHeight = 34;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.RowTemplate.Height = 30;
            g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 251);
            g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 219, 254);
            g.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        /// <summary>
        /// Chỉ hiện các cột được liệt kê theo dạng "TenCot:Tiêu đề" (theo đúng thứ tự), ẩn các cột còn lại.
        /// </summary>
        public static void Columns(DataGridView g, params string[] spec)
        {
            foreach (DataGridViewColumn c in g.Columns) c.Visible = false;
            for (int i = 0; i < spec.Length; i++)
            {
                var p = spec[i].Split(':');
                var col = g.Columns[p[0]];
                if (col == null) continue;
                col.Visible = true;
                col.HeaderText = p[1];
                col.DisplayIndex = i;
                if (col.ValueType == typeof(DateTime)) col.DefaultCellStyle.Format = "dd/MM/yyyy";
                if (col.ValueType == typeof(decimal)) col.DefaultCellStyle.Format = "#,##0";
            }
        }

        /// <summary>Đổ dữ liệu danh mục (cột Ma, Ten) vào ComboBox; có thể thêm dòng "Tất cả" (Ma = 0).</summary>
        public static void BindCombo(ComboBox cb, DataTable dt, string dongDau = null)
        {
            if (dongDau != null)
            {
                var r = dt.NewRow();
                r["Ma"] = 0;
                r["Ten"] = dongDau;
                dt.Rows.InsertAt(r, 0);
            }
            cb.DisplayMember = "Ten";
            cb.ValueMember = "Ma";
            cb.DataSource = dt;
        }

        /// <summary>Lấy giá trị đã chọn; 0 hoặc chưa chọn → null.</summary>
        public static int? SelectedId(ComboBox cb)
        {
            if (cb.SelectedValue == null) return null;
            int v = Convert.ToInt32(cb.SelectedValue);
            return v == 0 ? (int?)null : v;
        }
    }
}
