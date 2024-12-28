using Microsoft.AspNetCore.Mvc;

namespace WebApiCar.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class WebApiCarController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
