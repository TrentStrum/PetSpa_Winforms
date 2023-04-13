using TT.Data.Entities;
using TT.Data.Repositories;
using TT.Forms.Classes;

namespace TT.Forms.Forms
{
    public partial class EmployeeProfileForm : Form
    {
        public int EmployeeId { get; set; }
        protected Employee Employee { get; }
        private EmployeeRepository EmployeeRepo { get; } = new();
        private EmailRepository EmailRepo { get; } = new();
        private PersonRepository PersonRepo { get; } = new();
        private PhoneRepository PhoneRepo { get; } = new();
        private BindingSource EmployeeBindingSource { get; } = new();
        public EmployeeProfileForm(int employeeId)
        {
            EmployeeId = employeeId;
            InitializeComponent();
            Employee = EmployeeRepo.GetEmployeeById(EmployeeId);
            if (Employee == null) Employee = EmployeeRepo.GetNewEmployee();
        }

        private void EmployeeProfileForm_Load(object sender, EventArgs e)
        {
            EmployeeBindingSource.DataSource = Employee;

            EmployeeFirstNameTextBox.AddDataBinding(EmployeeBindingSource, "Person.FirstName");
            EmployeeLastNameTextBox.AddDataBinding(EmployeeBindingSource, "Person.LastName");
            EmployeeTitleTextBox.AddDataBinding(EmployeeBindingSource, "Title");
            EmployeeRoleTextBox.AddDataBinding(EmployeeBindingSource, "Role");
            EmployeeHireDateTextBox.AddDataBinding(EmployeeBindingSource, "HireDate");
            EmployeeTerminationTextBox.AddDataBinding(EmployeeBindingSource, "TerminationDate");
            EmployeeEmailTextBox.AddDataBinding(EmployeeBindingSource, "Email.Personal_Email");
            EmployeeMobileTextbox.AddDataBinding(EmployeeBindingSource, "Phone.Mobile");
            EmployeeHomeTextBox.AddDataBinding(EmployeeBindingSource, "Phone.Home");
            EmployeeStreetTextBox.AddDataBinding(EmployeeBindingSource, "Address.Street");
            EmployeeSupplementalTextBox.AddDataBinding(EmployeeBindingSource, "Address.Supplemental");
            EmployeeCityTextBox.AddDataBinding(EmployeeBindingSource, "Address.City");
            EmployeeStateComboBox.AddDataBindingComboBox(EmployeeBindingSource, "Address.State");
            EmployeeZipTextBox.AddDataBinding(EmployeeBindingSource, "Address.ZipCode");
        }

        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeBindingSource.EndEdit();

            if (Employee.Person.HasChanges())
            {
                int updatePerson = PersonRepo.UpdatePerson(Employee.Person);
                if (updatePerson == 1)
                {
                    MessageBox.Show("Person change made");
                }
                else
                {
                    MessageBox.Show("Error- person change not made");
                }
            }
            if (Employee.HasChanges() == true)
            {
                int updateCustomer = EmployeeRepo.UpdateEmployee(Employee);
                if (updateCustomer == 1)
                {
                    MessageBox.Show("Customer change made");
                }
                else
                {
                    MessageBox.Show("Error- Customer change not made");
                }
            }
            if (Employee.Phone.HasChanges() == true)
            {
                int updatePhone = PhoneRepo.UpdatePhone(Employee.Phone);
                if (updatePhone == 1)
                {
                    MessageBox.Show("Phone change made");
                }
                else
                {
                    MessageBox.Show("Error- phone change not made");
                }
            }
            if (Employee.Email.HasChanges() == true)
            {
                int updateEmail = EmailRepo.UpdateEmail(Employee.Email);
                if (updateEmail == 1)
                {
                    MessageBox.Show("Email change made");
                }
                else
                {
                    MessageBox.Show("Error- email change not made");
                }
            }
        }


    }
}
