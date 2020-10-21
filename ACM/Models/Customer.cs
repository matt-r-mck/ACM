﻿using ACM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {

      public int CustomerId { get; private set; }
      public List<Address> AddressList { get; set; }
      public string Email { get; set; }
      public string FirstName { get; set; }

      private string _lastName;

      public string LastName
      {
         get { return _lastName; }
         set { _lastName = value; }
      }


      public string FullName
      {
         get
         {
            string fullName = LastName;
            if (!string.IsNullOrWhiteSpace(FirstName))
            {
               if (!string.IsNullOrWhiteSpace(fullName))
               {
                  fullName += ", ";
               }
               fullName += FirstName;
            }
            return fullName;
         }
      }

      public bool Validate()
      {
         var isValid = true;

         if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
         if (string.IsNullOrWhiteSpace(Email)) isValid = false;

         return isValid;
      }

      public Customer(): this(0) {}

      public Customer(int customerId)
      {
         this.CustomerId = customerId;
         AddressList = new List<Address>();
      }

   }
}
