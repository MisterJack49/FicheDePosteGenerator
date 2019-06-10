using System.IO;
using iTextSharp.text.pdf;
using LanguageExt;

namespace FicheDePosteGenerator.Interfaces.Services
{
    public interface IPdfService
    {
        void CloseCreationStream(PdfStamper pdf);
        PdfStamper OpenCreationStream(Some<FileInfo> templateFileInfo, Some<FileInfo> generatedFileInfo);
        bool SetField(Some<AcroFields> form, Some<string> field, Some<string> value);
    }
}