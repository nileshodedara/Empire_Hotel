using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
//using BookingLibrary;

namespace ClassLibrary
{
    [TestClass]
    public class BookingUnitTest
    {
        [TestMethod]
        public void InstanceOk()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //test to see it exists
            Assert.IsNotNull(aBooking);
        }
        [TestMethod]
        public void BookingDatePropertyOk()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //creat some test data to ashing to the property
            DateTime testData = DateTime.Now;
            //assign the data to the property
            aBooking.BookingDate = testData;
            //test to see that two values are same
            Assert.AreEqual(aBooking.BookingDate, testData);
        }

        [TestMethod]
        public void BookingIDOk()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //creat some test data to ashing to the property
            Int32 testData = 100;
            //assign the data to the property
            aBooking.BookingID = testData;
            //test to see that two values are same
            Assert.AreEqual(aBooking.BookingID, testData);
        }

        [TestMethod]
        public void CheckInDateOk()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //creat some test data to ashing to the property
            DateTime testData = DateTime.Now ;
            //assign the data to the property
            aBooking.CheckInDate = testData;
            //test to see that two values are same
            Assert.AreEqual(aBooking.CheckInDate, testData);
        }


        [TestMethod]
        public void CheckOutDateOk()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //creat some test data to ashing to the property
            DateTime testData = DateTime.Now;
            //assign the data to the property
            aBooking.CheckOutDate = testData;
            //test to see that two values are same
            Assert.AreEqual(aBooking.CheckOutDate, testData);
        }

        [TestMethod]
        public void CustomerIDOk()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //creat some test data to ashing to the property
            Int32 testData = 100;
            //assign the data to the property
            aBooking.CustomerID = testData;
            //test to see that two values are same
            Assert.AreEqual(aBooking.CustomerID, testData);
        }

        [TestMethod]
        public void HotelIDOk()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //creat some test data to ashing to the property
            Int32 testData = 100;
            //assign the data to the property
            aBooking.HotelID = testData;
            //test to see that two values are same
            Assert.AreEqual(aBooking.HotelID, testData);
        }

        [TestMethod]
        public void NumOfNightsOk()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //creat some test data to ashing to the property
            Int32 testData = 100;
            //assign the data to the property
            aBooking.NumOfNights = testData;
            //test to see that two values are same
            Assert.AreEqual(aBooking.NumOfNights, testData);
        }

        [TestMethod]
        public void RoomNoOk()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //creat some test data to ashing to the property
            Int32 testData = 100;
            //assign the data to the property
            aBooking.RoomNo = testData;
            //test to see that two values are same
            Assert.AreEqual(aBooking.RoomNo, testData);
        }


        [TestMethod]
        public void FindMethodOk()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 BookingID = 1;
            //invoke the method
            Found = aBooking.Find(BookingID);          
            //test to see that two values are same
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void ValidateMethodOk()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 BookingID = 1;
            //invoke the method
            Found = aBooking.Validate(BookingID);
            //test to see that two values are same
            Assert.IsTrue(Found);
        }
    }
}
