using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            var address = new Address(addressId);

            if (addressId == 1)
            {
                address.StreetLine1 = "sadat";
                address.StreetLine2 = "orabi";
                address.CityName = "cairo";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveAddressById(int addressId)
        {

            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                StreetLine1 = "str1",
                StreetLine2 = "str2",
                CityName = "city1"
            };

            addressList.Add(address);

            address = new Address(2)
            {
                StreetLine1 = "str11",
                StreetLine2 = "str22",
                CityName = "city2"
            };

            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }

    }
}
