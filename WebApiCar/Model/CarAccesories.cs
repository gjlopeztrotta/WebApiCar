using System.Text.Json.Serialization;

namespace WebApiCar.Model
{
    public class CarAccesories
    {
        public int CarAccesoriesId { get; set; }
        public required string AccesoryName { get; set; }

        public string? AccesoryDescription { get; set; }

        [JsonIgnore]
        public List<Car>?  Cars {  get; set; }

        public int? CarAccesoriesPricesId { get; set; }
        public CarAccesoriesPrices? carAccesoriesPrices { get; set; }
    }
}
