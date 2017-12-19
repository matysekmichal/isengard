using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isengard.App
{
    public class ZbiornikPaliwa : IInformations


    {
        public long MaksymalnaIloscPaliwa { get; private set; }
        public long IloscPaliwa { get; private set; }
        public ZbiornikPaliwa ()
        {
            MaksymalnaIloscPaliwa = Toolbox.NoLong ;
            IloscPaliwa = Toolbox.NoLong;        
         }
        

        public void Dotankuj(long iloscPaliwa)
        {
            var obecnyStanPaliwa = iloscPaliwa + IloscPaliwa;
            if(iloscPaliwa < 0 )
            {
                throw new Exception("Nie mozna sprzedac wartosci ujemnej paliwa");
            }
            else if (MaksymalnaIloscPaliwa< obecnyStanPaliwa )
            {
                throw new Exception("Przetankowales");
            }
            IloscPaliwa = obecnyStanPaliwa;
        }
        public long Pobierz(long iloscPaliwa)
        {
            var obecnyStanPaliwa = IloscPaliwa - iloscPaliwa;
            if (obecnyStanPaliwa < 0)
            {
                return 0; 
            }
            IloscPaliwa = obecnyStanPaliwa;
            return IloscPaliwa;
        }
        public void ShowDetails()
        {
            throw new NotImplementedException();
        }
    }
}
