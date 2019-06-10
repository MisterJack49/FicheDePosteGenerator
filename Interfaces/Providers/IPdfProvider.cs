using iTextSharp.text.pdf;
using LanguageExt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Interfaces.Providers
{
    public interface IPdfProvider
    {
        PdfReader OpenFile(Some<FileInfo> file);
        PdfStamper OpenForm(Some<PdfReader> template, Some<FileStream> generatedFileStream);
    }
}
