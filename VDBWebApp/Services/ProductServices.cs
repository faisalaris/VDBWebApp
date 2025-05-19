using System.Net.Http;
using System.Text;
using VDBWebApp.Models;



namespace VDBWebApp.Services
{
    public class ProductServices
    {
        private readonly HttpClient _httpClient;

        public ProductServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetListProducts(int page, string query)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec dbo.SPW_GetItem {page * 10},'%{query}%'",
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
        public async Task<string> GetListProductsUser(int page, string query,string userid)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec dbo.SPW_GetItemUser {page * 10},'%{query}%','{userid}'",
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

        public async Task<string> GetProduct(string itemId)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec dbo.SPA_GetProductEdit '{itemId}'",
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
        public async Task<string> GetProductUser(string itemId,string userid)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec dbo.SPW_GetProductEdit '{itemId}','{userid}'",
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

        public async Task<string> SaveProductService(Product product)
        {
            string pItemId = product.item_id;
            string pItemCode = product.item_code;
            string pItemName = product.item_name;
            string pThumbnail = product.thumbnail;
            string pItemPrice = product.item_price;
            string pMsrp = product.msrp;
            string pItemStock = product.item_stock;
            string pIsActive = product.isactive;
            string pBrandName = product.brand_name;
            string pCategoryId = product.category_id;
            string pRemark = product.remark;
            string pStartHighlight = product.starthighlight;
            string pEndHighlight = product.endhighlight;

            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec dbo.SPA_SetProductEdit '{pItemId}','{pItemCode}','{pItemName}','{pCategoryId}'" +
                         $",'{pBrandName}','{pItemStock}','{pThumbnail}','{pMsrp}','{pItemPrice}','{pRemark}'" +
                         $",'{pIsActive}','{pStartHighlight}','{pEndHighlight}'",
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

        public async Task<string> GetPriceProduct(string itemId)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec dbo.SPA_GetItemPriceList '{itemId}'",
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

        public async Task<string> SavePriceProduct(string itemId,string catCode,string catPrice)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec dbo.SPA_SetItemPriceList '{itemId}','{catCode}','{catPrice}'",
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

        public async Task<string> GetHighlightProduct(string userType,string userId)
        {
            try
            {
                var url = "";

                if (userType == "ADMIN")
                {
                    var postData = new
                    {
                        SP = $"exec dbo.SPA_GetListHighlightAdmin",
                        ParamSP = new { }
                    };
                    var request = new HttpRequestMessage(HttpMethod.Post, url)
                    {
                        Content = new StringContent(System.Text.Json.JsonSerializer.Serialize(postData), Encoding.UTF8, "application/json")
                    };

                    var response = await _httpClient.SendAsync(request);
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    return jsonResponse;
                }
                else
                {
                    var postData = new
                    {
                        SP = $"exec dbo.SPA_GetListHighlight '{userId}'",
                        ParamSP = new { }
                    };
                    var request = new HttpRequestMessage(HttpMethod.Post, url)
                    {
                        Content = new StringContent(System.Text.Json.JsonSerializer.Serialize(postData), Encoding.UTF8, "application/json")
                    };

                    var response = await _httpClient.SendAsync(request);
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    return jsonResponse;
                } 

            }
            catch
            {
                return null;
            }
        }
    }
}
