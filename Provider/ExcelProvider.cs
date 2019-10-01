using FicheDePosteGenerator.Interfaces.Providers;
using LanguageExt;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Providers
{
    public class ExcelProvider : IExcelProvider
    {
        public ExcelPackage OpenFile(string filename)
        {
            var file = new FileInfo($"{filename}");
            if (!file.Exists) throw new FileNotFoundException(file.FullName);

            return new ExcelPackage(file);
        }

        public string ReadCell(ExcelWorksheet worksheet, string cell)
        {
            var cellColor = worksheet.Cells[cell].Style.Font.Color.Rgb;
            if (cellColor != "FF000000" && cellColor != "000000") return "";
            return worksheet.Cells[cell].Value?.ToString().Trim() ?? "";
        }

        public void CloseFile(ExcelPackage excelPackage)
        {
            excelPackage.Dispose();
        }
    }
}
