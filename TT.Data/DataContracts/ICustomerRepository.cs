using System.Data;
using System.Data.SqlClient;
using TT.Data;
using TT.Data.Entities;
using static TT.Common.Enums.Enums;

namespace TT.Data.DataContracts
{
    public interface ICustomerRepository
    {
        DataTable CustomerTable { get; }
        DataTable FillCustomerTable();
        Customer GetCustomerById(int customerId);
        DataTable GetCustomerByFirstAndLastName(string firstName, string LastName);
        Customer GetNewCustomer();
        Customer AddIndividualCustomer(Customer proposedCustomer);
        DataSet InsertIndividualCustomer(string firstName, string lastName, DateTime registrationDate, string mobilePhone, string homePhone, string personalEmail, string workEmail, int addressType, string street, string supplemental, string city, State state, string zipCode);
        int UpdateCustomer(Customer proposed);
    }
}
