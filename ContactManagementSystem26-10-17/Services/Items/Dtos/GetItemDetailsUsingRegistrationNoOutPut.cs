using ContactManagementSystem26_10_17.RegisterOwnerDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagementSystem26_10_17.Services.Items.Dtos
{
    public class GetItemDetailsUsingRegistrationNoOutPut
    {
        public Item Item { get; set; }
        public int? UserId { get; set; }

        public User User { get; set; }
    }
}