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
    public class MyTests
    {
        public MyTests()
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
    }
}
