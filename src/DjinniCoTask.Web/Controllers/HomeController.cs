using Microsoft.AspNetCore.Mvc;

namespace DjinniCoTask.Web.Controllers
{
    public class HomeController : DjinniCoTaskControllerBase
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