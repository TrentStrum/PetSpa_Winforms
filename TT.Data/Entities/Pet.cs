using System.Data;
using static TT.Common.Enums.Enums;

namespace TT.Data.Entities
{
    public class Pet
    {
        private DataRow PetRow { get; }
        internal Pet(DataRow petRow) => PetRow = petRow;

        public int Id
        {
            get => PetRow["Pet_Id"].As(0);
            set => PetRow["Pet_Id"] = value;
        }
        public string Name
        {
            get => PetRow["Name"].As("");
            set => PetRow["Name"] = value;
        }
        public AnimalType AnimalType
        {
            get => PetRow["AnimalType"].As(AnimalType.None);
            set => PetRow["AnimalType"] = value.As(0);
        }
        public string Breed
        {
            get => PetRow["Breed"].As("");
            set => PetRow["Breed"] = value;
        }
        public int Age
        {
            get => PetRow["Age"].As(0);
            set => PetRow["Age"] = value;
        }
        public int Weight
        {
            get => PetRow["Weight"].As(0);
            set => PetRow["Weight"] = value;
        }
        public Sex Sex
        {
            get => PetRow["Sex"].As(0).As(Sex.None);
            set => PetRow["Sex"] = value.As(0);
        }
        public int Customer_Id
        {
            get => PetRow["Customer_Id"].As(0);
            set => PetRow["Customer_Id"] = value;
        }
        public bool HasChanges()
        {
            return PetRow.Table.GetChanges()?.Rows.Count > 0;
        }
        public override string ToString()
        {
            return $"Name: {Name}, {Environment.NewLine}Animal Type: {AnimalType}, {Environment.NewLine}Breed: {Breed},{Environment.NewLine}Age: {Age},{Environment.NewLine}Weight: {Weight},{Environment.NewLine}Sex: {Sex}";
        }

    }
}
