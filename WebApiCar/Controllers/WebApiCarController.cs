using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCar.Database;
using WebApiCar.Model;

namespace WebApiCar.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class WebApiCarController : Controller
    {
        private readonly WebApiCarDbContext _context ;

        public WebApiCarController(WebApiCarDbContext context)
        {  
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Car>>> GetCars()
        {
            return Ok(await _context.Cars
                .Include(g => g.carPrice )
                .Include(g => g.Accesories)
                .Include(g => g.Options)
                .ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetVideoGameById(int id)
        {
            var game = await _context.Cars
                .Include(g => g.carPrice)
                .Include(g => g.Accesories)
                .Include(g => g.Options)
               // .Include(g=> g.Accesories.ToString<CarAccesoriesPrices> )
                .FirstOrDefaultAsync(x => x.carId == id);
            //var game= await _context.VideoGames.FindAsync(id);

            if (game == null)
                return NotFound();
           
            return Ok(game);

        }


        [HttpGet("/Modelo/{modelo}")]
        public async Task<ActionResult<Car>> GetVideoGameBymodelo(string modelo)
        {
            var game = await _context.Cars
                .Include(g => g.carPrice)
                .Include(g => g.Accesories)
                .Include(g => g.Options)
                // .Include(g=> g.Accesories.ToString<CarAccesoriesPrices> )
                .FirstOrDefaultAsync(x => x.modelo == modelo);
            //var game= await _context.VideoGames.FindAsync(id);
            if (game == null)
                return NotFound();

            return Ok(game);

        }
    }
}
