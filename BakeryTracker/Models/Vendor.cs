using System;

namespace BakeryTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Business { get; }
    public Vendor(string name, string business)
    {
      Name = name;
      Business = business;
    }
    
  }
}