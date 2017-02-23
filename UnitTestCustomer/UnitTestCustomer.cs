using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace ClassLibrary
{
    [TestClass]
    public class UnitTestCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of myscustomerclass
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);

        }
        [TestMethod]
        public void AddressOK()
        {
            //create an instance of myscustomerclass
            clsCustomer ACustomer = new clsCustomer();
            //variable to store validation
            string testdata = "coventry";
            //assign teset data to the property
            ACustomer.Address = testdata;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Address, testdata);

        }
        [TestMethod]
        public void ContactNumberOK()
        {
            //create an instance of myscustomerclass
            clsCustomer ACustomer = new clsCustomer();
            //variable to store validation
            string testdata = "04515";
            //assign teset data to the property
            ACustomer.ContactNumber = testdata;
            //test to see that it exists
            Assert.AreEqual(ACustomer.ContactNumber, testdata);

        }
        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of myscustomerclass
            clsCustomer ACustomer = new clsCustomer();
            //variable to store validation
            Int32 testdata = 15;
            //assign teset data to the property
            ACustomer.CustomerId = testdata;
            //test to see that it exists
            Assert.AreEqual(ACustomer.CustomerId, testdata);

        }
        [TestMethod]
        public void DateOfBirthOK()
        {
            //create an instance of myscustomerclass
            clsCustomer ACustomer = new clsCustomer();
            //variable to store validation
            DateTime testdata = DateTime.Now;
            //assign teset data to the property
            ACustomer.DateOfBirth = testdata;
            //test to see that it exists
            Assert.AreEqual(ACustomer.DateOfBirth, testdata);

        }
        [TestMethod]
        public void EmailOK()
        {
            //create an instance of myscustomerclass
            clsCustomer ACustomer = new clsCustomer();
            //variable to store validation
            string testdata = "naj@";
            //assign teset data to the property
            ACustomer.Email = testdata;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Email, testdata);

        }
        [TestMethod]
        public void NameOK()
        {
            //create an instance of myscustomerclass
            clsCustomer ACustomer = new clsCustomer();
            //variable to store validation
            string testdata = "najmudin";
            //assign teset data to the property
            ACustomer.Name = testdata;
            //test to see that it exists
            Assert.AreEqual(ACustomer.Name, testdata);

        }
        [TestMethod]
        public void PostCodeOK()
        {
            //create an instance of myscustomerclass
            clsCustomer ACustomer = new clsCustomer();
            //variable to store validation
            string testdata = "cv154";
            //assign teset data to the property
            ACustomer.PostCode = testdata;
            //test to see that it exists
            Assert.AreEqual(ACustomer.PostCode, testdata);

        }
        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of myscustomerclass
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string PostCode = "Le1 2hu";
            //invoke the method
            Found = ACustomer.Find(PostCode);
            //test to see that two values are same
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void ValidateMethodOk()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "35kingstreet";
            //var to store email and assign data
            string Email = "naj@gmail.com";
            //var to store name and assign data
            string Name = "bob";
            //var to store postcode and assign data
            string PostCode = "le1 52f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void AddressMinBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "Kings";
            //var to store email and assign data
            string Email = "naj@gmail.com";
            //var to store name and assign data
            string Name = "bob";
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "kings";
            //var to store email and assign data
            string Email = "naj@gmail.com";
            //var to store name and assign data
            string Name = "bob";
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(49, 'a');
            //var to store email and assign data
            string Email = "naj@gmail.com";
            //var to store name and assign data
            string Name = "bob";
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void AddressMaxBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(50, 'a');
            //var to store email and assign data
            string Email = "naj@gmail.com";
            //var to store name and assign data
            string Name = "bob";
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(51, 'a');
            //var to store email and assign data
            string Email = "naj@gmail.com";
            //var to store name and assign data
            string Name = "bob";
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void AddressMidBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(25, 'a');
            //var to store email and assign data
            string Email = "naj@gmail.com";
            //var to store name and assign data
            string Name = "bob";
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressExtreamMax()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(100, 'a');
            //var to store email and assign data
            string Email = "naj@gmail.com";
            //var to store name and assign data
            string Name = "bob";
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsFalse(OK);
        }
        //hhfhh
        [TestMethod]
        public void EmailMinBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "Kings";
            //var to store email and assign data
            string Email = "naj@hotmai";
            //var to store name and assign data
            string Name = "bob";
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "kings";
            //var to store email and assign data
            string Email = "naj@hotmail";
            //var to store name and assign data
            string Name = "bob";
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(49, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.co";

            //var to store name and assign data
            string Name = "bob";
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void EmailMaxBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(50, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.com";
            //var to store name and assign data
            string Name = "bob";
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(51, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.comm";
            //var to store name and assign data
            string Name = "bob";
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void EmailMidBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(25, 'a');
            //var to store email and assign data
            string Email = "naj@gmail.com";
            //var to store name and assign data
            string Name = "bob";
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void EmailExtreamMax()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(100, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.comnajmudinsaqib@hotmail.com";
            //var to store name and assign data
            string Name = "bob";
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsFalse(OK);
        }
        //hhfhh
        [TestMethod]
        public void NameMinBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "Kings";
            //var to store email and assign data
            string Email = "naj@hotmai";
            //var to store name and assign data
            string Name = "b";
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void NameMinPlusOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "kings";
            //var to store email and assign data
            string Email = "naj@hotmail";
            //var to store name and assign data
            string Name = "bo";
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void NameMaxLessOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(49, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.co";

            //var to store name and assign data
            string Name = "";
            Name = Name.PadRight(24, 'a');
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void NameMaxBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(50, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.com";
            //var to store name and assign data
            string Name = "";
            Name = Name.PadRight(25, 'a');
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void NameMaxPlusOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(51, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.comm";
            //var to store name and assign data
            string Name = "";
            Name = Name.PadRight(26, 'a');
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void NameMidBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(25, 'a');
            //var to store email and assign data
            string Email = "naj@gmail.com";
            //var to store name and assign data
            string Name = "najmudinsaqib";
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NameExtreamMax()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(100, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.comnajmudinsaqib@hotmail.com";
            //var to store name and assign data
            string Name = "";
            Name = Name.PadRight(50, 'a');
            //var to store postcode and assign data
            string PostCode = "le152f";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsFalse(OK);
        }
        //hhfhh
        [TestMethod]
        public void PostCodeMinBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "Kings";
            //var to store email and assign data
            string Email = "naj@hotmai";
            //var to store name and assign data
            string Name = "b";
            //var to store postcode and assign data
            string PostCode = "le1";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "kings";
            //var to store email and assign data
            string Email = "naj@hotmail";
            //var to store name and assign data
            string Name = "bo";
            //var to store postcode and assign data
            string PostCode = "le15";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(49, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.co";

            //var to store name and assign data
            string Name = "";
            Name = Name.PadRight(24, 'a');
            //var to store postcode and assign data
            string PostCode = "le1456789";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void PostCodeMaxBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(50, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.com";
            //var to store name and assign data
            string Name = "";
            Name = Name.PadRight(25, 'a');
            //var to store postcode and assign data
            string PostCode = "le14567891";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(51, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.comm";
            //var to store name and assign data
            string Name = "";
            Name = Name.PadRight(26, 'a');
            //var to store postcode and assign data
            string PostCode = "le145678912";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void PostCodeMidBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(25, 'a');
            //var to store email and assign data
            string Email = "naj@gmail.com";
            //var to store name and assign data
            string Name = "najmudinsaqib";
            //var to store postcode and assign data
            string PostCode = "le159";
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PostCodeExtreamMax()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(100, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.comnajmudinsaqib@hotmail.com";
            //var to store name and assign data
            string Name = "";
            Name = Name.PadRight(50, 'a');
            //var to store postcode and assign data
            string PostCode = "";
            PostCode = PostCode.PadRight(50, 'a');
            //var to store contactNumber and assign data
            string ContactNumber = "07745268789";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsFalse(OK);
        }
        //hhfhh
        [TestMethod]
        public void ContactNumberMinBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "Kings";
            //var to store email and assign data
            string Email = "naj@hotmai";
            //var to store name and assign data
            string Name = "b";
            //var to store postcode and assign data
            string PostCode = "le1";
            //var to store contactNumber and assign data
            string ContactNumber = "07712345678";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void ContactNumberMinPlusOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "kings";
            //var to store email and assign data
            string Email = "naj@hotmail";
            //var to store name and assign data
            string Name = "bo";
            //var to store postcode and assign data
            string PostCode = "le15";
            //var to store contactNumber and assign data
            string ContactNumber = "077123456781";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void ContactNumberMaxLessOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(49, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.co";

            //var to store name and assign data
            string Name = "";
            Name = Name.PadRight(24, 'a');
            //var to store postcode and assign data
            string PostCode = "le1456789";
            //var to store contactNumber and assign data
            string ContactNumber = "0771234567812";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void ContactNumberMaxBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(50, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.com";
            //var to store name and assign data
            string Name = "";
            Name = Name.PadRight(25, 'a');
            //var to store postcode and assign data
            string PostCode = "le14567891";
            //var to store contactNumber and assign data
            string ContactNumber = "07712345678123";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void ContactNumberMaxPlusOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(51, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.comm";
            //var to store name and assign data
            string Name = "";
            Name = Name.PadRight(26, 'a');
            //var to store postcode and assign data
            string PostCode = "le145678912";
            //var to store contactNumber and assign data
            string ContactNumber = "077452687891234";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ContactNumberMidBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(25, 'a');
            //var to store email and assign data
            string Email = "naj@gmail.com";
            //var to store name and assign data
            string Name = "najmudinsaqib";
            //var to store postcode and assign data
            string PostCode = "le159";
            //var to store contactNumber and assign data
            string ContactNumber = "077452687891";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ContactNumberExtreamMax()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(100, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.comnajmudinsaqib@hotmail.com";
            //var to store name and assign data
            string Name = "";
            Name = Name.PadRight(50, 'a');
            //var to store postcode and assign data
            string PostCode = "";
            PostCode = PostCode.PadRight(50, 'a');
            //var to store contactNumber and assign data
            string ContactNumber = "";
            PostCode = PostCode.PadRight(25, 'a');
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsFalse(OK);
        }
        //hhfhh
        [TestMethod]
        public void DateOfBirthMinBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "Kings";
            //var to store email and assign data
            string Email = "naj@hotmai";
            //var to store name and assign data
            string Name = "b";
            //var to store postcode and assign data
            string PostCode = "le1";
            //var to store contactNumber and assign data
            string ContactNumber = "07712345678";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-100).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "kings";
            //var to store email and assign data
            string Email = "naj@hotmail";
            //var to store name and assign data
            string Name = "bo";
            //var to store postcode and assign data
            string PostCode = "le15";
            //var to store contactNumber and assign data
            string ContactNumber = "077123456781";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-101).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsFalse(OK);


        }
        [TestMethod]
        public void DateOfBirthMaxLessOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(49, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.co";

            //var to store name and assign data
            string Name = "";
            Name = Name.PadRight(24, 'a');
            //var to store postcode and assign data
            string PostCode = "le1456789";
            //var to store contactNumber and assign data
            string ContactNumber = "0771234567812";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-17).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsFalse(OK);


        }
        [TestMethod]
        public void DateOfBirthMaxBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(50, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.com";
            //var to store name and assign data
            string Name = "";
            Name = Name.PadRight(25, 'a');
            //var to store postcode and assign data
            string PostCode = "le14567891";
            //var to store contactNumber and assign data
            string ContactNumber = "07712345678123";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-18).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(51, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.comm";
            //var to store name and assign data
            string Name = "";
            Name = Name.PadRight(26, 'a');
            //var to store postcode and assign data
            string PostCode = "le145678912";
            //var to store contactNumber and assign data
            string ContactNumber = "077452687891234";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(19).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateOfBirthMidBoundary()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(25, 'a');
            //var to store email and assign data
            string Email = "naj@gmail.com";
            //var to store name and assign data
            string Name = "najmudinsaqib";
            //var to store postcode and assign data
            string PostCode = "le159";
            //var to store contactNumber and assign data
            string ContactNumber = "077452687891";
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(-50).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DateOfBirthExtreamMax()
        {
            //creat an instance of clsBooking class
            clsCustomer ACustomer = new clsCustomer();
            //boolean var to store the result of the validation
            Boolean OK = false;
            //var to store address
            string Address;
            //asign some data to var
            Address = "";
            Address = Address.PadRight(100, 'a');
            //var to store email and assign data
            string Email = "najmudinsaqib@hotmail.comnajmudinsaqib@hotmail.com";
            //var to store name and assign data
            string Name = "";
            Name = Name.PadRight(50, 'a');
            //var to store postcode and assign data
            string PostCode = "";
            PostCode = PostCode.PadRight(50, 'a');
            //var to store contactNumber and assign data
            string ContactNumber = "";
            PostCode = PostCode.PadRight(25, 'a');
            //var to store dateofbirth
            string DateOfBirth = DateTime.Now.Date.AddYears(200).ToString();
            //invoke the method
            OK = ACustomer.Valid(Address, Email, Name, PostCode, ContactNumber, DateOfBirth);
            //test to see that two values are same
            Assert.IsFalse(OK);
        }


    }
}
