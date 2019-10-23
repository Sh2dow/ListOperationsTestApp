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
            for (int i = 1; i <= objectCount; i++)
            {
                orderViewModel.DetailsList.Add(
                    new DetailModel((i % 2) == 0 ? i - 1 : i + 1, "Detail #" + i, i <= 3, (decimal)i * 10.5M)
                );
            }
            return orderViewModel;
        }

        public ActionResult Index()
        {
            var model = DataInitializer(10);
            ViewBag.LimitCount = 3;
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(OrderViewModel order)
        {
            ViewBag.LimitCount = 3;
            return View(order);
        }
    }
}
