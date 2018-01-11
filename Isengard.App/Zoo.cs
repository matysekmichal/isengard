using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isengard.App
{
    class Zoo : IInformations
    {
        private static Zoo instance { get; set; }
        private List<Pet> ListOfPets = new List<Pet>();

        public static Zoo Instance()
        {
            return new Zoo();
        }

        public void SetPet(Pet pet)
        {
            ListOfPets.Add(pet);
        }

        public Pet GetPet(int i_id)
        {
            var result = ListOfPets.ElementAt(i_id);
            return result;
        }

        public void ShowDetails()
        {
            foreach (var pet in ListOfPets)
            {
                Console.WriteLine(pet);
            }

            
        }
    }
}
