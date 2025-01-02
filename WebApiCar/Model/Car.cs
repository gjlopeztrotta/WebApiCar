using System.Text.Json.Serialization;

namespace WebApiCar.Model
{
    public class Car
    {
        public int carId { get; set; }
        public required string familia { get; set; }
        public required string modelo { get; set; }

        public int CarPriceId {  get; set; }
        public CarPrice carPrice { get; set; }

        public required string decripcion {  get; set; }
        
        public List<CarAccesories>? Accesories { get; set; }
       
        public List<CarOptions>? Options { get; set; }



            
    }
}
