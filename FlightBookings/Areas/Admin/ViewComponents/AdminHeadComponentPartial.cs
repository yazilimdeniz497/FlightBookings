using Microsoft.AspNetCore.Mvc;

namespace FlightBookings.Areas.Admin.ViewComponents
{
    public class AdminHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
