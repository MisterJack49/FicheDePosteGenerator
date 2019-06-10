using FicheDePosteGenerator.Interfaces;
using FicheDePosteGenerator.Interfaces.Model;
using FicheDePosteGenerator.Interfaces.Services;
using FicheDePosteGenerator.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Services
{
    public sealed class GeneratorService : IGeneratorService
    {
        private readonly IEProtecAPIService _eProtecAPIService;
        private readonly ISettingsService _settingsService;
        private readonly IExcelService _excelService;
        private readonly IPdfService _pdfService;

        public GeneratorService(IEProtecAPIService eProtecAPIService, ISettingsService settingsService, IExcelService excelService, IPdfService pdfService)
        {
            _eProtecAPIService = eProtecAPIService ?? throw new ArgumentNullException(nameof(eProtecAPIService));
            _settingsService = settingsService ?? throw new ArgumentNullException(nameof(settingsService));
            _excelService = excelService ?? throw new ArgumentNullException(nameof(excelService));
            _pdfService = pdfService ?? throw new ArgumentNullException(nameof(pdfService));
        }


        public async void GeneratePdf(GenerationData data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            await _eProtecAPIService.GetEvent(data.EventId).IfSomeAsync(fileName =>
            {
                var fieldProperties = data.GetType().GetProperties().Where(x => x.PropertyType == typeof(IField)).ToList();
                var fields = fieldProperties.Select(x => (IField)x.GetValue(data));

                var cellProperties = data.GetType().GetProperties().Where(x => x.PropertyType == typeof(ICellField)).ToList();
                var cellFields = cellProperties.Select(x => (ICellField)x.GetValue(data));


                _excelService.GetCellsValue(fileName, cellFields.Select(x => x.Cell).ToList()).IfSome(mappingValues =>
                  {
                      foreach (var cellField in cellFields)
                      {
                          cellField.Value = mappingValues[cellField.Cell];
                      }

                      data.Date.Value = data.Date.Value.Split(new[] { "de" }, StringSplitOptions.None).First();
                      data.Time.Value = data.Time.Value.Split(new[] { "de" }, StringSplitOptions.None).Last();

                      var pdfFileInfo = new FileInfo($"Resources/FicheDePosteTemplate.pdf");

                      if (!Directory.Exists("Generated"))
                      {
                          Directory.CreateDirectory("Generated");
                      }

                      var generatedFileInfo = new FileInfo($"Generated/[DPS]{data.Event.Value}.pdf");

                      var pdfStream = _pdfService.OpenCreationStream(pdfFileInfo, generatedFileInfo);

                      foreach (var cellField in cellFields)
                      {
                          _pdfService.SetField(pdfStream.AcroFields, cellField.FieldName, cellField.Value);
                      }

                      foreach (var field in fields)
                      {
                          _pdfService.SetField(pdfStream.AcroFields, field.FieldName, field.Value);
                      }

                      _pdfService.CloseCreationStream(pdfStream);

                      Process.Start("explorer.exe", "/select," + generatedFileInfo.FullName);
                  });

                File.Delete($"{data.EventId}.xlsx");
            });
        }


    }
}
