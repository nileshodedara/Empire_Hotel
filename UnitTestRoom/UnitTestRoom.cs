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
        public void HotelIDOk()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Int32 TestData = 7; //create some test data to assign to the property
            NewRoom.HotelID = TestData; //assign the data to the property 
            Assert.AreEqual(NewRoom.HotelID, TestData); //test to see the two values are the same

        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean Found = false; // boolean variable to store the results of the validation
            Int32 RoomNumber = 1; //create some test data to use with the method 
            Found = NewRoom.Find(RoomNumber); //invoke the method
            Assert.IsTrue(Found); // test to see that the result is correct
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variablw to store the result of the validation 
            string HotelID = "Hilton10AD";
            string Inventory = "Blow Dryer";
            string RoomType = "Family Bed"; //create some test data to pass to the method 
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //test to see that the result is correct
            Assert.IsTrue(OK); //test to see that the result is correct        
        }

        [TestMethod]
        public void HotelIDMinusOne()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string HotelID = ""; // this should trigger an error 
            string Inventory = "Blow Dryer";
            string RoomType = "Family Bed";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void HotelIDMin()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string HotelID = "H"; // this should be ok
            string Inventory = "Blow Dryer";
            string RoomType = "Family Bed";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void HotelIDMinPlusOne()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string HotelID = "HL"; // this should be ok 
            string Inventory = "Blow Dryer";
            string RoomType = "Family Bed";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HotelIDMaxMinusOne()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string HotelID = "HLTN10AD8"; // this should be ok
            string Inventory = "Blow Dryer";
            string RoomType = "Family Bed";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void HotelIDBoundary()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string HotelID = "HLTN100AAD"; // this should be ok
            string Inventory = "Blow Dryer";
            string RoomType = "Family Bed";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HotelIDBoundaryPlusOne()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string HotelID = "HLTN100AADe"; // this should trigger an error 
            string Inventory = "Blow Dryer";
            string RoomType = "Family Bed";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void HotelIDMid()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string HotelID = "HLTN1"; // this should be ok 
            string Inventory = "Blow Dryer";
            string RoomType = "Family Bed";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void HotelIDExtremeMax()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string HotelID = "";
            HotelID = HotelID.PadRight(500, 'H'); // this should trigger an error
            string Inventory = "Blow Dryer";
            string RoomType = "Family Bed";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void RoomTypeMinusOne()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string RoomType = ""; // this should trigger an error 
            string HotelID = "HLT10AD";
            string Inventory = "Blow Dryer";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void RoomTypeMin()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string RoomType = "T"; // this should be ok
            string HotelID = "HLT10AD";
            string Inventory = "Blow Dryer";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void RoomTypeMinPlusOne()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string RoomType = "Twin B"; // this should be ok
            string HotelID = "HLT10AD";
            string Inventory = "Blow Dryer";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void RoomTypeMaxMinusOne()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string RoomType = "STANTwin B"; // this should be ok
            string HotelID = "HLT10AD";
            string Inventory = "Blow Dryer";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void RoomTypeMax()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string RoomType = "Family Bed"; // this should be ok
            string HotelID = "HLT10AD";
            string Inventory = "Blow Dryer";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void RoomTypeMaxPlusOne()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string RoomType = "STDN Twin Bed"; // this should trigger and error
            string HotelID = "HLT10AD";
            string Inventory = "Blow Dryer";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void RoomTypeMid()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string RoomType = "STDN T "; // this should be ok
            string HotelID = "HLT10AD";
            string Inventory = "Blow Dryer";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void RoomTypeExtremeMax()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string RoomType = ""; // this should trigger an error
            RoomType = RoomType.PadRight(200, 'H');
            string HotelID = "HLT10AD";
            string Inventory = "Blow Dryer";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void InventoryMinusOne()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string HotelID = "HLT10AD";
            string Inventory = "";// this should trigger an error 
            string RoomType = "Family Bed";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void InventoryMin()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string HotelID = "HLT10AD";
            string Inventory = "B";// this should trigger an error 
            string RoomType = "Family Bed";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void InventoryMinPlusOne()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string HotelID = "HLT10AD";
            string Inventory = "B D";// this should trigger an error 
            string RoomType = "Family Bed";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void InventoryMaxMinusOne()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string HotelID = "HLT10AD";
            string Inventory = "BlowDryer, Towel";// this should be ok 
            string RoomType = "Family Bed";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void InventoryMax()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string HotelID = "HLT10AD";
            string Inventory = "BlowDryer, Towels";// this should be ok 
            string RoomType = "Family Bed";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void InventoryMaxPlusOne()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string HotelID = "HLT10AD";
            string Inventory = "BlowDryer, Towels, Sp";// this should trigger an error
            string RoomType = "Family Bed";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void InventoryMid()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string HotelID = "HLT10AD";
            string Inventory = "Iron, Kettle";// this should be ok 
            string RoomType = "Family Bed";
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void InventoryExtremeMax()
        {
            clsRooms NewRoom = new clsRooms(); //create an instance of the class we want to create
            Boolean OK = false; //boolean variable to store the result of the validation 
            string RoomType = "Family Bed";
            string HotelID = "HLT10AD";
            string Inventory = "";
            Inventory = Inventory.PadRight(500, 'I');// this should trigger an error
            OK = NewRoom.Valid(HotelID, Inventory, RoomType); //invoke the method 
            Assert.IsFalse(OK);
        }














    }












}

 

