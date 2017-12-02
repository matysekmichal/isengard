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
        private List<Pet> ListOfPets;

        public Zoo()
        {

        }

        public static Zoo Instance()
        {
            return new Zoo();
        }

        public void SetPet(Pet pet)
        {
           
        }

        //public Pet GetPet(int IdPet)
        //{
        //    return new Pet();
        //}

        public void ShowDetails()
        {
            throw new NotImplementedException();
        }
    }
}
