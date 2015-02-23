using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Axaj_Add_Confirmation_jquery.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(true);
        }
        [HttpPost]
        public ActionResult Index(string str)
        {
            bool res = true;
            if (str == "Jude")
                res = false;
            return Json(res);
        }

    }
}
