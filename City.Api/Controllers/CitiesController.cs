using Microsoft.AspNetCore.Mvc;
using City.Api.Model;
namespace City.Api.Controllers
{
   
    [ApiController] //2. returning certain types of routig, aoutamicaaly returning bad inputs,returning prob details on headers
    [Route("api/cities")]
    //[Route("api/[controller]")]
    public class CitiesController:ControllerBase //1. access to model state. current user, returning responses
    {
        //controller: returning views, not needed for aPI
        //3. declare a method hat return data
        //[HttpGet("api/cities")]
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            // var temp = new JsonResult(CityDataStore.Current.Cities);
            //temp.StatusCode = 200;

            //return temp;

            return Ok(CityDataStore.Current.Cities);
        }
        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            var cityToReturn = CityDataStore.Current.Cities.FirstOrDefault(c=> c.Id == id);
            if(cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);
        }

    }
}
