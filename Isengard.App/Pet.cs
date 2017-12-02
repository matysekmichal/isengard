using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Isengard.App
{
    public abstract class Pet : IInformations
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public TypeOfPet Type { get; private set; }
       
        public enum TypeOfPet
        {
            Domestic = 0x0001,
            Farm = 0x0002,
            NoData = 0x0000,
        }

        public Pet()
        {
            SetData(Toolbox.NoData, Toolbox.NoNumber, TypeOfPet.NoData);
        }

        public Pet(string name)
        {
            SetData(name, Toolbox.NoNumber, TypeOfPet.NoData);
        }

        public Pet(string name, int age)
        {
            SetData(name, age, TypeOfPet.NoData);
        }

        public Pet(string name, int age, TypeOfPet type)
        {
            SetData(name, age, type);
        }

        public void SetData(string name, int age, TypeOfPet type)
        {
            Name = name;
            Age = age;
            Type = type;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Imię: {Name}, wiek: {Age}, typ: {Type}.");
        }

        public virtual void CreatePet() {}
        public abstract string Species();
        public abstract string Taste();
        public abstract Pet SetData();
        public abstract void LetsPetSaySomething();
    }
}
