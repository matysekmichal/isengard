using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isengard.App
{
    abstract class Pojazd 
    {
        public enum RodzajPojazdu
        {
            NoData = 0x0000,
            JEDNOSLAD = 0x0001,
            OSOBOWY = 0x0002,
            TERENOWY = 0x0003,
            CIEZAROWY = 0x0004
        };

        public ZbiornikPaliwa ZbiornikPaliwa { get; private set; }
        public Silnik Silnik { get; private set; }
        public RodzajPojazdu Rodzaj { get; private set; }

        public Pojazd()
        {
            this.Rodzaj = RodzajPojazdu.NoData;
        }

        public Pojazd(RodzajPojazdu rodzajPojazdu)
        {
            this.Rodzaj = rodzajPojazdu;
        }

        public virtual void WyswietlInformacje()
        {
            //NAPRAWA
        }

        public abstract string Marka()
        {

        }
        public abstract string Model()
        {

        }

        public virtual long JedziemyWSinaDal(long liczbaKilometrow)
        {

        }
    }
}