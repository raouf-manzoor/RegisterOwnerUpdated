using AutoMapper;
using ContactManagementSystem26_10_17.RegisterOwnerDataBase;
using ContactManagementSystem26_10_17.Services.Items.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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