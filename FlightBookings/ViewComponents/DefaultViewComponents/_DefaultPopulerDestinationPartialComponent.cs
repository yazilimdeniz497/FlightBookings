using Microsoft.AspNetCore.Mvc;

namespace FlightBookings.ViewComponents.DefaultViewComponents
{
    public class _DefaultPopulerDestinationPartialComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
