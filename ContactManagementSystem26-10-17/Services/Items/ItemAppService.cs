using AutoMapper;
using ContactManagementSystem26_10_17.Controllers;
using ContactManagementSystem26_10_17.RegisterOwnerDataBase;
using ContactManagementSystem26_10_17.Services.Items.Dtos;
using System;
using System.Linq;
namespace ContactManagementSystem26_10_17.Services.Items
{
    public class ItemAppService
    {
        public dynamic RegisterItem(ItemDto input)
        {
            try
            {

                RegisterOwnersContext dbcontext = new RegisterOwnersContext();
                var item = Mapper.Map<ItemDto, Item>(input);
                var itemAdded = dbcontext.Items.Add(item);

                // Adding Data In BridgeTable
                if (input.RegNoSize == 1)
                {
                    dbcontext.BridgeRegNoItemsS1.Add(new BridgeRegNoItemsS1()
                    {
                        RegId = input.RegNoId,
                        ItemId = itemAdded.Id,
                    });
                }

                else if (input.RegNoSize == 2)
                {
                    dbcontext.BridgeRegNoItemS2.Add(new BridgeRegNoItemS2()
                    {
                        RegId = input.RegNoId,
                        ItemId = itemAdded.Id,
                    });
                }

                else if (input.RegNoSize == 3)
                {
                    dbcontext.BridgeRegNoItemsS3.Add(new BridgeRegNoItemsS3()
                    {
                        RegId = input.RegNoId,
                        ItemId = itemAdded.Id,
                    });
                }

                else if (input.RegNoSize == 4)
                {
                    dbcontext.BridgeRegNoItemsS4.Add(new BridgeRegNoItemsS4()
                    {
                        RegId = input.RegNoId,
                        ItemId = itemAdded.Id,
                    });
                }

                else if (input.RegNoSize == 5)
                {
                    dbcontext.BridgeRegNoItemsS5.Add(new BridgeRegNoItemsS5()
                    {
                        RegId = input.RegNoId,
                        ItemId = itemAdded.Id,
                    });
                }

                else if (input.RegNoSize == 6)
                {
                    dbcontext.BridgeRegNoItemsS6.Add(new BridgeRegNoItemsS6()
                    {
                        RegId = input.RegNoId,
                        ItemId = itemAdded.Id,
                    });
                }

                else if (input.RegNoSize == 7)
                {
                    dbcontext.BridgeRegNoItemsS7.Add(new BridgeRegNoItemsS7()
                    {
                        RegId = input.RegNoId,
                        ItemId = itemAdded.Id,
                    });
                }

                else if (input.RegNoSize == 8)
                {
                    dbcontext.BridgeRegNosItemS8.Add(new BridgeRegNosItemS8()
                    {
                        RegId = input.RegNoId,
                        ItemId = itemAdded.Id,
                    });
                }

                dbcontext.SaveChanges();

                return new
                {
                    IsItemRegistered = true,
                    ItemId = itemAdded.Id
                };
            }
            catch (Exception ex)
            {
                return new
                {
                    IsItemRegistered = false,
                    ErrorException = ex
                };

            }

        }

