using System;

namespace ClassLibrary
{
    public class clsBooking
    {
        public DateTime BookingDate { get; set; }
        public int BookingID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int CustomerID { get; set; }
        public int HotelID { get; set; }
        public int NumOfNights { get; set; }
        public int RoomNo { get; set; }

        public bool Find(int bookingID)
        {
            return true;
        }

        public bool Validate(int bookingID)
        {
            return true;
        }
    }
}