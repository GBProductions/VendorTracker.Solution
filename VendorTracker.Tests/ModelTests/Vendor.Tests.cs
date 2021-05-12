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
    }
}