        public dynamic GetItemDetailsUsingRegistrationNo(GetItemDetailsUsingRegistrationNoInput input)
        {
            RegisterOwnersContext dbcontext = new RegisterOwnersContext();

            Item item = null;
            //var currentRegistrationNo = dbcontext.CurrentRegistrationNoes.First();
            if (input.RegNo.Length == 1)
            {
                var regNo = dbcontext.RegistrationNoS1.SingleOrDefault(e => e.RegNo == input.RegNo);
                var itemToCheck = regNo.BridgeRegNoItemsS1.FirstOrDefault();
                if (itemToCheck != null)
                {
                    item = dbcontext.Items.SingleOrDefault(e => e.Id == itemToCheck.ItemId);
                }
                return new
                {
                    UserId = regNo.userId,
                    Item = item != null ? Mapper.Map<Item, ItemDto>(item) : null,
                    User = Mapper.Map<User, UserDto>(regNo.User),
                };
            }
            else if (input.RegNo.Length == 2)
            {
                var regNo = dbcontext.RegistrationNoS2.SingleOrDefault(e => e.RegNo == input.RegNo);
                var itemToCheck = regNo.BridgeRegNoItemS2.FirstOrDefault();
                if (itemToCheck != null)
                {
                    item = dbcontext.Items.SingleOrDefault(e => e.Id == itemToCheck.ItemId);
                }
                return new
                {
                    UserId = regNo.userId,
                    Item = item != null ? Mapper.Map<Item, ItemDto>(item) : null,
                    User = Mapper.Map<User, UserDto>(regNo.User),
                };
            }
            else if (input.RegNo.Length == 3)
            {
                var regNo = dbcontext.RegistrationNoS3.SingleOrDefault(e => e.RegNo == input.RegNo);
                var itemToCheck = regNo.BridgeRegNoItemsS3.FirstOrDefault();
                if (itemToCheck != null)
                {
                    item = dbcontext.Items.SingleOrDefault(e => e.Id == itemToCheck.ItemId);
                }
                return new
                {
                    UserId = regNo.userId,
                    Item = item != null ? Mapper.Map<Item, ItemDto>(item) : null,
                    User = Mapper.Map<User, UserDto>(regNo.User),
                };
            }
            else if (input.RegNo.Length == 4)
            {
                var regNo = dbcontext.RegistrationNoS4.SingleOrDefault(e => e.RegNo == input.RegNo);
                var itemToCheck = regNo.BridgeRegNoItemsS4.FirstOrDefault();
                if (itemToCheck != null)
                {
                    item = dbcontext.Items.SingleOrDefault(e => e.Id == itemToCheck.ItemId);
                }
                return new
                {
                    UserId = regNo.userId,
                    Item = item != null ? Mapper.Map<Item, ItemDto>(item) : null,
                    User = Mapper.Map<User, UserDto>(regNo.User),
                };
            }
            else if (input.RegNo.Length == 5)
            {
                var regNo = dbcontext.RegistrationNoS5.SingleOrDefault(e => e.RegNo == input.RegNo);
                var itemToCheck = regNo.BridgeRegNoItemsS5.FirstOrDefault();
                if (itemToCheck != null)
                {
                    item = dbcontext.Items.SingleOrDefault(e => e.Id == itemToCheck.ItemId);
                }
                return new
                {
                    UserId = regNo.userId,
                    Item = item != null ? Mapper.Map<Item, ItemDto>(item) : null,
                    User = Mapper.Map<User, UserDto>(regNo.User),
                };
            }
            else if (input.RegNo.Length == 6)
            {
                var regNo = dbcontext.RegistrationNoS6.SingleOrDefault(e => e.RegNo == input.RegNo);
                var itemToCheck = regNo.BridgeRegNoItemsS6.FirstOrDefault();
                if (itemToCheck != null)
                {
                    item = dbcontext.Items.SingleOrDefault(e => e.Id == itemToCheck.ItemId);
                }
                return new
                {
                    UserId = regNo.userId,
                    Item = item != null ? Mapper.Map<Item, ItemDto>(item) : null,
                    User = Mapper.Map<User, UserDto>(regNo.User),
                };
            }
            else if (input.RegNo.Length == 7)
            {
                var regNo = dbcontext.RegistrationNoS7.SingleOrDefault(e => e.RegNo == input.RegNo);
                var itemToCheck = regNo.BridgeRegNoItemsS7.FirstOrDefault();
                if (itemToCheck != null)
                {
                    item = dbcontext.Items.SingleOrDefault(e => e.Id == itemToCheck.ItemId);
                }
                return new
                {
                    UserId = regNo.userId,
                    Item = item != null ? Mapper.Map<Item, ItemDto>(item) : null,
                    User = Mapper.Map<User, UserDto>(regNo.User),
                };
            }
            else if (input.RegNo.Length == 8)
            {
                var regNo = dbcontext.RegistrationNoS8.SingleOrDefault(e => e.RegNo == input.RegNo);
                var itemToCheck = regNo.BridgeRegNosItemS8.FirstOrDefault();
                if (itemToCheck != null)
                {
                    item = dbcontext.Items.SingleOrDefault(e => e.Id == itemToCheck.ItemId);
                }
                return new
                {
                    UserId = regNo.userId,
                    Item = item != null ? Mapper.Map<Item, ItemDto>(item) : null,
                    User = Mapper.Map<User, UserDto>(regNo.User),
                };
            }
            return null;

        }
        public dynamic GetItemDetailsUsingSerialNo(GetItemDetailsUsingSerialNoInput [] input)
        {
            RegisterOwnersContext dbcontext = new RegisterOwnersContext();
            var inputSerialNo = input[0].SerialNo;
            var listOfData = dbcontext.Items.Where(e => e.ItemSerial == inputSerialNo).Select(
                e => new GetItemDetailsUsingSerialNoOutput()
                {
                    Item = e,
                    UserId = null,
                    User = null
                }
             ).ToList();
            listOfData.ForEach(e =>
            {
                if (e.Item.BridgeRegNoItemsS1.Count > 0)
                {
                    var user = e.Item.BridgeRegNoItemsS1.First().RegistrationNoS1.User;
                    //e.User = Mapper.Map<User, UserDto>(user);
                    e.User = dbcontext.Users.AsNoTracking().Single(u => u.Id == user.Id);
                    e.UserId = user.Id;
                }
                else if (e.Item.BridgeRegNoItemS2.Count > 0)
                {
                    var user = e.Item.BridgeRegNoItemS2.First().RegistrationNoS2.User;
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = user;
                    e.User = dbcontext.Users.AsNoTracking().Single(u => u.Id == user.Id);
                    e.UserId = user.Id;
                }
                else if (e.Item.BridgeRegNoItemsS3.Count > 0)
                {
                    var user = e.Item.BridgeRegNoItemsS3.First().RegistrationNoS3.User;
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = user;
                    e.User = dbcontext.Users.AsNoTracking().Single(u => u.Id == user.Id);
                    e.UserId = user.Id;
                }
                else if (e.Item.BridgeRegNoItemsS4.Count > 0)
                {
                    var user = e.Item.BridgeRegNoItemsS4.First().RegistrationNoS4.User;
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = user;
                    e.User = dbcontext.Users.AsNoTracking().Single(u => u.Id == user.Id);
                    e.UserId = user.Id;
                }
                else if (e.Item.BridgeRegNoItemsS5.Count > 0)
                {
                    var user = e.Item.BridgeRegNoItemsS5.First().RegistrationNoS5.User;
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = user;
                    e.User = dbcontext.Users.AsNoTracking().Single(u => u.Id == user.Id);
                    e.UserId = user.Id;
                }
                else if (e.Item.BridgeRegNoItemsS6.Count > 0)
                {
                    var user = e.Item.BridgeRegNoItemsS6.First().RegistrationNoS6.User;
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = user;
                    e.User = dbcontext.Users.AsNoTracking().Single(u => u.Id == user.Id);
                    e.UserId = user.Id;
                }
                else if (e.Item.BridgeRegNoItemsS7.Count > 0)
                {
                    var user = e.Item.BridgeRegNoItemsS7.First().RegistrationNoS7.User;
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = user;
                    e.User = dbcontext.Users.AsNoTracking().Single(u => u.Id == user.Id);
                    e.UserId = user.Id;
                }
                else if (e.Item.BridgeRegNosItemS8.Count > 0)
                {
                    var user = e.Item.BridgeRegNosItemS8.First().RegistrationNoS8.User;
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = user;
                    e.User = dbcontext.Users.AsNoTracking().Single(u => u.Id == user.Id);
                    e.UserId = user.Id;
                }
            });
            return listOfData.Select(e => new
            {
                UserId = e.UserId,
                UserDto = Mapper.Map<User, UserDto>(e.User),
                Item = Mapper.Map<Item, ItemDto>(e.Item)

            }).ToList();

        }

