using System.Web.Mvc;
using Rozliczenia.Models.Interfaces;
using Rozliczenia.Models;
using Microsoft.AspNet.Identity;

namespace Rozliczenia.Controllers
{
    public class NaleznosciController : Controller
    {
        private readonly INaleznosci _repNaleznosci;

        public NaleznosciController(INaleznosci repNaleznosci)
        {
            _repNaleznosci = repNaleznosci;
        }

        public ActionResult Index()
        {
            return View(_repNaleznosci.GetNaleznosci(User.Identity.GetUserId()));
        }
        


    }
}
