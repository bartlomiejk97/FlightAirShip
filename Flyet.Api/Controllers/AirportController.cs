using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Flyet.Models;
using Flyet.Api.Models;

namespace Flyet.Api.Controllers
{
    [Route("api/airports")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly DataContext dataContext;
        public AirportController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        [Route("AllAirports")]
        public async Task<ActionResult> GetAllAirports()
        {
            var result = await dataContext.Airports.ToListAsync();
            return Ok(result);
        }

        [HttpPost]
        [Route("AddAirport")]
        public async Task<ActionResult> AddAirport(string name, string country)
        {
            await dataContext.AddAsync(new Airport
            {
                Name = name,
                Country = country
            });
            await dataContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteAirport")]
        public async Task<ActionResult> DeleteAirport(int id)
        {
            dataContext.Airports.Remove(dataContext.Airports.Find(id));
            await dataContext.SaveChangesAsync();
            return Ok();
        }


        //To Do, Updating
    }
}
