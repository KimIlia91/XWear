namespace XWear.WebApi.Common.Constants
{
    public static class DomainApiConstants
    {
        public static string TitleApi = "XWear API";
        public static string Version = "v1";
        public static string AuthScheme = "Bearer";
        public static string AuthNameHeader = "Authorization";
        public static string AuthDescription = "Авторизация JWT с использованием схемы Bearer Token.\r\n" +
                        "Введите «Bearer», а затем через пробел свой токен в текстовом поле ниже.\r\n" +
                        "\"Пример: \"Bearer {Ваш_Токен}\".\r\n" +
                        "Пример ввода токена в HTTP запрос \"Authorization: Bearer {Ваш_Токен}\"\r\n" +
                        "Токен указывается в \"Header\" HTTP запроса.";

        public static string Cors = "CORS";
        public static string ResourcesPath = "Resources";
        public static string CorsPolicyName = "CorsPolicy";
    }
}
