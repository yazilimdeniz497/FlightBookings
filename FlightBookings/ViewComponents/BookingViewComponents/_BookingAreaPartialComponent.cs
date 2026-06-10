using Microsoft.AspNetCore.Mvc;

namespace FlightBookings.ViewComponents.BookingViewComponents
{
    public class _BookingAreaPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
