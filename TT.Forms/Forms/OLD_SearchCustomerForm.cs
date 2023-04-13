using TT.Common.Extensions;
using TT.Data.Repositories;

namespace TT.Forms.Forms
{
    public partial class OLD_SearchCustomerForm : Form
    {
        CustomerRepository custRepo = new CustomerRepository();
        public OLD_SearchCustomerForm()
        {
            InitializeComponent();

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;

            var custSearchResults = custRepo.GetCustomerByFirstAndLastName(firstName, lastName);
            if (custSearchResults != null)
            {
                CustSearchGridView.DataSource = custSearchResults;
                this.CustSearchGridView.Columns["Person_ID"].Visible = false;
                this.CustSearchGridView.Columns["Customer_ID"].Visible = false;
                this.CustSearchGridView.Columns["FirstName"].HeaderText = "First Name";
                this.CustSearchGridView.Columns["LastName"].HeaderText = "Last Name";
                this.CustSearchGridView.Columns["Personal_Email"].HeaderText = "Email";

            }
            else
            {
                MessageBox.Show("Sorry, no customers by that name.");
            }
        }

        private void CustSearchGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //CustomerProfileForm customerProfileForm = new CustomerProfileForm();
            //customerProfileForm.CustomerId = this.CustSearchGridView.CurrentRow.Cells["Customer_ID"].Value.As(0);
            //customerProfileForm.MdiParent = this.ParentForm;
            //customerProfileForm.Show();
            //this.Close();
        }
    }
}
