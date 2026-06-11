using System.ComponentModel.DataAnnotations;

namespace FlightBookings.Entities
{
    public class Flights
    {
        [Key]
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public string AirlineNumber { get; set; }
    }
}
