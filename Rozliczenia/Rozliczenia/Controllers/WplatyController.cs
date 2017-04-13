using System.Web.Mvc;
using Rozliczenia.Models.Interfaces;

namespace Rozliczenia.Controllers
{
    public class WplatyController : Controller
    {
        private readonly IWplaty _repWplaty;

        public WplatyController(IWplaty repWplaty)
        {
            _repWplaty = repWplaty;
        }

        public ActionResult Index()
        {
            return View(_repWplaty.GetWplaty());
        }
        
       
    }
}
