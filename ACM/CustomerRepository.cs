using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
   public class CustomerRepository
   {
      public Customer Retrieve (int customerId)
      {
         Customer customer = new Customer(customerId);

         if (customerId == 1)
         {
            customer.Email = "fbaggins@gmail.com";
            customer.FirstName = "frodo";
            customer.LastName = "baggins";
         }
         return customer;
      }

      public bool Save(Customer customer)
      {
         return true;
      }
   }
}
