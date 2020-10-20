using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Models
{
   public class Order
   {
      public DateTimeOffset? OrderDate { get; set; }
      public int OrderId { get; set; }
      public bool Validate()
      {
         var isValid = true;

         if (OrderDate == null) isValid = false;

         return isValid;
      }

      public Order()
      {

      }

      public Order(int orderId)
      {
         this.OrderId = orderId;
      }
   }
}
