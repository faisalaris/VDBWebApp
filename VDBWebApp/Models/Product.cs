using System.Text.Json.Serialization;

namespace VDBWebApp.Models
{
    public class Product
    {
        public string? item_id { get; set; } = string.Empty;
        public string? item_code { get; set; } = string.Empty;// Inisialisasi untuk menghindari null warnings
        public string? item_name { get; set; } = string.Empty;
        public string? thumbnail { get; set; } = string.Empty;
        public string? item_price { get; set; } = string.Empty;
        public string? msrp { get; set; } = string.Empty;
        public string? item_stock { get; set; } = string.Empty;
        public string? isactive { get; set; } = string.Empty;
        public string? brand_name { get; set; } = string.Empty;
        public string? category_id { get; set; } = string.Empty;
        public string? category_name { get; set; } = string.Empty;
        public string? remark { get; set; } = string.Empty;
        public string? starthighlight { get; set; } = string.Empty;
        public string? endhighlight { get; set; } = string.Empty;
        public string? isWishlist { get; set; } = string.Empty;
        [JsonIgnore]
        public DateTime? startHighlightDate
        {
            get => DateTime.TryParse(starthighlight, out var result) ? result : null;
            set => starthighlight = value?.ToString("yyyy-MM-dd");
        }

        [JsonIgnore]
        public DateTime? endHighlightDate
        {
            get => DateTime.TryParse(endhighlight, out var result) ? result : null;
            set => endhighlight = value?.ToString("yyyy-MM-dd");
        }
    }

    public class HighlightProduct
    {
        public string? item_id { get; set; } = string.Empty;
        public string? item_name { get; set; } = string.Empty;
        public string? period { get; set; } = string.Empty;
        public string? thumbnail { get; set; } = string.Empty;
        public string? isshow { get; set; } = string.Empty;
    }
}
