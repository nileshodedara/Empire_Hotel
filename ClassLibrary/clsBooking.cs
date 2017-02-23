using System;

namespace ClassLibrary
{
    public class clsBooking
    { //private data member for the BookingID Property
        private Int32 aBookingId;
        //private data member for the HotelID property
        private Int32 aHotelId;
        //private data member for the customerID property
        private Int32 aCustomerId;
        //private data member for the RoomId property
        private Int32 aRoomNo;
        //private data member for the BookingDate property
        private DateTime aBookingDate;
        //private data member for the checkInDate property
        private DateTime aCheckInDate;
        //private data member for the checkOutDate
        private DateTime aCheckOutDate;
        //private data member for the NumOfNights property
        private Int32 aNumOfNights;

        //commente added to learn git hub

        //public property for BookingId
        public int BookingID
        {
            get
            {
                //retrun the private data
                return aBookingId;
            }
            set
            {
                //set the private data
                aBookingId = value;
            }
        }
        //public property for BookingDate
        public DateTime BookingDate
        {
            get
            {
                //retrun the private data
                return aBookingDate;
            }
            set
            {
                //set the private data
                aBookingDate = value;
            }
        }

        //public property for CheckInDate
        public DateTime CheckInDate
        {
            get
            {
                //retrun the private data
                return aCheckInDate;
            }
            set
            {
                //set the private data
                aCheckInDate = value;
            }
        }

        //public property for checkOutDate
        public DateTime CheckOutDate
        {
            get
            {
                //retrun the private data
                return aCheckOutDate;
            }
            set
            {
                //set the private data
                aCheckOutDate = value;
            }
        }

        //public property for CustomerId
        public int CustomerID
        {
            get
            {
                //retrun the private data
                return aCustomerId;
            }
            set
            {
                //set the private data
                aCustomerId = value;
            }
        }

        //public property for HotelId
        public int HotelID
        {
            get
            {
                //retrun the private data
                return aHotelId;
            }
            set
            {
                //set the private data
                aHotelId = value;
            }
        }
        //public property for the NumOfNights
        public int NumOfNights
        {
            get
            {
                //retrun the private data
                return aNumOfNights;
            }
            set
            {
                //set the private data
                aNumOfNights = value;
            }
        }

        //public property for roomNo
        public int RoomNo
        {
            get
            {
                //retrun the private data
                return aRoomNo;
            }
            set
            {
                //set the private data
                aRoomNo = value;
            }
        }



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
            //create an instance of data connection class
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the booking id to serch for
            DB.AddParameter("BookingId", bookingID);
            //execute the stored procedure
            DB.Execute("sproc_tblBooking_FilterByBookingId");
            //if one record found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                aBookingId = Convert.ToInt32(DB.DataTable.Rows[0]["BookingId"]);
                aCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                aHotelId = Convert.ToInt32(DB.DataTable.Rows[0]["HotelId"]);
                aRoomNo = Convert.ToInt32(DB.DataTable.Rows[0]["RoomNo"]);
                aBookingDate = Convert.ToDateTime(DB.DataTable.Rows[0]["BookingDate"]);
                aCheckInDate = Convert.ToDateTime(DB.DataTable.Rows[0]["CheckInDate"]);
                aCheckOutDate = Convert.ToDateTime(DB.DataTable.Rows[0]["CheckOutDate"]);
                aNumOfNights = Convert.ToInt32(DB.DataTable.Rows[0]["NumOfNights"]);
                return true;

            }
            //if no record was found
            else
            {
                //return false indication a problem
                return false;
            }
        }
    }
}