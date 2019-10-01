using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Model
{
    public class Settings
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public ConnectionStatus ConnectionStatus { get; set; }
        public string DietReferenceFileName { get; set; }
    }
}
