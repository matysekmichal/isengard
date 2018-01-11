using System;

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

        public Address(string street, string city, string postCode, int streetNumber) : this()
        {
            this.SetData(street, city, postCode, streetNumber);
        }

        public void ShowDetails()
        {
            Console.WriteLine($"{Street} {StreetNumber}, {PostCode} {City}");
        }

        public static Address SetData()
        {
            var address = new Address();

            Console.WriteLine("Wprowadź dane nowego adresu");

            address.SetData(Toolbox.InputString("Podaj ulicę: ",false), 
                          Toolbox.InputString("Podaj Miasto: ", false),
                          Toolbox.InputString("Podaj Kod Pocztowy: ", false), 
                          Toolbox.InputInteger("Nr Domu: ",1,200));

            return address;
        }

        public void SetData(string street, string city, string postCode, int streetNumber)
        {
            this.Street = street;
            this.City = city;
            this.PostCode = postCode;
            this.StreetNumber = streetNumber;
        }
    }
    
}
