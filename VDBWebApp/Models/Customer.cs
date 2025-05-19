using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VDBWebApp.Models
{
    public class Customer
    {
        public string? PersonId { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field Customer Name")]
        public string? PersonName { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field Gender")]
        public string? Gender { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }
        public string? PhoneNo { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field Category")]
        public string? PersonCategory { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field Customer Level")]
        public string? CustCategoryCode { get; set; }
        public string? CustCategoryName { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field Store Name")]
        public string? StoreName { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field Credit limit")]
        public string? CreditLimit { get; set; }
        public string? UserId { get; set; }
        public string? AddressCode { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field Street Address")]
        public string? StreetAddress { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field Store Phone Number")]
        public string? StorePhoneNo { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field User Name")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field Password")]
        public string? UserPwd { get; set; }
        public string ? ExpireDate { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please fill Mandatory Field Payment Note")]
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

    public class CustomerUser
    {
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string UserId { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string UserPassword { get; set; }
        public string RangePeriod { get; set; } 
        public string UserExpireDate { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string StartDate { get; set; }

        [JsonIgnore]
        public DateTime? StartDate_DateType
        {
            get => DateTime.TryParse(StartDate, out var result) ? result : null;
            set => StartDate = value?.ToString("yyyy-MM-dd");
        }
        [JsonIgnore]
        public DateTime? UserExpireDate_DateType
        {
            get => DateTime.TryParse(UserExpireDate, out var result) ? result : null;
            set => UserExpireDate = value?.ToString("yyyy-MM-dd");
        }

    }

    public class CustomerUserPassword
    {
        public string UserId { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Please fill Mandatory Field")]
        public string ConfirmPassword { get; set; }
    }

    public class CustomerUserProfile
    {
        public string PersonName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string CustCategory { get; set; }
        public string StartDate { get; set; }
    }
}
