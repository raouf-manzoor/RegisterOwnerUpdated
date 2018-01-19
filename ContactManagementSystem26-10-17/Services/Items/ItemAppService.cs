using AutoMapper;
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
                var regNo = dbcontext.RegistrationNoS1.SingleOrDefault(e => e.Id == input.RegNoId);
                var itemToCheck = regNo.BridgeRegNoItemsS1.FirstOrDefault();
                if (itemToCheck != null)
                {
                    item = dbcontext.Items.SingleOrDefault(e => e.Id == itemToCheck.ItemId);
                }
                return new
                {
                    UserId = regNo.userId,
                    Item = item != null ? Mapper.Map<Item, ItemDto>(item) : null,
                };
            }
            else if (input.RegNo.Length == 2)
            {
                var regNo = dbcontext.RegistrationNoS2.SingleOrDefault(e => e.Id == input.RegNoId);
                var itemToCheck = regNo.BridgeRegNoItemS2.FirstOrDefault();
                if (itemToCheck != null)
                {
                    item = dbcontext.Items.SingleOrDefault(e => e.Id == itemToCheck.ItemId);
                }
                return new
                {
                    UserId = regNo.userId,
                    Item = item != null ? Mapper.Map<Item, ItemDto>(item) : null,
                };
            }
            else if (input.RegNo.Length == 3)
            {
                var regNo = dbcontext.RegistrationNoS3.SingleOrDefault(e => e.Id == input.RegNoId);
                var itemToCheck = regNo.BridgeRegNoItemsS3.FirstOrDefault();
                if (itemToCheck != null)
                {
                    item = dbcontext.Items.SingleOrDefault(e => e.Id == itemToCheck.ItemId);
                }
                return new
                {
                    UserId = regNo.userId,
                    Item = item != null ? Mapper.Map<Item, ItemDto>(item) : null,
                };
            }
            else if (input.RegNo.Length == 4)
            {
                var regNo = dbcontext.RegistrationNoS4.SingleOrDefault(e => e.Id == input.RegNoId);
                var itemToCheck = regNo.BridgeRegNoItemsS4.FirstOrDefault();
                if (itemToCheck != null)
                {
                    item = dbcontext.Items.SingleOrDefault(e => e.Id == itemToCheck.ItemId);
                }
                return new
                {
                    UserId = regNo.userId,
                    Item = item != null ? Mapper.Map<Item, ItemDto>(item) : null,
                };
            }
            else if (input.RegNo.Length == 5)
            {
                var regNo = dbcontext.RegistrationNoS5.SingleOrDefault(e => e.Id == input.RegNoId);
                var itemToCheck = regNo.BridgeRegNoItemsS5.FirstOrDefault();
                if (itemToCheck != null)
                {
                    item = dbcontext.Items.SingleOrDefault(e => e.Id == itemToCheck.ItemId);
                }
                return new
                {
                    UserId = regNo.userId,
                    Item = item != null ? Mapper.Map<Item, ItemDto>(item) : null,
                };
            }
            else if (input.RegNo.Length == 6)
            {
                var regNo = dbcontext.RegistrationNoS6.SingleOrDefault(e => e.Id == input.RegNoId);
                var itemToCheck = regNo.BridgeRegNoItemsS6.FirstOrDefault();
                if (itemToCheck != null)
                {
                    item = dbcontext.Items.SingleOrDefault(e => e.Id == itemToCheck.ItemId);
                }
                return new
                {
                    UserId = regNo.userId,
                    Item = item != null ? Mapper.Map<Item, ItemDto>(item) : null,
                };
            }
            else if (input.RegNo.Length == 7)
            {
                var regNo = dbcontext.RegistrationNoS7.SingleOrDefault(e => e.Id == input.RegNoId);
                var itemToCheck = regNo.BridgeRegNoItemsS7.FirstOrDefault();
                if (itemToCheck != null)
                {
                    item = dbcontext.Items.SingleOrDefault(e => e.Id == itemToCheck.ItemId);
                }
                return new
                {
                    UserId = regNo.userId,
                    Item = item != null ? Mapper.Map<Item, ItemDto>(item) : null,
                };
            }
            else if (input.RegNo.Length == 8)
            {
                var regNo = dbcontext.RegistrationNoS8.SingleOrDefault(e => e.Id == input.RegNoId);
                var itemToCheck = regNo.BridgeRegNosItemS8.FirstOrDefault();
                if (itemToCheck != null)
                {
                    item = dbcontext.Items.SingleOrDefault(e => e.Id == itemToCheck.ItemId);
                }
                return new
                {
                    UserId = regNo.userId,
                    Item = item != null ? Mapper.Map<Item, ItemDto>(item) : null,
                };
            }
            return null;

        }
        public dynamic GetItemDetailsUsingSerialNo(GetItemDetailsUsingSerialNoInput input)
        {
            RegisterOwnersContext dbcontext = new RegisterOwnersContext();
            var listOfData = dbcontext.Items.Where(e => e.ItemSerial == input.SerialNo).Select(
                e => new GetItemDetailsUsingSerialNoOutput()
                {
                    Item = e,
                    UserId = null
                }
             ).ToList();
            listOfData.ForEach(e =>
            {
                if (e.Item.BridgeRegNoItemsS1.Count > 0)
                    e.UserId = e.Item.BridgeRegNoItemsS1.First().RegistrationNoS1.userId.Value;
                else if (e.Item.BridgeRegNoItemS2.Count > 0)
                    e.UserId = e.Item.BridgeRegNoItemS2.First().RegistrationNoS2.userId.Value;
                else if (e.Item.BridgeRegNoItemsS3.Count > 0)
                    e.UserId = e.Item.BridgeRegNoItemsS3.First().RegistrationNoS3.userId.Value;
                else if (e.Item.BridgeRegNoItemsS4.Count > 0)
                    e.UserId = e.Item.BridgeRegNoItemsS4.First().RegistrationNoS4.userId.Value;
                else if (e.Item.BridgeRegNoItemsS5.Count > 0)
                    e.UserId = e.Item.BridgeRegNoItemsS5.First().RegistrationNoS5.userId.Value;
                else if (e.Item.BridgeRegNoItemsS6.Count > 0)
                    e.UserId = e.Item.BridgeRegNoItemsS6.First().RegistrationNoS6.userId.Value;
                else if (e.Item.BridgeRegNoItemsS7.Count > 0)
                    e.UserId = e.Item.BridgeRegNoItemsS7.First().RegistrationNoS7.userId.Value;
                else if (e.Item.BridgeRegNosItemS8.Count > 0)
                    e.UserId = e.Item.BridgeRegNosItemS8.First().RegistrationNoS8.userId.Value;
            });
            return listOfData.Select(e => new
            {
                UserId = e.UserId,
                Item = Mapper.Map<Item, ItemDto>(e.Item)
            }).ToList();

        }

        public dynamic GetItemDetailsUsingByItemId(GetItemDetailsUsingItemIdInput input)
        {
            RegisterOwnersContext dbcontext = new RegisterOwnersContext();
            var listOfData = dbcontext.Items.Where(e => e.ItemId == input.ItemId).Select(
                e => new GetItemDetailsUsingSerialNoOutput()
                {
                    Item = e,
                    UserId = null
                }
             ).ToList();
            listOfData.ForEach(e =>
            {
                if (e.Item.BridgeRegNoItemsS1.Count > 0)
                    e.UserId = e.Item.BridgeRegNoItemsS1.First().RegistrationNoS1.userId.Value;
                else if (e.Item.BridgeRegNoItemS2.Count > 0)
                    e.UserId = e.Item.BridgeRegNoItemS2.First().RegistrationNoS2.userId.Value;
                else if (e.Item.BridgeRegNoItemsS3.Count > 0)
                    e.UserId = e.Item.BridgeRegNoItemsS3.First().RegistrationNoS3.userId.Value;
                else if (e.Item.BridgeRegNoItemsS4.Count > 0)
                    e.UserId = e.Item.BridgeRegNoItemsS4.First().RegistrationNoS4.userId.Value;
                else if (e.Item.BridgeRegNoItemsS5.Count > 0)
                    e.UserId = e.Item.BridgeRegNoItemsS5.First().RegistrationNoS5.userId.Value;
                else if (e.Item.BridgeRegNoItemsS6.Count > 0)
                    e.UserId = e.Item.BridgeRegNoItemsS6.First().RegistrationNoS6.userId.Value;
                else if (e.Item.BridgeRegNoItemsS7.Count > 0)
                    e.UserId = e.Item.BridgeRegNoItemsS7.First().RegistrationNoS7.userId.Value;
                else if (e.Item.BridgeRegNosItemS8.Count > 0)
                    e.UserId = e.Item.BridgeRegNosItemS8.First().RegistrationNoS8.userId.Value;
            });
            return listOfData.Select(e => new
            {
                UserId = e.UserId,
                Item = Mapper.Map<Item, ItemDto>(e.Item)
            }).ToList();

        }
    }
}