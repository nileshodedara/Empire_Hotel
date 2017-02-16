using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace ClassLibrary
{
    /// <summary>
    /// Summary description for StaffTest
    /// </summary>
    [TestClass]
    public class UnitTestStaff
    {
        public UnitTestStaff()
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
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void ActivePropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.Active = TestData;
            //test to see that it exists
            Assert.AreEqual(AStaff.Active, TestData);
        }

        [TestMethod]
        public void AddressPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "28 windsor avenve";
            //assign the data to the property
            AStaff.Address= TestData;
            //test to see that it exists
            Assert.AreEqual(AStaff.Address, TestData);
        }

        [TestMethod]
        public void DateJoinedPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DateJoined = TestData;
            //test to see that it exists
            Assert.AreEqual(AStaff.DateJoined, TestData);

        }
        [TestMethod]
        public void firstNamePropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Nilesh";
            //assign the data to the property
            AStaff.FirstName = TestData;
            //test to see that it exists
            Assert.AreEqual(AStaff.FirstName, TestData);
        }

        [TestMethod]
        public void JobTitlePropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Staff";
            //assign the data to the property
            AStaff.JobTitle = TestData;
            //test to see that it exists
            Assert.AreEqual(AStaff.JobTitle, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Koroma";
            //assign the data to the property
            AStaff.LastName = TestData;
            //test to see that it exists
            Assert.AreEqual(AStaff.LastName, TestData);
        }
        [TestMethod]
        public void PhoneNumberPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "0785556122";
            //assign the data to the property
            AStaff.PhoneNumber = TestData;
            //test to see that it exists
            Assert.AreEqual(AStaff.PhoneNumber, TestData);
        }
        [TestMethod]
        public void staffidPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 5367;
            //assign the data to the property
            AStaff.staffid = TestData;
            //test to see that it exists
            Assert.AreEqual(AStaff.staffid, TestData);
        }

        [TestMethod]
        public void PostcodePropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "le5 3tr";
            //assign the data to the property
            AStaff.Postcode = TestData;
            //test to see that it exists
            Assert.AreEqual(AStaff.Postcode, TestData);
        }




    }
}
