using TrentsTroublemakersWF.Forms;
using TT.Common.Extensions;
using TT.Data.Entities;
using TT.Data.Repositories;
using TT.Forms.Classes;

namespace TT.Forms.Forms
{
    public partial class CustomerProfileFormCW : Form
    {
        public int PetId { get; set; }
        protected Customer Customer { get; }
        public int CustomerId { get; }
        private CustomerRepository CustomerRepo { get; } = new();
        private PetRepository PetRepo { get; } = new();
        private BindingSource CustomerBindingSource { get; } = new();

        public CustomerProfileFormCW(int customerId)
        {
            InitializeComponent();
            CustomerId = customerId;
            Customer = CustomerRepo.GetCustomerById(CustomerId);
            if (Customer == null) Customer = CustomerRepo.GetNewCustomer();
        }

        private void CustomerProfileFormCW_Load(object sender, EventArgs e)
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
        }
    }
}
