using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;


namespace BakeryTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable

  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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

    [TestMethod]
    public void SetBusiness_SetBusiness_String()
    {
      //Arrange
      string name = "Jeff";
      string business = "Jeffs Cafe";
      Vendor newVendor = new Vendor(name, business);
      //Act
      string updatedBusiness = "Jeffs Bakery";
      newVendor.Business = updatedBusiness;
      string result = newVendor.Business;
      //Assert
      Assert.AreEqual(updatedBusiness, result);
    }

    [TestMethod]
    public void GetAll_GetEmptyList_VendorList()
    {
      //Arrange
      List<Vendor> newList = new List<Vendor> { };
      //Act
      List<Vendor> result = Vendor.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorList()
    {
      //Arrange
      string name01 = "Jeff";
      string name02 = "Fred";
      Vendor newVendor1 = new Vendor(name01, "business1");
      Vendor newVendor2 = new Vendor(name02, "business2");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      //Act
      List<Vendor> result = Vendor.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_VendorsInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string name = "Jeff";
      string business = "Jeffs Cafe";
      Vendor newVendor = new Vendor(name, business);
      //Act
      int result = newVendor.Id;
      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "Jeff";
      string name02 = "Fred";
      Vendor newVendor1 = new Vendor(name01, "business1");
      Vendor newVendor2 = new Vendor(name02, "business2");
      //Act
      Vendor result = Vendor.Find(2);
      //Assert
      Assert.AreEqual(newVendor2, result);
    }
  } 
}