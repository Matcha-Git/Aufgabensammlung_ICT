using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool i = true;
            while (i)
            {
                Console.WriteLine("Gib eine Zahl ein [Type \'000\' to exit]:");
                int zahl = Convert.ToInt32(Console.ReadLine());
                if (zahl == 000)
                {
                    return;
                }
                string bin = Convert.ToString(zahl, 2);
                Console.WriteLine("Die binäre Darstellung von " + zahl + " ist: " + bin);
                Console.WriteLine("\nPrees \'Enter\' to start a new calculation...\n");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
