using System.Text.Json.Serialization;

namespace VDBWebApp.Models
{
    public class OrderCustomer
    {
        public string? PersonId { get; set; }
        public string? PersonName { get; set; }
        public string? PersonCategory { get; set; }
        public string? PaymentNote { get; set; }
        public string? CustCategoryCode { get; set; }
        public string? ForeignCode { get; set; }
    }

    public class OrderListCustomers
    {
        public string Item_Id { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Price { get; set; }
        public string ItemDisc { get; set; }
        public string SubTotal { get; set; }
        public string Msrp { get; set; }
        public string Remark { get; set; }
        public string Item_Category_Name { get; set; }
        public string Thumbnail { get; set; }
        public string Brand_Name { get; set; }
        public string Stock { get; set; }
        public string Qty { get; set; }
        public string IsWishlist { get; set; }
        public string ItemAvailability { get; set; }
        [JsonIgnore]
        public decimal DiscAmount
        {
            get => decimal.TryParse(ItemDisc, out var value) ? value : 0;
            set => ItemDisc = value.ToString("F2");
        }
        [JsonIgnore]
        public decimal SubTotalAmount
        {
            get => decimal.TryParse(SubTotal, out var value) ? value : 0;
            set => SubTotal = value.ToString("F2");
        }
        [JsonIgnore]
        public int QtyNum
        {
            get => int.TryParse(Qty, out var value) ? value : 0;
            set => Qty = value.ToString();
        }
        [JsonIgnore]
        public int PriceNum
        {
            get => int.TryParse(Price, out var value) ? value : 0;
            set => Price = value.ToString("F2");
        }
    }

    
public class Order
    {
        public string UserId { get; set; }
        public string PersonId { get; set; }
        public string Remark { get; set; }
        public string SenderStoreId { get; set; }
        public string SenderName { get; set; }
        public string SenderAddressCode { get; set; }
        public string SenderStreetAddress { get; set; }
        public string SenderPhoneNo { get; set; }
        public string RecStoreId { get; set; }
        public string RecName { get; set; }
        public string RecAddressCode { get; set; }
        public string RecStreetAddress { get; set; }
        public string RecPhoneNo { get; set; }
        public string SubTotal { get; set; }
        public string Disc { get; set; }
        public string DeliveryCost { get; set; }
        public string CourierCode { get; set; }
        public string DeliveryReceiptNo { get; set; }
        public string ItemList { get; set; }
        public string OrderCode { get; set; }
        public string TotalQty { get; set; }
        public string PersonName { get; set; }
        public string CreatedBy { get; set; }
        public string PersonCategory { get; set; }
        public string CustCategoryCode { get; set; }
        public string OrderDate { get; set; }
        public string CourierName { get; set; }
        public string PaymentNoteName { get; set; }

        // Decimal helper properties for UI use only
        [JsonIgnore]
        public decimal SubTotalDecimal
        {
            get => decimal.TryParse(SubTotal, out var value) ? value : 0;
            set => SubTotal = value.ToString("F2");
        }

        [JsonIgnore]
        public decimal DiscDecimal
        {
            get => decimal.TryParse(Disc, out var value) ? value : 0;
            set => Disc = value.ToString("F2");
        }

        [JsonIgnore]
        public decimal DeliveryCostDecimal
        {
            get => decimal.TryParse(DeliveryCost, out var value) ? value : 0;
            set => DeliveryCost = value.ToString("F2");
        }
    }

}
