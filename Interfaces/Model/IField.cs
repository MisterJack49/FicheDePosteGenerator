using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Interfaces.Model
{
    public interface IField
    {
        string FieldName { get; }
        string Value { get; set; }
    }
}
