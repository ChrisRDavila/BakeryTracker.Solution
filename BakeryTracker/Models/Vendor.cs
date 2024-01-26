using System;
using System.Collections.Generic;

namespace BakeryTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Business { get; set; }
    public Vendor(string name, string business)
    {
      Name = name;
      Business = business;
      _instances.Add(this);
    }
    
  }
}