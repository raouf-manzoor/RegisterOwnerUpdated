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
        //public bool RegisterUser(User data)
        //{
        //    var dbcontext = new RegisterOwnersContext();
        //    dbcontext.Users.Add(data);
        //    dbcontext.SaveChanges();
        //    return true;
        //}
        [HttpPost]
        public RegistrationUserData RegisterUser(User data)
        {
            try
            {
                var dbcontext = new RegisterOwnersContext();
                dbcontext.Users.Add(data);
                dbcontext.SaveChanges();
                return new RegistrationUserData
                {
                    IsUserRegisterd = true,
                    Message = "User Is Registered SuccessFully",
                    ErrorException=null
                };
            }
            catch (Exception ex)
            {
                return new RegistrationUserData
                {
                    IsUserRegisterd = false,
                    Message = "Internal Server Error",
                    ErrorException = ex
                };

            }
        }
        [HttpPost]
        public User SignIn(User input)
        {
            var dbcontext = new RegisterOwnersContext();
            return dbcontext.Users.FirstOrDefault(e => e.Email == input.Email && e.Password == input.Password);
        }
    }

    public class RegistrationUserData
    {
        public bool IsUserRegisterd { get; set; }
        public string Message { get; set; }
        public Exception ErrorException { get; set; }
        
    }
}
