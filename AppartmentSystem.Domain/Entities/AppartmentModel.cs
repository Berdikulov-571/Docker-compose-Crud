using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AppartmentSystem.Domain.Entities
{
    public class AppartmentModel
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public int Number { get; set; } = default!;
        public int Floor { get; set; } = default!;
        public int Room { get; set; } = default!;
        public string Location { get; set; } = default!;
    }
}