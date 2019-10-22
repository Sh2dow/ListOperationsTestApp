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
        private OrderModel DataInitializer(int objectCount)
        {
            var orderModel = new OrderModel()
            {
                Id = 1
            };
            for (int i = 0; i < objectCount; i++)
            {

                orderModel.DetailsList.Add(new DetailsCollectionModel
                {
                    new DetailModel(i, "Detail number " + i, (i % 2) == 0, (decimal)i * 10.5M)
                });
            }
            return orderModel;
        }

        public ActionResult Result(OrderModel orderModel)
        {
            return View(orderModel);
        }

        public ActionResult Index()
        {
            int detailsCount = 10;
            return View("MainForm", DataInitializer(detailsCount));
        }


        [HttpPost]
        public ActionResult Update(OrderModel orderModel)
        {
            //var orderModel = BindForm(form);
            return View("MainForm", orderModel);
        }

        public OrderModel BindForm(FormCollection form)
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
            return (OrderModel)orderModel;
        }
    }
}
