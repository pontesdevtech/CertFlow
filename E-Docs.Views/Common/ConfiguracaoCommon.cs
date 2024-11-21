using Microsoft.Extensions.Configuration;

namespace E_Docs.Views.Common;
public class ConfiguracaoCommon
{
    public static IConfiguration LoadConfiguration()
    {
        // Configurar o carregamento do arquivo appsettings.json
        return new ConfigurationBuilder()
       .SetBasePath(Directory.GetCurrentDirectory())
       .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
       .Build();
    }
}
