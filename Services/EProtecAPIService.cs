using FicheDePosteGenerator.Interfaces;
using FicheDePosteGenerator.Interfaces.Services;
using LanguageExt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FicheDePosteGenerator.Services
{
    public class EProtecAPIService : IEProtecAPIService
    {
        private static readonly string _baseURI = "https://franceprotectioncivile.org";
        private HttpClient _httpClient;
        private readonly ISettingsService _settingsService;

        private bool _isConnected;

        public EProtecAPIService(ISettingsService settingsService)
        {
            _settingsService = settingsService ?? throw new ArgumentNullException(nameof(settingsService));
            _httpClient = new HttpClient();
        }

        public async Task<bool> Login(string login, string password)
        {
            if (string.IsNullOrEmpty(login)) throw new ArgumentNullException(nameof(login));
            if (string.IsNullOrEmpty(password)) throw new ArgumentNullException(nameof(password));

            string loginPage = $"{_baseURI}/check_login.php";

            if (_isConnected) return true;

            var content = new MultipartFormDataContent();

            content.Add(new StringContent(login), $"\"id\"");
            content.Add(new StringContent(password), $"\"pwd\"");

            var response = await _httpClient.PostAsync(loginPage, content);

            var contentResponse = await response.Content.ReadAsStringAsync();

            _isConnected = !contentResponse.ToLower().Contains("erreur");
            return _isConnected;
        }

        public async Task<Option<string>> GetEvent(Some<string> eventId)
        {
            var settings = _settingsService.Get();
            await Login(settings.Login, settings.Password);

            string eventXlsPage = $"{_baseURI}/evenement_xls.php?evenement={eventId.ToString()}";

            var response = await _httpClient.GetAsync(eventXlsPage);
            var fileName = $"{eventId}.xlsx";

            if (response.IsSuccessStatusCode)
            {
                var fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                await response.Content
                    .CopyToAsync(fileStream)
                    .ContinueWith(t => fileStream.Close());

                return fileName;
            }

            return null;
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}
