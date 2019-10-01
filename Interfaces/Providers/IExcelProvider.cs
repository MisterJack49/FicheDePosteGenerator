using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Interfaces.Providers
{
    public interface IExcelProvider
    {
        ExcelPackage OpenFile(string filename);
        string ReadCell(ExcelWorksheet excelPackage, string cell);
        void CloseFile(ExcelPackage excelPackage);
    }
}
