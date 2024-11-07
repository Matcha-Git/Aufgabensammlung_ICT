using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ergebnis = "";

            Console.WriteLine("Zahlen zwischen 1 und 30 die durch 3 oder 5 teilbar ohne rest sind:");

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    ergebnis += i + ", ";
                }
            }
            if (ergebnis.Length > 0)
            {
                ergebnis = ergebnis.Substring(0, ergebnis.Length - 2);
            }

            Console.WriteLine(ergebnis);

            Console.WriteLine("\nWaiting for input...");
            Console.ReadKey();
        }
    }
}