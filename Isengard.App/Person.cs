using System.Collections.Generic;
using System;
using System.Net.Mail;

namespace Isengard.App
{
    public class Person : IInformations
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public TypesGender Gender { get; private set; }
        public Address Address { get; private set; }
        public MailAddress Email { get; private set; }

        private List<Pet> ListOfPets;

        public enum TypesGender
        {
            Man = 0x0001,
            Female = 0x0002,
            NoData = 0x0000
        }

        public Person()
        {
            this.Gender = TypesGender.NoData;
            this.SetData(Toolbox.NoData, Toolbox.NoData);
            this.Address = new Address();
        }

        public Person(TypesGender gender ) :this ()
        {
            this.Gender = gender;
            this.SetData(Toolbox.NoData, Toolbox.NoData);
            this.Address = new Address();
        }

        public Person(TypesGender gender,string name,string surname) : this()
        {
            this.Gender = gender;
            this.SetData(Toolbox.InputString(name,false), Toolbox.InputString(surname,false));
            this.Address = new Address();
        }

        public Person(TypesGender gender, string name, string surname,string age) : this()
        {
            this.Gender = gender;
            this.SetData(Toolbox.InputString(name, false), Toolbox.InputString(surname, false),Toolbox.InputInteger(age,0,99));
            this.Address = new Address();
        }

        public Person(TypesGender gender, string name, string surname, string age,string email) : this()
        {
            this.Gender = gender;
            this.SetData(Toolbox.InputString(name, false), Toolbox.InputString(surname, false), Toolbox.InputInteger(age, 0, 99),Toolbox.InputEmail(email));
            this.Address = new Address();
        }

        public void SetData(string name, string surname)
        {
                this.Name = name;
                this.Surname = surname;
        }

        public void SetData(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public void SetData(string name, string surname, int age, MailAddress email)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Email = email;
        }

        public void AdoptPet(Pet pet)
        {
            ListOfPets.Add(pet);
        }

        public static Person CreatePerson()
        {
            var result = new Person();

            Console.WriteLine("=== Wprowadź dane nowej osoby ===");

            result.SetData(Toolbox.InputString("Podaj imie:", false),
                Toolbox.InputString("Podaj nazwisko:", false),
                Toolbox.InputInteger("Podaj wiek",0,120),
                Toolbox.InputEmail("Podaj email: "));

            result.Address.SetData(Toolbox.InputString("Podaj ulice:", false),
                Toolbox.InputString("Podaj miasto:", false),
                Toolbox.InputString("Podaj kod pocztowy:", false),
                Toolbox.InputInteger("Podaj nr domu:", 1, int.MaxValue));

            return result;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Imie = {Name} Nazwisko = {Surname}");
            this.Address.ShowDetails();
        }
    }
}
