using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
   /// <summary>
   /// Summary description for CustomerRepositoryTest
   /// </summary>
   [TestClass]
   public class CustomerRepositoryTest
   {

      [TestMethod]
      public void RetrieveValid()
      {
         //Arrange

         var customerRepository = new CustomerRepository();
         var expected = new Customer(1)
         {
            Email = "fbaggins@gmail.com",
            FirstName = "Frodo",
            LastName = "Baggins"
         };

         //Act

         var actual = customerRepository.Retrieve(1);

         //Assert

         Assert.AreEqual(expected, actual);

      }
   }
}
