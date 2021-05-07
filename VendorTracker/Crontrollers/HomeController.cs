using Microsoft.AspNetCore.Mvc;

namespace VendorTracker.Controllers
{
    public class HomeController : Controllers
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}