using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult CreateForm()
    {
        return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
        Vendor myVendor = new Vendor(name, description);
        return RedirectToAction("Index");
    }
  }
}