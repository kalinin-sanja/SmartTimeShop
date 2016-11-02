using System.Web.Mvc;
using WatchAPI.Services;

namespace WatchAPI.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(ILocator locator)
        {
            ServiceUoW = locator.ServiceUoW;
        }

        protected ServiceUoW ServiceUoW { get; }
    }
}