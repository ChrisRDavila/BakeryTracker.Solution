using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System;
using System.Collections.Generic;


namespace BakeryTracker.Tests
{
  [TestClass]
  public class OrderTests

  {
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("title", "description", 5.00M, new DateTime(2021, 1, 1));
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      //Arrange
      string title = "Bread";
      Order newOrder = new Order(title, "description", 5.00M, new DateTime(2021, 1, 1));
      //Act
      string result = newOrder.Title;
      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "Bread";
      Order newOrder = new Order(title, "description", 5.00M, new DateTime(2021, 1, 1));
      //Act
      string updatedTitle = "Pastry";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      //Assert
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      //Arrange
      string title = "Bread";
      string description = "Whole Wheat";
      Order newOrder = new Order(title, description, 5.00M, new DateTime(2021, 1, 1));
      //Act
      string result = newOrder.Description;
      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string title = "Bread";
      string description = "Whole Wheat";
      Order newOrder = new Order(title, description, 5.00M, new DateTime(2021, 1, 1));
      //Act
      string updatedDescription = "White";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsOrderPrice_Decimal()
    {
      //Arrange
      string title = "Bread";
      string description = "Whole Wheat";
      decimal price = 5.00M;
      Order newOrder = new Order(title, description, price, new DateTime(2021, 1, 1));
      //Act
      decimal result = newOrder.Price;
      //Assert
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Decimal()
    {
      //Arrange
      string title = "Bread";
      string description = "Whole Wheat";
      decimal price = 5.00M;
      Order newOrder = new Order(title, description, price, new DateTime(2021, 1, 1));
      //Act
      decimal updatedPrice = 6.00M;
      newOrder.Price = updatedPrice;
      decimal result = newOrder.Price;
      //Assert
      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetDate_ReturnsOrderDate_DateTime()
    {
      //Arrange
      string title = "Bread";
      string description = "Whole Wheat";
      decimal price = 5.00M;
      DateTime date = new DateTime(2021, 1, 1);
      Order newOrder = new Order(title, description, price, date);
      //Act
      DateTime result = newOrder.Date;
      //Assert
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetDate_SetDate_DateTime()
    {
      //Arrange
      string title = "Bread";
      string description = "Whole Wheat";
      decimal price = 5.00M;
      DateTime date = new DateTime(2021, 1, 1);
      Order newOrder = new Order(title, description, price, date);
      //Act
      DateTime updatedDate = new DateTime(2021, 1, 2);
      newOrder.Date = updatedDate;
      DateTime result = newOrder.Date;
      //Assert
      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };
      // Act
      List<Order> result = Order.GetAll();
      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}    