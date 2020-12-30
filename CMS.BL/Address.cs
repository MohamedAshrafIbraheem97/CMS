using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class Address
    {
        public Address()
        {

        }
        public Address(int addressId)
        {
            AddressId = addressId;
        }
        public int AddressId { get; set; }
        public int AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string PostalCode { get; set; }
        public string CountryName { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(StreetLine1)) isValid = false;


            return isValid;
        }

    }
}
