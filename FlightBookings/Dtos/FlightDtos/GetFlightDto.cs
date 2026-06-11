using System.ComponentModel.DataAnnotations;

namespace FlightBookings.Dtos.FlightDtos
{
    public class GetFlightDto
    {
        [Key]
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public string AirlineNumber { get; set; }
        public string DepartureAirportCode { get; set; }
        public string DepartureAirportName { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int DurationMinutes { get; set; }
        public int TotalSeats { get; set; }
        public int CapacitySeats { get; set; }
        public decimal BasePrice { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
    }
}
