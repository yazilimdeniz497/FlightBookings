using Microsoft.AspNetCore.Mvc;

namespace FlightBookings.Areas.Admin.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult AdminLayout()
        {
            return View();
        }
    }
}
