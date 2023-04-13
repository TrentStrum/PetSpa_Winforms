using System.Data;
using TT.Data.Entities;

namespace TT.Data.DataContracts
{
    public interface IAddressRepository
    {
        DataTable AddressTable { get; }
        Address GetNewAddress();
        Address GetAddressById(int id);
        Address AddNewAddress(Address proposed);
        int UpdateAddress(Address proposed);
        int DeleteAddressById(int addressId);
        Address DeleteAddress(Address proposed);
        IEnumerable<Address> GetAddresses();
        IEnumerable<Address> GetAddressesByPersonName(string findAddress);
        Address GetShippingAddressByPersonId(int personId);
        Address GetBillingAddressByPersonId(int personId);
    }
}
