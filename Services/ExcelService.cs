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
    public class ExcelService: IExcelService
    {
        private readonly IExcelProvider _excelProvider;

        public ExcelService(IExcelProvider excelProvider)
        {
            _excelProvider = excelProvider ?? throw new ArgumentNullException(nameof(excelProvider));
        }

        public Option<Dictionary<string, string>> GetCellsValue(Some<string> fileName, Some<IList<string>> cells)
        {
            var excelFile = _excelProvider.OpenFile(fileName);

            var cellValues = cells.Flatten().Distinct().ToDictionary(cell => cell, cell => _excelProvider.ReadCell(excelFile, cell));

            _excelProvider.CloseFile(excelFile);

            return new Dictionary<string, string>(cellValues);
        }
    }
}
