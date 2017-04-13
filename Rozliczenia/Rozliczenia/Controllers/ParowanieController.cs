using System.Web.Mvc;
using Rozliczenia.Models.Interfaces;
using Newtonsoft.Json;
using Rozliczenia.Models;

namespace Rozliczenia.Controllers
{
    public class ParowanieController : Controller
    {
        private readonly IParowanie _repParowanie;

        public ParowanieController(IParowanie repParowanie)
        {
            _repParowanie = repParowanie;
        }

        public ActionResult Index()
        {
            return View(_repParowanie.GetParowanie());
        }

        public JsonResult Piechart(IParowanie _vParowanie)
        {
            var chartsdata = _vParowanie.GetParowanie();
            return Json(chartsdata, JsonRequestBehavior.AllowGet);
        }

    }
}
