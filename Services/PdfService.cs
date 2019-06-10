using FicheDePosteGenerator.Interfaces.Providers;
using FicheDePosteGenerator.Interfaces.Services;
using iTextSharp.text.pdf;
using LanguageExt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Services
{
    public class PdfService : IPdfService
    {
        private readonly IPdfProvider _pdfProvider;

        public PdfService(IPdfProvider pdfProvider)
        {
            _pdfProvider = pdfProvider ?? throw new ArgumentNullException(nameof(pdfProvider));
        }

        public PdfStamper OpenCreationStream(Some<FileInfo> templateFileInfo, Some<FileInfo> generatedFileInfo)
        {
            return _pdfProvider.OpenForm(_pdfProvider.OpenFile(templateFileInfo), new FileStream(generatedFileInfo.Value.FullName, FileMode.Create));
        }

        public bool SetField(Some<AcroFields> form, Some<string> field, Some<string> value)
        {
            form.Value.SetFieldProperty(field, "textsize", 4,null);

            BaseFont font = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, BaseFont.EMBEDDED);
            form.Value.SetFieldProperty(field, "textfont", font, null);
            return form.Value.SetField(field, value);
        }

        public void CloseCreationStream(PdfStamper pdf)
        {
            pdf.Close();
        }
    }
}
