using TT.Data.DataContracts;
using TT.Data.Entities;
using TT.Data.Repositories;

namespace TT.Forms.Forms
{
    public partial class LoginForm : Form
    {
        public Employee Employee { get; set; }
        private IEmployeeRepository EmployeeRepo { get; }
        public LoginForm()
        {
            EmployeeRepo = new EmployeeRepository();
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.MaxLength = 14;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = UsernameTextbox.Text;
            string password = PasswordTextBox.Text;
            if (userName != null && password != null)
            {
                var employee = EmployeeRepo.EmployeeLogin(userName, password);
                if (employee != null)
                {
                    Employee = employee;
                    this.Close();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Incorrect login information provided. Please check username and/or password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            else
            {
                MessageBox.Show("Please provide username and password to login.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void CreateProfileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
        }

    }
}
