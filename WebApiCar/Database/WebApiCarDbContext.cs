using Microsoft.EntityFrameworkCore;
using WebApiCar.Model;

namespace WebApiCar.Database
{
    public class WebApiCarDbContext:DbContext
    {

        public DbSet<Car> Cars => Set<Car>();
        public DbSet<CarPrice> CarsPrices => Set<CarPrice>();

        public WebApiCarDbContext(DbContextOptions<WebApiCarDbContext> options) : base(options) 
        {
        }


    }
}
