using System.Data;
using System.Data.SqlClient;
using TT.Data.DataContracts;
using TT.Data.Entities;
using static TT.Common.Enums.Enums;

namespace TT.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private DataTable _customerTable = null;
        public DataTable CustomerTable { get => _customerTable ??= FillCustomerTable(); }
        public CustomerRepository() { }
        PersonRepository personRepo = new PersonRepository();
        PhoneRepository phoneRepo = new PhoneRepository();
        EmailRepository emailRepo = new EmailRepository();
        AddressRepository addressRepo = new AddressRepository();
        PetRepository petRepo = new PetRepository();

        public DataTable FillCustomerTable()
        {
            var dataSet = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getCustomerTable]");
            DataTable customerTable = dataSet.Tables[0];

            customerTable.Columns["Customer_Id"].AutoIncrement = true;
            customerTable.Columns["Customer_Id"].AutoIncrementSeed = 1;
            customerTable.Columns["Customer_Id"].AutoIncrementStep = 1;

            customerTable.AcceptChanges();
            return customerTable;
        }
        public Customer GetCustomerById(int customerId)
        {
            var custIdParam = DataAccess.BuildParameter(nameof(customerId), SqlDbType.Int, customerId, false);
            var sqlParameters = new SqlParameter[] { custIdParam };

            DataSet dataSet = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getCustomerById]", sqlParameters);
            dataSet.Tables[0].TableName = "Address";
            dataSet.Tables[1].TableName = "Customer";
            dataSet.Tables[2].TableName = "Email";
            dataSet.Tables[3].TableName = "Person";
            dataSet.Tables[4].TableName = "Pet";
            dataSet.Tables[5].TableName = "Phone";

            if (dataSet.Tables["Customer"].Rows.Count > 0)
            {
                // NOTE: Return the new customer directly, no need to create a variable
                return new Customer(dataSet.Tables["Customer"].Rows[0],
                    new Person(dataSet.Tables["Person"].Rows[0]),
                    new Phone(dataSet.Tables["Phone"].Rows[0]),
                    new Email(dataSet.Tables["Email"].Rows[0]),
                    new Address(dataSet.Tables["Address"].Rows[0]),
                    new Pet(dataSet.Tables["Pet"].Rows[0]));
                //Customer customer = new Customer(dataSet.Tables["Customer"].Rows[0], new Person(dataSet.Tables["Person"].Rows[0]), new Phone(dataSet.Tables["Phone"].Rows[0]), new Email(dataSet.Tables["Email"].Rows[0]), new Address(dataSet.Tables["Address"].Rows[0]), new Pet(dataSet.Tables["Pet"].Rows[0]));
                //return customer;
            }
            else
                return null;
        }


        public DataTable GetCustomerByFirstAndLastName(string firstName, string lastName)
        {
            var firstNameParam = DataAccess.BuildParameter(nameof(firstName), SqlDbType.VarChar, firstName, false);
            var lastNameParam = DataAccess.BuildParameter(nameof(lastName), SqlDbType.VarChar, lastName, false);

            var sqlParameters = new SqlParameter[] { firstNameParam, lastNameParam };
            DataSet ds = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getCustomerByFirstAndLastNames]", sqlParameters);
            DataTable custTable = ds.Tables[0];
            return custTable;
        }
        public Customer GetNewCustomer()
        {
            return new Customer(CustomerTable.NewRow(), personRepo.GetNewPerson(), phoneRepo.GetNewPhone(), emailRepo.GetNewEmail(), addressRepo.GetNewAddress(), petRepo.GetNewPet());
        }
        public Customer AddIndividualCustomer(Customer proposedCustomer)
        {
            Customer newCustomer = proposedCustomer;

            DataSet proposedDS = InsertIndividualCustomer(newCustomer.Person.FirstName, newCustomer.Person.LastName, newCustomer.RegistrationDate, newCustomer.Phone.Mobile, newCustomer.Phone.Home, newCustomer.Email.Personal_Email, newCustomer.Email.Work_Email, newCustomer.Address.Address_Type, newCustomer.Address.Street, newCustomer.Address.Supplemental, newCustomer.Address.City, newCustomer.Address.State, newCustomer.Address.ZipCode);

            Customer customer = new Customer(proposedDS.Tables["Customer"].Rows[0], new Person(proposedDS.Tables["Person"].Rows[0]), new Phone(proposedDS.Tables["Phone"].Rows[0]), new Email(proposedDS.Tables["Email"].Rows[0]), new Address(proposedDS.Tables["Address"].Rows[0]), null);
            return customer;
        }
        public DataSet InsertIndividualCustomer(string firstName, string lastName, DateTime registrationDate, string mobilePhone, string homePhone, string personalEmail, string workEmail, int addressType, string street, string supplemental, string city, State state, string zipCode)
        {
            var firstNameParam = DataAccess.BuildParameter(nameof(firstName), SqlDbType.VarChar, firstName, false);
            var lastNameParam = DataAccess.BuildParameter(nameof(lastName), SqlDbType.VarChar, lastName, false);
            var registrationDateParam = DataAccess.BuildParameter(nameof(registrationDate), SqlDbType.DateTime, registrationDate, false);
            var mobilePhoneParam = DataAccess.BuildParameter(nameof(mobilePhone), SqlDbType.VarChar, mobilePhone, false);
            var homePhoneParam = DataAccess.BuildParameter(nameof(homePhone), SqlDbType.VarChar, homePhone, false);
            var personalEmailParam = DataAccess.BuildParameter(nameof(personalEmail), SqlDbType.VarChar, personalEmail, false);
            var workEmailParam = DataAccess.BuildParameter(nameof(workEmail), SqlDbType.VarChar, workEmail, false);
            var addressTypeParam = DataAccess.BuildParameter(nameof(addressType), SqlDbType.Int, addressType, false);
            var streetParam = DataAccess.BuildParameter(nameof(street), SqlDbType.VarChar, street, false);
            var supplementalParam = DataAccess.BuildParameter(nameof(supplemental), SqlDbType.VarChar, supplemental, false);
            var cityParam = DataAccess.BuildParameter(nameof(city), SqlDbType.VarChar, city, false);
            var stateParam = DataAccess.BuildParameter(nameof(state), SqlDbType.Int, state, false);
            var zipCodeParam = DataAccess.BuildParameter(nameof(zipCode), SqlDbType.VarChar, zipCode, false);


            var sqlParameters = new SqlParameter[] { firstNameParam, lastNameParam, registrationDateParam, mobilePhoneParam, homePhoneParam, personalEmailParam, workEmailParam, addressTypeParam, streetParam, supplementalParam, cityParam, stateParam, zipCodeParam };

            DataSet dataSet = DataAccess.TTDataBase.ExecCmdQuery("stp_insertNewCustomer", sqlParameters);
            dataSet.Tables[0].TableName = "Address";
            dataSet.Tables[1].TableName = "Customer";
            dataSet.Tables[2].TableName = "Email";
            dataSet.Tables[3].TableName = "Person";
            dataSet.Tables[4].TableName = "Phone";
            return dataSet;
        }
        public int UpdateCustomer(Customer proposed)
        {
            DateTime registrationDate = proposed.RegistrationDate;
            int customerId = proposed.Id;

            var registrationDateParam = DataAccess.BuildParameter(nameof(registrationDate), SqlDbType.DateTime, registrationDate, false);
            var customerIdParam = DataAccess.BuildParameter(nameof(customerId), SqlDbType.Int, customerId, false);

            var sqlParameters = new SqlParameter[] { registrationDateParam, customerIdParam };

            return DataAccess.TTDataBase.ExecScaler("[dbo].[stp_updateCustomer]", sqlParameters);

        }
    }
}
