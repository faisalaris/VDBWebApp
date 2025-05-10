using System.Net.Http;
using System.Text;
using VDBWebApp.Models;

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

        public async Task<string> GetGenset(string gtype,string isactive,string includeimage,string gcode)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_GetGenset '{gtype}','{isactive}','{includeimage}','{gcode}'",
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
        public async Task<string> SetEditGenset(Genset genset,string gtype)
        {
            string pGcode = genset.GCode;
            string pGname = genset.Gname;
            string pGimage = ConvertBase64ToHex(genset.Gimage)  ;
            string pIsactive = genset.Isactive;
            string pThumbnail = genset.Thumbnail;
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_SetUpdateGenset '{gtype}','{pGcode}','{pGname}','{pIsactive}','{pThumbnail}','{pGimage}'",
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

        public async Task<string> SetAddGenset(Genset genset, string gtype)
        {
            string pGcode = genset.GCode;
            string pGname = genset.Gname;
            string pGimage = ConvertBase64ToHex(genset.Gimage);
            string pIsactive = genset.Isactive;
            string pThumbnail = genset.Thumbnail;
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_SetNewGenset '{gtype}','{pGcode}','{pGname}','{pIsactive}','{pThumbnail}','{pGimage}'",
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

        public async Task<string> GetBanner(string userid)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_GetBanner '{userid}'",
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
        public async Task<string> SetBanner(string bannerimage)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_SetInsertBanner '{bannerimage}'",
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
        
        public static string ConvertBase64ToHex(string base64)
        {
            if (string.IsNullOrWhiteSpace(base64))
                return "";

            try
            {
                // Jika base64 diawali dengan data:image/png;base64, buang prefix-nya
                var base64Clean = base64;

                var commaIndex = base64.IndexOf(',');
                if (commaIndex >= 0)
                    base64Clean = base64[(commaIndex + 1)..];

                var bytes = Convert.FromBase64String(base64Clean);
                var hex = BitConverter.ToString(bytes).Replace("-", "");

                return "0x" + hex;
            }
            catch
            {
                return "";
            }
        }
    }
}
