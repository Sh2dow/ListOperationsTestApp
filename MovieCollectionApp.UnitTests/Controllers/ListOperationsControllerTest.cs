using System.Web.Mvc;
using MovieCollectionApp.WebApp.Controllers;
using MovieCollectionApp.ViewModels.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieCollectionApp.UnitTests.Controllers
{
    [TestClass]
    public class ListOperationsControllerTest
    {
        [TestMethod]
        public void IndexTest()
        {
            // Arrange
            var controller = new ListOperationsController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Index_Passing_Model_Test()
        {
            // Arrange
            var controller = new ListOperationsController();
            var orderViewModel = new MovieCollectionViewModel();

            // Act
            var result = controller.Index(orderViewModel) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
