using Microsoft.AspNetCore.Mvc;

namespace CafeApi.WebUI.ViewCompenents
{
    public class AboutDefaultBoardComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
