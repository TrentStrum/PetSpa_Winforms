using System.Data;

namespace TT.Data.Entities
{
    public class Phone
    {
        private DataRow PhoneRow { get; }
        public Phone(DataRow phoneRow) => PhoneRow = phoneRow;
        public int Id
        {
            get => PhoneRow["Phone_Id"].As(0);
            set => PhoneRow["Phone_Id"] = value;
        }
        public string Mobile
        {
            get => PhoneRow["Mobile"].As("");
            set => PhoneRow["Mobile"] = value;
        }
        public string Home
        {
            get => PhoneRow["Home"].As("");
            set => PhoneRow["Home"] = value;
        }
        public string Business
        {
            get => PhoneRow["Business"].As("");
            set => PhoneRow["Business"] = value;
        }
        public bool HasChanges()
        {
            return PhoneRow.Table.GetChanges()?.Rows.Count > 0;
        }
    }
}
