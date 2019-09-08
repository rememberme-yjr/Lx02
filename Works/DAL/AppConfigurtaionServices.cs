using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace DAL
{
    public class AppConfigurtaionServices
    {
        public static IConfiguration Configuration { get; set; }
        static AppConfigurtaionServices()
        {
            Configuration = new ConfigurationBuilder()
                .Add(new JsonConfigurationSource { Path = "appsetting.json", ReloadOnChange = true }).Build();
        }
    }

}
