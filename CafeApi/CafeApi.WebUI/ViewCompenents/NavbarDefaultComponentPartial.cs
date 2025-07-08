using Microsoft.AspNetCore.Mvc;

namespace CafeApi.WebUI.ViewCompenents
{
    public class NavbarDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
