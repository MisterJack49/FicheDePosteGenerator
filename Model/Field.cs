using FicheDePosteGenerator.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Model
{
    public class Field : IField
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public string FieldName { get; set; }

        public Field() { }
        public Field(string field)
        {
            FieldName = field;
        }
    }
}
