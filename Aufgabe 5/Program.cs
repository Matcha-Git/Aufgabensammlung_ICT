using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int km;
            int n;
            char antwort;
            int i;

            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            input = Console.ReadLine();

            if (int.TryParse(input, out km) == true)
            {
               if (km > 42 || km < 0)
               {
                    Console.WriteLine("Du schaffst das nicht");
               }
               else
               {
                    km *= 1000;
                    n = km / 400;
                    Console.WriteLine($"Das sind {n} Runden. Bereit für den Lauf?");
                    Console.Write("J = Ja / N = Nein [J/N]:\t");
                    input = Console.ReadLine();
                    if (char.TryParse(input, out antwort) == true)
                    {
                        if (antwort == 'J')
                        {
                            i = 1;
                            while (i <= n)
                            {
                                Console.WriteLine($"Du läufst Runde {i}");
                                i++;
                            }
                            Console.WriteLine("Du hast es geschafft!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERROR");
                    }
               }
            }
            else
            {
                Console.WriteLine("\nError -> Es dürfen keine Buchstaben verwndet werden");
            }
            
            Console.WriteLine("\nWaiting for input...");
            Console.ReadKey();
        }
    }
}
