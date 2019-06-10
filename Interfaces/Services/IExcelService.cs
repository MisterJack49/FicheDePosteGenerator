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
        Option<Dictionary<string, string>> GetCellsValue(Some<string> fileName, Some<IList<string>> cells);
    }
}
