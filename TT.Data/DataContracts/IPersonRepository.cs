using System.Data;
using TT.Data.Entities;

namespace TT.Data.DataContracts
{
    public interface IPersonRepository
    {
        DataTable PersonTable { get; }
        Person GetNewPerson();
        Person GetPersonById(int PersonId);
        Person AddNewPerson(Person proposed);
        int UpdatePerson(Person proposed);
        Person DeletePersonById(int PersonId);
        Person DeletePerson(Person proposed);
        IEnumerable<Person> GetPersons();
        IEnumerable<Person> GetPersonsByPersonName(string findPerson);
    }
}
