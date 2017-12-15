using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isengard.App
{
    class Zoo : IInformations
    {
        private static Zoo instance;
        private List<Pet> ListOfPets = new List<Pet>();

        public Zoo()
        {
           
        }


        public static Zoo Instance()
        {
            return new Zoo();
        }

        public void SetPet(Pet pet)
        {
            ListOfPets.Add(pet);
        }

        //public Pet GetPet(int i_id)
        //{
        //    return new Pet();
        //}

        public void ShowDetails()
        {
            foreach (var pet in ListOfPets)
            {
                Console.WriteLine(pet);
            }

            
        }
    }
}
