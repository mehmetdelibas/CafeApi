using Microsoft.AspNetCore.Mvc;

namespace CafeApi.WebUI.ViewCompenents
{
    public class ServicesDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
