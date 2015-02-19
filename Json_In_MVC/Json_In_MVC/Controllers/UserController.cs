using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Json_In_MVC.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            string status = "my name is dayan";
            return View();
        }

        [HttpPost]
        public ActionResult Index(string option1)
        {
            //if (user == null)
            //    return Json(new { success = false });
            //else
            //    return Json(new { success = true});
            return Json(option1);
        }

    }
}
