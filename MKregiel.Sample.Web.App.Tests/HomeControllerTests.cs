using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MKregiel.Sample.Web.App.Controllers;

namespace MKregiel.Sample.Web.App.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index_Returns_ViewResult()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About_Sets_ViewBag_Message()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Your application description page.", controller.ViewBag.Message);
        }

        [TestMethod]
        public void Contact_Sets_ViewBag_Message()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Your contact page.", controller.ViewBag.Message);
        }

        [TestMethod]
        public void Calculate_Returns_Correct_Sum()
        {
            // Arrange  
            var controller = new HomeController();

            // Act  
            var result = controller.Calculate(2, 3) as JsonResult;

            // Assert  
            Assert.IsNotNull(result);
            dynamic data = result.Data; // Cast result.Data to dynamic  
            Assert.IsNotNull(data);
            Assert.AreEqual(5, data.result);
        }
    }
}