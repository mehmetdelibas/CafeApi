using Microsoft.AspNetCore.Mvc;

namespace CafeApi.WebUI.ViewCompenents
{
    public class HeadDefaultCompenentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
}
