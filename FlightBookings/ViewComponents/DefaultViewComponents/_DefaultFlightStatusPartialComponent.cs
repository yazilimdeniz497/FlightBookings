using Microsoft.AspNetCore.Mvc;

namespace FlightBookings.ViewComponents.DefaultViewComponents
{
    public class _DefaultFlightStatusPartialComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
