using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/orders/{orderId}/vendors/new")]
    public ActionResult New(int orderId)
    {
      Order order = Order.Find(orderId);
      return View(order);
    }
    
    [HttpPost("/vendors/delete")]
    public ActionResult DeleteAll()
    {
        Vendor.ClearAll();
        return View();
    }

    [HttpGet("/orders/{orderId}/vendors/{vendorId}")]
    public ActionResult Show(int orderId, int vendorId)
    {
        Vendor vendor = Vendor.Find(vendorId);
        Order order = Order.Find(orderId);
        Dictionary<string, object> model = new Dictionary<string, object>();
        model.Add("vendor", vendor);
        model.Add("order", order);
        return View(model);
    }
  }
}