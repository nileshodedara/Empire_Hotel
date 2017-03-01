using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace UnitTestCustomer
{
    [TestClass]
    public class UnitTestBookingCollection
    {
        [TestMethod]
        public void InstantOk()
        {
            //create an instans of the class we wants to create
            clsBookingCollection AllBookings = new clsBookingCollection();
            //test to see that it exists
            Assert.IsNotNull(AllBookings);
        }

        [TestMethod]
        public void BookingListOk()
        {
            //create an instans of the class we wants to create
            clsBookingCollection AllBookings = new clsBookingCollection();
            //create some test data to asig to the propertiy
            List<clsBooking> TestList = new List<clsBooking>;
            //add an item to the list
            //create an item of the test data
            clsBooking TestItem = new clsBooking();
            //set the properties
            TestItem.BookingID = 1;
            TestItem.CustomerID = 1;
            TestItem.HotelID = 1;
            TestItem.RoomNo = 1;
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.CheckInDate = DateTime.Now.Date.AddDays(2);
            TestItem.CheckOutDate = DateTime.Now.Date.AddDays(4);
            TestItem.NumOfNights = 2;
            //add the item to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllBookings.BookingList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllBookings.BookingList, TestList);
        }
    }
}
