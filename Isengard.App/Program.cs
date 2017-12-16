using System;

namespace Isengard.App
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello world!");
            var person = new Person();

            var pies = new Dog("Reksio", 3);
            var zoo = new Zoo();
            zoo.SetPet(pies);
            var pet = zoo.GetPet(0);

            Console.WriteLine($"To jest: {pet.Name} i ma {pet.Age} lat.");

            Person.CreatePerson();
        }
    }
}
