using TrentsTroublemakersWF.Forms;
using TT.Data.Entities;
using TT.Data.Repositories;
using TT.Forms.Classes;

namespace TT.Forms.Forms
{
    public partial class PetProfileForm : Form
    {
        private PetRepository PetRepo { get; } = new();
        private AppointmentRepository ApptRepo { get; } = new();
        protected Pet Pet { get; }
        private BindingSource petProfileBindingSource { get; } = new();
        public int PetId { get; set; }
        public PetProfileForm(int petId)
        {
            InitializeComponent();
            PetId = petId;
            Pet = PetRepo.GetPetById(PetId);
            if (Pet == null) Pet = PetRepo.GetNewPet();
        }

        public void PetProfileForm_Load(object sender, EventArgs e)
        {
            BindingSource petProfileBindingSource = new BindingSource();
            petProfileBindingSource.DataSource = Pet;

            NameTextBox.AddDataBinding(petProfileBindingSource, "Name");
            SpeciesTextBox.AddDataBinding(petProfileBindingSource, "AnimalType");
            BreedTextBox.AddDataBinding(petProfileBindingSource, "Breed");
            AgeTextBox.AddDataBinding(petProfileBindingSource, "Age");
            WeightTextBox.AddDataBinding(petProfileBindingSource, "Weight");
            SexTextBox.AddDataBinding(petProfileBindingSource, "Sex");

            LoadRecentAppts();
        }
        private void AddApptForm_ApptAdded(object? sender, EventArgs e)
        {
            LoadRecentAppts();
        }
        private void LoadRecentAppts()
        {
            BindingSource recentApptGridBindingSource = new BindingSource
            {
                DataSource = ApptRepo.GetApptByPetId(PetId)
            };
            RecentApptDataGridView.DataSource = recentApptGridBindingSource;

            RecentApptDataGridView.Columns["ApptId"].Visible = false;
            RecentApptDataGridView.Columns["PetId"].Visible = false;
            RecentApptDataGridView.Columns["CheckInDateTime"].HeaderText = "Check-in";
            RecentApptDataGridView.Columns["CheckOutDateTime"].HeaderText = "Check-out";
            RecentApptDataGridView.Columns["SpecialInstructions"].HeaderText = "Special Instructions";
            RecentApptDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void NewAppointmentButton_Click(object sender, EventArgs e)
        {
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm(0);
            addAppointmentForm.ApptAdded += AddApptForm_ApptAdded;
            addAppointmentForm.PetId = this.PetId;
            addAppointmentForm.MdiParent = this.ParentForm;
            addAppointmentForm.Show();
        }

        private void UpdatePetButton_Click(object sender, EventArgs e)
        {
            petProfileBindingSource.EndEdit();

            if (Pet.HasChanges())
            {
                int updatePet = PetRepo.UpdatePet(Pet);
                if (updatePet == 1)
                {
                    MessageBox.Show("Pet change made");
                }
                else
                {
                    MessageBox.Show("Error- pet change not made");
                }
            }
        }

        private void DeletePetButton_Click(object sender, EventArgs e)
        {
            PetRepo.DeletePetById(PetId);
            MessageBox.Show("Pet has been deleted");
            this.Close();
        }
    }
}
