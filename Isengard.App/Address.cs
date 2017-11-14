using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isengard.App
{
    public class Address : IInformations
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string PostCode { get; private set; }
        public int StreetNumber { get; private set; }

        public Address()
        {
            this.SetData(Toolbox.NoData, Toolbox.NoData, Toolbox.NoData, Toolbox.NoNumber);
        }

        public Address(string Street, string City, string PostCode, int StreetNumber) : this()
        {
            this.SetData(Street,City,PostCode,StreetNumber);
        }
        public void ShowDetails()
        {
            
        }

        public static Address SetData() //Podananie informacji dla wszystkich pól i przekazanie do metody SetData
        {
            Address result = new Address();

            Console.WriteLine("Wprowadź dane nowego adresu");

            result.SetData(Toolbox.inputString("Podaj ulicę: ",false), 
                          Toolbox.inputString("Podaj Miasto: ", false),
                          Toolbox.inputString("Podaj Kod Pocztowy: ", false), 
                          Toolbox.inputInteger("Nr Domu: ",1,200));
            return result;
        }

        public void SetData(string Street, string City, string PostCode, int StreetNumber)
        {
            this.Street = Street;
            this.City = City;
            this.PostCode = PostCode;
            this.StreetNumber = StreetNumber;
        }
    }
    
}
