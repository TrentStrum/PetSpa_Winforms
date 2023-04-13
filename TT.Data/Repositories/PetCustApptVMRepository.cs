using System.Data;
using System.Data.SqlClient;
using TT.Data.DataContracts;
using TT.Data.Entities;

namespace TT.Data.Repositories
{
    public class PetCustApptVMRepository : IPetCustApptVMRepository
    {
  
        public PetCustApptVMRepository() { }

        public IEnumerable<PetCustApptVM> GetTodaysCheckIns(DateTime today)
        {
            var checkInList = new List<PetCustApptVM>();

            var todayParam = DataAccess.BuildParameter(nameof(today), SqlDbType.DateTime, today, false);
            var sqlParameters = new SqlParameter[] { todayParam };

            DataSet dataSet = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getTodaysCheckIns]", sqlParameters);
            DataTable checkInTable = dataSet.Tables[0];

            if (checkInTable.Rows.Count > 0)
            {
                foreach (DataRow appt in checkInTable.Rows)
                {
                    checkInList.Add(new PetCustApptVM(appt));
                }
            }
            return checkInList;
        }

        public IEnumerable<PetCustApptVM> GetTodaysCheckOuts(DateTime today)
        {
            var checkOutList = new List<PetCustApptVM>();

            var todayParam = DataAccess.BuildParameter(nameof(today), SqlDbType.DateTime, today, false);
            var sqlParameters = new SqlParameter[] { todayParam };

            DataSet dataSet = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getTodaysCheckOuts]", sqlParameters);
            DataTable checkOutTable = dataSet.Tables[0];

            if (checkOutTable.Rows.Count > 0)
            {
                foreach (DataRow appt in checkOutTable.Rows)
                {
                    checkOutList.Add(new PetCustApptVM(appt));
                }
            }
            return checkOutList;
        }


    }
}
