using System.Web.Mvc;
using MovieCollectionApp.WebApp.Controllers;
using MovieCollectionApp.ViewModels.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieCollectionApp.Business;

namespace MovieCollectionApp.UnitTests.Controllers
{
    [TestClass]
    public class BusinessTest
    {
        [TestMethod]
        public void DataInitializerTest()
        {
            // Arrange
            var controller = new ListOperationsController();
            int categoriesCount = 4;
            int moviesCount = 18;

            // Act
            var movieCollection = DataGenerator.InitializeData();

            // Assert
            Assert.IsNotNull(movieCollection);
            Assert.IsTrue(movieCollection.Categories.Count == categoriesCount);
            var allMoviesCount = default(int); 
            movieCollection.Categories
                .ForEach(c => allMoviesCount += c.Movies.Count);
            Assert.IsTrue(allMoviesCount == moviesCount);
        }
    }
}
