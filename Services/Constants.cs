using Microsoft.Extensions.Configuration;

namespace EviggroenV2.Services
{
    public interface IConstants
    {
        string Author { get; set; }
    }

    public class Constants : IConstants
    {
        public Constants(IConfiguration configuration)
        {

            Author = configuration["Author"];
        }

        public string Author { get; set; }



    }
}