﻿using ContactManagementSystem26_10_17.RegisterOwnerDataBase;
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
            try
            {
                RegisterOwnersContext dbcontext = new RegisterOwnersContext();
                var currentRegistrationNo = dbcontext.CurrentRegistrationNoes.First();
                string oneDigitString = null;
                


                if (input.Digits == 1)
                {
                    //var regNos1 = new RegistrationNoS1();

                    int oneDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.OneDigit) + 1;

                    oneDigitString = Base36Converter.ConvertToBaseK(oneDigit, 1);
                    var regNos1Check = dbcontext.RegistrationNoS1.FirstOrDefault(e => e.RegNo == oneDigitString);

                    while (regNos1Check != null)
                    {
                        oneDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                        //oneDigit++;
                        //oneDigitString = oneDigit.ToString();
                        oneDigitString = Base36Converter.ConvertToBaseK(oneDigit, 1);
                        regNos1Check = dbcontext.RegistrationNoS1.FirstOrDefault(e => e.RegNo == oneDigitString);
                        //currentRegistrationNo.OneDigit = oneDigitString;
                    }
                    var regNos1 = new RegistrationNoS1()
                    {
                        RegNo = oneDigitString,
                        userId = input.UserId,
                        PaidStatus = true,
                        TimeStamp = DateTime.Now.TimeOfDay
                    };
                    //oneDigit++;
                    //oneDigitString = oneDigit.ToString();
                    currentRegistrationNo.OneDigit = oneDigitString;
                    dbcontext.RegistrationNoS1.Add(regNos1);
                    dbcontext.SaveChanges();
                }


                else if (input.Digits == 2)
                {
                    int twoDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.TwoDigit) + 1;

                    oneDigitString = Base36Converter.ConvertToBaseK(twoDigit, 2);
                    var regNos1Check = dbcontext.RegistrationNoS2.FirstOrDefault(e => e.RegNo == oneDigitString);

                    while (regNos1Check != null)
                    {
                        twoDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                        //oneDigit++;
                        //oneDigitString = oneDigit.ToString();
                        oneDigitString = Base36Converter.ConvertToBaseK(twoDigit, 2);
                        regNos1Check = dbcontext.RegistrationNoS2.FirstOrDefault(e => e.RegNo == oneDigitString);
                        //currentRegistrationNo.OneDigit = oneDigitString;
                    }
                    var regNos2 = new RegistrationNoS2()
                    {
                        RegNo = oneDigitString,
                        userId = input.UserId,
                        PaidStatus = true,
                        TimeStamp = DateTime.Now.TimeOfDay
                    };
                    //oneDigit++;
                    //oneDigitString = oneDigit.ToString();
                    currentRegistrationNo.TwoDigit = oneDigitString;
                    dbcontext.RegistrationNoS2.Add(regNos2);
                    dbcontext.SaveChanges();



                }
                return new
                {
                    IsGenerated = true,
                    RegNo = oneDigitString
                };
            }
            catch (Exception ex)
            {
                return new
                {
                    IsGenerated = false,
                    ErrorException = ex,
                };
            }

        }
    }
}