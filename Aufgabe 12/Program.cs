using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_12
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("--------------------");
            Console.WriteLine("Zahlen Aufsummieren");
            Console.WriteLine("--------------------");
            Console.Write("\nGeben Sie die zu sumierenden Ganzzahlen mit Komma getrennt ein:\n");

            string input = Console.ReadLine();
            int[] arr; input.Split(',');
            Console.WriteLine(value: arr);

            Console.ReadKey();
        }
    }
}
