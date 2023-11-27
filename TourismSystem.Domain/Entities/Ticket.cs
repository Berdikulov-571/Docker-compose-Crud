using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TourismSystem.Domain.Entities
{
    public class Ticket
    {
        [Key]
        [JsonIgnore]
        public int TicketId { get; set; }
        public string Where { get; set; }
        public string WhereTo { get; set; }
        public decimal Price { get; set; }
    }
}
