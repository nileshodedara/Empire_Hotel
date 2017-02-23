using System;
namespace ClassLibrary
{
    public class clsRooms
    {
        public string Inventory { get; set; }
        public int HotelID { get; set; }
        public string RoomType { get; set; }
        public int RoomNo { get; set; }

        public bool Find(int roomNumber)
        {
            return true; //always return true
        }


        public bool Valid(string hotelID, string inventory, string roomType)
        {
            Boolean OK = true; //create a boolena variable to flag the error 
            if (hotelID.Length < 1)
            {
                OK = false; //set the flag ok to false

            }
            if (hotelID.Length > 10)

            {
                OK = false;  //set the flag ok to false
            }
            if (roomType.Length < 1)
            {
                OK = false; //set the flag ok to false

            }
            if (roomType.Length > 20)

            {
                OK = false;  //set the flag ok to false
            }
            if (inventory.Length < 5)
            {
                OK = false; //set the flag ok to flase
            }
            if (inventory.Length > 20)
            {
                OK = false; //set the flag ok to false
            }


            return OK; //return the vale of OK
        }
    }
}