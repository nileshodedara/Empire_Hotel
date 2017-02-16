using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        public bool Active { get; set; }
        public string Address { get; set; }
        public DateTime DateJoined { get; set; }
        public string FirstName { get; set; }
        public string JobTitle { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Postcode { get; set; }
        public int staffid { get; set; }
    }
}