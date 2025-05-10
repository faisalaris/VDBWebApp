using System.Text;

namespace VDBWebApp.Services
{
    public class OrderServices
    {

        private readonly HttpClient _httpClient;

        public OrderServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetListCustToOrder()
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_GetCustToOrder",
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

        public async Task<string> GetListOrder(string personid)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_GetListOrder '{personid}'",
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
