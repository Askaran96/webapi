using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WMvcPro.Models;
using WMvcPro.ViewModel;

namespace WMvcPro.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult Index()
        {
            ContactUsClient contact = new ContactUsClient();
            ViewBag.listcontactus = contact.findAll();

            return View();
        }

        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(ContacUsViewModel pro)
        {
            ContactUsClient CC = new ContactUsClient();
            CC.Create(pro.contacUs);
            return RedirectToAction("HomePage", "Home");
        }


    }
}