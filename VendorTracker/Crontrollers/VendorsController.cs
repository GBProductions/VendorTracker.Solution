using Microsoft.AspNetCore.Mvc;

namespace VendorTracker.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            return View();
        }
    }
}