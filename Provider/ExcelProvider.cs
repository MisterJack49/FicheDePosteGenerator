using FicheDePosteGenerator.Interfaces.Providers;
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

        public string ReadCell(ExcelPackage excelPackage, string cell)
        {
            var worksheet = excelPackage.Workbook.Worksheets.First();

            return worksheet.Cells[cell].Value.ToString();
        }

        public void CloseFile(ExcelPackage excelPackage)
        {
            excelPackage.Dispose();
        }
    }
}
