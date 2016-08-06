using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToopHouse.Controllers
{
    public class RentingController : Controller
    {
        //
        // GET: /Renting/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calendar()
        {
            return View("Index");
        }
    }
}
