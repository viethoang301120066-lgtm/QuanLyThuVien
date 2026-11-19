using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Security;
using System.Text;

namespace GUI
{
    /// <summary>
    /// Ghi file Excel .xlsx thật (định dạng Office Open XML) chỉ bằng thư viện có sẵn của .NET Framework,
    /// không cần cài Office hay NuGet. Dòng đầu là tiêu đề cột (nền xanh, chữ trắng đậm).
    /// </summary>
    public static class XlsxWriter
    {
        public static void Ghi(string duongDan, string tenSheet, string[] tieuDeCot, List<object[]> dong)
        {
            if (File.Exists(duongDan)) File.Delete(duongDan);
            using (var zip = ZipFile.Open(duongDan, ZipArchiveMode.Create))
            {
                Them(zip, "[Content_Types].xml",
                    "<Types xmlns=\"http://schemas.openxmlformats.org/package/2006/content-types\">" +
                    "<Default Extension=\"rels\" ContentType=\"application/vnd.openxmlformats-package.relationships+xml\"/>" +
                    "<Default Extension=\"xml\" ContentType=\"application/xml\"/>" +
                    "<Override PartName=\"/xl/workbook.xml\" ContentType=\"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml\"/>" +
                    "<Override PartName=\"/xl/worksheets/sheet1.xml\" ContentType=\"application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml\"/>" +
                    "<Override PartName=\"/xl/styles.xml\" ContentType=\"application/vnd.openxmlformats-officedocument.spreadsheetml.styles+xml\"/>" +
                    "</Types>");
                Them(zip, "_rels/.rels",
                    "<Relationships xmlns=\"http://schemas.openxmlformats.org/package/2006/relationships\">" +
                    "<Relationship Id=\"rId1\" Type=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument\" Target=\"xl/workbook.xml\"/>" +
                    "</Relationships>");
                Them(zip, "xl/workbook.xml",
                    "<workbook xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\" " +
                    "xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\">" +
                    $"<sheets><sheet name=\"{Esc(TenSheetHopLe(tenSheet))}\" sheetId=\"1\" r:id=\"rId1\"/></sheets></workbook>");
                Them(zip, "xl/_rels/workbook.xml.rels",
                    "<Relationships xmlns=\"http://schemas.openxmlformats.org/package/2006/relationships\">" +
                    "<Relationship Id=\"rId1\" Type=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet\" Target=\"worksheets/sheet1.xml\"/>" +
                    "<Relationship Id=\"rId2\" Type=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles\" Target=\"styles.xml\"/>" +
                    "</Relationships>");
                // Style: 0 = thường, 1 = tiêu đề (đậm, trắng, nền xanh), 2 = số có phân cách hàng nghìn
                Them(zip, "xl/styles.xml",
                    "<styleSheet xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\">" +
                    "<fonts count=\"2\"><font><sz val=\"11\"/><name val=\"Calibri\"/></font>" +
                    "<font><b/><sz val=\"11\"/><color rgb=\"FFFFFFFF\"/><name val=\"Calibri\"/></font></fonts>" +
                    "<fills count=\"3\"><fill><patternFill patternType=\"none\"/></fill><fill><patternFill patternType=\"gray125\"/></fill>" +
                    "<fill><patternFill patternType=\"solid\"><fgColor rgb=\"FF2563EB\"/><bgColor indexed=\"64\"/></patternFill></fill></fills>" +
                    "<borders count=\"1\"><border><left/><right/><top/><bottom/><diagonal/></border></borders>" +
                    "<cellStyleXfs count=\"1\"><xf numFmtId=\"0\" fontId=\"0\" fillId=\"0\" borderId=\"0\"/></cellStyleXfs>" +
                    "<cellXfs count=\"3\"><xf numFmtId=\"0\" fontId=\"0\" fillId=\"0\" borderId=\"0\" xfId=\"0\"/>" +
                    "<xf numFmtId=\"0\" fontId=\"1\" fillId=\"2\" borderId=\"0\" xfId=\"0\" applyFont=\"1\" applyFill=\"1\"/>" +
                    "<xf numFmtId=\"3\" fontId=\"0\" fillId=\"0\" borderId=\"0\" xfId=\"0\" applyNumberFormat=\"1\"/></cellXfs>" +
                    "<cellStyles count=\"1\"><cellStyle name=\"Normal\" xfId=\"0\" builtinId=\"0\"/></cellStyles>" +
                    "</styleSheet>");
                Them(zip, "xl/worksheets/sheet1.xml", TaoSheet(tieuDeCot, dong));
            }
        }

