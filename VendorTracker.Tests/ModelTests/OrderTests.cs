using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
    [TestClass]
    public class OrderTests : IDisposable 
    {
        public void Dispose()
        {
            Order.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("test", "test");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetOrderName_ReturnsOrderName_String()
        {
            string name = "Pizza Hut";
            Order newOrder = new Order(name, "test");
            string result = newOrder.Name;
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void GetOrderDescription_ReturnsOrderDescription_String()
        {
            string description = "Sells pizzas.";
            Order newOrder = new Order("test", description);
            string result = newOrder.Description;
            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            //Arrange
            string description = "Sells pizzas.";
            Order newOrder = new Order("test", description);

            //Act
            string updatedDescription = "Sells salad.";
            newOrder.Description = updatedDescription;
            string result = newOrder.Description;

            //Assert
            Assert.AreEqual(updatedDescription, result);
        }

        [TestMethod]
        public void SetName_SetName_String()
        {
            //Arrange
            string name = "Sells pizzas.";
            Order newOrder = new Order(name, "test");

            //Act
            string updatedName = "Tender Greens";
            newOrder.Name = updatedName;
            string result = newOrder.Name;

            //Assert
            Assert.AreEqual(updatedName, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_OrderList()
        {
            //Arrange
            List<Order> newList = new List<Order> { };

            //Act
            List<Order> result = Order.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsOrders_OrderList()
        {
            //Arrange
            string description01 = "Serve Salad.";
            string description02 = "Deliver Pizza.";
            Order newOrder1 = new Order("Tender Greens", description01);
            Order newOrder2 = new Order("Pizza Hut", description02);
            List<Order> newList = new List<Order> { newOrder1, newOrder2};

            //Act
            List<Order> result = Order.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }
        
        [TestMethod]
        public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
        {
            //Arrange
            string name = "Tender Greens";
            string description = "Serve Salad";
            Order newOrder = new Order(name, description);

            //Act
            int result = newOrder.Id;

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectOrder_Order()
        {
            //Arrange
            string name01 = "Tender Greens";
            string name02 = "Pizza Hut";
            string description01 = "Serve Salad.";
            string description02 = "Deliver Pizza.";
            Order newOrder1 = new Order(name01, description01);
            Order newOrder2 = new Order(name02, description02);

            //Act
            Order result = Order.Find(2);

            //Assert
            Assert.AreEqual(newOrder2, result);
        }
    }
}