using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using TT.Data.DataContracts;
using TT.Data.Entities;
using static TT.Common.Enums.Enums;

namespace TT.Data.Repositories
{
    public class PetRepository : IPetRepository
    {
        private DataTable _petTable = null;
        public DataTable PetTable { get => _petTable ??= FillPetTable(); }
        public PetRepository() { }
        
        private DataTable FillPetTable()
        {
            var dataSet = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getPetTable]");

            DataTable petTable = dataSet.Tables[0];

            petTable.Columns["Pet_id"].AutoIncrement = true;
            petTable.Columns["Pet_id"].AutoIncrementSeed = -1;
            petTable.Columns["Pet_id"].AutoIncrementStep = -1;

            petTable.AcceptChanges();
            return petTable;
        }

        public Pet GetNewPet()
        {
            return new Pet(PetTable.NewRow());
        }

        public Pet AddNewPet(Pet proposed)
        {
            proposed.Id = InsertPet(proposed.Name, proposed.AnimalType, proposed.Breed, proposed.Age, proposed.Weight, proposed.Sex, proposed.Customer_Id);
            PetTable.AcceptChanges();
            return proposed;
        }
        private int InsertPet(string name, AnimalType animalType, string breed, int age, int weight, Sex sex, int customerId)
        {
            var nameParam = DataAccess.BuildParameter(nameof(name), SqlDbType.VarChar, name, false);
            var animalTypeParam = DataAccess.BuildParameter(nameof(animalType), SqlDbType.VarChar, animalType.As(0), false);
            var breedParam = DataAccess.BuildParameter(nameof(breed), SqlDbType.VarChar, breed, false);
            var ageParam = DataAccess.BuildParameter(nameof(age), SqlDbType.Int, age, false);
            var weightParam = DataAccess.BuildParameter(nameof(weight), SqlDbType.Int, weight, false);
            var sexParam = DataAccess.BuildParameter(nameof(sex), SqlDbType.VarChar, sex.As(0), false);
            var customerIdParam = DataAccess.BuildParameter(nameof(customerId), SqlDbType.Int, customerId, false);

            var sqlParameters = new SqlParameter[] { nameParam, animalTypeParam, breedParam, ageParam, weightParam, sexParam, customerIdParam };
            return DataAccess.TTDataBase.ExecScaler("[stp_insertNewPet]", sqlParameters);
        }
        public IEnumerable<Pet> GetPetsByCustomerId(int customerId)
        {
            var petList = new List<Pet>();
            var customerIdParam = DataAccess.BuildParameter(nameof(customerId), SqlDbType.Int, customerId, false);
            var sqlParameters = new SqlParameter[] { customerIdParam };

            DataSet dataSet = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getPetsByCustomerId]", sqlParameters);
            DataTable petsTable = dataSet.Tables[0];

            if (petsTable.Rows.Count > 0)
            {
                foreach (DataRow pet in petsTable.Rows)
                {
                    petList.Add(new Pet(pet));
                }
            }
            return petList;
        }
        public Pet GetPetById(int PetId)
        {
            var petIdParam = DataAccess.BuildParameter(nameof(PetId), SqlDbType.Int, PetId, false);
            var sqlParameters = new SqlParameter[] { petIdParam };
            DataSet dataSet = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getPetById]", sqlParameters);
            dataSet.Tables[0].TableName = "Pet";
            Pet pet = new Pet(dataSet.Tables["Pet"].Rows[0]);
            return pet;
        }

        public int UpdatePet(Pet proposed)
        {
            string name = proposed.Name;
            int animalType = (int)proposed.AnimalType;
            string breed = proposed.Breed;
            int age = proposed.Age;
            int weight = proposed.Weight;
            int sex = (int)proposed.Sex;
            int petId = proposed.Id;

            var nameParam = DataAccess.BuildParameter(nameof(name), SqlDbType.VarChar, name, false);
            var animalTypeParam = DataAccess.BuildParameter(nameof(animalType), SqlDbType.Int, animalType, false);
            var breedParam = DataAccess.BuildParameter(nameof(breed), SqlDbType.VarChar, breed, false);
            var ageParam = DataAccess.BuildParameter(nameof(age), SqlDbType.Int, age, false);
            var weightParam = DataAccess.BuildParameter(nameof(weight), SqlDbType.Int, weight, false);
            var sexParam = DataAccess.BuildParameter(nameof(sex), SqlDbType.Int, sex, false);
            var petIdParam = DataAccess.BuildParameter(nameof(petId), SqlDbType.Int, petId, false);
     
            var sqlParameters = new SqlParameter[] { nameParam, animalTypeParam, breedParam, ageParam, weightParam, sexParam, petIdParam };

            return DataAccess.TTDataBase.ExecScaler("[dbo].[stp_updatePet]", sqlParameters);
        }

        public int DeletePetById(int petId)
        {
            var petIdParam = DataAccess.BuildParameter(nameof(petId), SqlDbType.Int, petId, false);
            var sqlParameters = new SqlParameter[] { petIdParam };

            return DataAccess.TTDataBase.ExecScaler("[dbo].[stp_deletePetById]", sqlParameters);
        }

        public IEnumerable<Pet> GetPetByName(string petName)
        {
            var petList = new List<Pet>();
            var petNameParam = DataAccess.BuildParameter(nameof(petName), SqlDbType.VarChar, petName, false);

            var sqlParameters = new SqlParameter[] { petNameParam };

            DataSet dataSet = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getPetByName]", sqlParameters);
            DataTable petsTable = dataSet.Tables[0];

            if (petsTable.Rows.Count > 0)
            {
                foreach (DataRow pet in petsTable.Rows)
                {
                    petList.Add(new Pet(pet));
                }
            }
            return petList;
        }
        public DataTable GetAcceptedSpecies()
        {
            var speciesTable = DataAccess.TTDataBase.ExecCmdQuery("stp_getSpeciesTable");
            speciesTable.Tables[0].TableName = "Species"; 
            return speciesTable.Tables["Species"];
        }
        public IEnumerable<Pet> GetPetByCustFirstAndLastName(string custFirstName, string custLastName)
        {
            var petList = new List<Pet>();
            var custFirstNameParam = DataAccess.BuildParameter(nameof(custFirstName), SqlDbType.VarChar, custFirstName, false);
            var custLastNameParam = DataAccess.BuildParameter(nameof(custLastName), SqlDbType.VarChar, custLastName, false);

            var sqlParameters = new SqlParameter[] { custFirstNameParam, custLastNameParam };

            DataSet dataSet = DataAccess.TTDataBase.ExecCmdQuery("[dbo].[stp_getPetsByCustFirstAndLastName]", sqlParameters);
            DataTable petsTable = dataSet.Tables[0];

            if (petsTable.Rows.Count > 0)
            {
                foreach (DataRow pet in petsTable.Rows)
                {
                    petList.Add(new Pet(pet));
                }
            }
            return petList; 
        }
    }
}
