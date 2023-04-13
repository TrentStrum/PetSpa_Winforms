using System.Data;
using TT.Data.Entities;

namespace TT.Data.DataContracts
{
    public interface IPhoneRepository
    {
        DataTable PhoneTable { get; }
        Phone GetNewPhone();
        Phone GetPhoneById(int PersonId);
        Phone AddNewPhone(Phone proposed);
        int UpdatePhone(Phone proposed);
        Phone DeletePhoneById(int PersonId);
        Phone DeletePhone(Phone proposed);
        IEnumerable<Phone> GetPhones();
        IEnumerable<Phone> GetPhonesByPersonName(string findPhone);
    }
}
