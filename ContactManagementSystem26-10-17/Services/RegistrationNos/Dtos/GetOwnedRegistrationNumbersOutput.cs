using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagementSystem26_10_17.Services.RegistrationNos.Dtos
{
    public class GetOwnedRegistrationNumbersOutput
    {
        public int? ItemId { get; set; }

        public string RegNo { get; set; }

        public int? RegNoId { get; set; }
        public int UserId { get; set; }
    }
}