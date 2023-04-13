namespace TT.Data
{
    public class Practice_DataAccess
    {
        //public static DataTable GetDataTable(string query)
        //{
        //    string conString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=TrentsTroubleMakersDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //    using (SqlConnection con = new SqlConnection(conString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            cmd.CommandType = CommandType.Text;
        //            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
        //            {
        //                using (DataTable dt = new DataTable())
        //                {
        //                    sda.Fill(dt);
        //                    return dt;

        //                }
        //            }
        //        }
        //    }
        //}

        //public static DataSet ExecCmdQuery()
        //{
        //    string conString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=TrentsTroubleMakersDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //    using (SqlConnection conn = new SqlConnection(conString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.CommandText = "stp_Get_Tables";
        //            cmd.Connection = conn;
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            conn.Open();

        //            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

        //            DataSet dataSet = new DataSet();
        //            dataAdapter.Fill(dataSet);

        //            conn.Close();

        //            return dataSet;

        //        }
        //    }
        //}

        //public static DataTable GetPetByName(string petName)
        //{
        //    string name = petName;

        //    string conString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=TrentsTroubleMakersDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //    using (SqlConnection con = new SqlConnection(conString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Pet WHERE Name = '{name}'", con))
        //        {
        //            cmd.CommandType = CommandType.Text;
        //            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
        //            {
        //                using (DataTable dt = new DataTable())
        //                {
        //                    sda.Fill(dt);
        //                    return dt;

        //                }
        //            }
        //        }
        //    }

        //}

        //public static DataTable GetSpeciesList()
        //{
        //    string conString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=TrentsTroubleMakersDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //    using (SqlConnection con = new SqlConnection(conString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand($"SELECT * FROM AcceptedSpecies", con))
        //        {
        //            cmd.CommandType = CommandType.Text;
        //            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
        //            {
        //                using (DataTable dt = new DataTable())
        //                {
        //                    sda.Fill(dt);
        //                    return dt;

        //                }
        //            }
        //        }
        //    }
        //}

        //public static void AddPet(string name, string species, string breed, int age, int weight, string sex, int owner_Id)
        //{
        //    string conString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=TrentsTroubleMakersDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //    using (SqlConnection con = new SqlConnection(conString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("stp_insertNewPet", con))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@Name", name);
        //            cmd.Parameters.AddWithValue("@AnimalType", species);
        //            cmd.Parameters.AddWithValue("@Breed", breed);
        //            cmd.Parameters.AddWithValue("@Age", age);
        //            cmd.Parameters.AddWithValue("@Weight", weight);
        //            cmd.Parameters.AddWithValue("@Sex", sex);
        //            cmd.Parameters.AddWithValue("@Owner_Id", owner_Id);

        //            con.Open();
        //            cmd.ExecuteNonQuery();
        //            con.Close();


        //        }
        //    }

        //}


    }
}



















