using System.Collections.Generic;
using MovieCollectionApp.ViewModels.Models;
using MovieCollectionApp.Infrastructure;
using MovieCollectionApp.Infrastructure.Attributes;
using System;
using System.Collections;

namespace MovieCollectionApp.Business
{
    public class DataGenerator
    {
        private static readonly ArrayList CategoriesEnabledByDefault = new ArrayList { Categories.Thriller, Categories.SciFi, Categories.Comedy };

        public static MovieCollectionViewModel InitializeData()
        {
            var movieCollectionViewModel = new MovieCollectionViewModel()
            {
                Id = 1,
                Categories = InitCategories()
            };

            return movieCollectionViewModel;
        }

        private static List<CategoryViewModel> InitCategories()
        {
            var categories = new List<CategoryViewModel>();
            foreach (Categories category in Enum.GetValues(typeof(Categories)))
            {
                categories.Add(CreateCategory(category, CategoriesEnabledByDefault.Contains(category)));
            }
            return categories;
        }

        public static CategoryViewModel CreateCategory(Categories category, bool enabled)
        {
            return new CategoryViewModel
            {
                Id = (int)category,
                Name = StringEnum.GetStringValue(category),
                Movies = FillWithMovies(category),
                Enabled = enabled
            };
        }

        public static List<MovieViewModel> FillWithMovies(Categories category)
        {
            switch (category)
            {
                case Categories.Thriller:
                    return new List<MovieViewModel>
                    {
                        new MovieViewModel("Joker", 2019, 8.9),
                        new MovieViewModel("Breaking Bad", 2013, 9.5),
                        new MovieViewModel("Fargo", 2014, 9.0),
                        new MovieViewModel("No Time to Die", 2020, null),
                        new MovieViewModel("The Dark Knight Rises", 2012, 8.4),
                    };
                case Categories.SciFi:
                    return new List<MovieViewModel>
                    {
                        new MovieViewModel("Men in Black", 1997, 7.3),
                        new MovieViewModel("The Expanse", 2015, 8.4),
                        new MovieViewModel("Terminator: Dark Fate", 2019, null),
                        new MovieViewModel("Star Wars: The Rise of Skywalker", 2019, null),
                        new MovieViewModel("In the Shadow of the Moon", 2019, 6.2),
                    };
                case Categories.Comedy:
                    return new List<MovieViewModel>
                    {
                        new MovieViewModel("Back to the Future", 1985, 8.5),
                        new MovieViewModel("Thor: Ragnarok", 2017, 7.9),
                        new MovieViewModel("About Time (I)", 2013, 7.8),
                        new MovieViewModel("Galaxy Quest", 1999, 7.3),
                    };
                case Categories.Drama:
                    return new List<MovieViewModel>
                    {
                        new MovieViewModel("The Lobster", 2015, 7.1),
                        new MovieViewModel("Cocoon", 1985, 6.7),
                        new MovieViewModel("The Zero Theorem", 2013, 6.1),
                        new MovieViewModel("Electric Dreams", 1984, 6.4),
                    };
                default:
                    return new List<MovieViewModel> { };
            }
        }
    }
}
