﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Models
{
   class OrderItem
   {
      public int ProductId { get; set; }
      public int Quantity { get; set; }
      public decimal? PurchasePrice { get; set; }
      public int OrderItemId { get; set; }

      public bool Validate()
      {
         var isValid = true;

         if (Quantity <= 0) isValid = false;
         if (ProductId <= 0) isValid = false;
         if (PurchasePrice == null) isValid = false;

         return isValid;
      }

      public OrderItem Retrieve(int orderItemId)
      {
         return new OrderItem();
      }

      public List<OrderItem> Retrieve()
      {
         return new List<OrderItem>();
      }

      public bool Save()
      {
         return true;
      }

      public OrderItem()
      {

      }

      public OrderItem(int orderItemId)
      {
         this.OrderItemId = orderItemId;
      }

   }
}
