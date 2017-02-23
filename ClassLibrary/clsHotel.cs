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

        public bool Valid(string name, string address, string postCode, string phoneNo, string roomCapacity, string dateAdded)
        {
            Boolean OK = true; //create a boolean variable to flag the error
            DateTime DateTemp;



            if (name.Length == 0)
            {
                OK = false;

            }

            if (name.Length < 1)
            {
                OK = false;

            }

            if (name.Length > 30)
            {
                OK = false;

            }


            if (address.Length == 0)
            {
                OK = false;

            }

            if (address.Length < 1)
            {
                OK = false;

            }

            if (address.Length > 40)
            {
                OK = false;

            }

            if (postCode.Length == 0)
            {
                OK = false;

            }

            if (postCode.Length < 1)
            {
                OK = false;

            }

            if (postCode.Length > 9)
            {
                OK = false;

            }

            if (phoneNo.Length == 0)
            {
                OK = false;

            }

            if (phoneNo.Length < 1)
            {
                OK = false;

            }

            if (phoneNo.Length > 11)
            {
                OK = false;

            }

            if (roomCapacity.Length == 0)
            {
                OK = false;

            }

            if (roomCapacity.Length < 1)
            {
                OK = false;

            }

            if (roomCapacity.Length > 4)
            {
                OK = false;

            }

            try
            {
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    OK = false;
                }

                if (DateTemp > DateTime.Now.Date)
                {

                    OK = false;
                }
            }
            catch
            {
                OK = false;
            }


            //return the value ok
            return OK;
        }
    }
}
