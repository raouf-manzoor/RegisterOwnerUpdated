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



                else if (input.Digits == 3)
                {
                    int threeDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.ThreeDigit) + 1;

                    oneDigitString = Base36Converter.ConvertToBaseK(threeDigit, 3);
                    var regNos1Check = dbcontext.RegistrationNoS3.FirstOrDefault(e => e.RegNo == oneDigitString);

                    while (regNos1Check != null)
                    {
                        threeDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                        //oneDigit++;
                        //oneDigitString = oneDigit.ToString();
                        oneDigitString = Base36Converter.ConvertToBaseK(threeDigit, 3);
                        regNos1Check = dbcontext.RegistrationNoS3.FirstOrDefault(e => e.RegNo == oneDigitString);
                        //currentRegistrationNo.OneDigit = oneDigitString;
                    }
                    var regNos3 = new RegistrationNoS3()
                    {
                        RegNo = oneDigitString,
                        userId = input.UserId,
                        PaidStatus = true,
                        TimeStamp = DateTime.Now.TimeOfDay
                    };
                    //oneDigit++;
                    //oneDigitString = oneDigit.ToString();
                    currentRegistrationNo.ThreeDigit = oneDigitString;
                    dbcontext.RegistrationNoS3.Add(regNos3);
                    dbcontext.SaveChanges();



                }



                else if (input.Digits == 4)
                {
                    int fourDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.FourDigit) + 1;

                    oneDigitString = Base36Converter.ConvertToBaseK(fourDigit, 4);
                    var regNos1Check = dbcontext.RegistrationNoS4.FirstOrDefault(e => e.RegNo == oneDigitString);

                    while (regNos1Check != null)
                    {
                        fourDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                        //oneDigit++;
                        //oneDigitString = oneDigit.ToString();
                        oneDigitString = Base36Converter.ConvertToBaseK(fourDigit, 4);
                        regNos1Check = dbcontext.RegistrationNoS4.FirstOrDefault(e => e.RegNo == oneDigitString);
                        //currentRegistrationNo.OneDigit = oneDigitString;
                    }
                    var regNos4 = new RegistrationNoS4()
                    {
                        RegNo = oneDigitString,
                        userId = input.UserId,
                        PaidStatus = true,
                        TimeStamp = DateTime.Now.TimeOfDay
                    };
                    //oneDigit++;
                    //oneDigitString = oneDigit.ToString();
                    currentRegistrationNo.FourDigit = oneDigitString;
                    dbcontext.RegistrationNoS4.Add(regNos4);
                    dbcontext.SaveChanges();



                }



                else if (input.Digits == 5)
                {
                    int fiveDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.FiveDigit) + 1;

                    oneDigitString = Base36Converter.ConvertToBaseK(fiveDigit, 5);
                    var regNos1Check = dbcontext.RegistrationNoS5.FirstOrDefault(e => e.RegNo == oneDigitString);

                    while (regNos1Check != null)
                    {
                        fiveDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                        //oneDigit++;
                        //oneDigitString = oneDigit.ToString();
                        oneDigitString = Base36Converter.ConvertToBaseK(fiveDigit, 5);
                        regNos1Check = dbcontext.RegistrationNoS5.FirstOrDefault(e => e.RegNo == oneDigitString);
                        //currentRegistrationNo.OneDigit = oneDigitString;
                    }
                    var regNos5 = new RegistrationNoS5()
                    {
                        RegNo = oneDigitString,
                        userId = input.UserId,
                        PaidStatus = true,
                        TimeStamp = DateTime.Now.TimeOfDay
                    };
                    //oneDigit++;
                    //oneDigitString = oneDigit.ToString();
                    currentRegistrationNo.FiveDigit = oneDigitString;
                    dbcontext.RegistrationNoS5.Add(regNos5);
                    dbcontext.SaveChanges();



                }




                else if (input.Digits == 6)
                {
                    int sixDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.SixDigit) + 1;

                    oneDigitString = Base36Converter.ConvertToBaseK(sixDigit, 6);
                    var regNos1Check = dbcontext.RegistrationNoS6.FirstOrDefault(e => e.RegNo == oneDigitString);

                    while (regNos1Check != null)
                    {
                        sixDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                        //oneDigit++;
                        //oneDigitString = oneDigit.ToString();
                        oneDigitString = Base36Converter.ConvertToBaseK(sixDigit, 6);
                        regNos1Check = dbcontext.RegistrationNoS6.FirstOrDefault(e => e.RegNo == oneDigitString);
                        //currentRegistrationNo.OneDigit = oneDigitString;
                    }
                    var regNos6 = new RegistrationNoS6()
                    {
                        RegNo = oneDigitString,
                        userId = input.UserId,
                        PaidStatus = true,
                        TimeStamp = DateTime.Now.TimeOfDay
                    };
                    //oneDigit++;
                    //oneDigitString = oneDigit.ToString();
                    currentRegistrationNo.SixDigit = oneDigitString;
                    dbcontext.RegistrationNoS6.Add(regNos6);
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