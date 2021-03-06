﻿using ContactManagementSystem26_10_17.RegisterOwnerDataBase;
using ContactManagementSystem26_10_17.Services.RegistrationNos.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

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

                var regNoId = -1;

                if (input.Digits == 1)
                {
                    var oneDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.OneDigit) + 1;
                    oneDigitString = Base36Converter.ConvertToBaseK(oneDigit, 1);
                    var regNos1Check = dbcontext.RegistrationNoS1.FirstOrDefault(e => e.RegNo == oneDigitString);
                    while (regNos1Check != null)
                    {
                        oneDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                        oneDigitString = Base36Converter.ConvertToBaseK(oneDigit, 1);
                        regNos1Check = dbcontext.RegistrationNoS1.FirstOrDefault(e => e.RegNo == oneDigitString);
                    }
                    var regNos1 = new RegistrationNoS1()
                    {
                        RegNo = oneDigitString,
                        userId = input.UserId,
                        PaidStatus = true,
                        TimeStamp = DateTime.Now.TimeOfDay
                    };
                    currentRegistrationNo.OneDigit = oneDigitString;
                    dbcontext.RegistrationNoS1.Add(regNos1);
                    dbcontext.SaveChanges();
                    var currRegNo = dbcontext.RegistrationNoS1.FirstOrDefault(e => e.RegNo == oneDigitString);
                    regNoId = currRegNo.Id;
                }


                else if (input.Digits == 2)
                {
                    var twoDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.TwoDigit) + 1;
                    oneDigitString = Base36Converter.ConvertToBaseK(twoDigit, 2);
                    var regNos1Check = dbcontext.RegistrationNoS2.FirstOrDefault(e => e.RegNo == oneDigitString);
                    while (regNos1Check != null)
                    {
                        twoDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                        oneDigitString = Base36Converter.ConvertToBaseK(twoDigit, 2);
                        regNos1Check = dbcontext.RegistrationNoS2.FirstOrDefault(e => e.RegNo == oneDigitString);
                    }
                    var regNos2 = new RegistrationNoS2()
                    {
                        RegNo = oneDigitString,
                        userId = input.UserId,
                        PaidStatus = true,
                        TimeStamp = DateTime.Now.TimeOfDay
                    };
                    currentRegistrationNo.TwoDigit = oneDigitString;
                    dbcontext.RegistrationNoS2.Add(regNos2);
                    dbcontext.SaveChanges();
                    var currRegNo = dbcontext.RegistrationNoS2.FirstOrDefault(e => e.RegNo == oneDigitString);
                    regNoId = currRegNo.Id;

                }
                else if (input.Digits == 3)
                {
                    var threeDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.ThreeDigit) + 1;
                    oneDigitString = Base36Converter.ConvertToBaseK(threeDigit, 3);
                    var regNos1Check = dbcontext.RegistrationNoS3.FirstOrDefault(e => e.RegNo == oneDigitString);
                    while (regNos1Check != null)
                    {
                        threeDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                        oneDigitString = Base36Converter.ConvertToBaseK(threeDigit, 3);
                        regNos1Check = dbcontext.RegistrationNoS3.FirstOrDefault(e => e.RegNo == oneDigitString);
                    }
                    var regNos3 = new RegistrationNoS3()
                    {
                        RegNo = oneDigitString,
                        userId = input.UserId,
                        PaidStatus = true,
                        TimeStamp = DateTime.Now.TimeOfDay
                    };
                    currentRegistrationNo.ThreeDigit = oneDigitString;
                    dbcontext.RegistrationNoS3.Add(regNos3);
                    dbcontext.SaveChanges();
                    var currRegNo = dbcontext.RegistrationNoS3.FirstOrDefault(e => e.RegNo == oneDigitString);
                    regNoId = currRegNo.Id;
                }

                else if (input.Digits == 4)
                {
                    var fourDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.FourDigit) + 1;
                    oneDigitString = Base36Converter.ConvertToBaseK(fourDigit, 4);
                    var regNos1Check = dbcontext.RegistrationNoS4.FirstOrDefault(e => e.RegNo == oneDigitString);
                    while (regNos1Check != null)
                    {
                        fourDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                        oneDigitString = Base36Converter.ConvertToBaseK(fourDigit, 4);
                        regNos1Check = dbcontext.RegistrationNoS4.FirstOrDefault(e => e.RegNo == oneDigitString);
                    }
                    var regNos4 = new RegistrationNoS4()
                    {
                        RegNo = oneDigitString,
                        userId = input.UserId,
                        PaidStatus = true,
                        TimeStamp = DateTime.Now.TimeOfDay
                    };
                    currentRegistrationNo.FourDigit = oneDigitString;
                    dbcontext.RegistrationNoS4.Add(regNos4);
                    dbcontext.SaveChanges();
                    var currRegNo = dbcontext.RegistrationNoS4.FirstOrDefault(e => e.RegNo == oneDigitString);
                    regNoId = currRegNo.Id;
                }



                else if (input.Digits == 5)
                {
                    var fiveDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.FiveDigit) + 1;
                    oneDigitString = Base36Converter.ConvertToBaseK(fiveDigit, 5);
                    var regNos1Check = dbcontext.RegistrationNoS5.FirstOrDefault(e => e.RegNo == oneDigitString);
                    while (regNos1Check != null)
                    {
                        fiveDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                        oneDigitString = Base36Converter.ConvertToBaseK(fiveDigit, 5);
                        regNos1Check = dbcontext.RegistrationNoS5.FirstOrDefault(e => e.RegNo == oneDigitString);
                    }
                    var regNos5 = new RegistrationNoS5()
                    {
                        RegNo = oneDigitString,
                        userId = input.UserId,
                        PaidStatus = true,
                        TimeStamp = DateTime.Now.TimeOfDay
                    };
                    currentRegistrationNo.FiveDigit = oneDigitString;
                    dbcontext.RegistrationNoS5.Add(regNos5);
                    dbcontext.SaveChanges();
                    var currRegNo = dbcontext.RegistrationNoS5.FirstOrDefault(e => e.RegNo == oneDigitString);
                    regNoId = currRegNo.Id;
                }
                else if (input.Digits == 6)
                {
                    var sixDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.SixDigit) + 1;
                    oneDigitString = Base36Converter.ConvertToBaseK(sixDigit, 6);
                    var regNos1Check = dbcontext.RegistrationNoS6.FirstOrDefault(e => e.RegNo == oneDigitString);
                    while (regNos1Check != null)
                    {
                        sixDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                        oneDigitString = Base36Converter.ConvertToBaseK(sixDigit, 6);
                        regNos1Check = dbcontext.RegistrationNoS6.FirstOrDefault(e => e.RegNo == oneDigitString);
                    }
                    var regNos6 = new RegistrationNoS6()
                    {
                        RegNo = oneDigitString,
                        userId = input.UserId,
                        PaidStatus = true,
                        TimeStamp = DateTime.Now.TimeOfDay
                    };
                    currentRegistrationNo.SixDigit = oneDigitString;
                    dbcontext.RegistrationNoS6.Add(regNos6);
                    dbcontext.SaveChanges();
                    var currRegNo = dbcontext.RegistrationNoS6.FirstOrDefault(e => e.RegNo == oneDigitString);
                    regNoId = currRegNo.Id;
                }


                else if (input.Digits == 7)
                {
                    var sevenDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.SevenDigit) + 1;
                    oneDigitString = Base36Converter.ConvertToBaseK(sevenDigit, 7);
                    var regNos1Check = dbcontext.RegistrationNoS7.FirstOrDefault(e => e.RegNo == oneDigitString);
                    while (regNos1Check != null)
                    {
                        sevenDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                        oneDigitString = Base36Converter.ConvertToBaseK(sevenDigit, 7);
                        regNos1Check = dbcontext.RegistrationNoS7.FirstOrDefault(e => e.RegNo == oneDigitString);
                    }
                    var regNos7 = new RegistrationNoS7()
                    {
                        RegNo = oneDigitString,
                        userId = input.UserId,
                        PaidStatus = true,
                        TimeStamp = DateTime.Now.TimeOfDay
                    };
                    currentRegistrationNo.SevenDigit = oneDigitString;
                    dbcontext.RegistrationNoS7.Add(regNos7);
                    dbcontext.SaveChanges();
                    var currRegNo = dbcontext.RegistrationNoS7.FirstOrDefault(e => e.RegNo == oneDigitString);
                    regNoId = currRegNo.Id;
                }
                else if (input.Digits == 8)
                {
                    var eightDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.EightDigit) + 1;
                    oneDigitString = Base36Converter.ConvertToBaseK(eightDigit, 8);
                    var regNos1Check = dbcontext.RegistrationNoS8.FirstOrDefault(e => e.RegNo == oneDigitString);
                    while (regNos1Check != null)
                    {
                        eightDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                        oneDigitString = Base36Converter.ConvertToBaseK(eightDigit, 8);
                        regNos1Check = dbcontext.RegistrationNoS8.FirstOrDefault(e => e.RegNo == oneDigitString);
                    }
                    var regNos8 = new RegistrationNoS8()
                    {
                        RegNo = oneDigitString,
                        userId = input.UserId,
                        PaidStatus = true,
                        TimeStamp = DateTime.Now.TimeOfDay
                    };
                    currentRegistrationNo.EightDigit = oneDigitString;
                    dbcontext.RegistrationNoS8.Add(regNos8);
                    dbcontext.SaveChanges();
                    var currRegNo = dbcontext.RegistrationNoS8.FirstOrDefault(e => e.RegNo == oneDigitString);
                    regNoId = currRegNo.Id;
                }
                return new
                {
                    IsGenerated = true,
                    RegNoId = regNoId,
                    RegNo = oneDigitString
                };
            }
            catch (Exception ex)
            {
                return new
                {
                    IsGenerated = false,
                    RegNoId = "-1",
                    RegNo = "-1"
                };
            }

        }
        public dynamic GetOwnedRegistrationNumbers(GetOwnedRegistrationNumbersInput input)
        {
            var dbcontext = new RegisterOwnersContext();
            var user = dbcontext.Users.Single(e => e.Id == input.UserId);
            var regNoS1List = user.RegistrationNoS1.
                   Select(e => new GetOwnedRegistrationNumbersOutput()
                   {
                       UserId = input.UserId,
                       ItemId = e.BridgeRegNoItemsS1.Count > 0 ? (e.BridgeRegNoItemsS1.FirstOrDefault(b => b.RegId == e.Id) != null ? e.BridgeRegNoItemsS1.FirstOrDefault(b => b.RegId == e.Id).ItemId : null) : null,
                       RegNo = e.RegNo,
                       RegNoId = e.Id,
                       PaidStatus = e.PaidStatus

                   });
            var regNoS2List = user.RegistrationNoS2.
                   Select(e => new GetOwnedRegistrationNumbersOutput()
                   {
                       UserId = input.UserId,
                       // ItemId = e.BridgeRegNoItemS2 != null ? e.BridgeRegNoItemS2.First().ItemId : null,
                       //ItemId = e.ItemId,
                       ItemId = e.BridgeRegNoItemS2.Count > 0 ? (e.BridgeRegNoItemS2.FirstOrDefault(b => b.RegId == e.Id) != null ? e.BridgeRegNoItemS2.FirstOrDefault(b => b.RegId == e.Id).ItemId : null) : null,
                       RegNo = e.RegNo,
                       RegNoId = e.Id,
                       PaidStatus = e.PaidStatus

                   });
            var regNoS3List = user.RegistrationNoS3.
                   Select(e => new GetOwnedRegistrationNumbersOutput()
                   {
                       UserId = input.UserId,
                       //ItemId = e.ItemId,
                       RegNo = e.RegNo,
                       ItemId = e.BridgeRegNoItemsS3.Count > 0 ? (e.BridgeRegNoItemsS3.FirstOrDefault(b => b.RegId == e.Id) != null ? e.BridgeRegNoItemsS3.FirstOrDefault(b => b.RegId == e.Id).ItemId : null) : null,
                       RegNoId = e.Id,
                       PaidStatus = e.PaidStatus
                   });
            var regNoS4List = user.RegistrationNoS4.
              Select(e => new GetOwnedRegistrationNumbersOutput()
              {
                  UserId = input.UserId,
                  //ItemId = e.ItemId,
                  RegNo = e.RegNo,
                  ItemId = e.BridgeRegNoItemsS4.Count > 0 ? (e.BridgeRegNoItemsS4.FirstOrDefault(b => b.RegId == e.Id) != null ? e.BridgeRegNoItemsS4.FirstOrDefault(b => b.RegId == e.Id).ItemId : null) : null,
                  RegNoId = e.Id,
                  PaidStatus = e.PaidStatus

              });
            var regNoS5List = user.RegistrationNoS5.
              Select(e => new GetOwnedRegistrationNumbersOutput()
              {
                  UserId = input.UserId,
                  //ItemId = e.ItemId,
                  RegNo = e.RegNo,
                  ItemId = e.BridgeRegNoItemsS5.Count > 0 ? (e.BridgeRegNoItemsS5.FirstOrDefault(b => b.RegId == e.Id) != null ? e.BridgeRegNoItemsS5.FirstOrDefault(b => b.RegId == e.Id).ItemId : null) : null,
                  RegNoId = e.Id,
                  PaidStatus = e.PaidStatus

              });
            var regNoS6List = user.RegistrationNoS6.
              Select(e => new GetOwnedRegistrationNumbersOutput()
              {
                  UserId = input.UserId,
                  //ItemId = e.ItemId,
                  RegNo = e.RegNo,
                  ItemId = e.BridgeRegNoItemsS6.Count > 0 ? (e.BridgeRegNoItemsS6.FirstOrDefault(b => b.RegId == e.Id) != null ? e.BridgeRegNoItemsS6.FirstOrDefault(b => b.RegId == e.Id).ItemId : null) : null,
                  RegNoId = e.Id,
                  PaidStatus = e.PaidStatus
              });
            var regNoS7List = user.RegistrationNoS7.
              Select(e => new GetOwnedRegistrationNumbersOutput()
              {
                  UserId = input.UserId,
                  //ItemId = e.ItemId,
                  RegNo = e.RegNo,
                  ItemId = e.BridgeRegNoItemsS7.Count > 0 ? (e.BridgeRegNoItemsS7.FirstOrDefault(b => b.RegId == e.Id) != null ? e.BridgeRegNoItemsS7.FirstOrDefault(b => b.RegId == e.Id).ItemId : null) : null,
                  RegNoId = e.Id,
                  PaidStatus = e.PaidStatus
              });
            var regNoS8List = user.RegistrationNoS8.
              Select(e => new GetOwnedRegistrationNumbersOutput()
              {
                  UserId = input.UserId,
                  //ItemId = e.ItemId,
                  RegNo = e.RegNo,
                  ItemId = e.BridgeRegNosItemS8.Count > 0 ? (e.BridgeRegNosItemS8.FirstOrDefault(b => b.RegId == e.Id) != null ? e.BridgeRegNosItemS8.FirstOrDefault(b => b.RegId == e.Id).ItemId : null) : null,
                  RegNoId = e.Id,
                  PaidStatus = e.PaidStatus
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
            return new
            {
                RegNosList = totalRegNoList
            };
            // return totalRegNoList;
        }
        public dynamic TransferRegistrationNumberToNewUser(TransferRegistrationNumberToNewUserInput input)
        {
            try
            {
                var dbcontext = new RegisterOwnersContext();
                var user = dbcontext.Users.SingleOrDefault(e => e.Email == input.NewUserEmail);
                if (user == null)
                {
                    return new
                    {
                        IsTransfered = false,
                        Message = "User Does Not Exist",
                        ErrorException = ""

                    };
                }
                else
                {
                    var regNoSize = input.RegNo.Length;
                    if (regNoSize == 1)
                    {
                        var regNo = dbcontext.RegistrationNoS1.Single(e => e.Id == input.RegNoId);
                        var bridgeTable = dbcontext.BridgeRegNoItemsS1.Where(e => e.RegId == regNo.Id).SingleOrDefault();
                        var itemHistory = new ItemOwnerHistory();
                        if (bridgeTable != null)
                        {
                            if (bridgeTable.Item != null)
                            {
                                itemHistory.ItemIdMain = bridgeTable.Item.Id;
                                itemHistory.Category = bridgeTable.Item.Category;
                                itemHistory.DateOfPurchase = bridgeTable.Item.DateofPurchase;
                                itemHistory.BoolItem = bridgeTable.Item.BoolItem;
                                itemHistory.BoolPlace = bridgeTable.Item.BoolPlace;
                                itemHistory.BoolAdress = bridgeTable.Item.BoolAdress;
                                itemHistory.BoolFirstName = bridgeTable.Item.BoolFirstName;
                                itemHistory.BoolLastName = bridgeTable.Item.BoolLastName;
                                itemHistory.BoolPhoneNo = bridgeTable.Item.BoolPhoneNo;
                                itemHistory.BoolEmail = bridgeTable.Item.BoolEmail;
                                itemHistory.Email = regNo.User.Email;
                                itemHistory.FirstName = regNo.User.FirstName;
                                itemHistory.LastName = regNo.User.LastName;
                                itemHistory.Adress = regNo.User.Adress;
                                itemHistory.Place = regNo.User.Place;
                                itemHistory.MobileNo = regNo.User.MobileNo;
                                itemHistory.RegNo = regNo.RegNo;
                                dbcontext.ItemOwnerHistories.Add(itemHistory);
                            }
                        }
                        regNo.userId = user.Id;
                        dbcontext.SaveChanges();
                    }
                    else if (regNoSize == 2)
                    {
                        var regNo = dbcontext.RegistrationNoS2.Single(e => e.Id == input.RegNoId);
                        var bridgeTable = dbcontext.BridgeRegNoItemS2.Where(e => e.RegId == regNo.Id).SingleOrDefault();
                        var itemHistory = new ItemOwnerHistory();
                        if (bridgeTable != null)
                        {
                            if (bridgeTable.Item != null)
                            {
                                itemHistory.ItemIdMain = bridgeTable.Item.Id;
                                itemHistory.Category = bridgeTable.Item.Category;
                                itemHistory.DateOfPurchase = bridgeTable.Item.DateofPurchase;
                                itemHistory.BoolItem = bridgeTable.Item.BoolItem;
                                itemHistory.BoolPlace = bridgeTable.Item.BoolPlace;
                                itemHistory.BoolAdress = bridgeTable.Item.BoolAdress;
                                itemHistory.BoolFirstName = bridgeTable.Item.BoolFirstName;
                                itemHistory.BoolLastName = bridgeTable.Item.BoolLastName;
                                itemHistory.BoolPhoneNo = bridgeTable.Item.BoolPhoneNo;
                                itemHistory.BoolEmail = bridgeTable.Item.BoolEmail;
                                itemHistory.Email = regNo.User.Email;
                                itemHistory.FirstName = regNo.User.FirstName;
                                itemHistory.LastName = regNo.User.LastName;
                                itemHistory.Adress = regNo.User.Adress;
                                itemHistory.Place = regNo.User.Place;
                                itemHistory.MobileNo = regNo.User.MobileNo;
                                itemHistory.RegNo = regNo.RegNo;
                                dbcontext.ItemOwnerHistories.Add(itemHistory);
                            }
                        }
                        regNo.userId = user.Id;
                        dbcontext.SaveChanges();
                    }
                    else if (regNoSize == 3)
                    {
                        var regNo = dbcontext.RegistrationNoS3.Single(e => e.Id == input.RegNoId);
                        var bridgeTable = dbcontext.BridgeRegNoItemsS3.Where(e => e.RegId == regNo.Id).SingleOrDefault();
                        var itemHistory = new ItemOwnerHistory();
                        if (bridgeTable != null)
                        {
                            if (bridgeTable.Item != null)
                            {
                                itemHistory.ItemIdMain = bridgeTable.Item.Id;
                                itemHistory.Category = bridgeTable.Item.Category;
                                itemHistory.DateOfPurchase = bridgeTable.Item.DateofPurchase;
                                itemHistory.BoolItem = bridgeTable.Item.BoolItem;
                                itemHistory.BoolPlace = bridgeTable.Item.BoolPlace;
                                itemHistory.BoolAdress = bridgeTable.Item.BoolAdress;
                                itemHistory.BoolFirstName = bridgeTable.Item.BoolFirstName;
                                itemHistory.BoolLastName = bridgeTable.Item.BoolLastName;
                                itemHistory.BoolPhoneNo = bridgeTable.Item.BoolPhoneNo;
                                itemHistory.BoolEmail = bridgeTable.Item.BoolEmail;
                                itemHistory.Email = regNo.User.Email;
                                itemHistory.FirstName = regNo.User.FirstName;
                                itemHistory.LastName = regNo.User.LastName;
                                itemHistory.Adress = regNo.User.Adress;
                                itemHistory.Place = regNo.User.Place;
                                itemHistory.MobileNo = regNo.User.MobileNo;
                                itemHistory.RegNo = regNo.RegNo;
                                dbcontext.ItemOwnerHistories.Add(itemHistory);
                            }
                        }

                        regNo.userId = user.Id;
                        dbcontext.SaveChanges();
                    }
                    else if (regNoSize == 4)
                    {
                        var regNo = dbcontext.RegistrationNoS4.Single(e => e.Id == input.RegNoId);
                        var bridgeTable = dbcontext.BridgeRegNoItemsS4.Where(e => e.RegId == regNo.Id).SingleOrDefault();
                        var itemHistory = new ItemOwnerHistory();
                        if (bridgeTable != null)
                        {
                            if (bridgeTable.Item != null)
                            {
                                itemHistory.ItemIdMain = bridgeTable.Item.Id;
                                itemHistory.Category = bridgeTable.Item.Category;
                                itemHistory.DateOfPurchase = bridgeTable.Item.DateofPurchase;
                                itemHistory.BoolItem = bridgeTable.Item.BoolItem;
                                itemHistory.BoolPlace = bridgeTable.Item.BoolPlace;
                                itemHistory.BoolAdress = bridgeTable.Item.BoolAdress;
                                itemHistory.BoolFirstName = bridgeTable.Item.BoolFirstName;
                                itemHistory.BoolLastName = bridgeTable.Item.BoolLastName;
                                itemHistory.BoolPhoneNo = bridgeTable.Item.BoolPhoneNo;
                                itemHistory.BoolEmail = bridgeTable.Item.BoolEmail;
                                itemHistory.Email = regNo.User.Email;
                                itemHistory.FirstName = regNo.User.FirstName;
                                itemHistory.LastName = regNo.User.LastName;
                                itemHistory.Adress = regNo.User.Adress;
                                itemHistory.Place = regNo.User.Place;
                                itemHistory.MobileNo = regNo.User.MobileNo;
                                itemHistory.RegNo = regNo.RegNo;
                                dbcontext.ItemOwnerHistories.Add(itemHistory);
                            }
                        }
                        regNo.userId = user.Id;
                        dbcontext.SaveChanges();
                    }
                    else if (regNoSize == 5)
                    {
                        var regNo = dbcontext.RegistrationNoS5.Single(e => e.Id == input.RegNoId);
                        var bridgeTable = dbcontext.BridgeRegNoItemsS5.Where(e => e.RegId == regNo.Id).SingleOrDefault();
                        var itemHistory = new ItemOwnerHistory();
                        if (bridgeTable != null)
                        {
                            if (bridgeTable.Item != null)
                            {
                                itemHistory.ItemIdMain = bridgeTable.Item.Id;
                                itemHistory.Category = bridgeTable.Item.Category;
                                itemHistory.DateOfPurchase = bridgeTable.Item.DateofPurchase;
                                itemHistory.BoolItem = bridgeTable.Item.BoolItem;
                                itemHistory.BoolPlace = bridgeTable.Item.BoolPlace;
                                itemHistory.BoolAdress = bridgeTable.Item.BoolAdress;
                                itemHistory.BoolFirstName = bridgeTable.Item.BoolFirstName;
                                itemHistory.BoolLastName = bridgeTable.Item.BoolLastName;
                                itemHistory.BoolPhoneNo = bridgeTable.Item.BoolPhoneNo;
                                itemHistory.BoolEmail = bridgeTable.Item.BoolEmail;
                                itemHistory.Email = regNo.User.Email;
                                itemHistory.FirstName = regNo.User.FirstName;
                                itemHistory.LastName = regNo.User.LastName;
                                itemHistory.Adress = regNo.User.Adress;
                                itemHistory.Place = regNo.User.Place;
                                itemHistory.MobileNo = regNo.User.MobileNo;
                                itemHistory.RegNo = regNo.RegNo;
                                dbcontext.ItemOwnerHistories.Add(itemHistory);
                            }
                        }
                        regNo.userId = user.Id;
                        dbcontext.SaveChanges();
                    }
                    else if (regNoSize == 6)
                    {
                        var regNo = dbcontext.RegistrationNoS6.Single(e => e.Id == input.RegNoId);
                        var bridgeTable = dbcontext.BridgeRegNoItemsS6.Where(e => e.RegId == regNo.Id).SingleOrDefault();
                        var itemHistory = new ItemOwnerHistory();
                        if (bridgeTable != null)
                        {
                            if (bridgeTable.Item != null)
                            {
                                itemHistory.ItemIdMain = bridgeTable.Item.Id;
                                itemHistory.Category = bridgeTable.Item.Category;
                                itemHistory.DateOfPurchase = bridgeTable.Item.DateofPurchase;
                                itemHistory.BoolItem = bridgeTable.Item.BoolItem;
                                itemHistory.BoolPlace = bridgeTable.Item.BoolPlace;
                                itemHistory.BoolAdress = bridgeTable.Item.BoolAdress;
                                itemHistory.BoolFirstName = bridgeTable.Item.BoolFirstName;
                                itemHistory.BoolLastName = bridgeTable.Item.BoolLastName;
                                itemHistory.BoolPhoneNo = bridgeTable.Item.BoolPhoneNo;
                                itemHistory.BoolEmail = bridgeTable.Item.BoolEmail;
                                itemHistory.Email = regNo.User.Email;
                                itemHistory.FirstName = regNo.User.FirstName;
                                itemHistory.LastName = regNo.User.LastName;
                                itemHistory.Adress = regNo.User.Adress;
                                itemHistory.Place = regNo.User.Place;
                                itemHistory.MobileNo = regNo.User.MobileNo;
                                itemHistory.RegNo = regNo.RegNo;
                                dbcontext.ItemOwnerHistories.Add(itemHistory);
                            }
                        }
                        regNo.userId = user.Id;
                        dbcontext.SaveChanges();
                    }
                    else if (regNoSize == 7)
                    {
                        var regNo = dbcontext.RegistrationNoS7.Single(e => e.Id == input.RegNoId);
                        var bridgeTable = dbcontext.BridgeRegNoItemsS7.Where(e => e.RegId == regNo.Id).SingleOrDefault();
                        var itemHistory = new ItemOwnerHistory();
                        if (bridgeTable != null)
                        {
                            if (bridgeTable.Item != null)
                            {
                                itemHistory.ItemIdMain = bridgeTable.Item.Id;
                                itemHistory.Category = bridgeTable.Item.Category;
                                itemHistory.DateOfPurchase = bridgeTable.Item.DateofPurchase;
                                itemHistory.BoolItem = bridgeTable.Item.BoolItem;
                                itemHistory.BoolPlace = bridgeTable.Item.BoolPlace;
                                itemHistory.BoolAdress = bridgeTable.Item.BoolAdress;
                                itemHistory.BoolFirstName = bridgeTable.Item.BoolFirstName;
                                itemHistory.BoolLastName = bridgeTable.Item.BoolLastName;
                                itemHistory.BoolPhoneNo = bridgeTable.Item.BoolPhoneNo;
                                itemHistory.BoolEmail = bridgeTable.Item.BoolEmail;
                                itemHistory.Email = regNo.User.Email;
                                itemHistory.FirstName = regNo.User.FirstName;
                                itemHistory.LastName = regNo.User.LastName;
                                itemHistory.Adress = regNo.User.Adress;
                                itemHistory.Place = regNo.User.Place;
                                itemHistory.MobileNo = regNo.User.MobileNo;
                                itemHistory.RegNo = regNo.RegNo;
                                dbcontext.ItemOwnerHistories.Add(itemHistory);
                            }
                        }
                        regNo.userId = user.Id;
                        dbcontext.SaveChanges();
                    }
                    else if (regNoSize == 8)
                    {
                        var regNo = dbcontext.RegistrationNoS8.Single(e => e.Id == input.RegNoId);
                        var bridgeTable = dbcontext.BridgeRegNosItemS8.Where(e => e.RegId == regNo.Id).SingleOrDefault();
                        var itemHistory = new ItemOwnerHistory();
                        if (bridgeTable != null)
                        {
                            if (bridgeTable.Item != null)
                            {
                                itemHistory.ItemIdMain = bridgeTable.Item.Id;
                                itemHistory.Category = bridgeTable.Item.Category;
                                itemHistory.DateOfPurchase = bridgeTable.Item.DateofPurchase;
                                itemHistory.BoolItem = bridgeTable.Item.BoolItem;
                                itemHistory.BoolPlace = bridgeTable.Item.BoolPlace;
                                itemHistory.BoolAdress = bridgeTable.Item.BoolAdress;
                                itemHistory.BoolFirstName = bridgeTable.Item.BoolFirstName;
                                itemHistory.BoolLastName = bridgeTable.Item.BoolLastName;
                                itemHistory.BoolPhoneNo = bridgeTable.Item.BoolPhoneNo;
                                itemHistory.BoolEmail = bridgeTable.Item.BoolEmail;
                                itemHistory.Email = regNo.User.Email;
                                itemHistory.FirstName = regNo.User.FirstName;
                                itemHistory.LastName = regNo.User.LastName;
                                itemHistory.Adress = regNo.User.Adress;
                                itemHistory.Place = regNo.User.Place;
                                itemHistory.MobileNo = regNo.User.MobileNo;
                                itemHistory.RegNo = regNo.RegNo;
                                dbcontext.ItemOwnerHistories.Add(itemHistory);
                            }
                        }
                        regNo.userId = user.Id;
                        dbcontext.SaveChanges();
                    }
                }
                return new
                {
                    IsTransfered = true,
                    Message = "Registration Number SuccessFully Transfered",
                };
            }
            catch (Exception ex)
            {
                return new
                {
                    IsTransfered = false,
                    Message = "",
                    ErrorException = ex

                };
            }
        }

        public dynamic GetManualRegistrationNumber(GetManualRegistrationNoInput input)
        {
            try
            {
                //catch { }
                RegisterOwnersContext dbcontext = new RegisterOwnersContext();
                var size = input.RegNo.Length;
                string regNoString = null;
                var regNoId = -1;
                if (size == 1)
                {
                    var regNo = dbcontext.RegistrationNoS1.FirstOrDefault(e => e.RegNo == input.RegNo);
                    if (regNo == null)
                    {
                        var regNos1 = new RegistrationNoS1()
                        {
                            RegNo = input.RegNo,
                            userId = input.UserId,
                            PaidStatus = false,
                            TimeStamp = DateTime.Now.TimeOfDay
                        };
                        regNoString = input.RegNo;
                        dbcontext.RegistrationNoS1.Add(regNos1);
                        dbcontext.SaveChanges();
                        regNoId = regNos1.Id;
                    }
                    else
                        return new
                        {
                            IsGenerated = false,
                            RegNoId = "-1",
                            RegNo = "-1"
                        };
                }
                else if (size == 2)
                {
                    var regNo = dbcontext.RegistrationNoS2.FirstOrDefault(e => e.RegNo == input.RegNo);
                    if (regNo == null)
                    {
                        var regNos2 = new RegistrationNoS2()
                        {
                            RegNo = input.RegNo,
                            userId = input.UserId,
                            PaidStatus = false,
                            TimeStamp = DateTime.Now.TimeOfDay
                        };
                        regNoString = input.RegNo;
                        dbcontext.RegistrationNoS2.Add(regNos2);
                        dbcontext.SaveChanges();
                        regNoId = regNos2.Id;

                    }
                    else
                        return new
                        {
                            IsGenerated = false,
                            RegNoId = "-1",
                            RegNo = "-1"
                        };
                }
                else if (size == 3)
                {
                    var regNo = dbcontext.RegistrationNoS3.FirstOrDefault(e => e.RegNo == input.RegNo);
                    if (regNo == null)
                    {
                        var regNos3 = new RegistrationNoS3()
                        {
                            RegNo = input.RegNo,
                            userId = input.UserId,
                            PaidStatus = false,
                            TimeStamp = DateTime.Now.TimeOfDay
                        };
                        regNoString = input.RegNo;
                        dbcontext.RegistrationNoS3.Add(regNos3);
                        dbcontext.SaveChanges();
                        regNoId = regNos3.Id;

                    }
                    else
                        return new
                        {
                            IsGenerated = false,
                            RegNoId = "-1",
                            RegNo = "-1"
                        };
                }
                else if (size == 4)
                {
                    var regNo = dbcontext.RegistrationNoS4.FirstOrDefault(e => e.RegNo == input.RegNo);
                    if (regNo == null)
                    {
                        var regNos4 = new RegistrationNoS4()
                        {
                            RegNo = input.RegNo,
                            userId = input.UserId,
                            PaidStatus = false,
                            TimeStamp = DateTime.Now.TimeOfDay
                        };
                        regNoString = input.RegNo;
                        dbcontext.RegistrationNoS4.Add(regNos4);
                        dbcontext.SaveChanges();
                        regNoId = regNos4.Id;

                    }
                    else
                        return new
                        {
                            IsGenerated = false,
                            RegNoId = "-1",
                            RegNo = "-1"
                        };
                }
                else if (size == 5)
                {
                    var regNo = dbcontext.RegistrationNoS5.FirstOrDefault(e => e.RegNo == input.RegNo);
                    if (regNo == null)
                    {
                        var regNos5 = new RegistrationNoS5()
                        {
                            RegNo = input.RegNo,
                            userId = input.UserId,
                            PaidStatus = false,
                            TimeStamp = DateTime.Now.TimeOfDay
                        };
                        regNoString = input.RegNo;
                        dbcontext.RegistrationNoS5.Add(regNos5);
                        dbcontext.SaveChanges();
                        regNoId = regNos5.Id;

                    }
                    else
                        return new
                        {
                            IsGenerated = false,
                            RegNoId = "-1",
                            RegNo = "-1"
                        };
                }
                else if (size == 6)
                {
                    var regNo = dbcontext.RegistrationNoS6.FirstOrDefault(e => e.RegNo == input.RegNo);
                    if (regNo == null)
                    {
                        var regNos6 = new RegistrationNoS6()
                        {
                            RegNo = input.RegNo,
                            userId = input.UserId,
                            PaidStatus = false,
                            TimeStamp = DateTime.Now.TimeOfDay
                        };
                        regNoString = input.RegNo;
                        dbcontext.RegistrationNoS6.Add(regNos6);
                        dbcontext.SaveChanges();
                        regNoId = regNos6.Id;

                    }
                    else
                        return new
                        {
                            IsGenerated = false,
                            RegNoId = "-1",
                            RegNo = "-1"
                        };
                }
                else if (size == 7)
                {
                    var regNo = dbcontext.RegistrationNoS7.FirstOrDefault(e => e.RegNo == input.RegNo);
                    if (regNo == null)
                    {
                        var regNos7 = new RegistrationNoS7()
                        {
                            RegNo = input.RegNo,
                            userId = input.UserId,
                            PaidStatus = false,
                            TimeStamp = DateTime.Now.TimeOfDay
                        };
                        regNoString = input.RegNo;
                        dbcontext.RegistrationNoS7.Add(regNos7);
                        dbcontext.SaveChanges();
                        regNoId = regNos7.Id;

                    }
                    else
                        return new
                        {
                            IsGenerated = false,
                            RegNoId = "-1",
                            RegNo = "-1"
                        };
                }
                else if (size == 8)
                {
                    var regNo = dbcontext.RegistrationNoS8.FirstOrDefault(e => e.RegNo == input.RegNo);
                    if (regNo == null)
                    {
                        var regNos8 = new RegistrationNoS8()
                        {
                            RegNo = input.RegNo,
                            userId = input.UserId,
                            PaidStatus = false,
                            TimeStamp = DateTime.Now.TimeOfDay
                        };
                        regNoString = input.RegNo;
                        dbcontext.RegistrationNoS8.Add(regNos8);
                        dbcontext.SaveChanges();
                        regNoId = regNos8.Id;

                    }
                    else
                        return new
                        {
                            IsGenerated = false,
                            RegNoId = "-1",
                            RegNo = "-1"
                        };
                }
                return new
                {
                    IsGenerated = true,
                    RegNoId = regNoId,
                    RegNo = regNoString
                };
            }
            catch (Exception ex)
            {
                return new
                {
                    IsGenerated = false,
                    RegNoId = "-1",
                    RegNo = "-1"
                };
            }
        }

        public dynamic GetMultipleAutoRegistrationNo(GetMultipleRegistrationNoInput [] inputt)
        {
            GetMultipleRegistrationNoInput input = inputt[0];

            try
            {

                RegisterOwnersContext dbcontext = new RegisterOwnersContext();
                var currentRegistrationNo = dbcontext.CurrentRegistrationNoes.First();
                string oneDigitString = null;
                List<MultipleAutoRegNoOutPut> multipleAutoRegistrationNoList = new List<MultipleAutoRegNoOutPut>();

                var regNoId = -1;
                for (int i = 0; i < input.Quantity;)
                {
                    if (input.Digits == 1)
                    {
                        var oneDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.OneDigit) + 1;
                        oneDigitString = Base36Converter.ConvertToBaseK(oneDigit, 1);
                        var regNos1Check = dbcontext.RegistrationNoS1.FirstOrDefault(e => e.RegNo == oneDigitString);
                        while (regNos1Check != null)
                        {
                            oneDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                            oneDigitString = Base36Converter.ConvertToBaseK(oneDigit, 1);
                            regNos1Check = dbcontext.RegistrationNoS1.FirstOrDefault(e => e.RegNo == oneDigitString);
                        }
                        var regNos1 = new RegistrationNoS1()
                        {
                            RegNo = oneDigitString,
                            userId = input.UserId,
                            PaidStatus = true,
                            TimeStamp = DateTime.Now.TimeOfDay
                        };
                        currentRegistrationNo.OneDigit = oneDigitString;
                        dbcontext.RegistrationNoS1.Add(regNos1);
                        dbcontext.SaveChanges();
                        var currRegNo = dbcontext.RegistrationNoS1.FirstOrDefault(e => e.RegNo == oneDigitString);
                        regNoId = currRegNo.Id;
                        multipleAutoRegistrationNoList.Add(new MultipleAutoRegNoOutPut()
                        {
                            RegNo = oneDigitString,
                            RegNoId = regNoId,
                            IsGenerated = true
                        });
                        i++;
                    }


                    else if (input.Digits == 2)
                    {
                        var twoDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.TwoDigit) + 1;
                        oneDigitString = Base36Converter.ConvertToBaseK(twoDigit, 2);
                        var regNos1Check = dbcontext.RegistrationNoS2.FirstOrDefault(e => e.RegNo == oneDigitString);
                        while (regNos1Check != null)
                        {
                            twoDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                            oneDigitString = Base36Converter.ConvertToBaseK(twoDigit, 2);
                            regNos1Check = dbcontext.RegistrationNoS2.FirstOrDefault(e => e.RegNo == oneDigitString);
                        }
                        var regNos2 = new RegistrationNoS2()
                        {
                            RegNo = oneDigitString,
                            userId = input.UserId,
                            PaidStatus = true,
                            TimeStamp = DateTime.Now.TimeOfDay
                        };
                        currentRegistrationNo.TwoDigit = oneDigitString;
                        dbcontext.RegistrationNoS2.Add(regNos2);
                        dbcontext.SaveChanges();
                        var currRegNo = dbcontext.RegistrationNoS2.FirstOrDefault(e => e.RegNo == oneDigitString);
                        regNoId = currRegNo.Id;
                        multipleAutoRegistrationNoList.Add(new MultipleAutoRegNoOutPut()
                        {
                            RegNo = oneDigitString,
                            RegNoId = regNoId,
                            IsGenerated = true
                        });
                        i++;
                    }
                    else if (input.Digits == 3)
                    {
                        var threeDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.ThreeDigit) + 1;
                        oneDigitString = Base36Converter.ConvertToBaseK(threeDigit, 3);
                        var regNos1Check = dbcontext.RegistrationNoS3.FirstOrDefault(e => e.RegNo == oneDigitString);
                        while (regNos1Check != null)
                        {
                            threeDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                            oneDigitString = Base36Converter.ConvertToBaseK(threeDigit, 3);
                            regNos1Check = dbcontext.RegistrationNoS3.FirstOrDefault(e => e.RegNo == oneDigitString);
                        }
                        var regNos3 = new RegistrationNoS3()
                        {
                            RegNo = oneDigitString,
                            userId = input.UserId,
                            PaidStatus = true,
                            TimeStamp = DateTime.Now.TimeOfDay
                        };
                        currentRegistrationNo.ThreeDigit = oneDigitString;
                        dbcontext.RegistrationNoS3.Add(regNos3);
                        dbcontext.SaveChanges();
                        var currRegNo = dbcontext.RegistrationNoS3.FirstOrDefault(e => e.RegNo == oneDigitString);
                        regNoId = currRegNo.Id;
                        multipleAutoRegistrationNoList.Add(new MultipleAutoRegNoOutPut()
                        {
                            RegNo = oneDigitString,
                            RegNoId = regNoId,
                            IsGenerated = true
                        });
                        i++;
                    }

                    else if (input.Digits == 4)
                    {
                        var fourDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.FourDigit) + 1;
                        oneDigitString = Base36Converter.ConvertToBaseK(fourDigit, 4);
                        var regNos1Check = dbcontext.RegistrationNoS4.FirstOrDefault(e => e.RegNo == oneDigitString);
                        while (regNos1Check != null)
                        {
                            fourDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                            oneDigitString = Base36Converter.ConvertToBaseK(fourDigit, 4);
                            regNos1Check = dbcontext.RegistrationNoS4.FirstOrDefault(e => e.RegNo == oneDigitString);
                        }
                        var regNos4 = new RegistrationNoS4()
                        {
                            RegNo = oneDigitString,
                            userId = input.UserId,
                            PaidStatus = true,
                            TimeStamp = DateTime.Now.TimeOfDay
                        };
                        currentRegistrationNo.FourDigit = oneDigitString;
                        dbcontext.RegistrationNoS4.Add(regNos4);
                        dbcontext.SaveChanges();
                        var currRegNo = dbcontext.RegistrationNoS4.FirstOrDefault(e => e.RegNo == oneDigitString);
                        regNoId = currRegNo.Id;
                        multipleAutoRegistrationNoList.Add(new MultipleAutoRegNoOutPut()
                        {
                            RegNo = oneDigitString,
                            RegNoId = regNoId,
                            IsGenerated = true
                        });
                        i++;
                    }
                    else if (input.Digits == 5)
                    {
                        var fiveDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.FiveDigit) + 1;
                        oneDigitString = Base36Converter.ConvertToBaseK(fiveDigit, 5);
                        var regNos1Check = dbcontext.RegistrationNoS5.FirstOrDefault(e => e.RegNo == oneDigitString);
                        while (regNos1Check != null)
                        {
                            fiveDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                            oneDigitString = Base36Converter.ConvertToBaseK(fiveDigit, 5);
                            regNos1Check = dbcontext.RegistrationNoS5.FirstOrDefault(e => e.RegNo == oneDigitString);
                        }
                        var regNos5 = new RegistrationNoS5()
                        {
                            RegNo = oneDigitString,
                            userId = input.UserId,
                            PaidStatus = true,
                            TimeStamp = DateTime.Now.TimeOfDay
                        };
                        currentRegistrationNo.FiveDigit = oneDigitString;
                        dbcontext.RegistrationNoS5.Add(regNos5);
                        dbcontext.SaveChanges();
                        var currRegNo = dbcontext.RegistrationNoS5.FirstOrDefault(e => e.RegNo == oneDigitString);
                        regNoId = currRegNo.Id;
                        multipleAutoRegistrationNoList.Add(new MultipleAutoRegNoOutPut()
                        {
                            RegNo = oneDigitString,
                            RegNoId = regNoId,
                            IsGenerated = true
                        });
                        i++;
                    }
                    else if (input.Digits == 6)
                    {
                        var sixDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.SixDigit) + 1;
                        oneDigitString = Base36Converter.ConvertToBaseK(sixDigit, 6);
                        var regNos1Check = dbcontext.RegistrationNoS6.FirstOrDefault(e => e.RegNo == oneDigitString);
                        while (regNos1Check != null)
                        {
                            sixDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                            oneDigitString = Base36Converter.ConvertToBaseK(sixDigit, 6);
                            regNos1Check = dbcontext.RegistrationNoS6.FirstOrDefault(e => e.RegNo == oneDigitString);
                        }
                        var regNos6 = new RegistrationNoS6()
                        {
                            RegNo = oneDigitString,
                            userId = input.UserId,
                            PaidStatus = true,
                            TimeStamp = DateTime.Now.TimeOfDay
                        };
                        currentRegistrationNo.SixDigit = oneDigitString;
                        dbcontext.RegistrationNoS6.Add(regNos6);
                        dbcontext.SaveChanges();
                        var currRegNo = dbcontext.RegistrationNoS6.FirstOrDefault(e => e.RegNo == oneDigitString);
                        regNoId = currRegNo.Id;
                        multipleAutoRegistrationNoList.Add(new MultipleAutoRegNoOutPut()
                        {
                            RegNo = oneDigitString,
                            RegNoId = regNoId,
                            IsGenerated = true
                        });
                        i++;
                    }


                    else if (input.Digits == 7)
                    {
                        var sevenDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.SevenDigit) + 1;
                        oneDigitString = Base36Converter.ConvertToBaseK(sevenDigit, 7);
                        var regNos1Check = dbcontext.RegistrationNoS7.FirstOrDefault(e => e.RegNo == oneDigitString);
                        while (regNos1Check != null)
                        {
                            sevenDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                            oneDigitString = Base36Converter.ConvertToBaseK(sevenDigit, 7);
                            regNos1Check = dbcontext.RegistrationNoS7.FirstOrDefault(e => e.RegNo == oneDigitString);
                        }
                        var regNos7 = new RegistrationNoS7()
                        {
                            RegNo = oneDigitString,
                            userId = input.UserId,
                            PaidStatus = true,
                            TimeStamp = DateTime.Now.TimeOfDay
                        };
                        currentRegistrationNo.SevenDigit = oneDigitString;
                        dbcontext.RegistrationNoS7.Add(regNos7);
                        dbcontext.SaveChanges();
                        var currRegNo = dbcontext.RegistrationNoS7.FirstOrDefault(e => e.RegNo == oneDigitString);
                        regNoId = currRegNo.Id;
                        multipleAutoRegistrationNoList.Add(new MultipleAutoRegNoOutPut()
                        {
                            RegNo = oneDigitString,
                            RegNoId = regNoId,
                            IsGenerated = true
                        });
                        i++;
                    }
                    else if (input.Digits == 8)
                    {
                        var eightDigit = Base36Converter.ConvertToBase10(currentRegistrationNo.EightDigit) + 1;
                        oneDigitString = Base36Converter.ConvertToBaseK(eightDigit, 8);
                        var regNos1Check = dbcontext.RegistrationNoS8.FirstOrDefault(e => e.RegNo == oneDigitString);
                        while (regNos1Check != null)
                        {
                            eightDigit = Base36Converter.ConvertToBase10(oneDigitString) + 1;
                            oneDigitString = Base36Converter.ConvertToBaseK(eightDigit, 8);
                            regNos1Check = dbcontext.RegistrationNoS8.FirstOrDefault(e => e.RegNo == oneDigitString);
                        }
                        var regNos8 = new RegistrationNoS8()
                        {
                            RegNo = oneDigitString,
                            userId = input.UserId,
                            PaidStatus = true,
                            TimeStamp = DateTime.Now.TimeOfDay
                        };
                        currentRegistrationNo.EightDigit = oneDigitString;
                        dbcontext.RegistrationNoS8.Add(regNos8);
                        dbcontext.SaveChanges();
                        var currRegNo = dbcontext.RegistrationNoS8.FirstOrDefault(e => e.RegNo == oneDigitString);
                        regNoId = currRegNo.Id;
                        multipleAutoRegistrationNoList.Add(new MultipleAutoRegNoOutPut()
                        {
                            RegNo = oneDigitString,
                            RegNoId = regNoId,
                            IsGenerated = true
                        });
                        i++;
                    }
                }

                return multipleAutoRegistrationNoList;


            }
            catch (Exception ex)
            {
                return new
                {
                    IsGenerated = false,
                    RegNoId = "-1",
                    RegNo = "-1"
                };
            }

        }
    }

    public class MultipleAutoRegNoOutPut
    {
        public int RegNoId { get; set; }
        public string RegNo { get; set; }

        public bool IsGenerated { get; set; }
    }
}