﻿using ACM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
   public class ProductRepository
   {

      public Product Retrieve(int productId)
      {
         Product product = new Product(productId);

         if(productId == 2)
         {
            product.Name = "Sunflowers";
            product.Description = "Assorted Sunflowers";
            product.CurrentPrice = 15.96M;
         }
         return product;
      }

      public bool Save (Product product)
      {
         return true;
      }

   }
}
