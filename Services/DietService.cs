using FicheDePosteGenerator.Interfaces.Services;
using FicheDePosteGenerator.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Services
{
    public class DietService : IDietService
    {
        private readonly IEProtecAPIService _eProtecAPIService;
        private readonly ISettingsService _settingsService;
        private readonly IExcelService _excelService;

        public DietService(IEProtecAPIService eProtecAPIService, ISettingsService settingsService, IExcelService excelService)
        {
            _eProtecAPIService = eProtecAPIService ?? throw new ArgumentNullException(nameof(eProtecAPIService));
            _settingsService = settingsService ?? throw new ArgumentNullException(nameof(settingsService));
            _excelService = excelService ?? throw new ArgumentNullException(nameof(excelService));
        }

        public void SaveDietReferenceFile(string filePath)
        {

            var fileName = filePath.Split('\\').Last();
            var copyPath = $"Resources/{fileName}";

            if (File.Exists(copyPath)) File.Delete(copyPath);

            File.Copy(filePath, copyPath);

            var settings = _settingsService.Get();
            settings.DietReferenceFileName = fileName;
            _settingsService.Set(settings);
        }


        public async void GenerateDietSheet(DateTime startDate, DateTime endDate, IProgress<int> progress)
        {
            var generatedFileName = new FileInfo($"Generated/[RegimeAlimentaire]{startDate.ToString("dd-MM")} - {endDate.ToString("dd-MM")}.txt");

            await _eProtecAPIService.GetEvents(startDate, endDate).IfSomeAsync(async fileName =>
            {
                progress.Report(10);
                var eventsDataList = _excelService.GetListOfValues(fileName, 2, "A", "D", "I")
                .Flatten()
                .Select(x => new EventInfo(x));

                var prog = 0;
                var count = 0;
                foreach (var eventData in eventsDataList)
                {
                    count++;
                    prog = (count * 100) / eventsDataList.Count();

                    await _eProtecAPIService.GetEvent(eventData.Id).IfSomeAsync(eventFile =>
                    {
                        _excelService.GetCellValue(eventFile, "B8").IfSome(cellValue =>
                        {
                            var peopleRequired = int.Parse(cellValue.Split(',').First().Split(' ').Last());
                            var peopleSignedIn = int.Parse(cellValue.Split(',').Skip(1).First().Split(' ').Last());
                            _excelService.GetColumnValues(eventFile, "A", 10, 100).IfSome(peopleNames =>
                            {
                                var peoplesDietData = _excelService.GetListOfValues($"Resources/{_settingsService.Get().DietReferenceFileName}", 2, "B", "C", "D")
                                    .Flatten()
                                    .Select(x => new PeopleInfo(x));

                                var peopleWithDiet = peoplesDietData.Where(x => peopleNames.Contains(x.CompleteName, StringComparer.OrdinalIgnoreCase));

                                using (StreamWriter file = new StreamWriter(generatedFileName.FullName, true))
                                {
                                    file.WriteLine($"{eventData.Date} - {eventData.Name} :");
                                    file.WriteLine($"Nombre Requis : {peopleRequired} / Nombre d'inscrits : {peopleSignedIn}");
                                    if (peopleWithDiet.Any())
                                    {
                                        file.WriteLine("Régimes spécifiques :");
                                        peopleWithDiet.ToList()
                                            .ForEach(x => file.WriteLine($"    - {x.CompleteName}: {x.Diet}"));
                                    }
                                    file.WriteLine();
                                }
                            });
                        });
                        File.Delete(eventFile);
                    });
                }

                File.Delete(fileName);
                progress.Report(100);
                Process.Start("explorer.exe", "/select," + generatedFileName.FullName);
            });
        }

        private class EventInfo
        {
            public string Id;
            public string Name;
            public string Date;

            public EventInfo(List<string> values)
            {
                Id = values.First();
                Name = values.Skip(1).First();
                Date = values.Last();
            }
        }

        private class PeopleInfo
        {
            public string Name;
            public string FirstName;
            public string CompleteName => Name.ToUpper() + " " + FirstName;
            public string Diet;

            public PeopleInfo(List<string> values)
            {
                Name = values.First();
                FirstName = values.Skip(1).First();
                Diet = values.Last();
            }
        }
    }
}
