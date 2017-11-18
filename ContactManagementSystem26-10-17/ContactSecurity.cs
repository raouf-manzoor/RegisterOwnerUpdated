using ContactManagementSystem26_10_17.Models;
using ContactManagementSystem26_10_17.RegisterOwnerDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagementSystem26_10_17
{
    public class ContactSecurity
    {

        public static bool Login(string UserName, string PassWord)
        {
            //. >  
            var dbcontext = new RegisterOwnersContext();
            return dbcontext.Users.Any(e => e.Email == UserName && e.Password == PassWord);
            
        }
    }
}