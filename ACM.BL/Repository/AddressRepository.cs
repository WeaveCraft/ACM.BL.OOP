using System.Collections.Generic;

namespace ACM.BL
{
    internal class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            //Create the instance of the Address class.
            //Pass in the requested Id.
            Address address = new Address(addressId);

            //Code that retrieves the defined address.

            //Temporary hard coded values to return a populated address.
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Eearth";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customer)//IEnumerable is the recommended way to retun a sequence of data becouse the results are more flexible for the callers of the method.
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            //Code that saves the passed in address.

            return true; //return true to note that the save operation was successfull
        }
    }
}
