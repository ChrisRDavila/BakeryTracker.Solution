using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;


namespace BakeryTracker.Tests
{
  [TestClass]
  public class OrderTests

  {
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("title", "description");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      //Arrange
      string title = "Bread";
      Order newOrder = new Order(title, "description");
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
      Order newOrder = new Order(title, "description");
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
      Order newOrder = new Order(title, description);
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
      Order newOrder = new Order(title, description);
      //Act
      string updatedDescription = "White";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsOrderPrice_Int()
    {
      //Arrange
      string title = "Bread";
      string description = "Whole Wheat";
      int price = 5;
      Order newOrder = new Order(title, description, price);
      //Act
      int result = newOrder.Price;
      //Assert
      Assert.AreEqual(price, result);
    }
  }
}    