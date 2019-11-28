using Microsoft.AspNetCore.Mvc;

namespace HMSystem.Web.Controllers
{
    public class HomeController : HMSystemControllerBase
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Tasks");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}