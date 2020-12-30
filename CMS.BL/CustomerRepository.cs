using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            _addressRepository = new AddressRepository();
        }

        private AddressRepository _addressRepository { get; set; }


        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.FirstName = "Mohamed";
                customer.LastName = "Ashraf";
                customer.EmailAddress = "mohamed@gmail.com";
                customer.addressList = _addressRepository.RetrieveAddressById(customerId)
                                            .ToList();
            }

            Object objec = new Object();
            Console.WriteLine(objec.ToString());
            Console.WriteLine(customer.ToString());
            return customer;
        }

        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
                    {
                        //do save
                    }
                    else
                    {
                        // do update
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
