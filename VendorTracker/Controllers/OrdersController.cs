using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("/orders/new")]
    public ActionResult New()
    {
        return View();
    }

    [HttpPost("/orders")]
    public ActionResult Create(string orderName)
    {
        Order newOrder = new Order(orderName);
        return RedirectToAction("Index");
    }

    [HttpGet("/orders/{id}")]
    public ActionResult Show(int id)
    {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Order selectedOrder = Order.Find(id);
        List<Vendor> orderVendors = selectedOrder.Vendors;
        model.Add("order", selectedOrder);
        model.Add("vendors", orderVendors);
        return View(model);
    }


    //This one creates new Vendors within a given Order, not new Orders:

    [HttpPost("/orders/{orderId}vendors")]
    public ActionResult Create(int orderId, string name, string description)
    {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Order foundOrder = Order.Find(orderId);
        Vendor newVendor = new Vendor(name, description);
        foundOrder.AddVendor(newVendor);
        List<Vendor> orderVendors = foundOrder.Vendors;
        model.Add("vendors", orderVendors);
        model.Add("order", foundOrder);
        return View("Show", model);
    }
  }
}