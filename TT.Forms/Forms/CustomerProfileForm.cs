using TrentsTroublemakersWF.Forms;
using TT.Common.Extensions;
using TT.Data.Entities;
using TT.Data.Repositories;
using TT.Forms.Classes;

namespace TT.Forms.Forms
{
    public partial class CustomerProfileForm : Form
    {
        public int PetId { get; set; }
        protected Customer Customer { get; }
        protected Person Person { get; set; }
        protected Phone Phone { get; set; }
        protected Email Email { get; set; }
        public int CustomerId { get; }
        public int PersonId { get; }
        private CustomerRepository CustomerRepo { get; } = new();
        private PetRepository PetRepo { get; } = new();
        private EmailRepository EmailRepo { get; } = new();
        private PersonRepository PersonRepo { get; } = new();
        private PhoneRepository PhoneRepo { get; } = new();
        private BindingSource CustomerBindingSource { get; } = new();

        public CustomerProfileForm(int customerId)
        {
            InitializeComponent();
            CustomerId = customerId;
            Customer = CustomerRepo.GetCustomerById(CustomerId);
            if (Customer == null) Customer = CustomerRepo.GetNewCustomer();
        }

        private void AddPetButton_Click(object sender, EventArgs e)
        {
            AddPetForm addPetForm = new AddPetForm(Customer.Id);
            addPetForm.PetAdded += AddPetForm_PetAdded;
            addPetForm.CustomerId = this.CustomerId;
            addPetForm.MdiParent = this.ParentForm;
            addPetForm.Show();
        }

        private void AddPetForm_PetAdded(object? sender, EventArgs e)
        {
            LoadPetGrid();
        }

        public void LoadPetGrid()
        {
            BindingSource custPetGridBindingSource = new BindingSource
            {
                DataSource = PetRepo.GetPetsByCustomerId(CustomerId)
            };
            CustPetDataGridView.DataSource = custPetGridBindingSource;

            CustPetDataGridView.Columns["ID"].Visible = false;
            CustPetDataGridView.Columns["Customer_Id"].Visible = false;
            CustPetDataGridView.Columns["AnimalType"].HeaderText = "Species";
        }

        private void CustPetDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var petId = this.CustPetDataGridView.CurrentRow.Cells["ID"].Value.As(0);
            PetProfileForm petProfileForm = new PetProfileForm(petId)
            {
                MdiParent = this.ParentForm
            };
            petProfileForm.Show();
            this.Close();
        }

        private void UpdatePetButton_Click(object sender, EventArgs e)
        {
            if (CustPetDataGridView.SelectedRows.Count > 0)
            {
                var petId = this.CustPetDataGridView.CurrentRow.Cells["ID"].Value.As(0);
                PetProfileForm petProfileForm = new PetProfileForm(petId)
                {
                    MdiParent = this.ParentForm
                };
                petProfileForm.Show();
                this.Close();
            }
        }

        private void RemovePetButton_Click(object sender, EventArgs e)
        {
            if (CustPetDataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select pet to update.");
            }
            else
            {
                DataGridViewRow row = this.CustPetDataGridView.SelectedRows[0];
                int petId = (int)row.Cells["ID"].Value;
                string petName = (string)row.Cells["Name"].Value;
                int deleteCheck;

                DialogResult dialogResult = MessageBox.Show($"Are you sure you would like to delete {petName}?", "WARNING", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleteCheck = PetRepo.DeletePetById(petId);
                    if (deleteCheck == 1)
                    {
                        MessageBox.Show($"{petName} has successfully been deleted.");
                    }
                    else
                    {
                        MessageBox.Show("Error, delete was not completed successfully");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }

            }
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerBindingSource.EndEdit();

            if (Customer.Person.HasChanges())
            {
                int updatePerson = PersonRepo.UpdatePerson(Customer.Person);
                if (updatePerson == 1)
                {
                    MessageBox.Show("Person change made");
                }
                else
                {
                    MessageBox.Show("Error- person change not made");
                }
            }
            if (Customer.HasChanges() == true)
            {
                int updateCustomer = CustomerRepo.UpdateCustomer(Customer);
                if (updateCustomer == 1)
                {
                    MessageBox.Show("Customer change made");
                }
                else
                {
                    MessageBox.Show("Error- Customer change not made");
                }
            }
            if (Customer.Phone.HasChanges() == true)
            {
                int updatePhone = PhoneRepo.UpdatePhone(Customer.Phone);
                if (updatePhone == 1)
                {
                    MessageBox.Show("Phone change made");
                }
                else
                {
                    MessageBox.Show("Error- phone change not made");
                }
            }
            if (Customer.Email.HasChanges() == true)
            {
                int updateEmail = EmailRepo.UpdateEmail(Customer.Email);
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

        private void CustomerProfileForm_Load(object sender, EventArgs e)
        {
            CustomerBindingSource.DataSource = Customer;

            CustFirstNameTextBox.AddDataBinding(CustomerBindingSource, "Person.FirstName");
            CustLastNameTextBox.AddDataBinding(CustomerBindingSource, "Person.LastName");
            CustEmailTextBox.AddDataBinding(CustomerBindingSource, "Email.Personal_Email");
            CustMobileTextbox.AddDataBinding(CustomerBindingSource, "Phone.Mobile");
            CustHomeTextBox.AddDataBinding(CustomerBindingSource, "Phone.Home");
            CustRegistrationDateTextBox.AddDataBinding(CustomerBindingSource, "RegistrationDate");

            LoadPetGrid();
        }

        private void CustomerViewAddressButton_Click(object sender, EventArgs e)
        {
            ViewAddressesForm viewAddressesForm = new ViewAddressesForm(Customer.Person_Id)
            {
                MdiParent = this.ParentForm
            };
            viewAddressesForm.Show();
        }
    }
}
