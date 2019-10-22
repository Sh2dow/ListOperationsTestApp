using ListOperationsTestApp.Models;
using System.Web.Mvc;

namespace ListOperationsTestApp.Controllers
{
    public class ListOperationsController : Controller
    {
        private OrderViewModel DataInitializer(int objectCount)
        {
            var orderViewModel = new OrderViewModel()
            {
                Id = 1
            };
            for (int i = 0; i < objectCount; i++)
            {

                orderViewModel.DetailsList.Add(new DetailsCollectionModel
                {
                    new DetailModel(i, "Detail #" + i, (i % 2) == 0, (decimal)i * 10.5M)
                });
            }
            return orderViewModel;
        }

        public ActionResult Index()
        {
            int detailsCount = 10;
            var model = DataInitializer(detailsCount);
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(OrderViewModel order)
        {
            return View(order);
        }
    }
}
