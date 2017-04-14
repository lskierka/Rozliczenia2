using System.Web.Mvc;
using Rozliczenia.Models.Interfaces;
using Newtonsoft.Json;
using Rozliczenia.Models;
using Microsoft.AspNet.Identity;

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
            return View(_repParowanie.GetParowanie(User.Identity.GetUserId()));
        }

      

    }
}
