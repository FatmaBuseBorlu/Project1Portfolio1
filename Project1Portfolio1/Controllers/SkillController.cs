using Project1Portfolio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1Portfolio1.Controllers
{
    public class SkillController : Controller
    {

        MyPortflıoEntities1 context = new MyPortflıoEntities1();
        public ActionResult SkillList()
        {
            var values = context.Skıll.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSkill(Skıll skıll)
        {
            context.Skıll.Add(skıll);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        public ActionResult DeleteSkill(int id)
        {
            var value = context.Skıll.Find(id);
            context.Skıll.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}