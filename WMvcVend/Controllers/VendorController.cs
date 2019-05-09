using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WMvcVend.Models;
using WMvcVend.ViewModel;

namespace WMvcVend.Controllers
{
    public class VendorController : Controller
    {
        // GET: Vendor
        public ActionResult Index()
        {
            VendorClient CC = new VendorClient();
            ViewBag.listVendors = CC.findAll();

            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public ActionResult Create(VendorViewModel cvm)
        {
            VendorClient CC = new VendorClient();
            CC.Create(cvm.vendor);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            VendorClient CC = new VendorClient();
            CC.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            VendorClient CC = new VendorClient();
            VendorViewModel CVM = new VendorViewModel();
            CVM.vendor = CC.find(id);
            return View("Edit", CVM);
        }
        [HttpPost]
        public ActionResult Edit(VendorViewModel CVM)
        {
            VendorClient CC = new VendorClient();
            CC.Edit(CVM.vendor);
            return RedirectToAction("Index");
        }
    }
}