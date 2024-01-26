using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;


namespace BakeryTracker.Tests
{
  [TestClass]
  public class VendorTests

  {
    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}