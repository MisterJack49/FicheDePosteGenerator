using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Interfaces.Model
{
    public interface ICellField : IField
    {
        string Cell { get; }
    }
}
