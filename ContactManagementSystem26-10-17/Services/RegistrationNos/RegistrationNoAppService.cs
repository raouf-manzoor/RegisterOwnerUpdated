using ContactManagementSystem26_10_17.RegisterOwnerDataBase;
using ContactManagementSystem26_10_17.Services.RegistrationNos.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagementSystem26_10_17.Services.RegistrationNos
{
    public class RegistrationNoAppService
    {
        public dynamic GetAutoRegistrationNo(GetRegistrationNoInput input)
        {
            RegisterOwnersContext dbcontext = new RegisterOwnersContext();
            var currentRegistrationNo = dbcontext.CurrentRegistrationNoes.First();
            if (input.Digits == 1)
            {
                var regNos1 = new RegistrationNoS1();

               var val =   currentRegistrationNo.OneDigit;
            }
                return true;
        }
    }
}