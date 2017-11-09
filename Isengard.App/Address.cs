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
        public string StreetNumber { get; private set; }

        public Address()
        {
            
        }

        public void ShowDetails()
        {
            
        }

        public void SetData()
        {
            
        }
    }
    
}
