using Json_GET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Json_GET.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            return View();
        }
        public JsonResult getJson()
        {
            List<Customer> cus = new List<Customer> { 
                new Customer {ID = 1, Name = "Mendis" },
                new Customer {ID = 2, Name = "dayan"}
            };
            return Json(cus, JsonRequestBehavior.AllowGet);
        }

    }
}
