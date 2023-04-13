using System.Data;
using System.Data.SqlClient;
using TT.Data.DataContracts;
using TT.Data.Entities;
using static TT.Common.Enums.Enums;

namespace TT.Data.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private DataTable _addressTable = null;
        public DataTable AddressTable { get => _addressTable ??= FillAddressTable(); }
        public AddressRepository() { }

        private DataTable FillAddressTable()
        {
            var dataSet = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getAddressTable]");
            DataTable addressTable = dataSet.Tables[0];

            addressTable.Columns["Address_Id"].AutoIncrement = true;
            addressTable.Columns["Address_Id"].AutoIncrementSeed = 1;
            addressTable.Columns["Address_Id"].AutoIncrementStep = 1;

            addressTable.AcceptChanges();
            return addressTable;
        }

        public Address GetNewAddress()
        {
            return new Address(AddressTable.NewRow());
        }

        public Address AddNewAddress(Address proposed)
        {
            proposed.Id = InsertAddress(proposed.Address_Type, proposed.Street, proposed.Supplemental, proposed.City, proposed.State, proposed.ZipCode, proposed.PersonId);
            AddressTable.AcceptChanges();
            return proposed;
        }
        private int InsertAddress(int addressType, string street, string supplemental, string city, State state, string zipCode, int personId)
        {
            var addressTypeParam = DataAccess.BuildParameter(nameof(addressType), SqlDbType.Int, addressType, false);
            var streetParam = DataAccess.BuildParameter(nameof(street), SqlDbType.VarChar, street, false);
            var supplementalParam = DataAccess.BuildParameter(nameof(supplemental), SqlDbType.VarChar, supplemental, false);
            var cityParam = DataAccess.BuildParameter(nameof(city), SqlDbType.VarChar, city, false);
            var stateParam = DataAccess.BuildParameter(nameof(state), SqlDbType.Int, state, false);
            var zipCodeParam = DataAccess.BuildParameter(nameof(zipCode), SqlDbType.VarChar, zipCode, false);
            var personIdParam = DataAccess.BuildParameter(nameof(personId), SqlDbType.Int, personId, false);

            var sqlParameters = new SqlParameter[] { addressTypeParam, streetParam, supplementalParam, cityParam, stateParam, zipCodeParam, personIdParam };
            return DataAccess.TTDataBase.ExecScaler("[stp_insertNewAddress]", sqlParameters);
        }
        public Address GetAddressById(int id)
        {
            throw new NotImplementedException();
        }  
        public Address GetShippingAddressByPersonId(int personId)
        {
            var personIdParam = DataAccess.BuildParameter(nameof(personId), SqlDbType.Int, personId, false);
            var sqlParameters = new SqlParameter[] { personIdParam };

            DataSet ds = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getShippingAddressByPersonId]", sqlParameters);
            return new Address(ds.Tables[0].Rows[0]);
        }
        public Address GetBillingAddressByPersonId(int personId)
        {
            var personIdParam = DataAccess.BuildParameter(nameof(personId), SqlDbType.Int, personId, false);
            var sqlParameters = new SqlParameter[] { personIdParam };

            DataSet ds = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getBillingAddressByPersonId]", sqlParameters);
            if (ds.Tables[0].Rows.Count != 0)
            {
                return new Address(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
            
        }

        public int UpdateAddress(Address proposed)
        {
            int addressId = proposed.Id;

            var addressIdParam = DataAccess.BuildParameter(nameof(addressId), SqlDbType.Int, addressId, false);
            var addressTypeParam = DataAccess.BuildParameter(nameof(proposed.Address_Type), SqlDbType.Int, proposed.Address_Type, false);
            var streetParam = DataAccess.BuildParameter(nameof(proposed.Street), SqlDbType.VarChar, proposed.Street, false);
            var supplementalParam = DataAccess.BuildParameter(nameof(proposed.Supplemental), SqlDbType.VarChar, proposed.Supplemental, false);
            var cityParam = DataAccess.BuildParameter(nameof(proposed.City), SqlDbType.VarChar, proposed.City, false);
            var stateParam = DataAccess.BuildParameter(nameof(proposed.State), SqlDbType.Int, proposed.State, false);
            var zipCodeParam = DataAccess.BuildParameter(nameof(proposed.ZipCode), SqlDbType.VarChar, proposed.ZipCode, false);
            var personIdParam = DataAccess.BuildParameter(nameof(proposed.PersonId), SqlDbType.Int, proposed.PersonId, false);

            var sqlParameters = new SqlParameter[] { addressIdParam, addressTypeParam, streetParam, supplementalParam, cityParam, stateParam, zipCodeParam, personIdParam };

            return DataAccess.TTDataBase.ExecScaler("[dbo].[stp_updateAddress]", sqlParameters);
        }

        public int DeleteAddressById(int addressId)
        {
            var addressIdParam = DataAccess.BuildParameter(nameof(addressId), SqlDbType.Int, addressId, false);
            var sqlParameters = new SqlParameter[] { addressIdParam };

            return DataAccess.TTDataBase.ExecScaler("[dbo].[stp_deleteAddressById]", sqlParameters);
        }

        public Address DeleteAddress(Address proposed)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Address> GetAddresses()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Address> GetAddressesByPersonName(string findAddress)
        {
            throw new NotImplementedException();
        }
       
    }
}
