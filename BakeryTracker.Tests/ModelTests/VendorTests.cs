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
      Vendor newVendor = new Vendor("name");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsVendorName_String()
    {
      //Arrange
      string name = "Bread";
      Vendor newVendor = new Vendor(name);
      //Act
      string result = newVendor.Name;
      //Assert
      Assert.AreEqual(name, result);
    }

    public void SetName_SetName_String()
    {
      //Arrange
      string name = "Bread";
      Vendor newVendor = new Vendor(name);
      //Act
      string updatedName = "Pastry";
      newVendor.Name = updatedName;
      string result = newVendor.Name;
      //Assert
      Assert.AreEqual(updatedName, result);
    }
  } 
}