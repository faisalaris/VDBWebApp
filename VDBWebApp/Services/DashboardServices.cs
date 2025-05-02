using System.Net.Http;
using System.Text;


namespace VDBWebApp.Services
{
    public class DashboardServices
    {
        private readonly HttpClient _httpClient;

        public DashboardServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetDashboardHeaders(int personid)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_GetOrderStatusHeader {personid}",
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

        public async Task<string> GetDashboardHeaderDetails(int personid, string status)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_GetOrderStatusDetail {personid},'{status}'",
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
