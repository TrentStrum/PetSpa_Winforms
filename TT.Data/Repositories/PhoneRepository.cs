using System.Data;
using System.Data.SqlClient;
using TT.Data.DataContracts;
using TT.Data.Entities;

namespace TT.Data.Repositories
{
    public class PhoneRepository : IPhoneRepository
    {
        private DataTable _phoneTable = null;
        public DataTable PhoneTable { get => _phoneTable ??= FillPhoneTable(); }
        public PhoneRepository() { }

        private DataTable FillPhoneTable()
        {
            var dataSet = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getPhoneTable]");
            DataTable phoneTable = dataSet.Tables[0];

            phoneTable.Columns["Phone_Id"].AutoIncrement = true;
            phoneTable.Columns["Phone_Id"].AutoIncrementSeed = 1;
            phoneTable.Columns["Phone_Id"].AutoIncrementStep = 1;

            phoneTable.AcceptChanges();
            return phoneTable;
        }

        public Phone GetNewPhone()
        {
            return new Phone(PhoneTable.NewRow());
        }

        public Phone GetPhoneById(int PersonId)
        {
            throw new NotImplementedException();
        }

        public Phone AddNewPhone(Phone proposed)
        {
            throw new NotImplementedException();
        }

        public int UpdatePhone(Phone proposed)
        {
            string mobilePhone = proposed.Mobile;
            string homePhone = proposed.Home;
            int phoneId = proposed.Id;

            var mobilePhoneParam = DataAccess.BuildParameter(nameof(mobilePhone), SqlDbType.VarChar, mobilePhone, false);
            var homePhoneParam = DataAccess.BuildParameter(nameof(homePhone), SqlDbType.VarChar, homePhone, false);
            var phoneIdParam = DataAccess.BuildParameter(nameof(phoneId), SqlDbType.Int, phoneId, false);

            var sqlParameters = new SqlParameter[] { mobilePhoneParam, homePhoneParam, phoneIdParam };

            return DataAccess.TTDataBase.ExecScaler("[dbo].[stp_updatePhone]", sqlParameters);
        }

        public Phone DeletePhoneById(int PersonId)
        {
            throw new NotImplementedException();
        }

        public Phone DeletePhone(Phone proposed)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Phone> GetPhones()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Phone> GetPhonesByPersonName(string findPhone)
        {
            throw new NotImplementedException();
        }

        
    }
}
