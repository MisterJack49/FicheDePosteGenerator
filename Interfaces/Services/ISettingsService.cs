using FicheDePosteGenerator.Model;
using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Interfaces.Services
{
    public interface ISettingsService
    {
        Settings Get();
        bool Set(Settings settings);
    }
}
