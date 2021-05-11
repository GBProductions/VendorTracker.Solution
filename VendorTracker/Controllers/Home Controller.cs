using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
        Vendor starterVendor = new Vendor("Vendor", "Add first vendor to Vendor Tracker.");
        return View(starterVendor);
    }
  }
}