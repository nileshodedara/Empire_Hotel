using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
//using BookingLibrary;

namespace ClassLibrary
{
    [TestClass]
    public class UnitTestBooking
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
            //var to store NumOfNights
            string NumOfNights;
            //asign some data to var
            NumOfNights = "1";
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Found = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that two values are same
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void NumOfNightsMinLessOne()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights;
            //asign some data to var
            NumOfNights = "0";
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void NumOfNightsMinBoundary()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights;
            //asign some data to var
            NumOfNights = "1";
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void NumOfNightsMinPlusOne()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights;
            //asign some data to var
            NumOfNights = "2";
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void NumOfNightsMaxLessOne()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights;
            //asign some data to var
            NumOfNights = "29";
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void NumOfNightsMaxBoundary()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights;
            //asign some data to var
            NumOfNights = "29";
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void NumOfNightsMaxPlusOne()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights;
            //asign some data to var
            NumOfNights = "31";
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void NumOfNightsMidBoundary()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights;
            //asign some data to var
            NumOfNights = "15";
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void NumOfNightsExtreamMax()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights;
            //asign some data to var
            NumOfNights = "1000";
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void BookingDateExtremeMin()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(-100);
            //var to store BookingDate
            string BookigDate =TestDate.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void BookingDateMinLessOne()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(-1);
            //var to store BookingDate
            string BookigDate = TestDate.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void BookingDateMinBoundary()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date;
            //var to store BookingDate
            string BookigDate = TestDate.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void BookingDateMinPlusOne()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(1);
            //var to store BookingDate
            string BookigDate = TestDate.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void BookingDateMaxLessOne()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(-1);
            //var to store BookingDate
            string BookigDate = TestDate.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void BookingDateMaxBoundary()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date;
            //var to store BookingDate
            string BookigDate = TestDate.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void BookingDateMaxPlusOne()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(1);
            //var to store BookingDate
            string BookigDate = TestDate.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void BookingDateMidBoundary()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date;
            //var to store BookingDate
            string BookigDate = TestDate.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void BookingDateExtremeMax()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(100);
            //var to store BookingDate
            string BookigDate = TestDate.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void BookingDateInvalidData()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
           // DateTime TestDate;
            //asign some data to testdata
            //TestDate = DateTime.Now.Date.AddDays(100);
            //var to store BookingDate
            string BookigDate = "this is not a date";
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }


        [TestMethod]
        public void CheckInDateExtremeMini()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(-100);
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = TestDate.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CheckInDateMiniLessOne()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(-1);
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = TestDate.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CheckInDateMiniBoundary()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date;
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = TestDate.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CheckInDateMiniPlusOne()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(1);
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = TestDate.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.AddDays(20).ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void CheckInDateMaxLessOne()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(29);
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = TestDate.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.AddDays(35).ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CheckInDateMaxBoundary()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(30);
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = TestDate.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.AddDays(35).ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CheckInDateMaxPlusOne()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(31);
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = TestDate.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CheckInDateMidBoundary()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(15);
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = TestDate.ToString();
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.AddDays(35).ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void CheckInDateDateInvalidData()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            // DateTime TestDate;
            //asign some data to testdata
            //TestDate = DateTime.Now.Date.AddDays(100);
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = "this is not a date";
            //var to store CheckOutDate
            string CheckOutDate = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CheckOutDateExtremeMini()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(-100);
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = TestDate.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CheckOutDateMiniLessOne()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(-1);
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = TestDate.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }


        [TestMethod]
        public void CheckOutDateMiniBoundary()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date;
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = TestDate.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CheckOutDateMiniPlusOne()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(1);
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = TestDate.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CheckOutDateMaxLessOne()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(29);
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = TestDate.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CheckOutDateMaxBoundary()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(30);
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = TestDate.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CheckOutDateMaxPlusOne()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(31);
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = TestDate.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CheckOutDateMidBoundary()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(15);
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = TestDate.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CheckOutDateExtremeMax()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            DateTime TestDate;
            //asign some data to testdata
            TestDate = DateTime.Now.Date.AddDays(100);
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = TestDate.ToString();
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void CheckOutDateInvalidData()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Ok = false;
            //var to store NumOfNights
            string NumOfNights = "15";
            //create a var to store test data
            // DateTime TestDate;
            //asign some data to testdata
            //TestDate = DateTime.Now.Date.AddDays(100);
            //var to store BookingDate
            string BookigDate = DateTime.Now.Date.ToString();
            //var to store checkInDate
            string CheckInDate = DateTime.Now.Date.ToString();
            //var to store CheckOutDate
            string CheckOutDate = "this is not a date";
            //invoke the method
            Ok = aBooking.Valid(NumOfNights, BookigDate, CheckInDate, CheckOutDate);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void BookingIdFound()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Found = false;
            //boolean var to record if data is ok
            Boolean Ok = true;                    
            //create some test data to use with the method
            Int32 BookingID = 1;
            //invoke the method
            Found = aBooking.Find(BookingID);
            //chechk the data is num
            if (aBooking.BookingID !=1)
            {
                Ok = false;
            }
            //test to see that two values are same
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CustomerIdFound()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Found = false;
            //boolean var to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 BookingID = 1;
            //invoke the method
            Found = aBooking.Find(BookingID);
            //chechk the data is num
            if (aBooking.CustomerID != 1)
            {
                Ok = false;
            }
            //test to see that two values are same
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void HotelIdFound()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Found = false;
            //boolean var to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 BookingID = 1;
            //invoke the method
            Found = aBooking.Find(BookingID);
            //chechk the data is num
            if (aBooking.HotelID != 1)
            {
                Ok = false;
            }
            //test to see that two values are same
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void RoomNoFound()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Found = false;
            //boolean var to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 BookingID = 1;
            //invoke the method
            Found = aBooking.Find(BookingID);
            //chechk the data is num
            if (aBooking.RoomNo != 1)
            {
                Ok = false;
            }
            //test to see that two values are same
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void BookingDateFound()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Found = false;
            //boolean var to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 BookingID = 1;
            //invoke the method
            Found = aBooking.Find(BookingID);
            //chechk the data is num
            if (aBooking.BookingDate != Convert.ToDateTime("22/2/2017"))
            {
                Ok = false;
            }
            //test to see that two values are same
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CheckInDateFound()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Found = false;
            //boolean var to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 BookingID = 1;
            //invoke the method
            Found = aBooking.Find(BookingID);
            //chechk the data is num
            if (aBooking.CheckInDate != Convert.ToDateTime("22/2/2017"))
            {
                Ok = false;
            }
            //test to see that two values are same
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void CheckOutDateFound()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Found = false;
            //boolean var to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 BookingID = 1;
            //invoke the method
            Found = aBooking.Find(BookingID);
            //chechk the data is num
            if (aBooking.CheckOutDate != Convert.ToDateTime("22/2/2017"))
            {
                Ok = false;
            }
            //test to see that two values are same
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void NumOfNightsFound()
        {
            //creat an instance of clsBooking class
            clsBooking aBooking = new clsBooking();
            //boolean var to store the result of the validation
            Boolean Found = false;
            //boolean var to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 BookingID = 1;
            //invoke the method
            Found = aBooking.Find(BookingID);
            //chechk the data is num
            if (aBooking.NumOfNights != 1)
            {
                Ok = false;
            }
            //test to see that two values are same
            Assert.IsTrue(Ok);
        }
    }
}
