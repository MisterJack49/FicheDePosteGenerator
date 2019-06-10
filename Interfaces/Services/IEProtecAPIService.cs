using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Interfaces.Services
{
    public interface IEProtecAPIService
    {
        Task<bool> Login(string login, string password);
        Task<Option<string>> GetEvent(Some<string> eventId);
        void Dispose();
    }
}