        public dynamic GetItemDetailsUsingByItemId(GetItemDetailsUsingItemIdInput [] input)
        {
            RegisterOwnersContext dbcontext = new RegisterOwnersContext();
            var inputItemId = input[0].ItemId;
            var listOfData = dbcontext.Items.Where(e => e.ItemId == inputItemId).Select(
                e => new GetItemDetailsUsingSerialNoOutput()
                {
                    Item = e,
                    UserId = null,
                    User = null
                }
             ).ToList();
            listOfData.ForEach(e =>
            {
                if (e.Item.BridgeRegNoItemsS1.Count > 0)
                {
                    var user = e.Item.BridgeRegNoItemsS1.First().RegistrationNoS1.User;
                    //e.User = Mapper.Map<User, UserDto>(user);
                    e.User = dbcontext.Users.AsNoTracking().Single(u => u.Id == user.Id);
                    e.UserId = user.Id;
                }
                else if (e.Item.BridgeRegNoItemS2.Count > 0)
                {
                    var user = e.Item.BridgeRegNoItemS2.First().RegistrationNoS2.User;
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = user;
                    e.User = dbcontext.Users.AsNoTracking().Single(u => u.Id == user.Id);
                    e.UserId = user.Id;
                }
                else if (e.Item.BridgeRegNoItemsS3.Count > 0)
                {
                    var user = e.Item.BridgeRegNoItemsS3.First().RegistrationNoS3.User;
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = user;
                    e.User = dbcontext.Users.AsNoTracking().Single(u => u.Id == user.Id);
                    e.UserId = user.Id;
                }
                else if (e.Item.BridgeRegNoItemsS4.Count > 0)
                {
                    var user = e.Item.BridgeRegNoItemsS4.First().RegistrationNoS4.User;
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = user;
                    e.User = dbcontext.Users.AsNoTracking().Single(u => u.Id == user.Id);
                    e.UserId = user.Id;
                }
                else if (e.Item.BridgeRegNoItemsS5.Count > 0)
                {
                    var user = e.Item.BridgeRegNoItemsS5.First().RegistrationNoS5.User;
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = user;
                    e.User = dbcontext.Users.AsNoTracking().Single(u => u.Id == user.Id);
                    e.UserId = user.Id;
                }
                else if (e.Item.BridgeRegNoItemsS6.Count > 0)
                {
                    var user = e.Item.BridgeRegNoItemsS6.First().RegistrationNoS6.User;
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = user;
                    e.User = dbcontext.Users.AsNoTracking().Single(u => u.Id == user.Id);
                    e.UserId = user.Id;
                }
                else if (e.Item.BridgeRegNoItemsS7.Count > 0)
                {
                    var user = e.Item.BridgeRegNoItemsS7.First().RegistrationNoS7.User;
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = user;
                    e.User = dbcontext.Users.AsNoTracking().Single(u => u.Id == user.Id);
                    e.UserId = user.Id;
                }
                else if (e.Item.BridgeRegNosItemS8.Count > 0)
                {
                    var user = e.Item.BridgeRegNosItemS8.First().RegistrationNoS8.User;
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = Mapper.Map<User, UserDto>(user);
                    //e.User = user;
                    e.User = dbcontext.Users.AsNoTracking().Single(u => u.Id == user.Id);
                    e.UserId = user.Id;
                }
            });
            return listOfData.Select(e => new
            {
                UserId = e.UserId,
                UserDto = Mapper.Map<User, UserDto>(e.User),
                Item = Mapper.Map<Item, ItemDto>(e.Item)
            }).ToList();

        }

