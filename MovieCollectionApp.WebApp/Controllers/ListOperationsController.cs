﻿using MovieCollectionApp.ViewModels.Models;
using MovieCollectionApp.Business;
using System.Web.Mvc;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MovieCollectionApp.UnitTests")]
namespace MovieCollectionApp.WebApp.Controllers
{
    public class ListOperationsController : Controller
    {
        public ActionResult Index()
        {
            MovieCollectionViewModel orderViewModel = DataGenerator.InitializeData();
            return View(orderViewModel);
        }

        [HttpPost]
        public ActionResult Index(MovieCollectionViewModel orderViewModel)
        {
            return View(orderViewModel);
        }
    }
}
