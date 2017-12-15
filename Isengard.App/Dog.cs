using System;

namespace Isengard.App
{
   public abstract class Dog : Pet
   {
       public string Spieces { get; set; }
       public string TasteDog { get; set; }
        
       public  string Taste()
       {
           throw new NotImplementedException();
       }

        //public override Pet CreatePet()
        //{
        //        var result = new Dog();

        //        Console.WriteLine("=== Wprowadź dane nowego psa ===");

        //        result.SetData(Toolbox.inputString("Podaj imie:", false),
        //            Toolbox.inputString("Podaj nazwisko:", false),
        //            Toolbox.inputInteger("Podaj nazwisko", 0, 120),
        //            Toolbox.inputString("Podaj email: ", false));

        //        return result;
        //}
        
   }
}
