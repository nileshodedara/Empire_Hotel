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

        //test
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
            AStaff.Address = TestData;
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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //test to see that it exists
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void FirstNameMinLessONE()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "R";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "JO";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMinplusone()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "JOE";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void FirstNameMAXlessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "JOEEEEEEEEE";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMAXBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "JOEEEEEEEEEe";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMAXPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "JOEEEEEEEEEEE";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "JOEEEE";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'a'); //this should fail
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateJoinedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            string DateJoined = TestDate.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateJoinedMinLessONE()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-10);
            //convert the date variable to a string variable 
            string DateJoined = TestDate.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateJoinedMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            //TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            string DateJoined = TestDate.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateJoinedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable 
            string DateJoined = TestDate.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateJoinedMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable 
            string DateJoined = TestDate.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateJoinedMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            //TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            string DateJoined = TestDate.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateJoinedMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddMonths(1);
            //convert the date variable to a string variable 
            string DateJoined = TestDate.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateJoinedMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            //TestDate = TestDate.AddMonths(1);
            //convert the date variable to a string variable 
            string DateJoined = TestDate.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DateJoinedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(10);
            //convert the date variable to a string variable 
            string DateJoined = TestDate.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateJoinedInvalidDate()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "staff";
            //create a variable to store the test date data
            //DateTime TestDate;
            //set the date to todays date
            //TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            //TestDate = TestDate.AddYears(10);
            //convert the date variable to a string variable 
            string DateJoined = "No date";
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void JobTitleMinLessONe()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "rece";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void JobTitleMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "recep";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void JobTitleMinplusone()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "recesp";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void JobTitleMaxlessone()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "";
            JobTitle = JobTitle.PadRight(14, 'a');
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void JobTitleMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "";
            JobTitle = JobTitle.PadRight(15, 'a');
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void JobTitleMaxplusone()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "";
            JobTitle = JobTitle.PadRight(16, 'a');
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void JobTitleMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "";
            JobTitle = JobTitle.PadRight(7, 'a');
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void JobTitleExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "07858282521";
            string Address = "11 flue road";
            string JobTitle = "";
            JobTitle = JobTitle.PadRight(50, 'a');
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PhoneNumberMinlessone()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "0116257";
            string Address = "11 flue road";
            string JobTitle = "staff";

            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PhoneNumberMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "01162575";
            string Address = "11 flue road";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void PhoneNumberMinplusone()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "011625755";
            string Address = "11 flue road";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void PhoneNumberMaxlessone()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(14, 'a');
            string Address = "11 flue road";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PhoneNumberMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(15, 'a');
            string Address = "11 flue road";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PhoneNumberMaxplusone()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(16, 'a');
            string Address = "11 flue road";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(11, 'a');
            string Address = "11 flue road";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(50, 'a');
            string Address = "11 flue road";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "0115544514";
            // PhoneNumber = PhoneNumber.PadRight(14, 'a');
            string Address = "11Rd";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "0115544514";
            // PhoneNumber = PhoneNumber.PadRight(14, 'a');
            string Address = "11Rds";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMinplusone()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "0115544514";
            // PhoneNumber = PhoneNumber.PadRight(14, 'a');
            string Address = "11Rdsd";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMaxlessone()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "0115544514";
            // PhoneNumber = PhoneNumber.PadRight(14, 'a');
            string Address = "";
            Address = Address.PadRight(14, 'a');
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "0115544514";
            // PhoneNumber = PhoneNumber.PadRight(14, 'a');
            string Address = "";
            Address = Address.PadRight(15, 'a');
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMaxplusone()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "0115544514";
            // PhoneNumber = PhoneNumber.PadRight(14, 'a');
            string Address = "";
            Address = Address.PadRight(16, 'a');
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "0115544514";
            // PhoneNumber = PhoneNumber.PadRight(14, 'a');
            string Address = "";
            Address = Address.PadRight(10, 'a');
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4 1tv";
            string PhoneNumber = "0115544514";
            // PhoneNumber = PhoneNumber.PadRight(14, 'a');
            string Address = "";
            Address = Address.PadRight(50, 'a');
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le41t";
            string PhoneNumber = "0115544514";
            // PhoneNumber = PhoneNumber.PadRight(14, 'a');
            string Address = "";
            //Address = Address.PadRight(14, 'a');
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostCodeBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le41tz";
            string PhoneNumber = "0115544514";
            string Address = "23burnclose";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le41tzs";
            string PhoneNumber = "0115544514";
            string Address = "23burnclose";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodeMaxlessone()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le41tze";
            string PhoneNumber = "0115544514";
            string Address = "23burnclose";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodeMAXBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le41tzrd";
            string PhoneNumber = "0115544514";
            string Address = "23burnclose";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodeMAXplusone()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le41tzrkk";
            string PhoneNumber = "0115544514";
            string Address = "23burnclose";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "le4tess";
            string PhoneNumber = "0115544514";
            string Address = "23burnclose";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kanabar";
            string PostCode = "";
            PostCode = PostCode.PadRight(50, 'a');
            string PhoneNumber = "0115544514";
            string Address = "23burnclose";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kn";
            string PostCode = "le41tzrd";
            string PhoneNumber = "0115544514";
            string Address = "23burnclose";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kan";
            string PostCode = "le41tzrd";
            string PhoneNumber = "0115544514";
            string Address = "23burnclose";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void LastNameMinPlusCode()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kana";
            string PostCode = "le41tzrd";
            string PhoneNumber = "0115544514";
            string Address = "23burnclose";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMaxlessone()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "";
            LastName = LastName.PadRight(14, 'a');
            string PostCode = "le41tzrd";
            string PhoneNumber = "0115544514";
            string Address = "23burnclose";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "Kn";
            LastName = LastName.PadRight(15, 'a');
            string PostCode = "le41tzrd";
            string PhoneNumber = "0115544514";
            string Address = "23burnclose";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "";
            LastName = LastName.PadRight(16, 'a');
            string PostCode = "le41tzrd";
            string PhoneNumber = "0115544514";
            string Address = "23burnclose";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "";
            LastName = LastName.PadRight(5, 'a');
            string PostCode = "le41tzrd";
            string PhoneNumber = "0115544514";
            string Address = "23burnclose";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to use with the method
            string FirstName = "Rakhee";
            string LastName = "";
            LastName = LastName.PadRight(50, 'a');
            string PostCode = "le41tzrd";
            string PhoneNumber = "0115544514";
            string Address = "23burnclose";
            string JobTitle = "staff";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            OK = AStaff.Valid(FirstName, LastName, PostCode, PhoneNumber, Address, JobTitle, DateJoined);
            //test to see that it exists
            Assert.IsFalse(OK);
        }







    }



}


