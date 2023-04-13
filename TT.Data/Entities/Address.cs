using static TT.Common.Enums.Enums;
using System.Data;

namespace TT.Data.Entities
{
    public class Address
    {
        private DataRow AddressRow { get; }
        public Address(DataRow addressRow) => AddressRow = addressRow;
        public int Id
        {
            get => AddressRow["Address_Id"].As(0);
            set => AddressRow["Address_Id"] = value;
        }
        public int Address_Type
        {
            get => AddressRow["Address_Type"].As(0);
            set => AddressRow["Address_Type"] = value;
        }
        public string Street
        {
            get => AddressRow["Street"].As("");
            set => AddressRow["Street"] = value;
        }
        public string Supplemental
        {
            get => AddressRow["Supplemental"].As("");
            set => AddressRow["Supplemental"] = value;
        }
        public string City
        {
            get => AddressRow["City"].As("");
            set => AddressRow["City"] = value;
        }
        public State State
        {
            get => AddressRow["State"].As(0).As(State.None);
            set => AddressRow["State"] = value;
        }
        public string ZipCode
        {
            get => AddressRow["ZipCode"].As("");
            set => AddressRow["ZipCode"] = value;
        }
        public int PersonId
        {
            get => AddressRow["Person_Id"].As(0);
            set => AddressRow["Person_Id"] = value;
        }
        public bool HasChanges()
        {
            return AddressRow.Table.GetChanges()?.Rows.Count > 0;
        }
    }
}
