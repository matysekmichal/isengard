using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isengard.App
{
    abstract class Silnik : ZbiornikPaliwa , IInformations  
    {
        public long LiczbaPrzejechanychKilometrow { get; private set; }
        public long PojemnoscSilnika { get; private set; }


        public Silnik(long LiczbaPrzejechanychKilometrow = 0, long PojemnoscSilnika)
        {
            this.LiczbaPrzejechanychKilometrow = LiczbaPrzejechanychKilometrow;
            this.PojemnoscSilnika = PojemnoscSilnika;
        }



        public virtual void WyswietlInformacje()
        {
            //ta metoda wyświetli informację o instancji silnika
        }


        public virtual long JedziemyWSinaDal(long liczbaKilometrow, ZbiornikPaliwa zbiornikPaliwa)
        {
            zbiornikPaliwa  = new ZbiornikPaliwa();
            var spalanie = PojemnoscSilnika/200;
            var zuzyciePaliwa = (liczbaKilometrow / 100) * spalanie;

            LiczbaPrzejechanychKilometrow += liczbaKilometrow;

            zbiornikPaliwa.Pobierz(zuzyciePaliwa);

            return LiczbaPrzejechanychKilometrow;
        }
        /*	
        metoda powinna pozwolić na przejechanie liczby kilometrów, na która pozwala ilość paliwa w zbiorniku - nie wiecej,
        dodatkowo liczba przejechanych kilometrow powinna byc podbijana
        funkcja jako wartosc powrotna przekazuje liczbe autentycznie przejechanych kilometrow
        do obliczenia zużycia paliwa proszę wykorzystać pole PojemnoscSilnika - oczywiście chodzi tu o jakis prosty wzór - nie chcemy, bawić się w inżynierów mechaników :D
        */

        public abstract string TypSilnika() {...};
        //metoda musi być przysłonieta po stronie klasy dziedziczącej - jej zadaniem jest przekazanie nazwy typu silnika	
    }
}
