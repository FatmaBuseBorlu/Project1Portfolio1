using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project1Portfolio1.Models;

namespace Project1Portfolio1.Controllers
{
    public class StatisticController : Controller
    {
        MyPortflıoEntities1 context = new MyPortflıoEntities1();

        public ActionResult Index()
        {
            ViewBag.totalMessageCount = context.Profile.Count();
            ViewBag.messageIsReadTrue

            return View();
        }
    }
}