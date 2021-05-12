using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Vendor> Vendors { get; set; }

    public Order(string orderName)
    {
      Name = orderName;
      _instances.Add(this);
      Id = _instances.Count;
      Vendors = new List<Vendor>{};
    }

    public static void ClearAll()
    {
        _instances.Clear();
    }
    public static List<Order> GetAll()
    {
        return _instances;
    }

    public static Order Find(int searchId)
    {
        return _instances[searchId-1];
    }
  }
}