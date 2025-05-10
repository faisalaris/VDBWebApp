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

        public async Task<string> GetCustomersdetail(string customerid)
        {
            try
                {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_GetCustomerDetail '{customerid}'",
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

        public async Task<string> GetCustomerStore(string customerid)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_GetCustomerStoreDetail '{customerid}'",
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

        public async Task<string> GetCustomerUser(string customerid)
        {
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_GetCustomerUser '{customerid}'",
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

        public async Task<string> SetCustomersdetail(CustomerSet customer)
        {
            string pPersonId = customer.PersonId;
            string pPersonName = customer.PersonName;
            string pPhoneNo = customer.PhoneNo;
            string pPersonCategory = customer.PersonCategory;
            string pCustCategoryCode = customer.CustCategoryCode;
            string pPaymentNote = customer.PaymentNoteCode;
            string?pForeignCode = customer.ForeignCode;
            string pCreditLimit = customer.CreditLimit;
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_SetExistingCustomer '{pPersonId}','{pPersonName}','{pPhoneNo}','{pPersonCategory}','{pCustCategoryCode}'," +
                    $"'{pPaymentNote}','{pForeignCode}','{pCreditLimit}'",
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
        public async Task<string> SetEditCustomersStore(CustomerStore customerstore,string userid)
        {
            string pPersonId = userid;
            string pStoreId = customerstore.StoreId;
            string pPersonName = customerstore.StoreName;
            string pPhoneNo = customerstore.PhoneNo;
            string pAddressCode = customerstore.AddressCode;
            string pStreetAddress = customerstore.StreetAddress;
            string pIsActive = customerstore.IsActive;
            string pCreditLimit = customerstore.CreditLimit;
            
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_SetEditStore '{pPersonId}','{pStoreId}','{pPersonName}','{pPhoneNo}','{pCreditLimit}'," +
                    $"'{pAddressCode}','{pStreetAddress}','{pIsActive}'",
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
        public async Task<string> SetAddCustomersStore(CustomerStore customerstore, string userid)
        {
            string pPersonId = userid;
            string pStoreName = customerstore.StoreName;
            string pPhoneNo = customerstore.PhoneNo;
            string pAddressCode = customerstore.AddressCode;
            string pStreetAddress = customerstore.StreetAddress;
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_SetAddStore '{pPersonId}','{pStoreName}','{pAddressCode}','{pStreetAddress}','{pPhoneNo}'",
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
        public async Task<string> SetDefaultCustomerStore(string storeid, string userid)
        {
            string pPersonId = userid;
            string pStoreId = storeid;
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPW_SetUserProfileStoreDefault '{pPersonId}','{storeid}'",
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

        
            public async Task<string> SetEditCustomersUser(CustomerUser customersuser)
        {
            string pUserId = customersuser.UserId;
            string pUsrPwd = customersuser.UserPassword;
            string pStartDate = customersuser.StartDate;
            string pExpiredDate = customersuser.UserExpireDate;

            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_SetUpdateUser '{pUserId}','{pUsrPwd}','{pStartDate}','{pExpiredDate}'",
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
        public async Task<string> SetAddCustomersUser(CustomerUser customeruser,string customerid)
        {
            string pUserId = customerid;
            string pUserName = customeruser.UserId;
            string pUsrPwd = customeruser.UserPassword;
            string pStartDate = customeruser.StartDate;
            string pExpiredDate = customeruser.UserExpireDate;
            try
            {
                var url = "";
                var postData = new
                {
                    SP = $"exec SPA_SetNewUser '{pUserId}','{pUserName}','{pUsrPwd}','{pExpiredDate}'",
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
            string pCreditLimit = customer.CreditLimit;
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
