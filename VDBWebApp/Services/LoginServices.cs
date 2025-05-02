using System.Net.Http;
using System.Text;

namespace VDBWebApp.Services
{
    public class LoginServices
    {
        private readonly HttpClient _httpClient;

        public LoginServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetValidateUserAsync(string appCode,string deviceId, string userId, string password)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_GetValidateUser '{appCode}','{deviceId}','{userId}','{password}'",
                    ParamSP = new { }
                };

                var request = new HttpRequestMessage(HttpMethod.Post, url)
                {
                    Content = new StringContent(System.Text.Json.JsonSerializer.Serialize(postData), Encoding.UTF8, "application/json")
                };

                // Menambahkan header

                var response = await _httpClient.SendAsync(request);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                return jsonResponse;
            }
            catch
            {
                return null;
            }
        }

    }
}
