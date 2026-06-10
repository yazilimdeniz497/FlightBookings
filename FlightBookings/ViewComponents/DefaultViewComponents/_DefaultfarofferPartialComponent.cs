using Microsoft.AspNetCore.Mvc;

namespace FlightBookings.ViewComponents.DefaultViewComponents
{
    public class _DefaultfarofferPartialComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
