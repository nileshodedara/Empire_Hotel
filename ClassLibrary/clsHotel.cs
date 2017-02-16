using System;

namespace ClassLibrary
{
    public class clsHotel
    {
        public clsHotel()
        {
        }

        public string Address { get; set; }
        public DateTime DateAdded { get; set; }
        public int HotelID { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Postcode { get; set; }
        public int RoomCapacity { get; set; }

        public bool Find(int hotelID)
        {
            return true; //always return true
        }
    }
}