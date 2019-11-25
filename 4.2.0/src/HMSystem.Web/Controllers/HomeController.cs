using Microsoft.AspNetCore.Mvc;

namespace HMSystem.Web.Controllers
{
    public class HomeController : HMSystemControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}