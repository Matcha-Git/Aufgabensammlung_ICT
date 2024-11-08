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

            Console.WriteLine("Wie lang soll die Linie sein?");
            Console.Write("Deine Eingabe: ");
            uint input = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(" ");


            for (int i = 0; i < input; i++)
            {
                for (int i2 = 0;i2 < input; i2++)
                {
                    if (i == i2)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");
            }
            Console.ReadKey();

        }
    }
}
