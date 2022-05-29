using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Flyet.Models;
using Flyet.Api.Models;

namespace Flyet.Api.Controllers
{
    [Route("api/flights")]
    [ApiController]
    public class FlightsController: ControllerBase
    {
        private readonly DataContext dataContext;
        public FlightsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        [Route("AllFlights")]
        public async Task<ActionResult> GetAllFlights()
        {
            var result = await dataContext.Flights.ToListAsync();
            return Ok(result);
        }

        [HttpPost]
        [Route("AddFlight")]
        public async Task<ActionResult> PostFlight
            (
            string title,
            string airship,
            int airshipId,
            int capacity,
            int price,
            string type,
            string arrivalAirport,
            int arrivalAirportId,
            string landingPlace,
            int landingPlaceId,
            string author,
            int authorId
            )
        {
            await dataContext.AddAsync(new Flight 
            { 
                Title = title, 
                Airship = airship, 
                AirshipId = airshipId, 
                Capacity = capacity, 
                Price = price, 
                Type = type, 
                ArrivalAirport = arrivalAirport, 
                ArrivalAirportId = arrivalAirportId, 
                LandingPlace = landingPlace, 
                LandingPlaceId = landingPlaceId,
                Author = author,
                AuthorId = authorId
            });

            await dataContext.SaveChangesAsync();
            return Ok();
        }









    }
}
