using Microsoft.AspNetCore.Mvc;

namespace CafeApi.WebUI.Controllers
{
    public class DefultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
