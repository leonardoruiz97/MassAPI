using Microsoft.Extensions.Configuration;
namespace MassAPI.Logica
{

    
    public class GeneralLogica<T>
    {
        private IConfiguration Configuration;
        public string stringConexion { get; set; }

        public GeneralLogica()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false);
            IConfiguration configuration = builder.Build();
            stringConexion = configuration.GetValue<string>("ConnectionStrings:DefaultConnection");
            
        }
    }
}
