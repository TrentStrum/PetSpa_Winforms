using System.Data;
using System.Data.SqlClient;
using TT.Data.DataContracts;
using TT.Data.Entities;

namespace TT.Data.Repositories
{
    public class EmailRepository : IEmailRepository
    {
        private DataTable _emailTable = null;
        public DataTable EmailTable { get => _emailTable ??= FillEmailTable(); }
        public EmailRepository() { }

        private DataTable FillEmailTable()
        {
            var dataSet = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getEmailTable]");
            DataTable emailTable = dataSet.Tables[0];

            emailTable.Columns["Email_Id"].AutoIncrement = true;
            emailTable.Columns["Email_Id"].AutoIncrementSeed = 1;
            emailTable.Columns["Email_Id"].AutoIncrementStep = 1;

            emailTable.AcceptChanges();
            return emailTable;
        }

        public Email GetNewEmail()
        {
            return new Email(EmailTable.NewRow());
        }

        public Email GetEmailById(int CustomerId)
        {
            throw new NotImplementedException();
        }

        public Email AddNewEmail(Email proposed)
        {
            throw new NotImplementedException();
        }

        public int UpdateEmail(Email proposed)
        {
            string personalEmail = proposed.Personal_Email;
            int emailId = proposed.Id;

            var personalEmailParam = DataAccess.BuildParameter(nameof(personalEmail), SqlDbType.VarChar, personalEmail, false);
            var emailIdParam = DataAccess.BuildParameter(nameof(emailId), SqlDbType.Int, emailId, false);

            var sqlParameters = new SqlParameter[] { personalEmailParam, emailIdParam };

            return DataAccess.TTDataBase.ExecScaler("[dbo].[stp_updateEmail]", sqlParameters);
        }
    }
}
