using System;
using ACM.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
   [TestClass]
   public class ProductRepositoryTest
   {
      [TestMethod]
      public void RetrieveTest()
      {
         //Arrange
         var productRepository = new ProductRepository();
         var expected = new Product(2)
         {
            CurrentPrice = 15.9M,
            Description = "Assorted Sunflowers",
            Name = "Sunflowers"
         };

         //Act
         var actual = productRepository.Retrieve(2);

         //Assert
         Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
         Assert.AreEqual(expected.Description, actual.Description);
         Assert.AreEqual(expected.Name, actual.Name);
      }
   }
}
