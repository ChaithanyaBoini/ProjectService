using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectService.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        //[Route("api/values/value1")]
        //[HttpGet]
        //public string GetValue1(int id)
        //{
        //    return "value1";
        //}

        //[Route("api/values/value2")]
        //[HttpGet]
        //public string GetValue2(int id)
        //{
        //    return "value2";
        //}



        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
