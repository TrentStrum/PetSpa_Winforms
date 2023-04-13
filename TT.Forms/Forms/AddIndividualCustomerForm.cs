using System.ComponentModel;
using TT.Forms.Classes;
using static TT.Common.Enums.Enums;
using TT.Data.Entities;
using TT.Data.Repositories;
using TT.Common.Extensions;
using TrentsTroublemakersWF.Forms;

namespace TT.Forms.Forms
{
    public partial class AddIndividualCustomerForm : Form
    {
        private CustomerRepository CustomerRepo { get; } = new();
        private InputValidation inputValidation { get; } = new();
        private AddressRepository AddressRepo { get; } = new();
        protected Customer Customer { get; set; }
        public AddIndividualCustomerForm()
        {
            InitializeComponent();
            ShippingStateComboBox.SelectedItem = null;
            BillingStateComboBox.SelectedItem = null;
            FillStateComboBox(ShippingStateComboBox);
            FillStateComboBox(BillingStateComboBox);
        }

        private void AddCustomerSubmitButton_Click(object sender, EventArgs e)
        {

            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string mobilePhone = MobileNumberTextBox.Text;
            DateTime registrationDate = DateTime.Today;
            string homePhone = HomeNumberTextBox.Text;
            string personalEmail = PersonalEmailTextBox.Text;
            string workEmail = WorkEmailTextBox.Text;
            string shippingStreet = ShippingStreetAddressTextBox.Text;
            string shippingSupplmental = ShippingSupplementalTextBox.Text;
            string shippingCity = ShippingCityTextBox.Text;
            State shippingState = ShippingStateComboBox.SelectedIndex.As(State.None);
            string shippingZipCode = ShippingZipCodeTextBox.Text;
            string billingStreet = BillingStreetTextBox.Text;
            string billingSupplemental = BillingSupplementalTextBox.Text;
            string billingCity = BillingCityTextBox.Text;
            State billingState = BillingStateComboBox.SelectedIndex.As(State.None);
            string billingZipCode = BillingZipCodeTextBox.Text;

            Customer proposedCust = CustomerRepo.GetNewCustomer();
            proposedCust.Person.FirstName = firstName;
            proposedCust.Person.LastName = lastName;
            proposedCust.RegistrationDate = registrationDate;
            proposedCust.Phone.Mobile = mobilePhone;
            proposedCust.Phone.Home = homePhone;
            proposedCust.Email.Personal_Email = personalEmail;
            proposedCust.Email.Work_Email = workEmail;
            proposedCust.Address.Address_Type = 0;
            proposedCust.Address.Street = shippingStreet;
            proposedCust.Address.Supplemental = shippingSupplmental;
            proposedCust.Address.City = shippingCity;
            proposedCust.Address.State = shippingState;
            proposedCust.Address.ZipCode = shippingZipCode;

            Address billingAddress = AddressRepo.GetNewAddress();
            billingAddress.Address_Type = 1;
            billingAddress.Street = billingStreet;
            billingAddress.Supplemental = billingSupplemental;
            billingAddress.City = billingCity;
            billingAddress.State = billingState;
            billingAddress.ZipCode = billingZipCode;


            if (this.BillingSameAsShippingCheckBox.Checked == true)
            {
                Customer = CustomerRepo.AddIndividualCustomer(proposedCust);
            }
            else
            {
                AddressRepo.AddNewAddress(billingAddress);
                Customer = CustomerRepo.AddIndividualCustomer(proposedCust);
            }

            DialogResult dialogResult = MessageBox.Show("New customer was created. Would you like to add a pet for this customer?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            { 
                AddPetForm addPetForm = new AddPetForm(Customer.Id);
                addPetForm.Show();
                this.Close();
            }          
        }

        public void FillStateComboBox(ComboBox StateComboBox)
        {
            StateComboBox.BindEnumToCombobox(State.None);
        }



        private void EmailTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (inputValidation.EmailValidation(PersonalEmailTextBox.Text) == false)
            {
                e.Cancel = true;
                PersonalEmailTextBox.Focus();
                ValidEmailErrorProvider.SetError(PersonalEmailTextBox, "Please provide valid email address.");
            }
            else
            {
                e.Cancel = false;
                ValidEmailErrorProvider.SetError(PersonalEmailTextBox, null);
            }
        }



    }
}
