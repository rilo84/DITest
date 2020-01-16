using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DITest.Controllers
{
    public class HomeController : Controller
    {
        private ILogger _logger;

        public HomeController(Container container)
        {
            _logger = container.GetInstance<ILogger>();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            _logger.Save($"R entered about at {DateTime.Now}");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}