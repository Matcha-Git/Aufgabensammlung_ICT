using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string space = "---------------------------------------------";
            int sektag = 86400;
            int sekmonat;
            int tage;

            Console.WriteLine("Monat zu Sekunden rechner");
            Console.WriteLine(space);
            Console.WriteLine("Wie viele Tage hat der Monat, für den sie die Sekundenzahl berechnen wollen?\n");

            string input = Console.ReadLine();
            tage = 0;

            if (int.TryParse(input, out tage) == true)
            {
                if (tage == 28 || tage == 29 || tage == 30 || tage == 31)
                {
                    sekmonat = sektag * tage;
                    Console.WriteLine($"\nEin Monat mit {tage} Tagen hat {sekmonat} Sekunden.");
                }
                else
                {
                    Console.WriteLine("\nERROR -> Fehler bei der Zahlen angabe.");
                }
            }
            else
            {
                Console.WriteLine("\nERROR");
            }

            

            Console.ReadKey();
        }
    }
}
