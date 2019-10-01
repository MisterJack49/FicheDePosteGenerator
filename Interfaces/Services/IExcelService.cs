using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Interfaces.Services
{
    public interface IExcelService
    {
        Option<string> GetCellValue(Some<string> fileName, Some<string> cell);
        Option<Dictionary<string, string>> GetCellsValue(Some<string> fileName, Some<IList<string>> cells);
        Option<List<List<string>>> GetListOfValues(Some<string> fileName, Some<int> startRow, params string[] columns);
        Option<List<string>> GetColumnValues(Some<string> fileName, Some<string> column, Some<int> startRow, Some<int> endRow);
    }

}
