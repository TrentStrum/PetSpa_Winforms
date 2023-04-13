using System.Data;
using System.Data.SqlClient;
using TT.Data.DataContracts;
using TT.Data.Entities;

namespace TT.Data.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private DataTable _appointmentTable = null;
        public DataTable AppointmentTable { get => _appointmentTable ??= FillAppointmentTable(); }
        public AppointmentRepository() { }

        private DataTable FillAppointmentTable()
        {
            var dataSet = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getAppointmentTable]");
            DataTable appointmentTable = dataSet.Tables[0];

            appointmentTable.Columns[0].AutoIncrement = true;
            appointmentTable.Columns[0].AutoIncrementSeed = 1;
            appointmentTable.Columns[0].AutoIncrementStep = 1;

            appointmentTable.AcceptChanges();
            return appointmentTable;

        }

        public Appointment GetNewAppointment()
        {
            return new Appointment(AppointmentTable.NewRow());
        }
        public Appointment AddNewAppointment(Appointment proposed)
        {
            proposed.ApptId = InsertAppointment(proposed.PetId, proposed.CheckInDateTime, proposed.CheckOutDateTime, proposed.SpecialInstructions);
            AppointmentTable.AcceptChanges();
            return proposed;
        }
        private int InsertAppointment(int pet_Id, DateTime checkInDate, DateTime checkOutDate, string specialInstructions)
        {
            var petIdParam = DataAccess.BuildParameter(nameof(pet_Id), SqlDbType.Int, pet_Id, false);
            var checkInDateTimeParam = DataAccess.BuildParameter(nameof(checkInDate), SqlDbType.DateTime, checkInDate, false);
            var checkOutDateTimeParam = DataAccess.BuildParameter(nameof(checkOutDate), SqlDbType.DateTime, checkOutDate, false);
            var specialInstructionsParam = DataAccess.BuildParameter(nameof(specialInstructions), SqlDbType.VarChar, specialInstructions, false);

            var sqlParameters = new SqlParameter[] { petIdParam, checkInDateTimeParam, checkOutDateTimeParam, specialInstructionsParam };
            return DataAccess.TTDataBase.ExecScaler("[stp_insertNewAppointment]", sqlParameters);
        }
        public IEnumerable<Appointment> GetApptByPetId(int petId)
        {
            var apptList = new List<Appointment>();
            var petIdParam = DataAccess.BuildParameter(nameof(petId), SqlDbType.Int, petId, false);
            var sqlParameters = new SqlParameter[] { petIdParam };

            DataSet dataSet = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getApptByPetId]", sqlParameters);
            DataTable apptTable = dataSet.Tables[0];

            if (apptTable.Rows.Count > 0)
            {
                foreach (DataRow appt in apptTable.Rows)
                {
                    apptList.Add(new Appointment(appt));
                }
            }
            return apptList;
        }
        public Appointment GetAppointmentById(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateAppointment(Appointment proposed)
        {
            int pet_Id = proposed.PetId;
            DateTime checkInDate = proposed.CheckInDateTime;
            DateTime checkOutDate = proposed.CheckOutDateTime;
            string specialInstructions = proposed.SpecialInstructions;

            var petIdParam = DataAccess.BuildParameter(nameof(pet_Id), SqlDbType.Int, pet_Id, false);
            var checkInDateTimeParam = DataAccess.BuildParameter(nameof(checkInDate), SqlDbType.DateTime, checkInDate, false);
            var checkOutDateTimeParam = DataAccess.BuildParameter(nameof(checkOutDate), SqlDbType.DateTime, checkOutDate, false);
            var specialInstructionsParam = DataAccess.BuildParameter(nameof(specialInstructions), SqlDbType.VarChar, specialInstructions, false);

            var sqlParameters = new SqlParameter[] { petIdParam, checkInDateTimeParam, checkOutDateTimeParam, specialInstructionsParam };

            return DataAccess.TTDataBase.ExecScaler("[dbo].[stp_updateAppointment]", sqlParameters);
        }

        public Appointment DeleteAppointmentById(int addressId)
        {
            throw new NotImplementedException();
        }

        public Appointment DeleteAppointment(Appointment proposed)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Appointment> GetAppointments()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Appointment> GetAppointmentsByPersonName(string findAppointment)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges() => SaveChanges(AppointmentTable);
        public static void SaveChanges(DataTable proposed)
        {
            if (proposed?.Rows.Count == 0) return;
            var changeTable = proposed.GetChanges();
            foreach (DataRow change in changeTable.Rows)
            {
                switch (change.RowState)
                {
                    case DataRowState.Unchanged:
                        // Nothing to do
                        break;
                    case DataRowState.Added:
                        // Insert new customer
                        break;
                    case DataRowState.Deleted:
                        // Delete customer
                        break;
                    case DataRowState.Modified:
                        // Modify Customer
                        break;
                    case DataRowState.Detached:
                        // Modify Customer
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
