using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lee_hankins_backend_capstone.Models;

namespace lee_hankins_backend_capstone.Tests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            Customer customers = new Customer();
            Assert.IsNotNull(customers);
        }
    }
}
