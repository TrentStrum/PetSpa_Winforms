using TT.Common.Enums;
using TT.Common.Extensions;
using TT.Common.Helpers;
using TT.Data.DataContracts;
using TT.Data.Entities;
using TT.Data.Repositories;
using TT.Forms.Classes;
using static TT.Common.Enums.Enums;

namespace TT.Forms.Forms
{
    public partial class AddEmployeeForm : Form
    {
        private Encryption _encryption { get; }
        private IEmployeeRepository EmployeeRepo { get; }
        public AddEmployeeForm()
        {
            _encryption = new Encryption();
            EmployeeRepo = new EmployeeRepository();

            InitializeComponent();
            CreatePasswordTextBox.PasswordChar = '*';
            CreatePasswordTextBox.MaxLength = 14;
            ConfirmPasswordTextBox.PasswordChar = '*';
            ConfirmPasswordTextBox.MaxLength = 14;
            FillStateComboBox(StateComboBox);
            StateComboBox.SelectedItem = null;
            FillRoleComboBox(RoleComboBox);
            //RoleComboBox.SelectedItem = null;
        }

        public void FillStateComboBox(ComboBox StateComboBox)
        {
            StateComboBox.BindEnumToCombobox(State.None);
        }
        public void FillRoleComboBox(ComboBox RoleComboBox)
        {
            RoleComboBox.BindEnumToCombobox(Role.None);
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string title = TitleTextBox.Text;
            DateTime hireDate = HireDateDateTimePicker.Value;
            Role role = RoleComboBox.SelectedIndex.As(Enums.Role.None);
            string username = UsernameTextBox.Text;
            string createPassword = CreatePasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;
            string mobilePhone = MobilePhoneTextBox.Text;
            string homePhone = HomePhoneTextBox.Text;
            string email = EmailTextBox.Text;
            string addressType = "1";
            string street = StreetTextBox.Text;
            string supplemental = SupplementalTextBox.Text;
            string city = CityTextBox.Text;
            State state = StateComboBox.SelectedIndex.As(Enums.State.None);
            string zipCode = ZipCodeTextBox.Text;

            if (firstName != string.Empty || lastName != string.Empty || title != string.Empty || confirmPassword != string.Empty || createPassword != string.Empty || username != string.Empty)
            {
                if (createPassword == confirmPassword)
                {
                    //var cmd = new SqlCommand("select * from LoginTable where username='" + UsernameTextBox.Text + "'", cn);
                    //IEnumerable<Employee> employeeList = EmployeeRepo.GetEmployeeByUsername(username);
                    if (EmployeeRepo.GetEmployeeByUsername(username).Any())
                    {
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Employee proposedEmployee = EmployeeRepo.GetNewEmployee();
                        proposedEmployee.Person.FirstName = firstName;
                        proposedEmployee.Person.LastName = lastName;
                        proposedEmployee.Title = title;
                        proposedEmployee.HireDate = hireDate;
                        proposedEmployee.Role = role.As(0);
                        proposedEmployee.Username = username;
                        proposedEmployee.Password = _encryption.ComputeStringToSha256Hash(createPassword);
                        proposedEmployee.Phone.Mobile = mobilePhone;
                        proposedEmployee.Phone.Home = homePhone;
                        proposedEmployee.Email.Personal_Email = email;
                        proposedEmployee.Address.Address_Type = addressType.As(0);
                        proposedEmployee.Address.Street = street;
                        proposedEmployee.Address.Supplemental = supplemental;
                        proposedEmployee.Address.City = city;
                        proposedEmployee.Address.State = state;
                        proposedEmployee.Address.ZipCode = zipCode;

                        EmployeeRepo.AddEmployee(proposedEmployee);

                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReturnToLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
