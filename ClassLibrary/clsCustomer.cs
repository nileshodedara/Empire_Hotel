using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string PostCode { get; set; }

        public bool Find(string PostCode)
        {
            //always return true
            return true;
        }

        public bool Valid(string address, string email, string name, string postCode, string contactNumber, string dateOfBirth)
        {
            //creat a voolean variable to flag the error
            Boolean OK = true;
            //create a temporary variable to store data values
            DateTime DateOfBirth;
            //if address is blank
            //if (address.Length == 0)
            //{
            //    //set the falg Ok TO FALSE
            //    OK = false;
            //}
            //try the date validation assuming the date is valid date
            try
            {
                //copy the dateofbith value to the DATE OF BIRTH value
                DateOfBirth = Convert.ToDateTime(dateOfBirth);
                //check to see if the date is lees than toadys date
                if (DateOfBirth < DateTime.Now.Date.AddYears(-100))
                {

                    //set the flag ok to false
                    OK = false;
                }
                //if the date of bith is
                if (DateOfBirth > DateTime.Now.Date.AddYears(-18))
                {
                    //set ok to false
                    OK = false;
                }

            }
            catch
            {
                OK = false;
            }
            //test to see if the name has zero characters

            if (name.Length < 1)
            {
                //set ok to false
                OK = false;
            }
            //test to see that string is no more than 25 character
            if (name.Length > 25)
            {
                //set ok to false
                OK = false;
            }

            if (address.Length < 5)
            {
                //set ok to false
                OK = false;
            }
            //test to see that string is no more than 50 character
            if (address.Length > 50)
            {
                //set ok to false
                OK = false;
            }
            if (email.Length < 10)
            {
                //set ok to false
                OK = false;
            }
            //test to see that string is no more than 50 character
            if (email.Length > 25)
            {
                //set ok to false
                OK = false;
            }
            if (postCode.Length < 3)
            {
                //set ok to false
                OK = false;
            }
            //test to see that string is no more than 50 character
            if (postCode.Length > 10)
            {
                //set ok to false
                OK = false;
            }
            if (contactNumber.Length < 11)
            {
                //set ok to false
                OK = false;
            }
            //test to see that string is no more than 50 character
            if (contactNumber.Length > 14)
            {
                //set ok to false
                OK = false;
            }

            //return the value of ok
            return OK;
        }
    }
}