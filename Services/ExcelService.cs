using FicheDePosteGenerator.Interfaces.Providers;
using FicheDePosteGenerator.Interfaces.Services;
using LanguageExt;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Services
{
    public class ExcelService : IExcelService
    {
        private readonly IExcelProvider _excelProvider;

        public ExcelService(IExcelProvider excelProvider)
        {
            _excelProvider = excelProvider ?? throw new ArgumentNullException(nameof(excelProvider));
        }

        public Option<string> GetCellValue(Some<string> fileName, Some<string> cell)
        {
            var excelFile = _excelProvider.OpenFile(fileName);
            var worksheet = excelFile.Workbook.Worksheets.First();

            var cellValue = _excelProvider.ReadCell(worksheet, cell);

            _excelProvider.CloseFile(excelFile);

            return cellValue;
        }

        public Option<Dictionary<string, string>> GetCellsValue(Some<string> fileName, Some<IList<string>> cells)
        {
            var excelFile = _excelProvider.OpenFile(fileName);
            var worksheet = excelFile.Workbook.Worksheets.First();

            var cellValues = cells.Flatten().Distinct().ToDictionary(cell => cell, cell => _excelProvider.ReadCell(worksheet, cell));

            _excelProvider.CloseFile(excelFile);

            return new Dictionary<string, string>(cellValues);
        }

        public Option<List<string>> GetColumnValues(Some<string> fileName, Some<string> column, Some<int> startRow, Some<int> endRow)
        {
            var excelFile = _excelProvider.OpenFile(fileName);

            var sheet = excelFile.Workbook.Worksheets.First();
            var list = new List<string>();

            for (var i = startRow; i < endRow; i++)
            {
                var cell = _excelProvider.ReadCell(sheet, column + i);
                if (string.IsNullOrEmpty(cell)) continue;
                list.Add(cell);
            }

            _excelProvider.CloseFile(excelFile);
            return list;
        }

        public Option<List<List<string>>> GetListOfValues(Some<string> fileName, Some<int> startRow, params string[] columns)
        {
            var excelFile = _excelProvider.OpenFile(fileName);

            var list = new List<List<string>>();
            var sheet = excelFile.Workbook.Worksheets.First();
            for (var i = startRow; i <= sheet.Dimension.Rows; i++)
            {
                list.Add(columns.Select(x => _excelProvider.ReadCell(sheet, $"{x}{i}")).ToList());
            }

            _excelProvider.CloseFile(excelFile);

            return list;
        }
    }
}
