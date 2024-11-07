using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_10
{
    internal class Program
    {
        static int BerechneQuersumme(int zahl)
        {
            int sum = 0;
            while (zahl != 0)
            {
                sum += (zahl % 10);
                zahl /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Zahl: ");
            int zahl = Convert.ToInt32(Console.ReadLine());
            int sum = BerechneQuersumme(zahl);
            Console.WriteLine($"Die Quersumme von {zahl} ist: {sum}");
            Console.ReadKey();
        }
    }
}
