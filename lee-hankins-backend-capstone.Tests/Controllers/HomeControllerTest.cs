using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lee_hankins_backend_capstone;
using lee_hankins_backend_capstone.Controllers;

namespace lee_hankins_backend_capstone.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
