using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool start = true;
            int jahr = 0;
            string jahr00;
            string test = "00";

            Console.WriteLine("Prüfen, ob es sich bei einem Jahr um ein Schaltjahr handelt.");
            Console.WriteLine("************************************************************");

            while (start == true)
            {
                Console.WriteLine("\n-------------------------------------------\n");
                Console.Write("Eingabe Jahr (q to quit): ");
                string input = Console.ReadLine();
                jahr00 = input;

                if (int.TryParse(input, out jahr) == true)
                {
                    if (jahr % 100 == 0)
                    {
                        if (jahr % 400 == 0)
                        {
                            Console.WriteLine($"Das Jahr {jahr} ist ein Schaltjahr.");
                        }
                        else
                        {
                            Console.WriteLine($"Das Jahr {jahr} ist KEIN Schaltjahr.");
                        }
                    }
                    else if (jahr % 4 == 0)
                    {
                        Console.WriteLine($"Das Jahr {jahr} ist ein Schaltjahr.");
                    }
                    else
                    {
                        Console.WriteLine($"Das Jahr {jahr} ist KEIN Schaltjahr.");
                    }
                }
                else
                {
                    start = false;
                }
            }

        }
    }
}
