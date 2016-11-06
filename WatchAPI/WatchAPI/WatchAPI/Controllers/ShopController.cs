using System.Web.Mvc;

namespace WatchAPI.Controllers
{
    public class ShopController : BaseController
    {
        public ShopController(ILocator locator) : base(locator)
        {
        }

        public JsonResult GetAll()
        {
            var watchList = ServiceUoW.WatchService.GetAll();
            return Json(watchList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetByQuery(string query, string field, int offset, int limit, bool desc)
        {
            var watchList = ServiceUoW.WatchService
                .GetByQuery(query, field, offset, limit, desc);
            return Json(watchList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetById(int id)
        {
            var watch = ServiceUoW.WatchService.GetById(id);
            return Json(watch, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetWatchCount(string query)
        {
            var watchCount = ServiceUoW.WatchService.GetWatchCount(query);
            return Json(watchCount, JsonRequestBehavior.AllowGet);
        }
    }
}