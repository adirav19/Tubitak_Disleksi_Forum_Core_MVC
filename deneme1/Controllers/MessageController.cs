using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace deneme1.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager cm = new MessageManager(new EFMessageDal());
        [Authorize]
        public ActionResult Inbox()
        {
            var messagelist = cm.GetListInbox();
            return View(messagelist);
        }


        public ActionResult GetInBoxMessageDetails(int id)
        {
            var values = cm.GetByID(id);
            return View(values);
        }
        public ActionResult GetSendBoxMessageDetails(int id)
        {
            var values = cm.GetByID(id);
            return View(values);
        }

        public ActionResult Sendbox()
        {
            var messagelist = cm.GetListSendbox();
            return View(messagelist);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            return View();
        }
    }
}