namespace WebApiCar.Model
{
    public class CarOptions
    {

        public int CarOptionsId { get; set; }
        public required string OptionName { get; set; }

        public string? OptionDescription { get; set; }


        public List<Car>? Cars { get; set; }
    }
}
