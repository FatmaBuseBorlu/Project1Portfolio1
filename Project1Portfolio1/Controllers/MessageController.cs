﻿using Project1Portfolio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1Portfolio1.Controllers
{
    public class MessageController : Controller
    {
        MyPortflıoEntities1 context = new MyPortflıoEntities1();
        public ActionResult Inbox()
        {
            var values = context.Message.ToList();
            return View(values);
        }
        public ActionResult MessageDetails(int id)
        {
            var value = context.Message.Where(x => x.MessageId == id).FirstOrDefault();
            return View(value);
        }
        public ActionResult MessageStatusChangeToTrue(int id)
        {
            var value = context.Message.Where(x => x.MessageId == id).FirstOrDefault();
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public ActionResult MessageStatusChangeToFalse(int id)
        {
            var value = context.Message.Where(x => x.MessageId == id).FirstOrDefault();
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
    }
}