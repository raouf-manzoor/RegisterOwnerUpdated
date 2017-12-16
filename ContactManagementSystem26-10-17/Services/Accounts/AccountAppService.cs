using ContactManagementSystem26_10_17.Controllers;
using ContactManagementSystem26_10_17.RegisterOwnerDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagementSystem26_10_17.Services.Accounts
{
    public class AccountAppService
    {
        public dynamic UpdateUser(UserDto input)
        {
            try
            {
                var dbcontext = new RegisterOwnersContext();
                var user = dbcontext.Users.Single(e => e.Id == input.Id);
                user.FirstName = input.FirstName;
                user.LastName = input.LastName;
                user.MobileNo = input.MobileNo;
                user.Dob = input.Dob;
                user.Adress = input.Adress;
                user.ZipCode = input.ZipCode;
                user.Place = input.Place;
                user.Country = input.Country;
                user.MobileNo = input.MobileNo;
                dbcontext.SaveChanges();
                return new
                {
                    IsUpdated = true,
                };
            }
            catch (Exception ex)
            {
                return new
                {
                    IsUpdated = false,
                    ErrorException = ex

                };
            }


        }
    }
}