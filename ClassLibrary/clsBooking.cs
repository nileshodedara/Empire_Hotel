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

        

        public bool Valid(string numOfNights, string bookigDate, string checkInDate, string checkOutDate)
        {
            //create a boolean var to flag an error
            Boolean Ok = true;
            // var to store bookingDate
            DateTime temBookingDate;
            //var to store checkInDate
            DateTime temCheckInDate;
            //var to store CheckOutDate
            DateTime temCheckOutDate;
            //numofnights
            Int32 temNights;
            temNights = Convert.ToInt32(numOfNights);

            //if the NumOfNights is 0
            if (temNights == 0)
            {
                //set the flag ok to false
                Ok = false;
            }

            //if the NumOfNights is 0
            if (temNights > 30)
            {
                //set the flag ok to false
                Ok = false;
            }
            try
            {
                //copy the booking date value to temBooking date
                temBookingDate = Convert.ToDateTime(bookigDate);

                //check to see if the date is less than today's date
                if(temBookingDate < DateTime.Now.Date)
                {
                    //set the falg ok to false
                    Ok = false;
                }

                //chek to see if the date is greater than today's date
                if(temBookingDate>DateTime.Now.Date)
                {
                    //set the flag ok to false
                    Ok = false;
                }
                //copy the checkInDate  value to tempCheckInDate
                temCheckInDate = Convert.ToDateTime(checkInDate);

                //check to see if checkInDate is less than bookingDate
                if(temCheckInDate < temBookingDate)
                {
                    //set the flag ok to false
                    Ok = false;
                }
                //check to see if checkInDate is more a month after booking date
                if (temCheckInDate > temBookingDate.AddDays(30))
                {
                    //set the flag ok to false
                    Ok = false;
                }

                //copy the checkOut Date valu to temCkeckOut Date
                temCheckOutDate = Convert.ToDateTime(checkOutDate);

                //check to see if checkOut Date ise less than checkIn date
                if (temCheckOutDate < temCheckInDate)
                {
                    //set the flag ok to false
                    Ok = false;
                }
                //check to see checkOut date is more than a month from the checkIN date
                if (temCheckOutDate > temCheckInDate.AddDays(30))
                {
                    //set the flag ok to false
                    Ok = false;
                }


            }

            //the data was not a date so flage an error
            catch
            {
                //set the flag ok to false
                Ok = false;
            }

            return Ok;
        }

        public bool Find(int bookingID)
        {
            return true;
        }
    }
}