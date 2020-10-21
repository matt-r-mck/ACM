﻿using ACM.BL;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL {
    public class CustomerRepository {
        public CustomerRepository() {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

        public Customer Retrieve(int customerId) {
            Customer customer = new Customer(customerId);

            if (customerId == 1) {
                customer.Email = "fbaggins@gmail.com";
                customer.FirstName = "frodo";
                customer.LastName = "baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        public bool Save(Customer customer) {
            return true;
        }
    }
}
