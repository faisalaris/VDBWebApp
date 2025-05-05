using System.Net.Http;
using System.Text;
using VDBWebApp.Models;

namespace VDBWebApp.Services
{
    public class CustomerServices
    {
        private readonly HttpClient _httpClient;

        public CustomerServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetCustomers(string query)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_GetCustomer '%{query}%'",
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

        public async Task<string> GetProvince(string query)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_GetAddressProvince '%{query}%'",
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

        public async Task<string> GetCity(string provinceCode ,string query)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_GetAddressCity '{provinceCode}','%{query}%'",
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

        public async Task<string> GetDistrict(string cityCode, string query)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_GetAddressDistrict '{cityCode}','%{query}%'",
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

        public async Task<string> GetVillage(string districtCode, string query)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_GetAddressVillage '{districtCode}','%{query}%'",
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

        public async Task<string> GetAddressAll(string addresscode)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_GetZIPAddress '{addresscode}'",
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
        public async Task<string> SaveCustomer(Customer customer)
        {
            string pPersonName = customer.PersonName;
            string pGender = customer.Gender;
            string pEmail = customer.Email;
            string pPhoneNo = customer.PhoneNo;
            string pPersonCategory = customer.PersonCategory;
            string pCustCategoryCode = customer.CustCategoryCode;
            string pStoreName = customer.StoreName;
            string pCreditLimit = customer.CreditLimit.ToString();
            string pAddressCode = customer.AddressCode;
            string pStreetAddress = customer.StreetAddress;
            string pStorePhoneNo = customer.StorePhoneNo;
            string pUserName = customer.UserName;
            string pUserPwd = customer.UserPwd;
            string pPaymentNote = customer.PaymentNote;
            string pPaymentNoteName = customer.PaymentNoteName;
            string pForeignCode = customer.ForeignCode;
            string pExpireDate = customer.ExpireDate;

            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_SetNewCustomer '{pPersonName}','{pGender}','{pEmail}','{pPhoneNo}','{pPersonCategory}','{pCustCategoryCode}'," +
                    $"'{pStoreName}','{pCreditLimit}','{pAddressCode}','{pStreetAddress}','{pStorePhoneNo}','{pUserName}','{pUserPwd}'," +
                    $"'{pExpireDate}','{pPaymentNote}','{pForeignCode}'",
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
