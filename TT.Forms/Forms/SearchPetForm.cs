using TT.Common.Extensions;
using TT.Data.Repositories;
using TT.Forms.Forms;

namespace TT.Forms
{
    public partial class SearchPetForm : Form
    {
        private PetRepository PetRepo { get; } = new();
        public SearchPetForm()
        {
            InitializeComponent();
        }

        private void PetSearchButton_Click(object sender, EventArgs e)
        {
            string custFirstName = FirstNameTextBox.Text;
            string custLastName = LastNameTextBox.Text;
            string petName = PetNameTextBox.Text;

            if (string.IsNullOrEmpty(petName) && string.IsNullOrEmpty(custLastName) && string.IsNullOrEmpty(custFirstName))
            {
                MessageBox.Show("Please search using either Customer name or Pet name.");
            }
            else if (!string.IsNullOrEmpty(petName) && !string.IsNullOrEmpty(custLastName) && !string.IsNullOrEmpty(custFirstName))
            {
                MessageBox.Show("Please search using either Customer name or Pet name.");
            }
            else if (string.IsNullOrEmpty(petName) && !string.IsNullOrEmpty(custLastName) || !string.IsNullOrEmpty(custFirstName))
            {
                if (string.IsNullOrEmpty(custLastName))
                {
                    MessageBox.Show("Please include Last Name");
                }
                else if (string.IsNullOrEmpty(custFirstName))
                {
                    MessageBox.Show("Please include First Name");
                }
                else
                {
                    var petSearchResults = PetRepo.GetPetByCustFirstAndLastName(custFirstName, custLastName);
                    if (petSearchResults != null)
                    {
                        PetSearchGridView.DataSource = petSearchResults;
                        PetSearchGridView.DataSource = petSearchResults;
                        this.PetSearchGridView.Columns["Id"].Visible = false;
                        this.PetSearchGridView.Columns["Customer_ID"].Visible = false;
                        this.PetSearchGridView.Columns["AnimalType"].HeaderText = "Species";
                    }
                    else
                    {
                        MessageBox.Show("Sorry, no customers by that name.");
                    }

                }
            }
            else
            {
                var petSearchResults = PetRepo.GetPetByName(petName);
                if (petSearchResults != null)
                {
                    PetSearchGridView.DataSource = petSearchResults;
                    this.PetSearchGridView.Columns["Id"].Visible = false;
                    this.PetSearchGridView.Columns["Customer_ID"].Visible = false;
                    this.PetSearchGridView.Columns["AnimalType"].HeaderText = "Species";
                }
                else
                {
                    MessageBox.Show("Sorry, no pet by that name.");
                }
            }
        }

        private void PetSearchGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PetSearchGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var petId = this.PetSearchGridView.CurrentRow.Cells["ID"].Value.As(0);
            PetProfileForm petProfileForm = new PetProfileForm(petId)
            {
                MdiParent = this.ParentForm
            };
            petProfileForm.Show();
            this.Close();
        }
    }
}