        public dynamic DeleteItemHistory(DeleteItemHistoryInput input)
        {
            try
            {
                var dbcontext = new RegisterOwnersContext();
                var regNoSize = input.RegNo.Length;
                if (regNoSize == 1)
                {
                    var regNo = dbcontext.BridgeRegNoItemsS1.Single(e => e.RegId == input.RegNoId);
                    dbcontext.BridgeRegNoItemsS1.Remove(regNo);
                    dbcontext.SaveChanges();
                }
                else if (regNoSize == 2)
                {
                    var regNo = dbcontext.BridgeRegNoItemS2.Single(e => e.RegId == input.RegNoId);
                    dbcontext.BridgeRegNoItemS2.Remove(regNo);
                    dbcontext.SaveChanges();
                }
                else if (regNoSize == 3)
                {
                    var regNo = dbcontext.BridgeRegNoItemsS3.Single(e => e.RegId == input.RegNoId);
                    dbcontext.BridgeRegNoItemsS3.Remove(regNo);
                    dbcontext.SaveChanges();
                }
                else if (regNoSize == 4)
                {
                    var regNo = dbcontext.BridgeRegNoItemsS4.Single(e => e.RegId == input.RegNoId);
                    dbcontext.BridgeRegNoItemsS4.Remove(regNo);
                    dbcontext.SaveChanges();
                }
                else if (regNoSize == 5)
                {
                    var regNo = dbcontext.BridgeRegNoItemsS5.Single(e => e.RegId == input.RegNoId);
                    dbcontext.BridgeRegNoItemsS5.Remove(regNo);
                    dbcontext.SaveChanges();
                }
                else if (regNoSize == 6)
                {
                    var regNo = dbcontext.BridgeRegNoItemsS6.Single(e => e.RegId == input.RegNoId);
                    dbcontext.BridgeRegNoItemsS6.Remove(regNo);
                    dbcontext.SaveChanges();
                }
                else if (regNoSize == 7)
                {
                    var regNo = dbcontext.BridgeRegNoItemsS7.Single(e => e.RegId == input.RegNoId);
                    dbcontext.BridgeRegNoItemsS7.Remove(regNo);
                    dbcontext.SaveChanges();
                }
                else if (regNoSize == 8)
                {
                    var regNo = dbcontext.BridgeRegNosItemS8.Single(e => e.RegId == input.RegNoId);
                    dbcontext.BridgeRegNosItemS8.Remove(regNo);
                    dbcontext.SaveChanges();
                }

                return new
                {
                    IsDeleted = true,
                    Message = "Record Deleted"

                };
            }
            catch (Exception ex)
            {
                return new
                {
                    IsDeleted = false,
                    Message = "Error",
                    ErrorException = ex
                };

            };
        }
    }
}