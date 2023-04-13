using TT.Common.Extensions;
using TT.Data.Repositories;

namespace TT.Forms.Forms
{
    public partial class SearchEmployeeForm : Form
    {
        private EmployeeRepository employeeRepo { get; } = new();
        public int EmployeeId { get; }
        public SearchEmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeSearchButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;

            var employeeSearchResults = employeeRepo.GetEmployeeByFirstAndLastName(firstName, lastName);
            if (employeeSearchResults != null)
            {
                EmployeeSearchGridView.DataSource = employeeSearchResults;
                this.EmployeeSearchGridView.Columns["Person_ID"].Visible = false;
                this.EmployeeSearchGridView.Columns["Employee_Id"].HeaderText = "ID";
                this.EmployeeSearchGridView.Columns["FirstName"].HeaderText = "First Name";
                this.EmployeeSearchGridView.Columns["LastName"].HeaderText = "Last Name";
                this.EmployeeSearchGridView.Columns["Title"].HeaderText = "Title";
                this.EmployeeSearchGridView.Columns["HireDate"].HeaderText = "Hire Date";
                this.EmployeeSearchGridView.Columns["TerminationDate"].HeaderText = "Termination Date";

            }
            else
            {
                MessageBox.Show("Sorry, no customers by that name.");
            }
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.Show();
        }

        private void EmployeeSearchGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var employeeId = this.EmployeeSearchGridView.CurrentRow.Cells["Employee_Id"].Value.As(0);
            EmployeeProfileForm employeeProfileForm = new EmployeeProfileForm(employeeId)
            {
                MdiParent = this.ParentForm
            };
            employeeProfileForm.Show();
            this.Close();
        }
    }
}
