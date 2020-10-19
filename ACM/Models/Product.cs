using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Models
{
   class Product
   {
      public string Name { get; set; }
      public string Description { get; set; }
      public double CurrentPrice { get; set; }

      public bool Validate()
      {
         var isValid = true;

         if (string.IsNullOrWhiteSpace(Name)) isValid = false;
         if (string.IsNullOrWhiteSpace(Description)) isValid = false;

         return isValid;
      }

      public Product Retrieve(int customerId)
      {
         return new Product();
      }

      public List<Product> Retrieve()
      {
         return new List<Product>();
      }

      public bool Save()
      {
         return true;
      }


   }
}
