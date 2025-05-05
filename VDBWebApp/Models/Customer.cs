using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VDBWebApp.Models
{
    public class Customer
    {
        public string? PersonId { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? PersonName { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? Gender { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }
        public string? PhoneNo { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? PersonCategory { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? CustCategoryCode { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? StoreName { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public decimal CreditLimit { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? AddressCode { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? StreetAddress { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? StorePhoneNo { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? UserPwd { get; set; }
        public string ? ExpireDate { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? PaymentNote { get; set; }
        public string? PaymentNoteName { get; set; }
        public string? ForeignCode { get; set; }
        [JsonIgnore]
        public DateTime? startHighlightDate
        {
            get => DateTime.TryParse(ExpireDate, out var result) ? result : null;
            set => ExpireDate = value?.ToString("yyyy-MM-dd");
        }
    }

}
