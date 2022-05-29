using Flyet.Api.Models;

namespace Flyet.Models
{
    public record FlightTest
    {
        public int Id { get;  init; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string LandingPlace { get; set; }
        public string ArrivalAirport { get; set; }
        public decimal Price { get; set; }
        public int Airship { get; set; }
        public int Capacity { get; set; }
    }
}
