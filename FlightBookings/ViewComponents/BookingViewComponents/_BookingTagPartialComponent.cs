using Microsoft.AspNetCore.Mvc;

namespace FlightBookings.ViewComponents.BookingViewComponents
{
    public class _BookingTagPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
