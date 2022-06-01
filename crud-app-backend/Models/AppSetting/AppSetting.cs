namespace crud_app_backend.Model
{
    public class ConnectionStr {
        public static string databaseConnection {get; set; }

    }
    public class JWTSetting {
        public string jwtSecret { get; set; }
        public string clientUrl { get; set; }
    }
}