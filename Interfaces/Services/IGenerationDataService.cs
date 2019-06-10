using FicheDePosteGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Interfaces.Services
{
    public interface IGenerationDataService
    {
        GenerationData Get();
        bool Set(GenerationData generationData);
    }
}
