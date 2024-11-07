using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string space = "\n*******************************\n";

            Console.WriteLine("Addierer");
            Console.WriteLine(space);

            Console.Write("zahl 1:\t");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nzahl 2:\t");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            int summe = zahl1 + zahl2;

            Console.WriteLine($"\nSumme:\t{summe}");
            Console.WriteLine(space);
            Console.WriteLine("\nWaiting for input...");
            Console.ReadKey();
        }
    }
}