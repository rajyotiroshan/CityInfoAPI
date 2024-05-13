using City.Api.Controllers;
using City.Api.Model;
namespace City.Api
{
    public class CityDataStore
    {
        public List<CityDto> Cities { 
            get; set;
        }

        public static CityDataStore Current { get; } = new CityDataStore();

        public CityDataStore()
        {
            Cities = new List<CityDto>(){
                new CityDto() { Id = 1,Name="delhi", Description="chandni huouk"},
                new CityDto() { Id = 1,Name="mumbai", Description="india gate"},
                new CityDto() { Id = 1,Name="jaipur", Description="pink city" }
            };
        }
    }
}
