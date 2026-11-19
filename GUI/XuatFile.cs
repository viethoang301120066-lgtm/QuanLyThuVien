using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    /// <summary>Xuất Excel và in ấn (xem trước khi in) cho dữ liệu trên DataGridView.</summary>
    public static class XuatFile
    {
        private static List<DataGridViewColumn> CotHienThi(DataGridView g) =>
            g.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible).OrderBy(c => c.DisplayIndex).ToList();

        // ======================= EXCEL =======================
        public static void XuatExcel(DataGridView g, string tieuDe)
        {
            if (g.Rows.Count == 0) { UI.Warn("Không có dữ liệu để xuất."); return; }
            using (var dlg = new SaveFileDialog
            {
                Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                FileName = $"{tieuDe}_{DateTime.Now:yyyyMMdd_HHmm}.xlsx"
            })
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;
                var cols = CotHienThi(g);
                var dong = g.Rows.Cast<DataGridViewRow>()
                    .Select(r => cols.Select(c => r.Cells[c.Index].Value).ToArray()).ToList();

                if (UI.Try(() => XlsxWriter.Ghi(dlg.FileName, tieuDe, cols.Select(c => c.HeaderText).ToArray(), dong))
                    && UI.Confirm($"Đã xuất {dong.Count} dòng ra file:\n{dlg.FileName}\n\nMở file ngay?"))
                    UI.Try(() => Process.Start(dlg.FileName));
            }
        }

        // ======================= IN BẢNG =======================
        public static void InBang(DataGridView g, string tieuDe)
        {
            if (g.Rows.Count == 0) { UI.Warn("Không có dữ liệu để in."); return; }
            var cols = CotHienThi(g);
            var data = g.Rows.Cast<DataGridViewRow>()
                .Select(r => cols.Select(c => Convert.ToString(r.Cells[c.Index].FormattedValue)).ToArray()).ToList();
            float tongTrongSo = cols.Sum(c => c.FillWeight);

            int dong = 0, trang = 0;
            var doc = new PrintDocument { DocumentName = tieuDe };
            doc.DefaultPageSettings.Landscape = true;
            doc.DefaultPageSettings.Margins = new Margins(40, 40, 40, 40);
            doc.BeginPrint += (s, e) => { dong = 0; trang = 0; };
            doc.PrintPage += (s, e) =>
            {
                var gr = e.Graphics;
                var vung = e.MarginBounds;
                float y = vung.Top;
                trang++;
                using (var fTieuDe = new Font("Segoe UI", 16, FontStyle.Bold))
                using (var fDam = new Font("Segoe UI", 9.5f, FontStyle.Bold))
                using (var f = new Font("Segoe UI", 9.5f))
                using (var but = new Pen(Color.Silver))
                using (var nenTieuDe = new SolidBrush(UI.MauChinh))
                using (var sf = new StringFormat { Trimming = StringTrimming.EllipsisCharacter, FormatFlags = StringFormatFlags.NoWrap, LineAlignment = StringAlignment.Center })
                {
                    if (trang == 1)
                    {
                        gr.DrawString("THƯ VIỆN - " + tieuDe.ToUpper(), fTieuDe, Brushes.Black,
                            new RectangleF(vung.Left, y, vung.Width, 34), new StringFormat { Alignment = StringAlignment.Center });
                        y += 38;
                        gr.DrawString($"Ngày in: {DateTime.Now:dd/MM/yyyy HH:mm}    Người in: {PhienDangNhap.TaiKhoan?.HoTen}    " +
                                      $"Tổng số dòng: {data.Count}", f, Brushes.DimGray, vung.Left, y);
                        y += 28;
                    }

                    float rowH = f.GetHeight(gr) + 10;
                    float[] rong = cols.Select(c => vung.Width * c.FillWeight / tongTrongSo).ToArray();

                    // Dòng tiêu đề cột
                    float x = vung.Left;
                    for (int c = 0; c < cols.Count; c++)
                    {
                        var o = new RectangleF(x, y, rong[c], rowH);
                        gr.FillRectangle(nenTieuDe, o);
                        gr.DrawString(cols[c].HeaderText, fDam, Brushes.White, new RectangleF(o.X + 3, o.Y, o.Width - 6, o.Height), sf);
                        x += rong[c];
                    }
                    y += rowH;

                    // Dữ liệu
                    while (dong < data.Count && y + rowH <= vung.Bottom - 20)
                    {
                        x = vung.Left;
                        for (int c = 0; c < cols.Count; c++)
                        {
                            var o = new RectangleF(x, y, rong[c], rowH);
                            gr.DrawRectangle(but, o.X, o.Y, o.Width, o.Height);
                            gr.DrawString(data[dong][c], f, Brushes.Black, new RectangleF(o.X + 3, o.Y, o.Width - 6, o.Height), sf);
                            x += rong[c];
                        }
                        y += rowH;
                        dong++;
                    }
                    gr.DrawString($"Trang {trang}", f, Brushes.DimGray, vung.Right - 60, vung.Bottom);
                }
                e.HasMorePages = dong < data.Count;
            };
            XemTruoc(doc);
        }

        // ======================= IN PHIẾU MƯỢN =======================
        public static void InPhieuMuon(int maPhieu, string docGia, DateTime hanTra, IList<string> dsSach)
        {
            var doc = new PrintDocument { DocumentName = "Phiếu mượn " + maPhieu };
            doc.PrintPage += (s, e) =>
            {
                var gr = e.Graphics;
                var v = e.MarginBounds;
                float y = v.Top;
                var giua = new StringFormat { Alignment = StringAlignment.Center };
                using (var fTo = new Font("Segoe UI", 18, FontStyle.Bold))
                using (var fDam = new Font("Segoe UI", 11, FontStyle.Bold))
                using (var f = new Font("Segoe UI", 11))
                using (var fNghieng = new Font("Segoe UI", 10, FontStyle.Italic))
                {
                    gr.DrawString("THƯ VIỆN", fDam, Brushes.Black, new RectangleF(v.Left, y, v.Width, 24), giua); y += 30;
                    gr.DrawString("PHIẾU MƯỢN SÁCH", fTo, Brushes.Black, new RectangleF(v.Left, y, v.Width, 36), giua); y += 40;
                    gr.DrawString($"Số phiếu: {maPhieu}", f, Brushes.Black, new RectangleF(v.Left, y, v.Width, 24), giua); y += 40;

                    void Dong(string nhan, string giaTri)
                    {
                        gr.DrawString(nhan, fDam, Brushes.Black, v.Left, y);
                        gr.DrawString(giaTri, f, Brushes.Black, v.Left + 160, y);
                        y += 28;
                    }
                    Dong("Độc giả:", docGia);
                    Dong("Ngày mượn:", DateTime.Today.ToString("dd/MM/yyyy"));
                    Dong("Hạn trả:", hanTra.ToString("dd/MM/yyyy"));
                    Dong("Thủ thư:", PhienDangNhap.TaiKhoan?.HoTen);
                    y += 10;
                    gr.DrawString("Danh sách sách mượn:", fDam, Brushes.Black, v.Left, y); y += 28;
                    for (int i = 0; i < dsSach.Count; i++) { gr.DrawString($"  {i + 1}. {dsSach[i]}", f, Brushes.Black, v.Left, y); y += 26; }
                    y += 16;
                    gr.DrawString($"Trả sách quá hạn bị phạt {QuyDinh.TienPhatMoiNgay:#,##0} đ/ngày/cuốn.",
                        fNghieng, Brushes.DimGray, v.Left, y);
                    y += 50;
                    float nua = v.Width / 2f;
                    gr.DrawString("Độc giả\n(Ký, ghi rõ họ tên)", fDam, Brushes.Black, new RectangleF(v.Left, y, nua, 60), giua);
                    gr.DrawString("Thủ thư\n(Ký, ghi rõ họ tên)", fDam, Brushes.Black, new RectangleF(v.Left + nua, y, nua, 60), giua);
                }
            };
            XemTruoc(doc);
        }

        private static void XemTruoc(PrintDocument doc)
        {
            using (var dlg = new PrintPreviewDialog { Document = doc, Width = 1100, Height = 750, StartPosition = FormStartPosition.CenterScreen })
            {
                ((Form)dlg).WindowState = FormWindowState.Maximized;
                UI.Try(() => dlg.ShowDialog());
            }
            doc.Dispose();
        }
    }
}
