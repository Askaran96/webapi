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
    public class LogInController : ApiController
    {
        private VendMgmtEntities db = new VendMgmtEntities();

        // GET: api/LogIn
        [ResponseType(typeof(LogIn))]
        public IHttpActionResult LogInCheck(LogIn logIn)
        {
            LogIn log = db.LogIns.FirstOrDefault(u => u.UserName == logIn.UserName && u.Password == logIn.Password);
            if (log == null)
            {
                return NotFound();
            }

            return Ok(log);
        }
        
    }
}