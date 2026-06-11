using Microsoft.AspNetCore.Mvc;

namespace FlightBookings.Areas.Admin.ViewComponents
{
    public class AdminTopbarComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
