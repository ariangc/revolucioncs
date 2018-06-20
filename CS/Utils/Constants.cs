namespace Utils {
    public class Constants {
        public static string connectionString = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g3;" + "database=inf282g3;" + "port=3306;password=H9u1oC;SslMode=none;" + "";
        public static string CurrentUserText { get; set; }
        public static string CurrentUserName { get; set; }
        public static string CurrentPassword { get; set; }
        public static int CurrentUserID { get; set; }

        public static string DniRegex = @"^\d{8}";
        public static string NameRegex = @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$";
        public static string SurnameRegex = @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$";
        public static string PlaceRegex = @"^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$";
        public static string PhoneRegex = @"^([2-9])(\d{2})(-?|\040?)(\d{4})( ?|\040?)(\d{1,4}?|\040?)$";
        public static string EmailRegex = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,6}";
        public static string RucRegex = @"^\d{11}$";
        public static string CompanyNameRegex = @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$";
        public static string IntegerRegex = @"^\d{1,9}";
        public static string CompanyRegex = @"^[.@&]?[a-zA-Z0-9 ]+[ !.@&()]?[ a-zA-Z0-9!()]+";
    }
}
