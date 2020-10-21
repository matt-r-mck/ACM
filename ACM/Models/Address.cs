using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Models
{
   public class Address
   {
      public int AddressID { get; private set; }
      public int AddressType { get; set; }
      public string City { get; set; }
      public string Country { get; set; }
      public string PostalCode { get; set; }
      public string State { get; set; }
      public string StretLine1 { get; set; }
      public string StreetLine2 { get; set; }

      public bool Validate()
      {
         var isValid = true;

         if (PostalCode == null) isValid = false;

         return isValid;
      }

      public Address()
      {

      }

      public Address(int addressId)
      {
         this.AddressID = addressId;
      }
   }
}
