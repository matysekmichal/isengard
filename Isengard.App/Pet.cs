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
            NoData = 0x0000
        }
        public Pet()
        {
            this.SetData(Toolbox.NoData, Toolbox.NoNumber);
        }

        public Pet(string Name, int Age) :this()
        {
          this.SetData(Name,Age);
        }

        public abstract Pet SetData();


        public void SetData(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public void SetData(TypeOfPet type) 
        {
            this.Name = Name;
            this.Age = Age;
            this.Type = type;

        }

        public abstract string Species();
        public abstract string Taste();
        public abstract void LetsPetSaySomething();

        public void ShowDetails()
        {

        }
    }
}
