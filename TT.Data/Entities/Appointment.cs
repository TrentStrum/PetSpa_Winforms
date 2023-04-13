using System.Data;

namespace TT.Data.Entities
{
    public class Appointment
    {
        private DataRow AppointmentRow { get; }
        public Appointment(DataRow appointmentRow) => AppointmentRow = appointmentRow;

        public int ApptId
        {
            get => AppointmentRow["Appt_Id"].As(0);
            set => AppointmentRow["Appt_Id"] = value;

        }
        public int PetId
        {
            get => AppointmentRow["Pet_Id"].As(0);
            set => AppointmentRow["Pet_Id"] = value;
        }
        public DateTime CheckInDateTime
        {
            get => AppointmentRow["CheckInDateTime"].As(DateTime.Now);
            set => AppointmentRow["CheckInDateTime"] = value;
        }
        public DateTime CheckOutDateTime
        {
            get => AppointmentRow["CheckOutDateTime"].As(DateTime.Now);
            set => AppointmentRow["CheckOutDateTime"] = value;
        }
        public string SpecialInstructions
        {
            get => AppointmentRow["SpecialInstructions"].As("");
            set => AppointmentRow["SpecialInstructions"] = value;
        }
        public bool HasChanges()
        {
            return AppointmentRow.Table.GetChanges()?.Rows.Count > 0;
        }
        public override string ToString()
        {
            return $"Checkin: {CheckInDateTime}, {Environment.NewLine}Checkout: {CheckOutDateTime},{Environment.NewLine}Special Instructions: {SpecialInstructions}";
        }
    }
}
