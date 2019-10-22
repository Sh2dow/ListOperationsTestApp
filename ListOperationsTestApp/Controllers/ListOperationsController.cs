using ListOperationsTestApp.Models;
using System.Web.Mvc;

namespace ListOperationsTestApp.Controllers
{
    public class ListOperationsController : Controller
    {
        private BaseModel DataInitializer(int objectCount)
        {
            var baseModel = new BaseModel();
            for (int i = 0; i < objectCount; i++)
            {

                baseModel.DetailsList.Add(new DetailsCollectionModel
                {
                    new DetailModel(i, "Obj number " + i, (i % 2) == 0, (decimal)i * 10.5M)
                });
            }
            return baseModel;
        }

        public ActionResult Result(BaseModel baseModel)
        {
            return View(baseModel);
        }

        public ActionResult Index()
        {
            int detailsCount = 10;
            return View("Result", DataInitializer(detailsCount));
        }

        [HttpPost]
        public ActionResult Update(BaseModel baseModel)
        {
            try
            {
                // TODO: Add update logic here

                return View("Result", baseModel);
            }
            catch
            {
                return View();
            }
        }
    }
}
