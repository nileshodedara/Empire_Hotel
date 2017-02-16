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
            Assert.AreEqual(ACustomer.Address,testdata);

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
      
    }
}
