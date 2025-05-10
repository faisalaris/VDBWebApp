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
        public string Msrp { get; set; }
        public string Remark { get; set; }
        public string Item_Category_Name { get; set; }
        public string Thumbnail { get; set; }
        public string Brand_Name { get; set; }
        public string Stock { get; set; }
        public string Qty { get; set; }
    }
}
