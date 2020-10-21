using ACM.Models;
using System.Collections.Generic;

namespace ACM.BL
{
   public class AddressRepository
   {

      public Address Retrieve(int addressId)
      {
         Address address = new Address(addressId);

         if (addressId == 1)
         {
            address.AddressType = 1;
            address.StretLine1 = "Bag End";
            address.StreetLine2 = "Bagshot Row";
            address.City = "Hobbiton";
            address.State = "Shire";
            address.Country = "Middle Earth";
            address.PostalCode = "144";
         }
         return address;
      }

      public IEnumerable<Address> RetrieverByCustomerId(int customerId)
      {

         var addressList = new List<Address>();
         Address address = new Address(1)
         {
            address.AddressType = 1,
            address.StretLine1 = "Bag End",
            address.StreetLine2 = "Bagshot Row",
            address.City = "Hobbiton",
            address.State = "Shire",
            address.Country = "Middle Earth",
            address.PostalCode = "144",
         };
         addressList.Add(address);

         address = new Address(2)
         {
            address.AddressType = 2,
            address.StretLine1 = "Green Dragon",
            address.StreetLine2 = "Bywater",
            address.City = "Shire",
            address.State = "Shire",
            address.Country = "Middle Earth",
            address.PostalCode = "146",
         };
         addressList.Add(address);

         return addressList;
      }
 
      public bool SaveAddress(Address address)
      {
         return true;
      }

   }
}
