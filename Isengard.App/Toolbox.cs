using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Isengard.App
{

    public class Toolbox
    {
        public static string NoData = "Brak danych";
        public static int NoNumber = 0;

        public static int InputInteger(string inputText, int min, int max)
        {
            int result = 0;

            while (true)
            {
                string liczba = Toolbox.InputString(inputText, false);

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

        public static MailAddress InputEmail(string inputEmail)
        {
            while (true)
            {
                Console.Write(inputEmail);
                var email = Console.ReadLine();

                try
                {
                    var vaildMailAddress = new MailAddress(email ?? throw new InvalidOperationException());
                    return vaildMailAddress;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieproawidłowy adres email.");
                }
            }
        }

        public static string InputString(string inputText, bool isEmpty)
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
