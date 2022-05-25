using BussinesLayer.Concrete;
using BussinesLayer.ValidationRules;
using DataAccesLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace deneme1.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new EFcontactDal());
        ContactValidator cv = new ContactValidator();
        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }
        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetByID(id);
            return View(contactvalues);
        }
        public ActionResult ContactPartial()
        {
            return PartialView();
        }
    }
}