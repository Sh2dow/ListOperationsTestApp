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
            int CategoryLimitCount = 3;

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.ViewBag.CategoryLimitCount, CategoryLimitCount);
        }

        [TestMethod]
        public void Index_Passing_Model_Test()
        {
            // Arrange
            var controller = new ListOperationsController();
            var orderViewModel = new MovieCollectionViewModel();
            int CategoryLimitCount = 3;

            // Act
            var result = controller.Index(orderViewModel) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.ViewBag.CategoryLimitCount, CategoryLimitCount);
        }
    }
}
