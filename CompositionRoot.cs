using FicheDePosteGenerator.Interfaces;
using FicheDePosteGenerator.Interfaces.Providers;
using FicheDePosteGenerator.Interfaces.Services;
using FicheDePosteGenerator.Provider;
using FicheDePosteGenerator.Providers;
using FicheDePosteGenerator.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator
{
    public class CompositionRoot : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<ISettingsService>().To<SettingsService>().InSingletonScope();
            Kernel.Bind<IGenerationDataService>().To<GenerationDataService>().InSingletonScope();
            Kernel.Bind<IEProtecAPIService>().To<EProtecAPIService>().InSingletonScope();
            Kernel.Bind<IGeneratorService>().To<GeneratorService>().InSingletonScope();
            Kernel.Bind<IExcelService>().To<ExcelService>().InSingletonScope();
            Kernel.Bind<IPdfService>().To<PdfService>().InSingletonScope();

            Kernel.Bind<IExcelProvider>().To<ExcelProvider>().InSingletonScope();
            Kernel.Bind<IPdfProvider>().To<PdfProvider>().InSingletonScope();
        }
    }
}
