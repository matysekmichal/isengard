using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Isengard.App;

namespace Isengard.App
{
   public class Dog :IInformations, Pet
   {
        public new string Species { get; private set; }
       public string Taste { get; private set; }

        public string Species(string Spieces)
       {
           this.Species = Spieces;
           return this.Species;
       }

       public string Taste(string Taste)
       {
           this.Taste = Taste;
           return Taste;
       }

       public void SetData()
       {
           
       }

       public void LetsPetSaySomething()
       {
           
       }
        

   }
}
