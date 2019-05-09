using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WMvcVend.Models;
using WMvcVend.ViewModel;

namespace WMvcVend.Controllers
{
    public class VendRegController : Controller
    {
        // GET: VendReg
        public ActionResult VendDet()
        {
            VendRegClient vend = new VendRegClient();
            ViewBag.listVendRegs = vend.VendRegfindAll();

            return View();
        }

        public ActionResult VendCre()
        {
            return View("VendCre");
        }

        [HttpPost]
        public ActionResult VendCre(VendRegViewModel pro)
        {
            VendRegClient CC = new VendRegClient();
            CC.VendRegCre(pro.vendReg);
            return RedirectToAction("HomePage", "Home");
        }
    }
}