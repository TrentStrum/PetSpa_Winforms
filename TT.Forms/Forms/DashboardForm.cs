using TT.Data.Repositories;
using TT.Common.Extensions;
using TT.Data.Entities;

namespace TT.Forms.Forms
{
    public partial class DashboardForm : Form
    {
        private AppointmentRepository ApptRepo { get; } = new();
        private PetCustApptVMRepository petCustApptVMRepo { get; } = new();
        public DashboardForm()
        {
            InitializeComponent();

        }
        private void CustomerSearchButton_Click(object sender, EventArgs e)
        {
            SearchCustomerForm seachCustomerForm = new SearchCustomerForm();
            seachCustomerForm.MdiParent = this.ParentForm;
            seachCustomerForm.Show();
            this.Hide();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            BindingSource TodayCheckInGridBindingSource = new BindingSource
            {
                DataSource = petCustApptVMRepo.GetTodaysCheckIns(today)
            };
            TodaysCheckInGridView.DataSource = TodayCheckInGridBindingSource;

            TodaysCheckInGridView.Columns["PetName"].HeaderText = "Pet Name";
            TodaysCheckInGridView.Columns["CustomerFirstName"].HeaderText = "First Name";
            TodaysCheckInGridView.Columns["CustomerLastName"].HeaderText = "Last Name";
            TodaysCheckInGridView.Columns["CheckInDateTime"].HeaderText = "Check-in Date";
            TodaysCheckInGridView.Columns["CheckOutDateTime"].HeaderText = "Check-out Date";
            TodaysCheckInGridView.Columns["SpecialInstructions"].HeaderText = "Special Instructions";
            TodaysCheckInGridView.Columns["ApptId"].HeaderText = "Appt_ID";
            TodaysCheckInGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TodaysCheckInGridView.ClearSelection();

            BindingSource TodayCheckOutGridBindingSource = new BindingSource
            {
                DataSource = petCustApptVMRepo.GetTodaysCheckOuts(today)
            };
            TodaysCheckOutGridView.DataSource = TodayCheckOutGridBindingSource;

            TodaysCheckOutGridView.Columns["PetName"].HeaderText = "Pet Name";
            TodaysCheckOutGridView.Columns["CustomerFirstName"].HeaderText = "First Name";
            TodaysCheckOutGridView.Columns["CustomerLastName"].HeaderText = "Last Name";
            TodaysCheckOutGridView.Columns["CheckInDateTime"].HeaderText = "Check-in Date";
            TodaysCheckOutGridView.Columns["CheckOutDateTime"].HeaderText = "Check-out Date";
            TodaysCheckOutGridView.Columns["SpecialInstructions"].HeaderText = "Special Instructions";
            TodaysCheckOutGridView.Columns["ApptId"].HeaderText = "Appt_ID";
            TodaysCheckOutGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TodaysCheckOutGridView.ClearSelection();
        }

        private void TodayScheduleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // open appointment update form
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddIndividualCustomerForm addIndividualCustomerForm = new AddIndividualCustomerForm();
            addIndividualCustomerForm.Show();
        }



        private void TodaysCheckInGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var aptId = this.TodaysCheckInGridView.CurrentRow.Cells["ApptId"].Value.As(0);
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm(aptId)
            {
                MdiParent = this.ParentForm
            };
            addAppointmentForm.Show();
        }

        private void TodaysCheckOutGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var aptId = this.TodaysCheckOutGridView.CurrentRow.Cells["ID"].Value.As(0);
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm(aptId)
            {
                MdiParent = this.ParentForm
            };
            addAppointmentForm.Show();
        }

        private void SearchPetButton_Click(object sender, EventArgs e)
        {
            SearchPetForm searchPetForm = new SearchPetForm();
            searchPetForm.Show();
        }
    }
}
