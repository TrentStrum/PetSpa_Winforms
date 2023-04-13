global using TT.Contracts;

using System.Data;
using System.Data.SqlClient;

namespace TT.Data
{
    public class TTDataAccess
    {
        public static void Init(string connectionString)
        {
            ConnectionString = connectionString;
        }
        private static string ConnectionString { get; set; }
        public static TTDataAccess TTDataBase
        {
            get => _TTDataBase ??= new TTDataAccess();
        }
        private TTDataAccess() { }
        private static TTDataAccess _TTDataBase = null;

        public DataTable GetPetTable()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("[dbo].[stp_getPetTable]", conn))
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    conn.Close();
                    return dt;
                }
            }
        }
        public DataTable GetPersonTable()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter($"SELECT * FROM Person", conn))
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    conn.Close();
                    return dt;
                }
            }
        }
        public DataTable GetUserTable()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter($"SELECT * FROM User", conn))
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    conn.Close();
                    return dt;
                }
            }

        } 
        public DataTable GetApptTable()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter($"SELECT * FROM Appointment", conn))
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    conn.Close();
                    return dt;
                }
            }
        }
        public DataTable GetAcceptedSpeciesTable()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("[dbo].[stp_getAcceptedSpeciesTable]", conn))
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    conn.Close();
                    return dt;
                }
            }
        }
    }
}