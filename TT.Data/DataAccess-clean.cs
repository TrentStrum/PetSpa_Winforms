//using TrentsTroublemakersWF.Common.Extensions;
//using System.Data;
//using System.Data.SqlClient;
//using System.Xml.Linq;
//using System.Drawing;

//namespace TrentsTroublemakersWF.Data
//{
//    public class DataAccess
//    {
//        public static void Init(string connectionString)
//        {
//            ConnectionString = connectionString;
//        }
//        private static string ConnectionString { get; set; }
//        private DataAccess() { }
//        private static DataAccess _TTDataBase = null;
//        public static DataAccess TTDataBase
//        {
//            get => _TTDataBase ??= new DataAccess();
//        }


//        public static DataTable GetDataTable(string query)
//        {
//            using (SqlConnection conn = new SqlConnection(ConnectionString))
//            {
//                using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
//                {
//                    conn.Open();
//                    DataTable dt = new DataTable();
//                    sda.Fill(dt);
//                    conn.Close();
//                    return dt;
//                }
//            }
//        }

//        public static DataSet ExecCmdQuery(string commandText, SqlParameter[] parms = null)
//        {
//            using (SqlConnection conn = new SqlConnection(ConnectionString))
//            {
//                using (SqlCommand cmd = new SqlCommand(commandText, conn)
//                {
//                    CommandType = CommandType.StoredProcedure
//                })
//                {
//                    if (parms != null && parms.Length > 0) cmd.Parameters.AddRange(parms);
//                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
//                    {
//                        conn.Open();
//                        DataSet dataSet = new DataSet();
//                        dataAdapter.Fill(dataSet);
//                        conn.Close();
//                        return dataSet;
//                    }
//                }
//            }
//        }
//        public static void ExecCommand(string commandText, SqlParameter[] parms = null)
//        {
//            using (SqlConnection conn = new SqlConnection(ConnectionString))
//            {
//                using (SqlCommand cmd = new SqlCommand(commandText, conn)
//                {
//                    CommandType = CommandType.StoredProcedure
//                })
//                {
//                    if (parms != null && parms.Length > 0) cmd.Parameters.AddRange(parms);
//                    conn.Open();
//                    cmd.ExecuteNonQuery();
//                    conn.Close();
//                }
//            }
//        }
//    }
//}