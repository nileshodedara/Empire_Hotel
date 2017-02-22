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

        public bool Find(int staffID)
        {
            return true;

        }

        public bool Valid(string firstName, string lastName, string postCode, string phoneNumber, string address, string jobTitle, string dateJoined)
        {

            //create a Boolean variable to flag the error
            Boolean OK = true;
            //create a temporary variable to store date values 
            DateTime DateTemp;
            //if the FirstName is blank 
            if (firstName.Length < 2)
            {

                //set the flag to false 
                OK = false;
            }
            // If the firstname is greater than 12 characters 
            if (firstName.Length > 12)
            {
                OK = false;
            }
            try
            {
                //copy the DateAdded value to the DateTemp Variable 
                DateTemp = Convert.ToDateTime(dateJoined);
                //check to see if the date is less than todays date
                if (DateTemp < DateTime.Now.Date)
                {
                    //set the flag OK to false 
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

            if (jobTitle.Length < 5)
            {
                OK = false;
            }

            if (jobTitle.Length > 15)
            {
                OK = false;
            }
            if (phoneNumber.Length < 8)
            {
                OK = false;
            }
            if (phoneNumber.Length > 15)
            {
                OK = false;
            }
            if (address.Length < 5)
            {
                OK = false;
            }
            if (address.Length > 15)

            {
                OK = false;
            }

            if (postCode.Length < 6)
            {
                OK = false;

            }
            if (postCode.Length > 8)
            {
                OK = false;
            }
            if (lastName.Length < 3)
            {
                OK = false;
            }
            if (lastName.Length > 15)
            {
                OK = false;
            }

            //return the value of Ok
            return OK;
        }
    }
}

