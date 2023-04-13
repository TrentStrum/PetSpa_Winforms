using System.Data;
using System.Data.SqlClient;
using TT.Common.Helpers;
using TT.Data.DataContracts;
using TT.Data.Entities;
using static TT.Common.Enums.Enums;

namespace TT.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private DataTable _employeeTable = null;
        public DataTable EmployeeTable { get => _employeeTable ??= FillEmployeeTable(); }
        public EmployeeRepository() { }
        Encryption Encryption = new Encryption();
        PersonRepository personRepo = new PersonRepository();
        PhoneRepository phoneRepo = new PhoneRepository();
        EmailRepository emailRepo = new EmailRepository(); 
        AddressRepository addressRepo = new AddressRepository();

        private DataTable FillEmployeeTable()
        {
            var dataSet = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getEmployeeTable]");

            DataTable employeeTable = dataSet.Tables[0];

            employeeTable.Columns["Employee_Id"].AutoIncrement = true;
            employeeTable.Columns["Employee_Id"].AutoIncrementSeed = -1;
            employeeTable.Columns["Employee_Id"].AutoIncrementStep = -1;

            employeeTable.AcceptChanges();
            return employeeTable;
        }
        public Employee GetNewEmployee()
        {
            return new Employee(EmployeeTable.NewRow(), personRepo.GetNewPerson(), phoneRepo.GetNewPhone(), emailRepo.GetNewEmail(), addressRepo.GetNewAddress());
        }
        public DataTable GetEmployeeByFirstAndLastName(string firstName, string lastName)
        {
            var firstNameParam = DataAccess.BuildParameter(nameof(firstName), SqlDbType.VarChar, firstName, false);
            var lastNameParam = DataAccess.BuildParameter(nameof(lastName), SqlDbType.VarChar, lastName, false);

            var sqlParameters = new SqlParameter[] { firstNameParam, lastNameParam };
            DataSet ds = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getEmployeeByFirstAndLastNames]", sqlParameters);
            DataTable custTable = ds.Tables[0];
            return custTable;
        }
        public Employee GetEmployeeById(int employeeId)
        {
            var employeeIdParam = DataAccess.BuildParameter(nameof(employeeId), SqlDbType.Int, employeeId, false);
            var sqlParameters = new SqlParameter[] { employeeIdParam };

            DataSet dataSet = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getEmployeeById]", sqlParameters);
        
            dataSet.Tables[0].TableName = "Employee";
            dataSet.Tables[1].TableName = "Person";
            dataSet.Tables[2].TableName = "Phone";
            dataSet.Tables[3].TableName = "Email";
            dataSet.Tables[4].TableName = "Address";


            if (dataSet.Tables["Employee"].Rows.Count > 0)
            {
                return new Employee(dataSet.Tables["Employee"].Rows[0],
                    new Person(dataSet.Tables["Person"].Rows[0]),
                    new Phone(dataSet.Tables["Phone"].Rows[0]),
                    new Email(dataSet.Tables["Email"].Rows[0]),
                    new Address(dataSet.Tables["Address"].Rows[0]));
            }
            else
                return null;
        }
        public IEnumerable<Employee> GetEmployeeByUsername(string username)
        {
            var usernameParam = DataAccess.BuildParameter(nameof(username), SqlDbType.VarChar, username, false);

            var sqlParameters = new SqlParameter[] { usernameParam };
            DataSet ds = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getEmployeeByUsername]", sqlParameters);

            var fullList = new List<Employee>();
            foreach (var employee in ds.Tables[0].Select())
            {
                fullList.Add(new Employee(employee));
            }
            return fullList;
        }
        public Employee AddEmployee(Employee proposedEmployee)
        {
 
            Employee newEmployee = proposedEmployee;

            DataSet proposedDS = InsertEmployee(newEmployee.Person.FirstName, newEmployee.Person.LastName, newEmployee.Title, newEmployee.HireDate, newEmployee.Role, newEmployee.Username, newEmployee.Password, newEmployee.Phone.Mobile, newEmployee.Phone.Home, newEmployee.Phone.Business, newEmployee.Email.Personal_Email, newEmployee.Email.Work_Email, newEmployee.Address.Address_Type, newEmployee.Address.Street, newEmployee.Address.Supplemental, newEmployee.Address.City, newEmployee.Address.State, newEmployee.Address.ZipCode);

            Employee employee = new Employee(proposedDS.Tables["Employee"].Rows[0], new Person(proposedDS.Tables["Person"].Rows[0]), new Phone(proposedDS.Tables["Phone"].Rows[0]), new Email(proposedDS.Tables["Email"].Rows[0]), new Address(proposedDS.Tables["Address"].Rows[0]));
            return employee;
            
        }
        private DataSet InsertEmployee(string firstName, string lastName, string title, DateTime hireDate, int role, string username, string password, string mobilePhone, string homePhone, string businessPhone, string personalEmail, string workEmail, int addressType, string street, string supplemental, string city, State state, string zipCode)
        {
            var firstNameParam = DataAccess.BuildParameter(nameof(firstName), SqlDbType.VarChar, firstName, false);
            var lastNameParam = DataAccess.BuildParameter(nameof(lastName), SqlDbType.VarChar, lastName, false);
            var titleParam = DataAccess.BuildParameter(nameof(title), SqlDbType.VarChar, title, false);
            var hireDateParam = DataAccess.BuildParameter(nameof(hireDate), SqlDbType.VarChar, hireDate.As(DateTime.Now), false);
            var roleParam = DataAccess.BuildParameter(nameof(role), SqlDbType.Int, role, false);
            var usernameParam = DataAccess.BuildParameter(nameof(username), SqlDbType.VarChar, username, false);
            var passwordParam = DataAccess.BuildParameter(nameof(password), SqlDbType.VarChar, password, false);
            var mobilePhoneParam = DataAccess.BuildParameter(nameof(mobilePhone), SqlDbType.VarChar, mobilePhone, false);
            var homePhoneParam = DataAccess.BuildParameter(nameof(homePhone), SqlDbType.VarChar, homePhone, false);
            var businessPhoneParam = DataAccess.BuildParameter(nameof(businessPhone), SqlDbType.VarChar, businessPhone, false);
            var personalEmailParam = DataAccess.BuildParameter(nameof(personalEmail), SqlDbType.VarChar, personalEmail, false);
            var workEmailParam = DataAccess.BuildParameter(nameof(workEmail), SqlDbType.VarChar, workEmail, false);
            var addressTypeParam = DataAccess.BuildParameter(nameof(addressType), SqlDbType.Int, addressType, false);
            var streetParam = DataAccess.BuildParameter(nameof(street), SqlDbType.VarChar, street, false);
            var supplementalParam = DataAccess.BuildParameter(nameof(supplemental), SqlDbType.VarChar, supplemental, false);
            var cityParam = DataAccess.BuildParameter(nameof(city), SqlDbType.VarChar, city, false);
            var stateParam = DataAccess.BuildParameter(nameof(state), SqlDbType.VarChar, state, false);
            var zipCodeParam = DataAccess.BuildParameter(nameof(zipCode), SqlDbType.VarChar, zipCode, false);

            var sqlParameters = new SqlParameter[] { firstNameParam, lastNameParam, titleParam, hireDateParam, roleParam, usernameParam, passwordParam, mobilePhoneParam, homePhoneParam, businessPhoneParam, personalEmailParam, workEmailParam, addressTypeParam, streetParam, supplementalParam, cityParam, stateParam, zipCodeParam};
            DataSet dataSet = DataAccess.TTDataBase.ExecCmdQuery("[stp_insertNewEmployee]", sqlParameters);
            dataSet.Tables[0].TableName = "Address";
            dataSet.Tables[1].TableName = "Email";
            dataSet.Tables[2].TableName = "Employee";
            dataSet.Tables[3].TableName = "Person";
            dataSet.Tables[4].TableName = "Phone";
            return dataSet;
        }

        public Employee EmployeeLogin (string username, string password) 
        {
            string Password = Encryption.ComputeStringToSha256Hash(password);

            var userNameParam = DataAccess.BuildParameter(nameof(username), SqlDbType.VarChar, username, false);
            var passwordParam = DataAccess.BuildParameter(nameof(Password), SqlDbType.VarChar, Password, false);

            var slqParameters = new SqlParameter[] { userNameParam, passwordParam };

            DataSet employeeDs = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_employeeLogin]", slqParameters);
            DataTable employeeDt = employeeDs.Tables[0];

            if (employeeDt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return new Employee(employeeDt.Rows[0]);
            }
        }
        public int UpdateEmployee(Employee proposed)
        {
            string title = proposed.Title;
            DateTime hireDate = proposed.HireDate;
            DateTime ? terminationDate = proposed.TerminationDate;
            int role = proposed.Role;
            int employeeId = proposed.ID;

            if (terminationDate != null) 
            {
                var titleParam = DataAccess.BuildParameter(nameof(title), SqlDbType.VarChar, title, false);
                var hireDateParam = DataAccess.BuildParameter(nameof(hireDate), SqlDbType.DateTime, hireDate, false);
                var terminationDateParam = DataAccess.BuildParameter(nameof(terminationDate), SqlDbType.DateTime, terminationDate, false);
                var roleParam = DataAccess.BuildParameter(nameof(role), SqlDbType.VarChar, role, false);
                var employeeIdParam = DataAccess.BuildParameter(nameof(employeeId), SqlDbType.Int, employeeId, false);

                var sqlParameters = new SqlParameter[] { titleParam, hireDateParam, terminationDateParam, roleParam, employeeIdParam };

                return DataAccess.TTDataBase.ExecScaler("[dbo].[stp_updateEmployeeWithTermination]", sqlParameters);
            }
            else
            {
                var titleParam = DataAccess.BuildParameter(nameof(title), SqlDbType.VarChar, title, false);
                var hireDateParam = DataAccess.BuildParameter(nameof(hireDate), SqlDbType.DateTime, hireDate, false);
                var roleParam = DataAccess.BuildParameter(nameof(role), SqlDbType.VarChar, role, false);
                var employeeIdParam = DataAccess.BuildParameter(nameof(employeeId), SqlDbType.Int, employeeId, false);

                var sqlParameters = new SqlParameter[] { titleParam, hireDateParam, roleParam, employeeIdParam };

                return DataAccess.TTDataBase.ExecScaler("[dbo].[stp_updateEmployeeNoTermination]", sqlParameters);
            }

        }
    }
}
