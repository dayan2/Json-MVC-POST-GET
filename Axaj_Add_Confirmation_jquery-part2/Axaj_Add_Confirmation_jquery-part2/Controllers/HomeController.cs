using Axaj_Add_Confirmation_jquery_part2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace Axaj_Add_Confirmation_jquery_part2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Customer cus)
        {
            //JavaScriptSerializer js = new JavaScriptSerializer();
            //var cus1 = js.Deserialize<Customer>(cus);
            
            string str = null;
            if (cus.Name == "jude")
                str = "Success";
            else
                str = "Error!!";
            return Json(str);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}