using Microsoft.AspNetCore.Mvc;

namespace FlightBookings.ViewComponents.DefaultViewComponents
{
    public class _DefaultDestinitionOfferComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
