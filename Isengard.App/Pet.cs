using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Isengard.App
{
    public  class Pet : IInformations
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public TypeOfPet Type { get; private set; }
        public string Species { get; private set; }
        public string Taste { get; private set; }


        public enum TypeOfPet
        {
            Domestic= 0x0001,
            Farm = 0x0002,
            NoData = 0x0000,
        }
        
        public Pet()
        {

            this.SetData(Toolbox.NoData, Toolbox.NoNumber, TypeOfPet.NoData, Toolbox.NoData, Toolbox.NoData );
        }

       
        public Pet(string name, int age, TypeOfPet type, string species, string taste): this()
        {
            SetData(name, age, type, species, taste);
        }

        public void SetData(string name, int age, TypeOfPet type, string species, string taste)
        {
            this.Name = name;
            this.Age = age;
            this.Type = type;
            this.Species= species;
            this.Taste = taste;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Imię: {Name}, wiek: {Age}, typ: {Type}, gatunek:{Species}.");
        }

        public virtual void CreatePet() { }
                
      
    }
    
}
