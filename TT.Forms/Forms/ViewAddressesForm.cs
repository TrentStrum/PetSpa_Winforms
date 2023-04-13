using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TT.Common.Extensions;
using TT.Data.Entities;
using TT.Data.Repositories;
using TT.Forms.Classes;
using static TT.Common.Enums.Enums;

namespace TT.Forms.Forms
{
    public partial class ViewAddressesForm : Form
    {
        public int PersonId { get; }
        public int AddressId { get; }
        protected Address ShippingAddress { get; }
        protected Address? BillingAddress { get; }
        private AddressRepository AddressRepo { get; } = new();
        private BindingSource ShippingAddressBindingSource { get; } = new();
        private BindingSource BillingAddressBindingSource { get; } = new();
        public ViewAddressesForm(int personId)
        {
            InitializeComponent();
            PersonId = personId;
            FillShippingStateComboBox(ShippingStateComboBox);
            FillBillingStateComboBox(BillingStateComboBox);
            ShippingAddress = AddressRepo.GetShippingAddressByPersonId(personId);
            BillingAddress = AddressRepo.GetBillingAddressByPersonId(personId);
        }
        public void FillShippingStateComboBox(ComboBox ShippingStateComboBox)
        {
            ShippingStateComboBox.BindEnumToCombobox(State.None);
        }
        public void FillBillingStateComboBox(ComboBox BillingStateComboBox)
        {
            BillingStateComboBox.BindEnumToCombobox(State.None);
        }
        private void ViewAddressesForm_Load(object sender, EventArgs e)
        {
            if (BillingAddress != null)
            {
                LoadShipping();
                LoadBilling();

            }
            else
            {
                LoadShipping();
                SameAsShippingCheckBox.CheckState = CheckState.Checked;
            }
        }

        private void LoadShipping()
        {
            ShippingAddressBindingSource.DataSource = ShippingAddress;

            ShippingStreetTextBox.AddDataBinding(ShippingAddressBindingSource, "Street");
            ShippingSupplementalTextBox.AddDataBinding(ShippingAddressBindingSource, "Supplemental");
            ShippingCityTextBox.AddDataBinding(ShippingAddressBindingSource, "City");
            ShippingStateComboBox.AddDataBindingComboBox(ShippingAddressBindingSource, "State");
            ShippingZipTextBox.AddDataBinding(ShippingAddressBindingSource, "ZipCode");
        }
        private void LoadBilling()
        {
            BillingAddressBindingSource.DataSource = BillingAddress;

            BillingStreetTextBox.AddDataBinding(BillingAddressBindingSource, "Street");
            BillingSupplementalTextBox.AddDataBinding(BillingAddressBindingSource, "Supplemental");
            BillingCityTextBox.AddDataBinding(BillingAddressBindingSource, "City");
            BillingStateComboBox.AddDataBindingComboBox(BillingAddressBindingSource, "State");
            BillingZipTextBox.AddDataBinding(BillingAddressBindingSource, "ZipCode");
        }

        private void UpdateAddressesButton_Click(object sender, EventArgs e)
        {
            BillingAddressBindingSource.EndEdit();
            ShippingAddressBindingSource.EndEdit();
            if (ShippingAddress.HasChanges())
            {
                ShippingAddress.Address_Type = 0;
                int updateAddress = AddressRepo.UpdateAddress(ShippingAddress);
                if (updateAddress == 1)
                {
                    MessageBox.Show("Shipping address change made");
                }
                else
                {
                    MessageBox.Show("Error- shipping address change not made");
                }
            }
            if (BillingAddress == null)
            {
                Address billing = AddressRepo.GetNewAddress();
                billing.Address_Type = 1;
                billing.Street = BillingStreetTextBox.Text;
                billing.Supplemental = BillingSupplementalTextBox.Text;
                billing.City = BillingCityTextBox.Text;
                billing.State = (State)BillingStateComboBox.SelectedValue;
                billing.ZipCode = BillingZipTextBox.Text;
                billing.PersonId = PersonId;

                AddressRepo.AddNewAddress(billing);
                MessageBox.Show("New billing address has been added.");
            }
            else
            {
                if (BillingAddress.HasChanges())
                {
                    BillingAddress.Address_Type = 1;
                    int updateAddress = AddressRepo.UpdateAddress(BillingAddress);
                    if (updateAddress == 1)
                    {
                        MessageBox.Show("Billing address change made");
                    }
                    else
                    {
                        MessageBox.Show("Error- billing address change not made");
                    }
                }
            }
        }

        private void SameAsShippingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SameAsShippingCheckBox.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete billing address?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AddressRepo.DeleteAddressById(BillingAddress.Id);
                    BillingStreetTextBox.Text = string.Empty;
                    BillingSupplementalTextBox.Text = string.Empty;
                    BillingCityTextBox.Text = string.Empty;
                    BillingStateComboBox.SelectedIndex = 0;
                    BillingZipTextBox.Text = string.Empty;
                }
                else
                {
                    SameAsShippingCheckBox.Checked = false;
                }
            }
            else
            {
                string billingStreet = BillingStreetTextBox.Text;
                string billingSupplemental = BillingSupplementalTextBox.Text;
                string billingCity = BillingCityTextBox.Text;
                State billingState = BillingStateComboBox.SelectedIndex.As(State.None);
                string billingZipCode = BillingZipTextBox.Text;

                Address billingAddress = AddressRepo.GetNewAddress();
                billingAddress.Address_Type = 1;
                billingAddress.Street = billingStreet;
                billingAddress.Supplemental = billingSupplemental;
                billingAddress.City = billingCity;
                billingAddress.State = billingState;
                billingAddress.ZipCode = billingZipCode;

                AddressRepo.AddNewAddress(billingAddress);
            }
        }
    }
}
