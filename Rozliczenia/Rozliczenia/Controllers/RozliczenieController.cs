using System.Web.Mvc;
using Rozliczenia.Models.Interfaces;
using Newtonsoft.Json;
using Rozliczenia.Models;

namespace Rozliczenia.Controllers
{
    public class RozliczenieController : Controller
    {
        private readonly IRozliczenie _repRozliczenie;

        public RozliczenieController(IRozliczenie repRozliczenie)
        {
            _repRozliczenie = repRozliczenie;
        }

        public ActionResult Index()
        {
            return View(_repRozliczenie.GetRozliczenie());
        }
        
    }
}
