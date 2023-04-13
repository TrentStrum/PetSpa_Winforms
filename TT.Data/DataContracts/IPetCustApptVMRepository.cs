using TT.Data.Entities;

namespace TT.Data.DataContracts
{
    public interface IPetCustApptVMRepository
    {
        IEnumerable<PetCustApptVM> GetTodaysCheckIns(DateTime today);
        IEnumerable<PetCustApptVM> GetTodaysCheckOuts(DateTime today);
    }
}
