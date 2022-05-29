using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Flyet.Models;
using Flyet.Api.Models;

namespace Flyet.Api.Controllers
{
    [Route("api/airships")]
    [ApiController]
    public class AirshipController : ControllerBase
    {
        private readonly DataContext dataContext;
        public AirshipController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        [Route("AllAirships")]
        public async Task<ActionResult> GetAllAirships()
        {
            var result = await dataContext.Airships.ToListAsync();
            return Ok(result);
        }

        [HttpPost]
        [Route("AddAirship")]
        public async Task<ActionResult> AddAirship(string name)
        {
            await dataContext.AddAsync(new Airship
            {
                Name = name,
            });
            await dataContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteAirship")]
        public async Task<ActionResult> DeleteAirship(int id)
        {
            dataContext.Airships.Remove(dataContext.Airships.Find(id));
            await dataContext.SaveChangesAsync();
            return Ok();
        }

        //To Do, Updating
    }
}
