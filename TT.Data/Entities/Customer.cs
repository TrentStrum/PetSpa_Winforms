using System.Data;

namespace TT.Data.Entities
{
    public class Customer 
    {
        private DataRow CustomerRow { get; }
        public Person Person { get; }
        public Phone Phone { get; }
        public Email Email { get; }
        public Address Address { get; }
        public Pet Pet { get; }
        public Customer(DataRow customerRow, Person person, Phone phone, Email email, Address shippingAddress, Pet pet)
        {
            CustomerRow = customerRow;
            Person = person;
            Phone = phone;
            Email = email;
            Address = shippingAddress;
            Pet = pet;
        }
        public Customer(DataRow customerRow) => CustomerRow = customerRow;
        public int Id
        {
            get => CustomerRow["Customer_Id"].As(0);
            set => CustomerRow["Customer_Id"] = value;
        }
        public int Person_Id
        {
            get => CustomerRow["Person_Id"].As(0);
            set => CustomerRow["Person_Id"] = value;
        }

        public DateTime RegistrationDate
        {
            get => CustomerRow["RegistrationDate"].As(DateTime.Now);
            set => CustomerRow["RegistrationDate"] = value;
        }
        public bool HasChanges()
        {
            return CustomerRow.Table.GetChanges()?.Rows.Count > 0;
        }
    }
}
