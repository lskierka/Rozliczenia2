using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Rozliczenia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Informacje o projekcie.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Strona kontaktowa.";

            return View();
        }

        public ActionResult Naleznosci()
        {
            ViewBag.Message = "Twoje naleznosci.";

            return View();
        }

        public ActionResult Wplaty()
        {
            ViewBag.Message = "Twoje wpłaty.";

            return View();
        }

        public ActionResult Rozliczenie()
        {
            ViewBag.Message = "Twoje Rozliczenie.";

            return View();
        }
    }
}