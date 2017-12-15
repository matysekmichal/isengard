using System;

namespace Isengard.App
{
   public class Dog : Pet
   {
       public override string Species { get; set; }
       public override string Taste { get; set; }
      

        public Dog() :base()
        {
            this.SetData(Toolbox.NoData, Toolbox.NoNumber, TypeOfPet.NoData,Toolbox.NoData,Toolbox.NoData);
        }
        public Dog(string name, int age, TypeOfPet type) : base()
        {
            SetData(name, age, type);
        }

        
        public Dog(string name, int age, TypeOfPet type, string species, string taste): base()
        {
            SetData(name, age, type,species,taste);
        }
        new public void SetData(string name, int age, TypeOfPet type)
        {
            base.Name = name;
            base.Age = age;
            base.Type = type;
        }
        public void SetData(string name, int age, TypeOfPet type, string species, string taste)
        {
            base.Name = name;
            base.Age = age;
            base.Type = type;
            this.Species = species;
            this.Taste = taste;

        }
        public Pet CreatePet()
        {
            var result = new Dog();

            Console.WriteLine("=== Wprowadź dane nowego psa ===");

            result.SetData(Toolbox.InputString("Podaj imie psa :", false),
                Toolbox.InputInteger("Podaj wiek psa:", 0, 20),
                TypeOfPet.NoData,
                Toolbox.InputString("Gatunek psa :", false),
                Toolbox.InputString("Rasa psa :", false)
                );

            return result;
        }

    }
}
