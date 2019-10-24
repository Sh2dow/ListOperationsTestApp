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
            int categoriesCount = 4;
            int moviesCount = 18;

            // Act
            var movieCollection = controller.DataInitializer() as MovieCollectionViewModel;

            // Assert
            Assert.IsNotNull(movieCollection);
            Assert.IsTrue(movieCollection.Categories.Count == categoriesCount);
            var allMoviesCount = default(int); 
            movieCollection.Categories
                .ForEach(c => allMoviesCount += c.Movies.Count);
            Assert.IsTrue(allMoviesCount == moviesCount);
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
            var orderViewModel = new MovieCollectionViewModel();
            int LimitCount = 3;

            // Act
            var result = controller.Index(orderViewModel) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.ViewBag.LimitCount, LimitCount);
        }
    }
}
