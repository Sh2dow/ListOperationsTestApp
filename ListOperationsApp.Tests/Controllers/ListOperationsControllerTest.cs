using System.Web.Mvc;
using ListOperationsApp.Controllers;
using ListOperationsApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListOperationsApp.Tests.Controllers
{
    [TestClass]
    public class ListOperationsControllerTest
    {
        [TestMethod]
        public void DataInitializerTest()
        {
            // Arrange
            var controller = new ListOperationsController();
            int objectCount = 10;

            // Act
            var result = controller.DataInitializer(objectCount) as OrderViewModel;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.DetailsList.Count == objectCount);
        }

        [TestMethod]
        public void IndexTest()
        {
            // Arrange
            var controller = new ListOperationsController();
            int LimitCount = 3;

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.ViewBag.LimitCount, LimitCount);
        }

        [TestMethod]
        public void Index_Passing_Model_Test()
        {
            // Arrange
            var controller = new ListOperationsController();
            var orderViewModel = new OrderViewModel();
            int LimitCount = 3;

            // Act
            var result = controller.Index(orderViewModel) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.ViewBag.LimitCount, LimitCount);
        }
    }
}
