using ListOperationsTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace ListOperationsTestApp.Controllers
{
    public class ListOperationsController : Controller
    {
        private OrderViewModel DataInitializer(int objectCount)
        {
            var orderModel = new OrderViewModel()
            {
                Id = 1
            };
            orderModel.DetailsList = new List<DetailsCollectionModel>();
            DetailsCollectionModel.Instance.Clear();
            for (int i = 0; i < objectCount; i++)
            {
                DetailsCollectionModel.Instance.Add(new DetailModel(i, "Detail number " + i, (i % 2) == 0, (decimal)i * 10.5M));
            }
            orderModel.DetailsList.Add(DetailsCollectionModel.Instance);
            return orderModel;
        }

        public ActionResult Result(OrderViewModel orderModel)
        {
            return View(orderModel);
        }

        public ActionResult Index()
        {
            int detailsCount = 10;
            var model = DataInitializer(detailsCount);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(OrderViewModel model)
        {
            //var orderModel = BindForm(form);
            return View(model);
        }

        public OrderViewModel BindForm(FormCollection form)
        {
            var request = Request;

            const string objectToInstantiate = "ListOperationsTestApp.Models.OrderModel, ListOperationsTestApp";
            var objectType = Type.GetType(objectToInstantiate);
            var orderModel = Activator.CreateInstance(objectType);
            Type modelType = orderModel.GetType();

            foreach (PropertyInfo propertyInfo in modelType.GetProperties())
            {
                var mykey = propertyInfo.Name;
                if (propertyInfo.CanRead && form.AllKeys.Contains(mykey))
                {
                    try
                    {
                        var value = form[mykey];
                        propertyInfo.SetValue(orderModel, value);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            return (OrderViewModel)orderModel;
        }
    }
}
