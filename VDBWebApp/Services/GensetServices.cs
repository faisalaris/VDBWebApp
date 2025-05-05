using System.Net.Http;
using System.Text;

namespace VDBWebApp.Services
{
    public class GensetServices
    {
        private readonly HttpClient _httpClient;

        public GensetServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetListCategory()
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"SELECT Gcode,GName FROM G_GenSet WHERE GType ='05' ORDER BY GName ASC",
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

        public async Task<string> GetListCustomerCategory()
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"SELECT Gcode,GName FROM G_GenSet WHERE GType ='01' ORDER BY GName ASC",
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

        public async Task<string> GetListPaymentCategory()
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"SELECT Gcode,GName FROM G_GenSet WHERE GType ='03' ORDER BY GName ASC",
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
