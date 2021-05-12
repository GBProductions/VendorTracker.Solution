using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Vendor> Vendors { get; set; }
  }
}