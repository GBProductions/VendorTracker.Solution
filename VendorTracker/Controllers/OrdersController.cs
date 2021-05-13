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
        Order myOrder = new Order(orderName);
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
  }
}