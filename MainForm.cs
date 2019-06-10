using FicheDePosteGenerator.Interfaces;
using FicheDePosteGenerator.Interfaces.Services;
using FicheDePosteGenerator.Model;
using FicheDePosteGenerator.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FicheDePosteGenerator
{
    public partial class MainForm : Form
    {
        private readonly ISettingsService _settingsService;
        private readonly IEProtecAPIService _eProtecAPIService;
        private readonly IGeneratorService _generatorService;
        private readonly IGenerationDataService _generationDataService;
        private Settings _settings;
        private GenerationData _generationData;

        public MainForm(ISettingsService settingsService, IEProtecAPIService eProtecAPIService, IGeneratorService generatorService, IGenerationDataService generationDataService)
        {
            _settingsService = settingsService ?? throw new ArgumentNullException(nameof(settingsService));
            _eProtecAPIService = eProtecAPIService ?? throw new ArgumentNullException(nameof(eProtecAPIService));
            _generatorService = generatorService ?? throw new ArgumentNullException(nameof(generatorService));
            _generationDataService = generationDataService ?? throw new ArgumentNullException(nameof(generationDataService));

            InitializeComponent();
            InitializeSettings();
            InitializeGenerationData();
        }

        private void InitializeGenerationData()
        {
            _generationData = _generationDataService.Get();

            OrganizerPdfTextBox.Text = _generationData.Organizer?.FieldName;
            OrganizerExcelTextBox.Text = _generationData.Organizer?.Cell;
            EventPdfTextBox.Text = _generationData.Event?.FieldName;
            EventExcelTextBox.Text = _generationData.Event?.Cell;
            PlacePdfTextBox.Text = _generationData.Place?.FieldName;
            PlaceExcelTextBox.Text = _generationData.Place?.Cell;
            DatePdfTextBox.Text = _generationData.Date?.FieldName;
            DateExcelTextBox.Text = _generationData.Date?.Cell;
            TimePdfTextBox.Text = _generationData.Time?.FieldName;
            TimeExcelTextBox.Text = _generationData.Time?.Cell;
            PapsPdfTextBox.Text = _generationData.Paps?.FieldName;
            TeamNumberPdfTextBox.Text = _generationData.TeamNumber?.FieldName;
            LocalPdfTextBox.Text = _generationData.Local?.FieldName;
            MealPdfTextBox.Text = _generationData.Meal?.FieldName;
        }

        private void InitializeSettings()
        {
            _settings = _settingsService.Get();
            LoginTextBox.Text = _settings.Login;
            PasswordTextBox.Text = _settings.Password;
            ConnectionStatusLabel.Text = GetStatus(_settings.ConnectionStatus);
        }

        private async void ConnectionTestButton_Click(object sender, EventArgs e)
        {
            _settings.Login = LoginTextBox.Text;
            _settings.Password = PasswordTextBox.Text;
            _settings.ConnectionStatus = ConnectionStatus.Untested;

            var test = await _eProtecAPIService.Login(_settings.Login, _settings.Password);

            _settings.ConnectionStatus = test ? ConnectionStatus.Ok : ConnectionStatus.Ko;

            ConnectionStatusLabel.Text = GetStatus(_settings.ConnectionStatus);
        }

        private string GetStatus(ConnectionStatus status)
        {
            switch (status)
            {
                case ConnectionStatus.Ko:
                    return "Connexion Ko";
                case ConnectionStatus.Ok:
                    return "Connexion Ok";
                default:
                    return "Non testée";
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            _generationData.EventId = DPSIdTextBox.Text;
            _generationData.TeamNumber.Value = TeamNumberTextBox.Text;
            _generationData.Paps.Value = PapsCheckBox.Checked ? "Yes" : "No";
            _generationData.Meal.Value = MealCheckBox.Checked ? "Yes" : "No";
            _generationData.Local.Value = LocalCheckBox.Checked ? "Yes" : "No";

            _generatorService.GeneratePdf(_generationData);
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            _generationData.Organizer = new CellField(OrganizerPdfTextBox.Text, OrganizerExcelTextBox.Text);
            _generationData.Event = new CellField(EventPdfTextBox.Text, EventExcelTextBox.Text);
            _generationData.Place = new CellField(PlacePdfTextBox.Text, PlaceExcelTextBox.Text);
            _generationData.Date = new CellField(DatePdfTextBox.Text, DateExcelTextBox.Text);
            _generationData.Time = new CellField(TimePdfTextBox.Text, TimeExcelTextBox.Text);
            _generationData.Paps = new Field(PapsPdfTextBox.Text);
            _generationData.TeamNumber = new Field(TeamNumberPdfTextBox.Text);
            _generationData.Local = new Field(LocalPdfTextBox.Text);
            _generationData.Meal = new Field(MealPdfTextBox.Text);

            _generationDataService.Set(_generationData);
            _settingsService.Set(_settings);
        }
    }
}
