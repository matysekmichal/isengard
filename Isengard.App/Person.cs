using System.Collections.Generic;

namespace Isengard.App
{
    public class Person : IInformations
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public TypesGender Gender { get; private set; }
        public Address Address { get; private set; }
        public string Email { get; private set; }

        private List<Pet> ListOfPets;

        public enum TypesGender
        {
            Man = 0x0001,
            Female = 0x0002,
            NoData = 0x0000
        }

        public Person()
        {
            this.TypesGender = TypesGender.NoData;
            this.SetData(Toolbox.NoData, Toolbox.NoData);
            this.Address = new Address();
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void SetData(string name, string surname)
        {
            if (!string.IsNotNullOrEmpty(name))
                Name = name;
            if (!string.IsNotNullOrEmpty(surname))
                Surname = surname;
        }

        public void AdoptPet(Pet pet)
        {
            ListOfPets.Add(pet);
        }

        public static Person CreatePerson()
        {
            Person result = new Person();

            Console.WriteLine("=== Wprowadź dane nowej osoby ===");

            result.SetData(Toolbox.inputString("Podaj imie:", true),
                           Toolbox.inputString("Podaj nazwisko:", false));

            result.Adres.SetData(Toolbox.inputString("Podaj ulice:", false),
                                 Toolbox.inputString("Podaj miasto:", false),
                                 Toolbox.inputString("Podaj kod pocztowy:", false),
                                 Toolbox.inputInteger("Podaj nr domu:", 1, int.MaxValue));

            return result;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Imie = {Name} Nazwisko = {Surname}");
            this.Address.ShowDetails();
        }
    }
}
