using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isengard.App
{
    class Pet : IInformations
    {
        

        public string Name { get; private set; }
        public int Age { get; private set; }
        public enum TypeOfPet
        {
            Domestic = 0x0001,
            Farm = 0x0002,
            NoData = 0x0000
        };

        public void SetData()
        {

        }

        public abstract Species();
        public abstract Taste();
        public abstract LetsPetSaySomething();




        public void ShowDetails()
        {
           
        }
    }
}
