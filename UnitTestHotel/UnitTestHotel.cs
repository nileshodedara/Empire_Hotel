using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace ClassLibrary
{
    /// <summary>
    /// Summary description for MyTests
    /// </summary>
    [TestClass]
    public class UnitTestHotel
    {
        public UnitTestHotel()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        [TestMethod]
        public void InstanceOK()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Assert.IsNotNull(AHotel); //test to see that it exists

        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            string TestData = "25 Drinkstone Road"; //create some test data to assign to the property
            AHotel.Address = TestData; //assign the data to the property
            Assert.AreEqual(AHotel.Address, TestData); //test to see that two values are the same

        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            DateTime TestData = DateTime.Now.Date; //create some test data to assign to the property
            AHotel.DateAdded = TestData; //assign the data to the property
            Assert.AreEqual(AHotel.DateAdded, TestData); //test to see that two values are the same

        }

        [TestMethod]
        public void HotelIDPropertyOK()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Int32 TestData = 5; //create some test data to assign to the property
            AHotel.HotelID = TestData; //assign the data to the property
            Assert.AreEqual(AHotel.HotelID, TestData); //test to see that two values are the same

        }

        [TestMethod]
        public void NamePropertyOK()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            string TestData = "EmpireKings"; //create some test data to assign to the property
            AHotel.Name = TestData; //assign the data to the property
            Assert.AreEqual(AHotel.Name, TestData); //test to see that two values are the same

        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            string TestData = "01162245676"; //create some test data to assign to the property
            AHotel.PhoneNo = TestData; //assign the data to the property
            Assert.AreEqual(AHotel.PhoneNo, TestData); //test to see that two values are the same

        }

        [TestMethod]
        public void PostcodePropertyOK()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            string TestData = "LE1 9BH"; //create some test data to assign to the property
            AHotel.Postcode = TestData; //assign the data to the property
            Assert.AreEqual(AHotel.Postcode, TestData); //test to see that two values are the same

        }

        [TestMethod]
        public void RoomCapacityPropertyOK()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Int32 TestData = 200; //create some test data to assign to the property
            AHotel.RoomCapacity = TestData; //assign the data to the property
            Assert.AreEqual(AHotel.RoomCapacity, TestData); //test to see that two values are the same

        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean Found = false; //boolean variable to store the result of the validation
            Int32 HotelID = 5; //create some test data to use with the method
            Found = AHotel.Find(HotelID);//invoke the method
            Assert.IsTrue(Found); //test to see that the result is correct

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void NameMin()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "P";
            string Address = "Test Street";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Pr";
            string Address = "Test Street";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "";
            Name = Name.PadRight(29, 'P');
            string Address = "Test Street";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void NameMax()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "";
            Name = Name.PadRight(30, 'P');
            string Address = "Test Street";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "";
            Name = Name.PadRight(31, 'P');
            string Address = "Test Street";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsFalse(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void NameMid()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "";
            Name = Name.PadRight(15, 'P');
            string Address = "Test Street";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void AddressMinBound()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "T";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Te";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void AddressLessOne()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "";
            Address = Address.PadRight(39, 'T');
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void AddressMax()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "";
            Address = Address.PadRight(40, 'T');
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "";
            Address = Address.PadRight(41, 'T');
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsFalse(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void AddressMid()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "";
            Address = Address.PadRight(20, 'T');
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsFalse(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void PostCodeMin()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Te";
            string PostCode = "L";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void PostCodePlusOne()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "Le";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "Le12 9BH1";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void PostCodeMax()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "Le12 BH12";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "Le122 9BH99";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsFalse(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void PostCodeMid()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "Le1 9";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void PhoneNoMin()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Te";
            string PostCode = "Le1 9BH";
            string PhoneNo = "0";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void PhoneNoPlusOne()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void PhoneNoMaxLessOne()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "Le1 9BH";
            string PhoneNo = "0712345678";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void PhoneNoMax()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void PhoneNoMaxPlusOne()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "Le122 9BH99";
            string PhoneNo = "071234567891";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsFalse(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void PhoneNoMid()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }


        [TestMethod]
        public void RoomCapacityMin()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Te";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "3";
            string DateAdded = DateTime.Now.Date.ToString();
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void RoomCapacityPlusOne()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "30";
            string DateAdded = DateTime.Now.Date.ToString();
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void RoomCapacityMaxLessOne()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            string DateAdded = DateTime.Now.Date.ToString();
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void RoomCapacityMax()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "3000";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void RoomCapacityMaxPlusOne()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "Le122 9BH99";
            string PhoneNo = "07123456789";
            string RoomCapacity = "30001";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsFalse(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void RoomCapacityMid()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "30";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsTrue(OK); //test to see that the result is correct
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsHotel AHotel = new clsHotel(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation
            //create some test data to pass the method
            string Name = "Premier Inn";
            string Address = "Test Street";
            string PostCode = "Le1 9BH";
            string PhoneNo = "07123456789";
            string RoomCapacity = "300";
            DateTime TestDate; //create a variable to store the test data
            TestDate = DateTime.Now.Date; //set the date to todaus date
            TestDate = TestDate.AddYears(-100); //change current time to 100 years less
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AHotel.Valid(Name, Address, PostCode, PhoneNo, RoomCapacity, DateAdded);
            Assert.IsFalse(OK); //test to see that the result is correct
        }
    }
}
