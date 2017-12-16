using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagementSystem26_10_17.Services.Items.Dtos
{
    public class ItemDto
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Producer { get; set; }
        public string Model { get; set; }
        public string ItemId { get; set; }
        public string ItemSerial { get; set; }
        public string OtherInfo { get; set; }
        public Nullable<System.DateTime> DateofPurchase { get; set; }
        public string ReceiptImage { get; set; }
        public Nullable<bool> BoolDateOfPurchase { get; set; }
        public Nullable<bool> BoolPlace { get; set; }
        public Nullable<bool> BoolItem { get; set; }
        public Nullable<bool> BoolAdress { get; set; }
        public Nullable<bool> BoolFirstName { get; set; }
        public Nullable<bool> BoolLastName { get; set; }
        public Nullable<bool> BoolPhoneNo { get; set; }
        public Nullable<bool> BoolEmail { get; set; }
        public Nullable<bool> BoolReceipt { get; set; }

        public int RegNoSize { get; set; }
        public int RegNoId { get; set; }

    }

}