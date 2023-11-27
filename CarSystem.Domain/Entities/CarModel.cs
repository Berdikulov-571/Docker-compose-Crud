using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CarSystem.Domain.Entities
{
    public class CarModel
    {
        [Key]
        [JsonIgnore]
        public int CartId { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }
}