using Microsoft.AspNetCore.Mvc;

namespace westcoast_cars.web.Controllers
{
  [Route("[controller]")]
    public class VehiclesController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}