using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_11
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
            int zahl1;
            int zahl2;
            int qsum1;
            int qsum2;
            int sum;

            Console.WriteLine("Zahl 1:");
            zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zahl 2:");
            zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" --------------------------------------------------");
            Console.WriteLine("|Zahl\t|Quersumme\t|Zahl/Quersumme\t|");
            Console.WriteLine(" --------------------------------------------------");
            for (int i = zahl1; i <= zahl2; i++)
            {
                BerechneQuersumme(i, out sum);

                Console.WriteLine(sum);
            }



            Console.ReadKey();
        }
    }
}
