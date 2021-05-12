using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("test category");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            //Arrange
            string name = "Test Order";
            Order newOrder = new Order(name);

            //Act
            string result = newOrder.Name;

            //Assert
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void GetId_ReturnsOrderId_Int()
        {
            //Arrange
            string name = "Test Order";
            Order newOrder = new Order(name);

            //Act
            int result = newOrder.Id;

            //Assert
            Assert.AreEqual(1, result);
        }

    }
}