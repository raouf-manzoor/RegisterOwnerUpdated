using ContactManagementSystem26_10_17.RegisterOwnerDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ContactManagementSystem26_10_17.Controllers
{
    [EnableCorsAttribute("*", "*", "*", SupportsCredentials = true)]
    public class RegistrationController : ApiController
    {
        // GET api/values

        //[HttpPost]
        //public void RegisterUser(User data)
        //{
        //    var dbcontext = new RegisterOwnersContext();
        //    dbcontext.Users.Add(data);
        //    dbcontext.SaveChanges();
        //}
        [HttpPost]
        public dynamic RegisterUser(User data)
        {
            try
            {
                var dbcontext = new RegisterOwnersContext();
                dbcontext.Users.Add(data);
                dbcontext.SaveChanges();
                return new
                {
                    IsUserRegisterd = true,
                    Message = "User Is Registered SuccessFully",

                };
            }
            catch (Exception ex)
            {
                return new
                {
                    IsUserRegisterd = false,
                    Message = "Internal Server Error",
                    ErrorException = ex
                };

            }
        }

    }
}
