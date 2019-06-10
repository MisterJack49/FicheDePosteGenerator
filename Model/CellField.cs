using FicheDePosteGenerator.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Model
{
    public class CellField : Field, ICellField
    {
        public string Cell { get; set; }

        public CellField() { }
        public CellField(string field, string cell):base(field)
        {
            Cell = cell;
        }
    }
}
