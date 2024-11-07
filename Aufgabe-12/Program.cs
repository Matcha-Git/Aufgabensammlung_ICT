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
            Console.WriteLine("\nGeben Sie die zu sumierenden Ganzzahlen mit Komma getrennt ein:");

            string input = Console.ReadLine();
            string[] input2 = input.Split(',');
            int[] zahl = new int[input2.Length];
            int[] ergebnis = new int[input2.Length];
            int sum = 0;

            for (int i = 0; i < input2.Length; i++)
            {
                zahl[i] = int.Parse(input2[i]);
            }

            Console.WriteLine("\nResultat:");
            SumUp(zahl, input2);

            Console.ReadKey();
        }
        static int[] SumUp(int[] zahl, string[] input2)
        {
            int[] ergebnis = new int[input2.Length];
            int sum = 0;
            for (int i = 0; i < input2.Length; i++)
            {
                sum += zahl[i];
                ergebnis[i] = sum;
                if (i + 1 < input2.Length)
                {
                    Console.Write($"[{i}] -> {ergebnis[i]}, ");
                }
                else
                {
                    Console.Write($"[{i}] -> {ergebnis[i]}");
                }
            }
            return ergebnis;
        }
    }
}