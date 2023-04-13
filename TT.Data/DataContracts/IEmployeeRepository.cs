using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Data.Entities;

namespace TT.Data.DataContracts
{
    public interface IEmployeeRepository
    {
        DataTable EmployeeTable { get; }
        IEnumerable<Employee> GetEmployeeByUsername(string username);
        Employee GetNewEmployee();
        DataTable GetEmployeeByFirstAndLastName(string firstName, string LastName);
        Employee AddEmployee(Employee proposed);
        Employee EmployeeLogin(string userName, string password);
        int UpdateEmployee(Employee proposed);
    }
}
