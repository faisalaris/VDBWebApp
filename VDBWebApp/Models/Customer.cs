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
        public string? CustCategoryName { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? StoreName { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? CreditLimit { get; set; }
        public string? UserId { get; set; }
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
        public string? PaymentNoteCode { get; set; }
        public string? PaymentNoteName { get; set; }
        public string? ForeignCode { get; set; }

        [JsonIgnore]
        public DateTime? startHighlightDate
        {
            get => DateTime.TryParse(ExpireDate, out var result) ? result : null;
            set => ExpireDate = value?.ToString("yyyy-MM-dd");
        }
    }

    public class CustomerSet 
    {
        public string? PersonId { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? PersonName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }
        public string? PhoneNo { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? PersonCategory { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? CustCategoryCode { get; set; }
        public string? PaymentNoteCode { get; set; }
        public string? CreditLimit { get; set; }
        public string? ForeignCode { get; set; }

    }
    public class CustomerStore
    {
        public string? StoreId { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? StoreName { get; set; }
        public string? IsDefault { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? CreditLimit { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? AddressCode { get; set; }
        public string? StreetAddress { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string? PhoneNo { get; set; }
        public string? IsActive { get; set; }
    }

}
