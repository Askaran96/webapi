using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WApiVend.Models;

namespace WApiVend.Controllers
{
    public class VendorController : ApiController
    {
        private VendMgmtEntities db = new VendMgmtEntities();

        // GET: api/Vendor
        public IQueryable<Vendor> GetVendors()
        {
            return db.Vendors;
        }

        // GET: api/Vendor/5
        [ResponseType(typeof(Vendor))]
        public IHttpActionResult GetVendor(int id)
        {
            Vendor vendor = db.Vendors.Find(id);
            if (vendor == null)
            {
                return NotFound();
            }

            return Ok(vendor);
        }

        // PUT: api/Vendor/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCustomer(int id, Vendor vendor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vendor.VendorId)
            {
                return BadRequest();
            }

            db.Entry(vendor).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Vendor
        [ResponseType(typeof(Vendor))]
        public IHttpActionResult PostCustomer(Vendor vendor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Vendors.Add(vendor);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vendor.VendorId }, vendor);
        }

        // DELETE: api/Vendor/5
        [ResponseType(typeof(Vendor))]
        public IHttpActionResult DeleteCustomer(int id)
        {
            Vendor customer = db.Vendors.Find(id);
            if (customer == null)
            {
                return NotFound();
            }

            db.Vendors.Remove(customer);
            db.SaveChanges();

            return Ok(customer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VendorExists(int id)
        {
            return db.Vendors.Count(e => e.VendorId == id) > 0;
        }
    }
}