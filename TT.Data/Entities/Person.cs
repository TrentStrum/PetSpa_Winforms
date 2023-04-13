using System.Data;

namespace TT.Data.Entities
{
    public class Person
    {
        private DataRow PersonRow { get; }
        public Person(DataRow personRow) => PersonRow = personRow;
        public int Id
        {
            get => PersonRow["Person_Id"].As(0);
            set => PersonRow["Person_Id"] = value;
        }
        public string FirstName
        {
            get => PersonRow["FirstName"].As(""); 
            set => PersonRow["FirstName"] = value;
        }
        public string LastName
        {
            get => PersonRow["LastName"].As("");
            set => PersonRow["LastName"] = value;
        }
        public int Phone_Id
        {
            get => PersonRow["Phone_Id"].As(0);
            set => PersonRow["Phone_Id"] = value;
        }
        public int Email_Id
        {
            get => PersonRow["Email_Id"].As(0);
            set => PersonRow["Email_Id"] = value;
        }

        public bool HasChanges()
        {
            return PersonRow.Table.GetChanges()?.Rows.Count > 0;
        }
    }
}
