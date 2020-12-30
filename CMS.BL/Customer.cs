using System;
using System.Collections.Generic;


namespace CMS.BL
{
    public class Customer : EntityBase , ILoggable
    {
        public Customer() : this (0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            addressList = new List<Address>();
        }

        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> addressList { get; set; }

        public static int countInstances;
        // lastName, firstName

        public string FUllName
        {
            get
            {
                string fullName = LastName;
                if (!String.IsNullOrWhiteSpace(FirstName))
                {
                    if (!String.IsNullOrWhiteSpace(fullName))
                        fullName += ", ";

                    fullName += FirstName;
                }

                return fullName;

            }
        }

        
        public override string ToString() => FUllName;
        
        public override bool Validate()
        {
            if (string.IsNullOrWhiteSpace(EmailAddress)) return false;
            if (string.IsNullOrWhiteSpace(LastName)) return false;

            return true;
        }

        public string log() => $"{CustomerId}, Name: {FUllName} , Email: {EmailAddress}";
    }
}
