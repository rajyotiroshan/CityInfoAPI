using Microsoft.AspNetCore.Mvc;

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
        public JsonResult GetCities()
        {
           
            return new JsonResult(
                new List<object>
                {
                    new {id=1,Name="New York cities"},
                    new { id=2, Name="Antwerp"}
                }
                );
        }

    }
}
