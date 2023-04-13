using System.Data;

namespace TT.Data.Entities
{
    public class Email
    {
        private DataRow EmailRow { get; }
        public Email(DataRow emailRow) => EmailRow = emailRow;
        public int Id
        {
            get => EmailRow["Email_Id"].As(0);
            set => EmailRow["Email_Id"] = value;
        }
        public string Personal_Email
        {
            get => EmailRow["Personal_Email"].As("");
            set => EmailRow["Personal_Email"] = value;
        }
        public string Work_Email
        {
            get => EmailRow["Work_Email"].As("");
            set => EmailRow["Work_Email"] = value;
        }
        public bool HasChanges()
        {
            return EmailRow.Table.GetChanges()?.Rows.Count > 0;
        }
    }
}
