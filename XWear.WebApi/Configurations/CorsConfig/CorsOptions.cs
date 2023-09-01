namespace XWear.WebApi.Configurations.CorsConfig
{
    public class CorsOptions
    {
        public List<string> AllowedHosts { get; set; } = new();

        public List<string> AllowedHeaders { get; set; } = new();
    }
}
