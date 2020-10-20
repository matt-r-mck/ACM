using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Models
{
   public class Product
   {
      public string Name { get; set; }
      public string Description { get; set; }
      public decimal? CurrentPrice { get; set; }
      public int ProductId { get; set; }

      public bool Validate()
      {
         var isValid = true;

         if (string.IsNullOrWhiteSpace(Name)) isValid = false;
         if (CurrentPrice == null) isValid = false;

         return isValid;
      }

      public Product()
      {

      }

      public Product(int productId)
      {
         this.ProductId = productId;
      }

   }
}
