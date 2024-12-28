namespace WebApiCar.Model
{
    public class CarPrice
    {
        public int CarPriceId { get; set; }

        public double Totalprice { get; set; }
        public double IVA { get; set; }
        public double IGIC { get; set; }
        public double Listprice { get; set; }

        public required int carId { get; set; }


    }
}
