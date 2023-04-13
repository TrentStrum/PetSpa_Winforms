using System.Data;
using System.Data.SqlClient;
using TT.Data.DataContracts;
using TT.Data.Entities;

namespace TT.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private DataTable _personTable = null;
        public DataTable PersonTable { get => _personTable ??= FillPersonTable(); }
        public PersonRepository() { }

        private DataTable FillPersonTable()
        {
            var dataSet = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getPersonTable]");

            DataTable personTable = dataSet.Tables[0];

            personTable.Columns["Person_id"].AutoIncrement = true;
            personTable.Columns["Person_id"].AutoIncrementSeed = -1;
            personTable.Columns["Person_id"].AutoIncrementStep = -1;

            personTable.AcceptChanges();
            return personTable;
        }

        public Person GetNewPerson()
        {
            return new Person(PersonTable.NewRow());
        }

        public Person GetPersonById(int PersonId)
        {
            throw new NotImplementedException();
        }

        public Person AddNewPerson(Person proposed)
        {
            throw new NotImplementedException();
        }

        public int UpdatePerson(Person proposed)
        {
            string firstName = proposed.FirstName;
            string lastName = proposed.LastName;
            int personId = proposed.Id;

            var firstNameParam = DataAccess.BuildParameter(nameof(firstName), SqlDbType.VarChar, firstName, false);
            var lastNameParam = DataAccess.BuildParameter(nameof(lastName), SqlDbType.VarChar, lastName, false);
            var personIdParam = DataAccess.BuildParameter(nameof(personId), SqlDbType.Int, personId, false);

            var sqlParameters = new SqlParameter[] { firstNameParam, lastNameParam, personIdParam };

            return DataAccess.TTDataBase.ExecScaler("[dbo].[stp_updatePerson]", sqlParameters);

        }

        public Person DeletePersonById(int PersonId)
        {
            throw new NotImplementedException();
        }

        public Person DeletePerson(Person proposed)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPersons()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPersonsByPersonName(string findPerson)
        {
            throw new NotImplementedException();
        }
       
    }
}
