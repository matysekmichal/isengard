using System;

namespace Isengard.App
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello world!");
           // var person = new Person();

           // Toolbox.InputEmail("Podaj adres email:");

            var zoo = new Zoo();
            var labrador = zoo.SetPet();

        }
    }
}
