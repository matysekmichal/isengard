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
            
        }

        public void SetData()
        {
            
        }

        public void AdoptPet(Pet pet)
        {
            
        }

        public static Person CreatePerson()
        {
            return new Person();
        }

        public void ShowDetails()
        {

        }
    }
}