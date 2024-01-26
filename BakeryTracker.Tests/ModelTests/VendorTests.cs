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
      Vendor newVendor = new Vendor("name", "business");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsVendorName_String()
    {
      //Arrange
      string name = "Jeff";
      Vendor newVendor = new Vendor(name, "business");
      //Act
      string result = newVendor.Name;
      //Assert
      Assert.AreEqual(name, result);
    }

    public void SetName_SetName_String()
    {
      //Arrange
      string name = "Jeff";
      Vendor newVendor = new Vendor(name, "business");
      //Act
      string updatedName = "Fred";
      newVendor.Name = updatedName;
      string result = newVendor.Name;
      //Assert
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetBusiness_ReturnsVendorBusiness_String()
    {
      //Arrange
      string name = "Jeff";
      string business = "Jeffs Cafe";
      Vendor newVendor = new Vendor(name, business);
      //Act
      string result = newVendor.Business;
      //Assert
      Assert.AreEqual(business, result);
    }
  } 
}