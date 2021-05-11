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

    [Route("/vendors/new")]
    public ActionResult CreateForm()
    {
        return View();
    }

    [Route("/vendors")]
    public ActionResult Create(string name, string description)
    {
        Vendor myVendor = new Vendor(name, description);
        return View("Index", myVendor);
    }
  }
}