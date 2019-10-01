using FicheDePosteGenerator.Interfaces;
using FicheDePosteGenerator.Interfaces.Services;
using LanguageExt;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FicheDePosteGenerator
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(kernel.Get<ISettingsService>(), kernel.Get<IEProtecAPIService>(), kernel.Get<IGeneratorService>(), kernel.Get<IGenerationDataService>(), kernel.Get<IDietService>()));
        }
    }
}
