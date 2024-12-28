namespace WebApiCar.Model
{
    public class CarAccesories
    {
        public int CarAccesoriesId { get; set; }
        public required string AccesoryName { get; set; }

        public string? AccesoryDescription { get; set; }


        public List<Car>?  Cars {  get; set; }
    }
}
