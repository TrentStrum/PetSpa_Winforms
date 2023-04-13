global using TT.Contracts;
global using TT.Common.Extensions; 

using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace TT.Data
{
    public class DataAccess 
    {
        public static void Init(string connectionString)
        {
            ConnectionString = connectionString;
        }
        private static string ConnectionString { get; set; }
        public static DataAccess TTDataBase
        {
            get => _TTDataBase ??= new DataAccess();
        }
        private DataAccess() { }
        private static DataAccess _TTDataBase = null;

        public DataTable GetDataTable(string stp)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(stp, conn))
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    conn.Close();
                    return dt;
                }
            }
        }
        public DataSet ExecCmdQuery(string commandText, SqlParameter[] parms = null)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    if (parms != null && parms.Length > 0) cmd.Parameters.AddRange(parms);
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        conn.Open();
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        conn.Close();
                        return dataSet;
                    }
                }
            }
        }
        public int ExecNonQuery(string commandText, SqlParameter[] parms = null)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))

            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    if (parms != null && parms.Length > 0) cmd.Parameters.AddRange(parms);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected;
                }
            }
        }
        public int ExecScaler(string commandText, SqlParameter[] parms = null)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    if (parms != null && parms.Length > 0) cmd.Parameters.AddRange(parms);
                    conn.Open();
                    object modified = cmd.ExecuteScalar();
                    modified = modified != DBNull.Value ? modified : modified;
                    int newMod = Convert.ToInt32(modified);
                    conn.Close();

                    return newMod;
                }
            }
        }
        public static SqlParameter BuildParameter<TType>(string parameterName, System.Data.SqlDbType dbType, TType value, bool isNullable = false)
        {
            if (value == null && !isNullable)
                throw new ArgumentException("Parameter value cannot be null for a non-nullable column");

            var result = new SqlParameter(parameterName, dbType);
            if (isNullable) result.IsNullable = true; ;

            result.Value = value == null ? System.DBNull.Value : value;
            return result;
        }
    }
}