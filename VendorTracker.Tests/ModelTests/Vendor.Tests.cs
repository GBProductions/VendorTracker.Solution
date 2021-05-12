using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
    [TestClass]
    public class VendorTests : IDisposable 
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }

        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("test", "test");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetVendorName_ReturnsVendorName_String()
        {
            string name = "Pizza Hut";
            Vendor newVendor = new Vendor(name, "test");
            string result = newVendor.Name;
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void GetVendorDescription_ReturnsVendorDescription_String()
        {
            string description = "Sells pizzas.";
            Vendor newVendor = new Vendor("test", description);
            string result = newVendor.Description;
            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            //Arrange
            string description = "Sells pizzas.";
            Vendor newVendor = new Vendor("test", description);

            //Act
            string updatedDescription = "Sells salad.";
            newVendor.Description = updatedDescription;
            string result = newVendor.Description;

            //Assert
            Assert.AreEqual(updatedDescription, result);
        }

        [TestMethod]
        public void SetName_SetName_String()
        {
            //Arrange
            string name = "Sells pizzas.";
            Vendor newVendor = new Vendor(name, "test");

            //Act
            string updatedName = "Tender Greens";
            newVendor.Name = updatedName;
            string result = newVendor.Name;

            //Assert
            Assert.AreEqual(updatedName, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_VendorList()
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
            string description01 = "Serve Salad.";
            string description02 = "Deliver Pizza.";
            Vendor newVendor1 = new Vendor("Tender Greens", description01);
            Vendor newVendor2 = new Vendor("Pizza Hut", description02);
            List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2};

            //Act
            List<Vendor> result = Vendor.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }
        [TestMethod]
        public void GetId_VendorInstantiateWithAnIdAndGetterReturns_Int()
        {
            //Arrange
            string name = "Tender Greens";
            string description = "Serve Salad";
            Vendor newVendor = new Vendor(name, description);

            //Act
            int result = newVendor.Id;

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectVendor_Vendor()
        {
            //Arrange
            string name01 = "Tender Greens";
            string name02 = "Pizza Hut";
            string description01 = "Serve Salad.";
            string description02 = "Deliver Pizza.";
            Vendor newVendor1 = new Vendor(name01, description01);
            Vendor newVendor2 = new Vendor(name02, description02);

            //Act
            Vendor result = Vendor.Find(2);

            //Assert
            Assert.AreEqual(newVendor2, result);
        }
    }
}