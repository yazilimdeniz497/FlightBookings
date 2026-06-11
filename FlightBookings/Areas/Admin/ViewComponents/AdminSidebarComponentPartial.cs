using Microsoft.AspNetCore.Mvc;

namespace FlightBookings.Areas.Admin.ViewComponents
{
    public class AdminSidebarComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
