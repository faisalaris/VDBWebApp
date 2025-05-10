using System.Text.Json.Serialization;

namespace VDBWebApp.Models
{
    public class Genset
    {
        public string? GCode { get; set; }
        public string? Gname { get; set; }

        public string? Gimage { get; set; }

        public string? Isactive { get; set; }

        public string? Thumbnail { get; set; }

        [JsonIgnore]
        public string? GimageType { get; set; } = "image/png";

        // Untuk ditampilkan di <img>
    }

    public class GensetBanner
    {
        public string ? BannerSeqno { get; set; }

        // Untuk tipe image dari SQL Server
        public string BannerImage { get; set; }

        public byte[] GimageByte { get; set; }

        // Jika ingin ditampilkan sebagai base64 di UI
        public string Base64ImageSrc
        {
            get
            {
                if (BannerImage == null || BannerImage.Length == 0)
                    return "images/VDBDefault.jpg"; // fallback image lokal

                var mime = GetMimeType(ConvertHexToBytes(BannerImage));
                var base64 = Convert.ToBase64String(ConvertHexToBytes(BannerImage));
                return $"data:{mime};base64,{base64}";
            }
        }

        private static string GetMimeType(byte[] fileBytes)
        {
            if (fileBytes.Length < 4)
                return "application/octet-stream";

            return fileBytes switch
            {
                var b when b[0] == 0x89 && b[1] == 0x50 && b[2] == 0x4E && b[3] == 0x47 => "image/png",
                var b when b[0] == 0xFF && b[1] == 0xD8 => "image/jpeg",
                var b when b[0] == 0x47 && b[1] == 0x49 && b[2] == 0x46 && b[3] == 0x38 => "image/gif",
                var b when b[0] == 0x42 && b[1] == 0x4D => "image/bmp",
                _ => "application/octet-stream"
            };
        }

        public static byte[] ConvertHexToBytes(string hex)
        {
            if (string.IsNullOrWhiteSpace(hex))
                return Array.Empty<byte>();

            if (hex.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                hex = hex.Substring(2); // Hilangkan "0x"

            // Validasi panjang genap
            if (hex.Length % 2 != 0)
                throw new FormatException("Hex string must have even length.");

            byte[] bytes = new byte[hex.Length / 2];

            for (int i = 0; i < hex.Length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }

            return bytes;
        }
    }
}