        private static string TaoSheet(string[] tieuDeCot, List<object[]> dong)
        {
            var sb = new StringBuilder();
            sb.Append("<worksheet xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\">");
            // Đóng băng dòng tiêu đề
            sb.Append("<sheetViews><sheetView workbookViewId=\"0\"><pane ySplit=\"1\" topLeftCell=\"A2\" activePane=\"bottomLeft\" state=\"frozen\"/></sheetView></sheetViews>");
            sb.Append("<cols>");
            for (int c = 0; c < tieuDeCot.Length; c++)
            {
                int rong = tieuDeCot[c].Length;
                foreach (var d in dong) rong = Math.Max(rong, ChuoiO(d[c]).Length);
                sb.Append($"<col min=\"{c + 1}\" max=\"{c + 1}\" width=\"{Math.Min(60, rong + 3)}\" customWidth=\"1\"/>");
            }
            sb.Append("</cols><sheetData>");

            sb.Append("<row r=\"1\">");
            for (int c = 0; c < tieuDeCot.Length; c++) sb.Append(OChu(TenCot(c) + "1", tieuDeCot[c], 1));
            sb.Append("</row>");

            for (int i = 0; i < dong.Count; i++)
            {
                int r = i + 2;
                sb.Append($"<row r=\"{r}\">");
                for (int c = 0; c < tieuDeCot.Length; c++)
                {
                    object v = dong[i][c];
                    string refO = TenCot(c) + r;
                    if (v is int || v is long || v is short)
                        sb.Append($"<c r=\"{refO}\"><v>{Convert.ToString(v, CultureInfo.InvariantCulture)}</v></c>");
                    else if (v is decimal || v is double || v is float)
                        sb.Append($"<c r=\"{refO}\" s=\"2\"><v>{Convert.ToString(v, CultureInfo.InvariantCulture)}</v></c>");
                    else
                        sb.Append(OChu(refO, ChuoiO(v), 0));
                }
                sb.Append("</row>");
            }
            sb.Append("</sheetData></worksheet>");
            return sb.ToString();
        }

        private static string ChuoiO(object v)
        {
            if (v == null || v is DBNull) return "";
            if (v is DateTime d) return d.ToString("dd/MM/yyyy");
            return Convert.ToString(v, CultureInfo.InvariantCulture);
        }

        private static string OChu(string refO, string text, int style) =>
            $"<c r=\"{refO}\" t=\"inlineStr\"{(style > 0 ? $" s=\"{style}\"" : "")}><is><t xml:space=\"preserve\">{Esc(text)}</t></is></c>";

        /// <summary>0 → A, 25 → Z, 26 → AA ...</summary>
        private static string TenCot(int i)
        {
            string s = "";
            for (i++; i > 0; i = (i - 1) / 26) s = (char)('A' + (i - 1) % 26) + s;
            return s;
        }

        private static string TenSheetHopLe(string ten)
        {
            foreach (char ch in @"\/?*[]:") ten = ten.Replace(ch, ' ');
            ten = ten.Trim();
            if (ten == "") ten = "Sheet1";
            return ten.Length > 31 ? ten.Substring(0, 31) : ten;
        }

        private static string Esc(string s) => SecurityElement.Escape(s ?? "");

        private static void Them(ZipArchive zip, string ten, string xml)
        {
            var entry = zip.CreateEntry(ten, CompressionLevel.Optimal);
            using (var w = new StreamWriter(entry.Open(), new UTF8Encoding(false)))
            {
                w.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
                w.Write(xml);
            }
        }
    }
}
