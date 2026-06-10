using Microsoft.AspNetCore.Mvc;

namespace FlightBookings.ViewComponents.DefaultViewComponents
{
    public class _DefaultNavbarPartialComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
