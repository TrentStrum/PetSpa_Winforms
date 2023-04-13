using System.Data;
using TT.Data.Entities;

namespace TT.Data.DataContracts
{
    public interface IPetRepository
    {
        DataTable PetTable { get; }
        DataTable GetAcceptedSpecies();
        Pet GetNewPet();
        Pet GetPetById(int PetId);
        IEnumerable<Pet> GetPetsByCustomerId(int customerId);
        Pet AddNewPet(Pet proposed);
        int UpdatePet(Pet proposed);
        int DeletePetById(int petId);
        IEnumerable<Pet> GetPetByName(string findPet);

    }
}
