using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WApiVend.Models;

namespace WApiPro.Controllers
{
    public class ContactUsController : ApiController
    {
        private VendMgmtEntities db = new VendMgmtEntities();

        // GET: api/ContactUs
        public IQueryable<ContactU> GetContacts()
        {
            return db.ContactUs;
        }

        // POST: api/ContactUs
        [ResponseType(typeof(ContactU))]
        public IHttpActionResult PostContact(ContactU contactU)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ContactUs.Add(contactU);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = contactU.ContactId }, contactU);
        }

    }
}