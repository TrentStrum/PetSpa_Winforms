using TT.Data.DataContracts;
using TT.Data.Entities;
using TT.Data.Repositories;
using TT.Forms.Classes;

namespace TT.Forms.Forms
{
    public partial class AddAppointmentForm : Form
    {
        private AppointmentRepository ApptRepo { get; } = new();
        public int PetId { get; set; }
        public int ApptId { get; set; }
        protected Appointment Appointment { get; }
        private BindingSource apptBindingSource { get; } = new();
        public event EventHandler? ApptAdded;
        public AddAppointmentForm(int apptId)
        {
            InitializeComponent();
            ApptId = apptId;
            Appointment = ApptRepo.GetAppointmentById(ApptId);
            if (Appointment == null) Appointment = ApptRepo.GetNewAppointment();
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ApptId == 0)
            {
                Appointment proposedAppt = ApptRepo.GetNewAppointment();
                proposedAppt.PetId = PetId;
                proposedAppt.CheckInDateTime = CheckInDateTimePicker.Value;
                proposedAppt.CheckOutDateTime = CheckOutDateTimePicker.Value;
                proposedAppt.SpecialInstructions = SpecialInstructionsTextBox.Text;

                ApptRepo.AddNewAppointment(proposedAppt);

                OnApptAdded(sender, e);

                MessageBox.Show("New appointment added.");
            }
            else
            {
                apptBindingSource.EndEdit();

                if (Appointment.HasChanges())
                {
                    int updatePet = ApptRepo.UpdateAppointment(Appointment);
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

        }
        private void OnApptAdded(object sender, EventArgs e)
        {
            if (ApptAdded != null)
            {
                ApptAdded(this, EventArgs.Empty);
            }
        }

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            BindingSource apptBindingSource = new BindingSource();
            apptBindingSource.DataSource = Appointment;

            CheckInDateTimePicker.AddDataBindingDateTime(apptBindingSource, "CheckInDateTime");
            CheckOutDateTimePicker.AddDataBindingDateTime(apptBindingSource, "CheckOutDateTime");

        }
    }
}
