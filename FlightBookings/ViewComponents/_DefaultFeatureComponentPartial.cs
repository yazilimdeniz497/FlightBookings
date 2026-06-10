using Microsoft.AspNetCore.Mvc;

namespace FlightBookings.ViewComponents
{
    public class _DefaultFeatureComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
