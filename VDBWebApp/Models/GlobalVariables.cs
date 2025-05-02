namespace VDBWebApp.Models
{
    public static class GlobalVariables
    {
        public static string? userid { get; set; }
        public static string? username { get; set; }
        public static string? usertype { get; set; }
        public static string? userlevel { get; set; }
        public static int? personid { get; set; }
        public static string? category { get; set; }
        public static string? paymentnotename { get; set; }


        public static void ResetAll()
        {
            userid = null;
            username = null;
            usertype = null;
            userlevel = null;
            personid = 0;
            category= null; 
            paymentnotename = null;
            // Atur semua properti global lainnya ke nilai defaultnya di sini
        }
    }
}
