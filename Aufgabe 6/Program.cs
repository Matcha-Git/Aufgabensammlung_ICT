using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string space = "---------------";

            Console.WriteLine(space);
            Console.WriteLine("Kleines 1x1");
            Console.WriteLine(space);

            for (int i1 = 1; i1 <= 10; i1++)
            {
                for (int i2 = 1; i2 <= 10; i2++)
                {
                    int zahl = i1 * i2;
                    Console.Write(zahl + "\t");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\nWaiting for input...");
            Console.ReadKey();
        }
    }
}
