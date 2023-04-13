using System.Data;
using static TT.Common.Enums.Enums;
using TT.Common.Extensions;
using TT.Data.Entities;
using TT.Forms.Classes;
using TT.Data.DataContracts;
using TT.Data.Repositories;

namespace TrentsTroublemakersWF.Forms
{
    public partial class AddPetForm : Form
    {
        private PetRepository petRepo { get; } = new();
        public int CustomerId { get; set; }
        public event EventHandler? PetAdded;
        public AddPetForm(int customerId)
        {

            InitializeComponent();
            CustomerId = customerId;
            FillSpeciesComboBox(SpeciesComboBox);
            SpeciesComboBox.SelectedItem = null;
            FillSexComboBox();

        }
        public void FillSpeciesComboBox(ComboBox SpeciesComboBox)
        {
            DataTable dt = petRepo.GetAcceptedSpecies();

            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Please select species";
            dt.Rows.InsertAt(row, 0);
            SpeciesComboBox.DataSource = dt;
            SpeciesComboBox.ValueMember = "SpeciesID";
            SpeciesComboBox.DisplayMember = "Name";

            SpeciesComboBox.DataBindings.Add("SelectedValue", dt, "SpeciesID");

        }
        public void FillSexComboBox()
        {
            SexComboBox.BindEnumToCombobox(Sex.None);
        }
        public void CreateNewPetButton_Click(object sender, EventArgs e)
        {
            AnimalType animalType = SpeciesComboBox.SelectedValue.As(0).As(AnimalType.None);
            Sex sex = SexComboBox.SelectedValue.As(0).As(Sex.None);

            Pet proposedPet = petRepo.GetNewPet();
            proposedPet.Name = PetNameTextBox.Text;
            proposedPet.AnimalType = animalType;
            proposedPet.Breed = PetBreedTextBox.Text;
            proposedPet.Age = PetAgeTextBox.Text.As(0);
            proposedPet.Weight = PetWeightTextBox.Text.As(0);
            proposedPet.Sex = sex;
            proposedPet.Customer_Id = CustomerId;

            petRepo.AddNewPet(proposedPet);

            OnPetAdded(sender, e);

            MessageBox.Show($"Congrats, a pet profile has been created for {proposedPet.Name}!");

        }
        private void OnPetAdded(object sender, EventArgs e)
        {
            if (PetAdded != null)
            {
                PetAdded(this, EventArgs.Empty);
            }
        }
    }
}
