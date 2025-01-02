using System.Text.Json.Serialization;

namespace WebApiCar.Model
{
    public class CarOptions
    {

        public int CarOptionsId { get; set; }
        public required string OptionName { get; set; }

        public string? OptionDescription { get; set; }

        [JsonIgnore]
        public List<Car>? Cars { get; set; }
    }
}
