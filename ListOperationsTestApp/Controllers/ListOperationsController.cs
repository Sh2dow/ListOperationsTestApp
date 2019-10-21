using ListOperationsTestApp.Models;
using System.Web.Mvc;

namespace ListOperationsTestApp.Controllers
{
    public class ListOperationsController : Controller
    {
        public ActionResult Result(BaseModel baseModel)
        {
            return View(baseModel);
        }

        public ActionResult Index()
        {
            var baseModel = new BaseModel()
            {
                Id = 1,
                Details = {
                new DetailModel
                {
                    DetailId = 1,
                    Name = "str1",
                    BooleanValue = true
                },
                new DetailModel
                {
                    DetailId = 2,
                    Name = "str2",
                    BooleanValue = false
                },
                new DetailModel
                {
                    DetailId = 3,
                    Name = "str3",
                    BooleanValue = true
                },new DetailModel
                {
                    DetailId = 4,
                    Name = "str4",
                    BooleanValue = false
                }
            }
            };
            return View("Result", baseModel);
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
