using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isengard.App
{
    public abstract class Cat: Pet
    {
        public string Spieces { get; set; }
        public string TasteCat { get; set; }
        
        public  string Taste()
        {
            throw new NotImplementedException();
        }

        //public override Pet CreatePet()
        //{
        //        var result = new Cat();

        //        Console.WriteLine("=== Wprowadź dane nowego kota ===");

        //        result.SetData(Toolbox.inputString("Podaj imie:", false),
        //            Toolbox.inputString("Podaj nazwisko:", false),
        //            Toolbox.inputInteger("Podaj nazwisko", 0, 120),
        //            Toolbox.inputString("Podaj email: ", false));

        //        return result;
        //}

       
    }

}

