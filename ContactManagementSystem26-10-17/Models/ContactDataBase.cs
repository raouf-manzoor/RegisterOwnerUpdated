using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagementSystem26_10_17.Models
{
    public class ContactDataBase
    {
        public static List<ContactInfo> contacts = new List<ContactInfo>()
        {
            new ContactInfo(){Name="Raouf" , Password="1234"},
            new ContactInfo(){Name="Hamza" , Password="1234"},

        };
    }
}