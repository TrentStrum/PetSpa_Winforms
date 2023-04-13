using System.Runtime.InteropServices;
using TT.Common.Extensions;
using TT.Data.Repositories;

namespace TT.Forms.Forms
{
    public partial class SearchCustomerForm : Form
    {
        CustomerRepository custRepo = new CustomerRepository();

        public SearchCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddIndividualCustomerForm addIndividualCustomerForm = new AddIndividualCustomerForm();
            addIndividualCustomerForm.Show();
        }

        private void CustSearchButton_Click(object sender, EventArgs e)
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

        private void CustSearchGridView_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var customerId = this.CustSearchGridView.CurrentRow.Cells["Customer_ID"].Value.As(0);
            CustomerProfileForm customerProfileForm = new CustomerProfileForm(customerId)
            {
                MdiParent = this.ParentForm
            };
            customerProfileForm.Show();
            this.Close();
        }

        private void CustSearchToolStrip_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("user32.dll")]

        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWind, int msg, int wParam, int lParam);

    }
}
