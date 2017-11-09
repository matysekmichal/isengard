using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isengard.App
{
    public abstract class Pet : IInformations
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Pet(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public enum TypeOfPet
        {
            Domestic = 0x0001,
            Farm = 0x0002,
            NoData = 0x0000
        }

        public void SetData()
        {

        }

        public abstract string Species();
        public abstract string Taste();
        public abstract void LetsPetSaySomething();

        public void ShowDetails()
        {
           
        }
    }
}
