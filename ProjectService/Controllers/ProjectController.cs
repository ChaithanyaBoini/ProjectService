using ProjectService.Models;
using ProjectService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.ModelBinding;
using System.Web;



namespace ProjectService.Controllers
{
    public class ProjectController : ApiController
    {
        //[HttpPost]
        //public IHttpActionResult Signup(Login l)
        //{
        //    DBoperations dBoperations = new DBoperations();
        //    String s = dBoperations.register(l);
        //    return Ok(s);
        //}
        [HttpPost]
        public IHttpActionResult login(Loginvalidation logval)
        {
            DBoperations dBoperations = new DBoperations();
            Login l = null;
            bool flag = dBoperations.validateUser(logval, out l);
            if (flag)
            {
                Login typ = dBoperations.extracttype(logval);
                 return Ok(typ);
                //if (typ.type.Equals("ADMIN"))
                //{

                //    return Ok("ADMIN");
                //}
                //else
                //{

                //    return Ok("MANAGER");
                //}

            }
            // ModelState.AddModelError("", "No user found");
            return Ok();
        }
    }
}
