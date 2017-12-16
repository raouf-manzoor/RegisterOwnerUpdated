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

                    var oneDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.OneDigit) + 1;

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
                    var twoDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.TwoDigit) + 1;

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
                    var threeDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.ThreeDigit) + 1;

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
                    var fourDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.FourDigit) + 1;

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
                    var fiveDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.FiveDigit) + 1;

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
                    var sixDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.SixDigit) + 1;

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


                else if (input.Digits == 7)
                {
                    var sevenDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.SevenDigit) + 1;

                    oneDigitString = Base36Converter.ConvertToBaseK(sevenDigit, 7);
                    var regNos1Check = dbcontext.RegistrationNoS7.FirstOrDefault(e => e.RegNo == oneDigitString);

                    while (regNos1Check != null)
                    {
                        sevenDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                        //oneDigit++;
                        //oneDigitString = oneDigit.ToString();
                        oneDigitString = Base36Converter.ConvertToBaseK(sevenDigit, 7);
                        regNos1Check = dbcontext.RegistrationNoS7.FirstOrDefault(e => e.RegNo == oneDigitString);
                        //currentRegistrationNo.OneDigit = oneDigitString;
                    }
                    var regNos7 = new RegistrationNoS7()
                    {
                        RegNo = oneDigitString,
                        userId = input.UserId,
                        PaidStatus = true,
                        TimeStamp = DateTime.Now.TimeOfDay
                    };
                    //oneDigit++;
                    //oneDigitString = oneDigit.ToString();
                    currentRegistrationNo.SevenDigit = oneDigitString;
                    dbcontext.RegistrationNoS7.Add(regNos7);
                    dbcontext.SaveChanges();


                }



                else if (input.Digits == 8)
                {
                    var eightDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.EightDigit) + 1;

                    oneDigitString = Base36Converter.ConvertToBaseK(eightDigit, 8);
                    var regNos1Check = dbcontext.RegistrationNoS8.FirstOrDefault(e => e.RegNo == oneDigitString);

                    while (regNos1Check != null)
                    {
                        eightDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                        //oneDigit++;
                        //oneDigitString = oneDigit.ToString();
                        oneDigitString = Base36Converter.ConvertToBaseK(eightDigit, 8);
                        regNos1Check = dbcontext.RegistrationNoS8.FirstOrDefault(e => e.RegNo == oneDigitString);
                        //currentRegistrationNo.OneDigit = oneDigitString;
                    }
                    var regNos8 = new RegistrationNoS8()
                    {
                        RegNo = oneDigitString,
                        userId = input.UserId,
                        PaidStatus = true,
                        TimeStamp = DateTime.Now.TimeOfDay
                    };
                    //oneDigit++;
                    //oneDigitString = oneDigit.ToString();
                    currentRegistrationNo.EightDigit = oneDigitString;
                    dbcontext.RegistrationNoS8.Add(regNos8);
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
        public List<GetOwnedRegistrationNumbersOutput> GetOwnedRegistrationNumbers(GetOwnedRegistrationNumbersInput input)
        {
            var dbcontext = new RegisterOwnersContext();
            var user = dbcontext.Users.Single(e => e.Id == input.UserId);
            var regNoS1List = user.RegistrationNoS1.
                   Select(e => new GetOwnedRegistrationNumbersOutput()
                   {
                       UserId = input.UserId,
                       ItemId = e.ItemId,
                       RegNo = e.RegNo
                   });
            var regNoS2List = user.RegistrationNoS2.
                   Select(e => new GetOwnedRegistrationNumbersOutput()
                   {
                       UserId = input.UserId,
                       ItemId = e.ItemId,
                       RegNo = e.RegNo
                   });
            var regNoS3List = user.RegistrationNoS3.
                   Select(e => new GetOwnedRegistrationNumbersOutput()
                   {
                       UserId = input.UserId,
                       ItemId = e.ItemId,
                       RegNo = e.RegNo
                   });
            var regNoS4List = user.RegistrationNoS4.
              Select(e => new GetOwnedRegistrationNumbersOutput()
              {
                  UserId = input.UserId,
                  ItemId = e.ItemId,
                  RegNo = e.RegNo
              });
            var regNoS5List = user.RegistrationNoS5.
              Select(e => new GetOwnedRegistrationNumbersOutput()
              {
                  UserId = input.UserId,
                  ItemId = e.ItemId,
                  RegNo = e.RegNo
              });
            var regNoS6List = user.RegistrationNoS6.
              Select(e => new GetOwnedRegistrationNumbersOutput()
              {
                  UserId = input.UserId,
                  ItemId = e.ItemId,
                  RegNo = e.RegNo
              });
            var regNoS7List = user.RegistrationNoS7.
              Select(e => new GetOwnedRegistrationNumbersOutput()
              {
                  UserId = input.UserId,
                  ItemId = e.ItemId,
                  RegNo = e.RegNo
              });
            var regNoS8List = user.RegistrationNoS8.
              Select(e => new GetOwnedRegistrationNumbersOutput()
              {
                  UserId = input.UserId,
                  ItemId = e.ItemId,
                  RegNo = e.RegNo
              });
            var totalRegNoList = new List<GetOwnedRegistrationNumbersOutput>();
            totalRegNoList.AddRange(regNoS1List);
            totalRegNoList.AddRange(regNoS2List);
            totalRegNoList.AddRange(regNoS3List);
            totalRegNoList.AddRange(regNoS4List);
            totalRegNoList.AddRange(regNoS5List);
            totalRegNoList.AddRange(regNoS6List);
            totalRegNoList.AddRange(regNoS7List);
            totalRegNoList.AddRange(regNoS8List);
            return totalRegNoList;
        }
    }
}