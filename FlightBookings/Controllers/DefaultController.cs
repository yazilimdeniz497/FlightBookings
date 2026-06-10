using Microsoft.AspNetCore.Mvc;

namespace FlightBookings.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
