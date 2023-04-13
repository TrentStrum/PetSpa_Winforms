using System.Data;
using TT.Data.Entities;

namespace TT.Data.DataContracts
{
    public interface IAppointmentRepository
    {
        DataTable AppointmentTable { get; }       
        Appointment GetNewAppointment();
        Appointment GetAppointmentById(int id);
        IEnumerable<Appointment> GetApptByPetId(int petId);
        Appointment AddNewAppointment(Appointment proposed);
        int UpdateAppointment(Appointment proposed);
        Appointment DeleteAppointmentById(int addressId);
        Appointment DeleteAppointment(Appointment proposed);
        IEnumerable<Appointment> GetAppointments();
        IEnumerable<Appointment> GetAppointmentsByPersonName(string findAppointment);
    }
}
