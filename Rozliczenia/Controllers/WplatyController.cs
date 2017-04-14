using System.Web.Mvc;
using Rozliczenia.Models.Interfaces;
using Newtonsoft.Json;
using Rozliczenia.Models;
using Microsoft.AspNet.Identity;

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
            return View(_repWplaty.GetWplaty(User.Identity.GetUserId()));
        }
        
       
    }
}
