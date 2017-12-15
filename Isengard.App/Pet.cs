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
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public TypeOfPet Type { get; protected set; }

        public enum TypeOfPet
        {
            Domestic= 1,
            Farm = 2,
            NoData = 0,
        }
        
        public Pet()
        {

            this.SetData(Toolbox.NoData, Toolbox.NoNumber, TypeOfPet.NoData);
        }

       
        public Pet(string name, int age, TypeOfPet type, string species, string taste): this()
        {
            SetData(name, age, type);
        }

        public void SetData(string name, int age, TypeOfPet type)
        {
            this.Name = name;
            this.Age = age;
            this.Type = type;
            
        }
        public abstract string Species { get; set; }
        public abstract string Taste { get; set; }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Imię: {Name}, wiek: {Age}, typ: {Type}, gatunek:{Species}.");
        }
        
                
      
    }
    
}
