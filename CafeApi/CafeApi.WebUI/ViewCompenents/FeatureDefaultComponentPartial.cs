using Microsoft.AspNetCore.Mvc;

namespace CafeApi.WebUI.ViewCompenents
{
    public class FeatureDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
