using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i2 = 0;

            Console.WriteLine("Wie lang soll die Linie sein?");
            Console.Write("Deine Eingabe: ");
            uint input = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(" ");

            string[,] linie = new string[input,input];

            for (int i = 0; i < input; i++)
            {
                if (i == i2)
                {
                    linie[i, i2] = "*";
                    i2++;
                }
                else
                {
                    linie[i, i2] = " ";
                }
            }
            Console.WriteLine(linie);
            Console.ReadKey();

        }
    }
}
