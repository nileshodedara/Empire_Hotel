using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace ClassLibrary
{
    /// <summary>
    /// Summary description for RoomsTest
    /// </summary>
    [TestClass]
    public class UnitTestRoom
    {
        public UnitTestRoom()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void InstanceOk()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Assert.IsNotNull(NewRoom); //test to see that it exists
        }

        [TestMethod]
    public void PropertyRoomOk()
    {
        clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
        Int32 TestData = 7; //create some test data to assign to the property
        NewRoom.RoomNo = TestData; //assign the data to the property 
        Assert.AreEqual(NewRoom.RoomNo, TestData); //test to see the two values are the same
    }


        [TestMethod]
        public void PropertyInventoryOk()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            string TestData = "BlowDryer"; //create some test data to assign to the property
            NewRoom.Inventory = TestData; //assign the data to the property 
            Assert.AreEqual(NewRoom.Inventory, TestData); //test to see the two values are the same
          
        }


        [TestMethod]
        public void RoomTypeOk()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            string TestData = "Family Bed"; //create some test data to assign to the property
            NewRoom.RoomType = TestData; //assign the data to the property 
            Assert.AreEqual(NewRoom.RoomType, TestData); //test to see the two values are the same

        }

        [TestMethod]
        public void HouseKeepingOk()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean TestData = true; //create some test data to assign to the property
            NewRoom.HouseKeeping = TestData; //assign the data to the property 
            Assert.AreEqual(NewRoom.HouseKeeping, TestData); //test to see the two values are the same

        }

        [TestMethod]
        public void HotelIDOk()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Int32 TestData = 7; //create some test data to assign to the property
            NewRoom.HotelID = TestData; //assign the data to the property 
            Assert.AreEqual(NewRoom.HotelID, TestData); //test to see the two values are the same

        }

        //[TestMethod]
        //public void FindMethodOk()
        //{
        //    clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
        //    Boolean Found = false; // boolean variable to store the results of the validation
        //    Int32 ARoom = 1; //create some test data to use with the method 
        //   // Found = ARoom.Find(RoomNo); //invoke the method
        //    Assert.IsTrue(Found); // test to see that the result is correct
        //}












    }

 
}
