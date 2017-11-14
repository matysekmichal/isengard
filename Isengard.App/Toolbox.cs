using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isengard.App
{
    public class Toolbox
    {
        public static string NoData = "Brak Danych";
        public static int NoNumber = 0;

        public static int inputInteger(string inputText, int min, int max)
        {
            int result = 0;

            while (true)
            {
                string liczba = Toolbox.inputString(inputText, false);

                result = int.Parse(liczba);

                if (!int.TryParse(liczba, out result) ||
                    (result < min || result > max))
                {
                    Console.WriteLine("Wprowadzono niepoprawna wartosc (Zakres {0} {1})", min, max);
                }
                else
                    break;
            }

            return result;
        }

        public static string inputString(string inputText, bool isEmpty)
        {
            string result = "";

            while (true)
            {
                Console.Write(inputText);
                result = Console.ReadLine();

                if (isEmpty)
                {
                    break;
                }
                else
                if (string.IsNullOrEmpty(result))
                {
                    Console.WriteLine("Wartosc nie moze byc pusta!");
                }
                else
                    break;
            }

            return result;
        }
    }

}
