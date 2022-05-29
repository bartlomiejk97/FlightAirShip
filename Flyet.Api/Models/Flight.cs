using Flyet.Api.Models;

namespace Flyet.Models
{
    public record Flight
    {
        public int Id { get;  init; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string LandingPlace { get; set; }
        public int LandingPlaceId { get; set; }
        public string ArrivalAirport { get; set; }
        public int ArrivalAirportId { get; set; }
        public decimal Price { get; set; }
        public string Airship { get; set; }
        public int AirshipId { get; set; }
        public int Capacity { get; set; }
        public int AuthorId { get; set; }
        public string Author { get; set; }
    }
}
