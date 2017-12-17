using AutoMapper;
using ContactManagementSystem26_10_17.RegisterOwnerDataBase;
using ContactManagementSystem26_10_17.Services.Items.Dtos;
using System;

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

    }
}