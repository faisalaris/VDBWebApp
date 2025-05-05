namespace VDBWebApp.Models
{
    public class Address
    {
        public string? AddressCode { get; set; }
        public string? AlamatLengkap { get; set; }
    }

    public class AddressProvince
    {
        public string? ProvinceCode { get; set; }
        public string? ProvinceName { get; set; }
    }

    public class AddressCity
    {
        public string? CityCode { get; set; }
        public string? CityName { get; set; }
    }
    public class AddressDistrict
    {
        public string? DistrictCode { get; set; }
        public string? DistrictName { get; set; }
    }

    public class AddressVillage
    {
        public string? Seqno { get; set; }
        public string? VillageName { get; set; }
        public string? ZipCode { get; set; }
    }

    public class AddressAll
    {
        public string? SeqNo { get; set; }
        public string? ProvinceCode { get; set; }
        public string? ProvinceName { get; set; }
        public string? CityCode { get; set; }
        public string? CityName { get; set; }
        public string? DistrictCode { get; set; }
        public string? DistrictName { get; set; }
        public string? VillageCode { get; set; }
        public string? VillageName { get; set; }
        public string? ZipCode { get; set; }
    }

}
