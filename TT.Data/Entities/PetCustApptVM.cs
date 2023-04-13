using System.Data;

namespace TT.Data.Entities
{
    public class PetCustApptVM
    {
        private DataRow PetCustomerAppointmentViewModelRow { get; }
        public PetCustApptVM(DataRow petCustomerAppointmentViewModelRow) => PetCustomerAppointmentViewModelRow = petCustomerAppointmentViewModelRow;

        public int PetId
        {
            get => PetCustomerAppointmentViewModelRow["PetId"].As(0);
            set => PetCustomerAppointmentViewModelRow["PetId"] = value;
        }
        public int ApptId
        {
            get => PetCustomerAppointmentViewModelRow["Appt_Id"].As(0);
            set => PetCustomerAppointmentViewModelRow["Appt_Id"] = value;
        }
        public string PetName
        {
            get => PetCustomerAppointmentViewModelRow["PetName"].As("");
            set => PetCustomerAppointmentViewModelRow["PetName"] = value;
        }
        public string CustomerFirstName
        {
            get => PetCustomerAppointmentViewModelRow["CustomerFirstName"].As("");
            set=> PetCustomerAppointmentViewModelRow["CustomerFirstName"] = value;
        }
        public string CustomerLastName
        {
            get => PetCustomerAppointmentViewModelRow["CustomerLastName"].As("");
            set => PetCustomerAppointmentViewModelRow["CustomerLastName"] = value;
        }
        public DateTime CheckInDateTime
        {
            get=> PetCustomerAppointmentViewModelRow["CheckInDateTime"].As(DateTime.Now);
            set=> PetCustomerAppointmentViewModelRow["CheckInDateTime"]= value;
        }
        public DateTime CheckOutDateTime
        {
            get => PetCustomerAppointmentViewModelRow["CheckOutDateTime"].As(DateTime.Now);
            set => PetCustomerAppointmentViewModelRow["CheckOutDateTime"] = value;
        }
        public string SpecialInstructions
        {
            get => PetCustomerAppointmentViewModelRow["SpecialInstructions"].As("");
            set => PetCustomerAppointmentViewModelRow["SpecialInstructions"] = value;
        }
    }
}
