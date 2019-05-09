using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WApiVend.Models;

namespace WApiVend.Controllers
{
    public class VendRegController : ApiController
    {
        private VendMgmtEntities db = new VendMgmtEntities();

        // GET: api/ContactUs
        public IQueryable<VendorReg> GetVendorRegs()
        {
            return db.VendorRegs;
        }

        // POST: api/ContactUs
        [ResponseType(typeof(VendorReg))]
        public IHttpActionResult PostVendorReg(VendorReg vendorReg)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VendorRegs.Add(vendorReg);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vendorReg.RegId }, vendorReg);
        }

    }
}