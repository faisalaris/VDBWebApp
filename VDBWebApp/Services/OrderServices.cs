using System.Text;
using VDBWebApp.Models;
using static MudBlazor.CategoryTypes;

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
                    SP = $"exec SPW_GetListOrder '{personid}'",
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

        public async Task<string> GetListTransactionOrderHeader(string orderid)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_GetOrderHeader '{orderid}'",
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
        public async Task<string> GetListTransactionOrderDetail(string orderid)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_GetOrderDetail '{orderid}'",
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

        public async Task<string> GetListReplicateTransactionOrderDetail(string orderid,string personid)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_SetReplicateOrder '{orderid}','{personid}'",
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
        public async Task<string> SetQtyCart(string personid,string itemid,string qty,string remark)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_SetQtyCart '{personid}','{itemid}','{qty}','{remark}'",
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

        public async Task<string> SetQtyOrder(string orderid, string itemid, string qty, string remark)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_SetQtyOrder '{orderid}','{itemid}','{qty}','{remark}'",
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

        public async Task<string> SetDiscAmountCart(string personid, string itemid, string disc)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_SetDiscCart '{personid}','{itemid}','{disc}'",
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

        public async Task<string> SetDiscAmountOrder(string orderid, string itemid, string disc)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_SetDiscOrder '{orderid}','{itemid}','{disc}'",
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

        public async Task<string> SetDiscPercentageCart(string personid, string itemid, string disc)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_SetDiscPercentCart '{personid}','{itemid}','{disc}'",
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

        public async Task<string> SetDiscPercentageOrder(string orderid, string itemid, string disc)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_SetDiscPercentOrder '{orderid}','{itemid}','{disc}'",
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

        public async Task<string> AddItemToCart(string personid, string itemid)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_AddItemCart '{personid}','{itemid}'",
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

        public async Task<string> DeleteItemFromCart(string personid, string itemid)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_DeleteItemCart '{personid}','{itemid}'",
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

        public async Task<string> DeleteItemFromOrder(string orderid, string itemid)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_DeleteItemOrder '{orderid}','{itemid}'",
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
        
        public async Task<string> SetOrderInsertSO(string personid,string userid, Order order)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_SetInsertSO '{userid}','{personid}','{order.Remark}','{order.SenderStoreId}','{order.SenderName}'," +
                    $"'{order.SenderAddressCode}','{order.SenderStreetAddress}','{order.SenderPhoneNo}','{order.RecStoreId}','{order.RecName}'," +
                    $"'{order.RecAddressCode}','{order.RecStreetAddress}','{order.RecPhoneNo}','{order.SubTotalDecimal.ToString("F2")}','{order.Disc}','{order.DeliveryCost}'," +
                    $"'{order.CourierCode}','{order.DeliveryReceiptNo}','{order.ItemList}','{order.OrderCode}'",
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

        public async Task<string> SetStatusOrder(string orderId, string personid, string action)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_SetOrderStatus '{orderId}','{personid}','{action}'",
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
        public async Task<string> GetFileReport(string orderId, string doctype, string filetype)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_GetFile '{orderId}','{doctype}','{filetype}'",
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
        public async Task<string> GetOrderHistory(string personId, string period, string StatusCode, string key)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_GetOrderStatusFiltered '{personId}','{period}','{StatusCode}','{key}'",
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
