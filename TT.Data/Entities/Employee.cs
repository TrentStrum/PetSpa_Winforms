using System.Data;
using TT.Common.Extensions;

namespace TT.Data.Entities
{
    public class Employee
    {
        private DataRow EmployeeRow { get; }
        public Person Person { get; }
        public Phone Phone { get; }
        public Email Email { get; }
        public Address Address { get; }
        public Employee(DataRow employeeRow, Person person, Phone phone, Email email, Address address) 
        {
            EmployeeRow = employeeRow;
            Person = person;
            Phone = phone;
            Email = email;
            Address = address;
        }
        public Employee(DataRow employeeRow) => EmployeeRow = employeeRow;
 
        public int ID
        {
            get => EmployeeRow["Employee_Id"].As(0);
            set => EmployeeRow["Employee_Id"] = value;
        }
        public string Title
        {
            get => EmployeeRow["Title"].As("");
            set => EmployeeRow["Title"] = value;
        }  
        public DateTime HireDate
        {
            get => EmployeeRow["HireDate"].As(DateTime.Now);
            set => EmployeeRow["HireDate"] = value;
        }
        public DateTime? TerminationDate
        {
            get => EmployeeRow["TerminationDate"] == DBNull.Value ? null : EmployeeRow["TerminationDate"].As<DateTime>();
            set => EmployeeRow["TerminationDate"] = value;
        }
        public string Username
        {
            get => EmployeeRow["Username"].As("");
            set => EmployeeRow["Username"] = value;
        }
        public string Password  
        {
            get => EmployeeRow["Password"].As("");
            set => EmployeeRow["Password"] = value;
        }
        public int Role
        {
            get => EmployeeRow["Role"].As(0);
            set => EmployeeRow["Role"] = value;
        }
        public bool HasChanges()
        {
            return EmployeeRow.Table.GetChanges()?.Rows.Count > 0;
        }
    }
}
