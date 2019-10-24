using MovieCollectionApp.ViewModels.Models;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Mvc;

[assembly: InternalsVisibleTo("MovieCollectionApp.UnitTests")]
namespace MovieCollectionApp.WebApp.Controllers
{
    public class ListOperationsController : Controller
    {
        private static List<CategoryViewModel> InitializeData()
        {
            return new List<CategoryViewModel>
            {
                new CategoryViewModel
                    {
                        Id = 1,
                        Name = "Thriller",
                        Movies = new List<MovieViewModel>
                        {
                            new MovieViewModel("Joker", 2019, 8.9),
                            new MovieViewModel("Breaking Bad", 2013, 9.5),
                            new MovieViewModel("Fargo", 2014, 9.0),
                            new MovieViewModel("No Time to Die", 2020, null),
                            new MovieViewModel("The Dark Knight Rises", 2012, 8.4),
                        }  
                    },

                new CategoryViewModel
                    {
                        Id = 2,
                        Name = "Sci-fi",
                        Movies = new List<MovieViewModel>
                        {
                            new MovieViewModel("Men in Black", 1997, 7.3),
                            new MovieViewModel("The Expanse", 2015, 8.4),
                            new MovieViewModel("Terminator: Dark Fate", 2019, null),
                            new MovieViewModel("Star Wars: The Rise of Skywalker", 2019, null),
                            new MovieViewModel("In the Shadow of the Moon", 2019, 6.2),
                        }
                    },
                new CategoryViewModel
                    {
                        Id = 3,
                        Name = "Comedy",
                        Movies = new List<MovieViewModel>
                        {
                            new MovieViewModel("Back to the Future", 1985, 8.5),
                            new MovieViewModel("Thor: Ragnarok", 2017, 7.9),
                            new MovieViewModel("About Time (I)", 2013,  7.8),
                            new MovieViewModel("Galaxy Quest", 1999,  7.3),
                        }
                    },

                new CategoryViewModel
                    {
                        Id = 4,
                        Name = "Drama",
                        Movies = new List<MovieViewModel>
                        {
                            new MovieViewModel("The Lobster", 2015, 7.1),
                            new MovieViewModel("Cocoon", 1985, 6.7),
                            new MovieViewModel("The Zero Theorem", 2013, 6.1),
                            new MovieViewModel("Electric Dreams", 1984, 6.4),
                        }
                    },
            };
        }

        internal MovieCollectionViewModel DataInitializer()
        {
            var orderViewModel = new MovieCollectionViewModel()
            {
                Id = 1,
                Categories = InitializeData()
            };
            return orderViewModel;
        }

        public ActionResult Index()
        {
            var model = DataInitializer();
            ViewBag.LimitCount = 3;
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(MovieCollectionViewModel order)
        {
            ViewBag.LimitCount = 3;
            return View(order);
        }
    }
}
