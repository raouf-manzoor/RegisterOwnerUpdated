using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ContactManagementSystem26_10_17.Controllers
{
    [EnableCorsAttribute("*", "*", "*",SupportsCredentials=true)]
    public class ValuesController : ApiController
    {
        // GET api/values



        [HttpGet]
        [BasicAuthenticationClass]
        public dynamic GetData()
        {

            return new
            {
                Name = "Raouf",
                Institute = "Pucit",
                array = new int[] { 1, 2, 3, 4, 5, 5, 5, 5 }
            };
        }

        [HttpGet]
        //[BasicAuthenticationClass]
        public void RegisterUser()
        { 
        
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
