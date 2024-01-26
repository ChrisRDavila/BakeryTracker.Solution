using System;
using System.Collections.Generic;

namespace BakeryTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Business { get; set; }
    public int Id { get; }
    public static List<Vendor> _instances = new List<Vendor> { };
    public Vendor(string name, string business)
    {
      Name = name;
      Business = business;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    
  }
}