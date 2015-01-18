using Json_DropDownList_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Json_DropDownList_Example.Controllers
{
    public class SystemController : Controller
    {
        //
        // GET: /System/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getJsonCustomers()
        {
            List<Customer> user = new List<Customer> 
            { 
                new Customer { ID = 23, Name = "Mendis" },
                new Customer { ID = 13, Name = "Ewerdney" }
            };
            return Json(user, JsonRequestBehavior.AllowGet);
        }

        public ActionResult getJsonUsers()
        {
            List<User> user = new List<User> 
            { 
                new User { ID = 2, Name = "dayan" },
                new User { ID = 1, Name = "Neranjan" }
            };
            return Json(user, JsonRequestBehavior.AllowGet);
        }

    }
}
