using FicheDePosteGenerator.Interfaces.Providers;
using iTextSharp.text.pdf;
using LanguageExt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Provider
{
    public class PdfProvider: IPdfProvider
    {
        public PdfReader OpenFile(Some<FileInfo> file)
        {
            return new PdfReader(file.Value.FullName);
        }

        public PdfStamper OpenForm(Some<PdfReader> template, Some<FileStream> generatedFileStream)
        {
            return new PdfStamper(template.Value, generatedFileStream.Value);
        }
    }
}
